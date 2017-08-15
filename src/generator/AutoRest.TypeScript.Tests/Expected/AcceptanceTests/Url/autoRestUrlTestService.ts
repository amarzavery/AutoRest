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
/**
 * AutoRestUrlTestServiceOptions for AutoRestUrlTestService.
 */
interface AutoRestUrlTestServiceOptions extends msRest.ServiceClientOptions {
  /**
   * @property {string} [globalStringQuery] - should contain value null
   */
  globalStringQuery?: string;
}

class AutoRestUrlTestService extends msRest.ServiceClient {
  globalStringPath: string;
  globalStringQuery: string;
  baseUri: string;

  // Operation groups
  paths: operations.Paths;
  queries: operations.Queries;
  pathItems: operations.PathItems;
  serializer: msRest.Serializer;
  /**
   * @class
   * Initializes a new instance of the AutoRestUrlTestService class.
   * @constructor
   *
   * @param {string} globalStringPath - A string value 'globalItemStringPath' that appears in the path
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
   * @param {string} [options.globalStringQuery] - should contain value null
   *
   */
  constructor(globalStringPath: string, baseUri?: string, options?: AutoRestUrlTestServiceOptions) {
    if (globalStringPath === null || globalStringPath === undefined) {
      throw new Error('\'globalStringPath\' cannot be null.');
    }

    if (!options) options = {};

    super(undefined, options);

    this.baseUri = baseUri as string;
    if (!this.baseUri) {
      this.baseUri = 'http://localhost';
    }
    this.globalStringPath = globalStringPath;

    this.addUserAgentInfo(`${packageName}/${packageVersion}`);
    if(options.globalStringQuery !== null && options.globalStringQuery !== undefined) {
      this.globalStringQuery = options.globalStringQuery;
    }
    this.paths = new operations.Paths(this);
    this.queries = new operations.Queries(this);
    this.pathItems = new operations.PathItems(this);
    this.serializer = new msRest.Serializer(Mappers);
  }
}

export { AutoRestUrlTestService, Models };
