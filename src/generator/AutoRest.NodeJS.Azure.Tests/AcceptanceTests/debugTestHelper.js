var msRestAzure = require('ms-rest-azure');

var lroClient = require('../Expected/AcceptanceTests/Lro/autoRestLongRunningOperationTestService');
var dummySubscriptionId = '1234-5678-9012-3456';
var dummyToken = 'dummy12321343423';
var credentials = new msRestAzure.TokenCredentials(dummyToken);
var clientOptions = {};
var baseUri = 'http://localhost:3000';
var product = { location: 'West US' };
var testClient = new lroClient(credentials, baseUri, {longRunningOperationRetryTimeout: 1});
testClient.lROSADs.putError201NoProvisioningStatePayload({ product: product }, function (error, result) {
  if (error) {
    return console.log(error);
  }
  return console.log(result);
});