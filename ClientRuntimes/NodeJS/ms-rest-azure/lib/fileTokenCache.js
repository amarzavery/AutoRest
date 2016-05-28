// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

'use strict';
var path = require('path');
var fs = require('fs');
var adal = require('adal-node');
var util = require('util');
var MemoryCache = adal.MemoryCache;

var FileTokenStorage = require('./fileTokenStorage');

/**
 * Constructs a new token cache that works with adal-node.
 * @constructor
 * @param {string} [filePath] - the file path to the token store. Default value is <User's Home Profile>/.azure/tokencache.json
 */
function FileTokenCache(filePath) {
  FileTokenCache['super_'].call(this);
  if (!filePath) {
    filePath = _getTokenFilePath();
  }
  this._tokenStorage = new FileTokenStorage(filePath);
  this._entries = this._tokenStorage.loadEntries();
}

util.inherits(FileTokenCache, MemoryCache);

/**
 * Adds a collection of entries to the cache in a single batch operation.
 * @param {Array}   entries  An array of entries to add to the cache.
 * @param  {Function} callback This function is called when the operation is complete.  Any error is provided as the
 *                             first parameter.
 */
FileTokenCache.prototype.add = function add(entries, callback) {
  var self = this;
  FileTokenCache['super_'].prototype.add.call(self, entries, function (err, result) {
    if (err) return callback(err);
    return self._tokenStorage.save(self._entries, callback);
  });
};

/**
 * Removes a collection of entries from the cache in a single batch operation.
 * @param  {Array}   entries  An array of cache entries to remove.
 * @param  {Function} callback This function is called when the operation is complete.  Any error is provided as the
 *                             first parameter.
 */
FileTokenCache.prototype.remove = function remove(entries, callback) {
  var self = this;
  FileTokenCache['super_'].prototype.remove.call(self, entries, function (err, result) {
    if (err) return callback(err);
    return self._tokenStorage.save(self._entries, callback);
  });
};

/**
 * Clears the token cache on the filesystem and in the memory representation.
 * @param  {Function} callback This function is called when the operation is complete.  Any error is provided as the
 *                             first parameter.
 */
FileTokenCache.prototype.clear = function clear(callback) {
  var entries = [];
  return this._tokenStorage.save(entries, function(err, result) {
    if (err) return callback(err);
    this._entries = entries;
    callback(null);
  });
};

function _homeFolder() {
  if (process.env.HOME !== undefined) {
    return process.env.HOME;
  }
  
  if (process.env.HOMEDRIVE && process.env.HOMEPATH) {
    return path.join(process.env.HOMEDRIVE, process.env.HOMEPATH);
  }
  
  throw new Error('No HOME path available');
}

function _getTokenFilePath() {
  return path.join(_homeFolder(), '.azure', 'tokenCache.json');
}

module.exports = FileTokenCache;