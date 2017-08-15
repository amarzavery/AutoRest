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
import { Mappers } from "./models/mappers";
import * as operations from "./operations";

const packageName = 'foo';
const packageVersion = '3.0.0-preview';
class AutoRestIntegerTestService extends msRest.ServiceClient {
  baseUri: string;

  // Operation groups
  intModel: operations.IntModel;
  serializer: msRest.Serializer;
  /**
   * @class
   * Initializes a new instance of the AutoRestIntegerTestService class.
   * @constructor
   *
   * @param {string} [baseUri] - The base URI of the service.
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
   */
  constructor(baseUri?: string, options?: msRest.ServiceClientOptions) {

    if (!options) options = {};

    super(undefined, options);

    this.baseUri = baseUri as string;
    if (!this.baseUri) {
      this.baseUri = 'http://localhost';
    }

    this.addUserAgentInfo(`${packageName}/${packageVersion}`);
    this.intModel = new operations.IntModel(this);
    this.serializer = new msRest.Serializer(Mappers);
  }
}

export { AutoRestIntegerTestService, Models };
