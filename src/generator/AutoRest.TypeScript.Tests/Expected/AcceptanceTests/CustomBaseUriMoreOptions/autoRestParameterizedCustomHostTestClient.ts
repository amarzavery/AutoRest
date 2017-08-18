/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRest from "ms-rest";
import * as Models from "./models";
import * as Mappers from "./models/mappers";
import * as operations from "./operations";

const packageName = 'foo';
const packageVersion = '3.0.0-preview';
/**
 * AutoRestParameterizedCustomHostTestClientOptions for AutoRestParameterizedCustomHostTestClient.
 */
interface AutoRestParameterizedCustomHostTestClientOptions extends msRest.ServiceClientOptions {
  /**
   * @property {string} [dnsSuffix] - A string value that is used as a global part of the parameterized host. Default value 'host'.
   */
  dnsSuffix?: string;
}

class AutoRestParameterizedCustomHostTestClient extends msRest.ServiceClient {
  subscriptionId: string;
  dnsSuffix: string;
  baseUri: string;

  // Operation groups
  paths: operations.Paths;
  serializer: msRest.Serializer;

  /**
   * @class
   * Initializes a new instance of the AutoRestParameterizedCustomHostTestClient class.
   * @constructor
   *
   * @param {string} subscriptionId - The subscription id with value 'test12'.
   *
   * @param {object} [options] - The parameter options
   *
   * @param {Array} [options.filters] - Filters to be added to the request pipeline
   *
   * @param {object} [options.requestOptions] - Options for the underlying request object
   * {@link https://github.com/request/request#requestoptions-callback Options doc}
   *
   * @param {boolean} [options.noRetryPolicy] - If set to true, turn off default retry policy
   *
   * @param {string} [options.dnsSuffix] - A string value that is used as a global part of the parameterized host. Default value 'host'.
   *
   */
  constructor(subscriptionId: string, options?: AutoRestParameterizedCustomHostTestClientOptions) {
    if (subscriptionId === null || subscriptionId === undefined) {
      throw new Error('\'subscriptionId\' cannot be null.');
    }

    if (!options) options = {};

    super(undefined, options);

    this.dnsSuffix = 'host';
    this.baseUri = '{vault}{secret}{dnsSuffix}';
    this.subscriptionId = subscriptionId;

    this.addUserAgentInfo(`${packageName}/${packageVersion}`);
    if(options.dnsSuffix !== null && options.dnsSuffix !== undefined) {
      this.dnsSuffix = options.dnsSuffix;
    }
    this.paths = new operations.Paths(this);
    this.serializer = new msRest.Serializer(Mappers);
  }
}

export { AutoRestParameterizedCustomHostTestClient, Models as AutoRestParameterizedCustomHostTestModels, Mappers as AutoRestParameterizedCustomHostTestMappers };
