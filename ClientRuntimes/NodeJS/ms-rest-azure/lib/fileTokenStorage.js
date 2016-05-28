/**
* Copyright (c) Microsoft.  All rights reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*   http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

'use strict';
var fs = require('fs');
var path = require('path');

/**
 * Constructs a new disk file based token storage.
 * @constructor
 *
 * @param {string} filename filename to store/retrieve data from
 *
 */
function FileTokenStorage(filename) {
  this._setFile(filename);
}

FileTokenStorage.prototype._writeFile = function _writeFile(content) {
  var writeOptions = {
    encoding: 'utf8',
    mode: 384, // Permission 0600 - owner read/write, nobody else has access
    flag: 'w'
  };
  
  fs.writeFileSync(this._filename, content, writeOptions);
};

FileTokenStorage.prototype._readFile = function _readFile() {
  return fs.readFileSync(this._filename);
};

FileTokenStorage.prototype._setFile = function _setFile(filename) {
  var createFile = false;
  try {
    fs.statSync(filename);
  } catch (ex) {
    if (ex.code !== 'ENOENT') {
      throw ex;
    }
    // It is possible that directory did not exist.
    var dirname = path.dirname(filename);
    try {
      fs.statSync(dirname);
    } catch (err) {
      if (err.code !== 'ENOENT') {
        throw err;
      }
      fs.mkdirSync(dirname);
    }
    //Now, directory has to be present. So let's cerate the file with stringified empty array.
    createFile = true;
  }
  this._filename = filename;
  //Intialize the file with an empty array string if we are creating the file or the given file is empty.
  if (createFile || this._readFile().length === 0) {
    this._writeFile('[]');
  }
  return;
};
  
FileTokenStorage.prototype.loadEntries = function loadEntries() {
  var entries = [];
  var err;
  try {
    var content = this._readFile();
    entries = JSON.parse(content);
    for (var i=0; i < entries.length; i++) {
      entries[i].expiresOn = new Date(entries[i].expiresOn);
    }
  } catch (ex) {
    var err = new Error ();
    err.message = util.format('Error ("%s") occured while loading entries into the ' + 
      'FileTokenCache from file "%s". \n The actual error stack is: \n ("%s")', ex.message, 
      this._filename, ex.stack);
    throw err;
  }
  return entries;
};

FileTokenStorage.prototype.save = function save(entries, done) {
  try {
    this._writeFile(JSON.stringify(entries));
  } catch (err) {
    return done(err);
  }
  return done();
};

module.exports = FileTokenStorage;