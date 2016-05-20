// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

var util = require('util');
var msrest = require('ms-rest');
var adal = require('adal-node');
var Constants = msrest.Constants;

var azureConstants = require('../constants');
var AzureEnvironment = require('../azureEnvironment');

/**
* Creates a new DeviceTokenCredentials object that gets a new access token using userCodeInfo (contains user_code, device_code)
* for authenticating user on device.
*
* When this credential is used, the script will provide a url and code. The user needs to copy the url and the code, paste it 
* in a browser and authenticate over there. If successful, the script will get the access token.
*
* @constructor
* @param {string} username The user name for account in the form: 'user@example.com'.
* @param {object} [options] Object representing optional parameters.
* @param {AzureEnvironment} [options.environment] The azure environment to authenticate with. Default environment is "Azure" popularly known as "Public Azure Cloud".
* @param {string} [options.domain] The domain or tenant id containing this application. Default value is 'common'
* @param {string} [options.clientId] The active directory application client id. 
* See {@link https://azure.microsoft.com/en-us/documentation/articles/active-directory-devquickstarts-dotnet/ Active Directory Quickstart for .Net} 
* for an example.
* @param {string} [options.authorizationScheme] The authorization scheme. Default value is 'bearer'.
* @param {object} [options.tokenCache] The token cache. Default value is the MemoryCache object from adal.
*/
function DeviceTokenCredentials(username, options) {
  if (!Boolean(username) || typeof username.valueOf() !== 'string') {
    throw new Error('username must be a non empty string.');
  }

  if (!options) {
    options = {};
  }

  if (!options.environment) {
    options.environment = AzureEnvironment.Azure;
  }

  if (!options.domain) {
    options.domain = azureConstants.AAD_COMMON_TENANT;
  }

  if (!options.clientId) {
    options.clientId = azureConstants.DEFAULT_ADAL_CLIENT_ID;
  }
  
  if (!options.authorizationScheme) {
    options.authorizationScheme = Constants.HeaderConstants.AUTHORIZATION_SCHEME;
  }

  if (!options.tokenCache) {
    options.tokenCache = new adal.MemoryCache();
  }
  
  this.username = username;
  this.environment = options.environment;
  this.domain = options.domain;
  this.clientId = options.clientId;
  this.authorizationScheme = options.authorizationScheme;
  this.tokenCache = options.tokenCache;
  var authorityUrl = this.environment.activeDirectoryEndpointUrl + this.domain;
  this.context = new adal.AuthenticationContext(authorityUrl, this.environment.validateAuthority, this.tokenCache);
}

DeviceTokenCredentials.prototype.retrieveTokenFromCache = function (callback) {
  var self = this;
  self.context.acquireToken(self.environment.activeDirectoryResourceId, self.username, self.clientId, function (err, result) {
    if (err) return callback(err);
    return callback(null, result.tokenType, result.accessToken);
  });
};


/**
* Signs a request with the Authentication header.
*
* @param {webResource} The WebResource to be signed.
* @param {function(error)}  callback  The callback function.
* @return {undefined}
*/
DeviceTokenCredentials.prototype.signRequest = function (webResource, callback) {
  return this.retrieveTokenFromCache(function(err, scheme, token) {
    if (err) return callback(err);
    webResource.headers[Constants.HeaderConstants.AUTHORIZATION] = util.format('%s %s', scheme, token);
    return callback(null);
  });
};

module.exports = DeviceTokenCredentials;