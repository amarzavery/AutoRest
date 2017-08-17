/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRest from 'ms-rest';
import * as Mappers from '../models/mappers';
import { AutoRestAzureSpecialParametersTestClient } from '../autoRestAzureSpecialParametersTestClient';

const WebResource = msRest.WebResource;

/** Class representing a Odata. */
export class Odata {
  private readonly client: AutoRestAzureSpecialParametersTestClient;
  /**
   * Create a Odata.
   * @param {AutoRestAzureSpecialParametersTestClient} client Reference to the service client.
   */
  constructor(client: AutoRestAzureSpecialParametersTestClient) {
    this.client = client;
  }

  /**
   * Specify filter parameter with value '$filter=id gt 5 and name eq
   * 'foo'&$orderby=id&$top=10'
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {string} [options.filter] The filter parameter with value '$filter=id
   * gt 5 and name eq 'foo''.
   *
   * @param {number} [options.top] The top parameter with value 10.
   *
   * @param {string} [options.orderby] The orderby parameter with value id.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<null>} - The deserialized result object.
   *
   * @reject {Error|ServiceError} - The error object.
   */
  async getWithFilterWithHttpOperationResponse(options?: { filter? : string, top? : number, orderby? : string, customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;
    let filter = (options && options.filter !== undefined) ? options.filter : undefined;
    let top = (options && options.top !== undefined) ? options.top : undefined;
    let orderby = (options && options.orderby !== undefined) ? options.orderby : undefined;
    // Validate
    try {
      if (filter !== null && filter !== undefined && typeof filter.valueOf() !== 'string') {
        throw new Error('filter must be of type string.');
      }
      if (top !== null && top !== undefined && typeof top !== 'number') {
        throw new Error('top must be of type number.');
      }
      if (orderby !== null && orderby !== undefined && typeof orderby.valueOf() !== 'string') {
        throw new Error('orderby must be of type string.');
      }
      if (this.client.acceptLanguage !== null && this.client.acceptLanguage !== undefined && typeof this.client.acceptLanguage.valueOf() !== 'string') {
        throw new Error('this.client.acceptLanguage must be of type string.');
      }
    } catch (error) {
      return Promise.reject(error);
    }

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'azurespecials/odata/filter';
    let queryParameters: Array<any> = [];
    if (filter !== null && filter !== undefined) {
      queryParameters.push('$filter=' + encodeURIComponent(filter));
    }
    if (top !== null && top !== undefined) {
      queryParameters.push('$top=' + encodeURIComponent(top.toString()));
    }
    if (orderby !== null && orderby !== undefined) {
      queryParameters.push('$orderby=' + encodeURIComponent(orderby));
    }
    if (queryParameters.length > 0) {
      requestUrl += '?' + queryParameters.join('&');
    }

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'GET';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
    if (this.client.generateClientRequestId) {
        httpRequest.headers['x-ms-client-request-id'] = msRest.generateUuid();
    }
    if (this.client.acceptLanguage !== undefined && this.client.acceptLanguage !== null) {
      httpRequest.headers['accept-language'] = this.client.acceptLanguage;
    }
    if(options && options.customHeaders) {
      for(let headerName in options.customHeaders) {
        if (options.customHeaders.hasOwnProperty(headerName)) {
          httpRequest.headers[headerName] = options.customHeaders[headerName];
        }
      }
    }
    httpRequest.body = null;
    // Send Request
    let operationRes: msRest.HttpOperationResponse;
    try {
      operationRes = await client.pipeline(httpRequest);
      let response = operationRes.response;
      let statusCode = response.status;
      if (statusCode !== 200) {
        let error = new msRest.RestError(operationRes.bodyAsText as string);
        error.statusCode = response.status;
        error.request = msRest.stripRequest(httpRequest);
        error.response = msRest.stripResponse(response);
        let parsedErrorResponse = operationRes.bodyAsJson as { [key: string]: any };
        try {
          if (parsedErrorResponse) {
            let internalError = null;
            if (parsedErrorResponse.error) internalError = parsedErrorResponse.error;
            error.code = internalError ? internalError.code : parsedErrorResponse.code;
            error.message = internalError ? internalError.message : parsedErrorResponse.message;
          }
          if (parsedErrorResponse !== null && parsedErrorResponse !== undefined) {
            let resultMapper = Mappers.ErrorModel;
            error.body = client.serializer.deserialize(resultMapper, parsedErrorResponse, 'error.body');
          }
        } catch (defaultError) {
          error.message = `Error "${defaultError.message}" occurred in deserializing the responseBody ` +
                           `- "${operationRes.bodyAsText}" for the default response.`;
          return Promise.reject(error);
        }
        return Promise.reject(error);
      }

    } catch(err) {
      return Promise.reject(err);
    }

    return Promise.resolve(operationRes);
  }

  /**
   * Specify filter parameter with value '$filter=id gt 5 and name eq
   * 'foo'&$orderby=id&$top=10'
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {string} [options.filter] The filter parameter with value '$filter=id
   * gt 5 and name eq 'foo''.
   *
   * @param {number} [options.top] The top parameter with value 10.
   *
   * @param {string} [options.orderby] The orderby parameter with value id.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @param {ServiceCallback} callback - The callback.
   *
   * @returns {ServiceCallback} callback(err, result, request, response)
   *
   *                      {Error|ServiceError}  err        - The Error object if an error occurred, null otherwise.
   *
   *                      {null} [result]   - The deserialized result object if an error did not occur.
   *
   *                      {WebResource} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {http.IncomingMessage} [response] - The HTTP Response stream if an error did not occur.
   */
  getWithFilter(): Promise<void>;
  getWithFilter(options: { filter? : string, top? : number, orderby? : string, customHeaders? : { [headerName: string]: string; } }): Promise<void>;
  getWithFilter(callback: msRest.ServiceCallback<void>): void;
  getWithFilter(options: { filter? : string, top? : number, orderby? : string, customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<void>): void;
  getWithFilter(options?: { filter? : string, top? : number, orderby? : string, customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<void>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<void>;
    if (!callback) {
      return this.getWithFilterWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as void);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.getWithFilterWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as void;
        return cb(err, result, data.request, data.response);
      });
    }
  }

}
