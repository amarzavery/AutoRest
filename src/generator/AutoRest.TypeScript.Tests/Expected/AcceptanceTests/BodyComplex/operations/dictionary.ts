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
import * as Models from '../models';
import * as Mappers from '../models/mappers';
import { AutoRestComplexTestService } from '../autoRestComplexTestService';

const WebResource = msRest.WebResource;

/** Class representing a Dictionary. */
export class Dictionary {
  private readonly client: AutoRestComplexTestService;
  /**
   * Create a Dictionary.
   * @param {AutoRestComplexTestService} client Reference to the service client.
   */
  constructor(client: AutoRestComplexTestService) {
    this.client = client;
  }

  /**
   * Get complex types with dictionary property
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<DictionaryWrapper>} - The deserialized result object.
   *
   * @reject {Error|ServiceError} - The error object.
   */
  async getValidWithHttpOperationResponse(options?: { customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/valid';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'GET';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
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
      // Deserialize Response
      if (statusCode === 200) {
        let parsedResponse = operationRes.bodyAsJson as { [key: string]: any };
        try {
          if (parsedResponse !== null && parsedResponse !== undefined) {
            let resultMapper = Mappers.DictionaryWrapper;
            operationRes.bodyAsJson = client.serializer.deserialize(resultMapper, parsedResponse, 'operationRes.bodyAsJson');
          }
        } catch (error) {
          let deserializationError = new msRest.RestError(`Error ${error} occurred in deserializing the responseBody - ${operationRes.bodyAsText}`);
          deserializationError.request = msRest.stripRequest(httpRequest);
          deserializationError.response = msRest.stripResponse(response);
          return Promise.reject(deserializationError);
        }
      }

    } catch(err) {
      return Promise.reject(err);
    }

    return Promise.resolve(operationRes);
  }

  /**
   * Put complex types with dictionary property
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.defaultProgram]
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
  async putValidWithHttpOperationResponse(options?: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;
    let defaultProgram = (options && options.defaultProgram !== undefined) ? options.defaultProgram : undefined;
    // Validate
    try {
      if (defaultProgram && typeof defaultProgram === 'object') {
        for(let valueElement in defaultProgram) {
          if (defaultProgram[valueElement] !== null && defaultProgram[valueElement] !== undefined && typeof defaultProgram[valueElement].valueOf() !== 'string') {
            throw new Error('defaultProgram[valueElement] must be of type string.');
          }
        }
      }
    } catch (error) {
      return Promise.reject(error);
    }
    let complexBody: any
    if (defaultProgram !== null && defaultProgram !== undefined) {
      complexBody = {};
      complexBody.defaultProgram = defaultProgram;
    }

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/valid';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'PUT';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
    if(options && options.customHeaders) {
      for(let headerName in options.customHeaders) {
        if (options.customHeaders.hasOwnProperty(headerName)) {
          httpRequest.headers[headerName] = options.customHeaders[headerName];
        }
      }
    }
    // Serialize Request
    let requestContent = null;
    let requestModel = null;
    try {
      if (complexBody !== null && complexBody !== undefined) {
        let requestModelMapper = Mappers.DictionaryWrapper;
        requestModel = client.serializer.serialize(requestModelMapper, complexBody, 'complexBody');
        requestContent = JSON.stringify(requestModel);
      }
    } catch (error) {
      let serializationError = new Error(`Error "${error.message}" occurred in serializing the ` +
          `payload - ${JSON.stringify(complexBody, null, 2)}.`);
      return Promise.reject(serializationError);
    }
    httpRequest.body = requestContent;
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
   * Get complex types with dictionary property which is empty
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<DictionaryWrapper>} - The deserialized result object.
   *
   * @reject {Error|ServiceError} - The error object.
   */
  async getEmptyWithHttpOperationResponse(options?: { customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/empty';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'GET';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
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
      // Deserialize Response
      if (statusCode === 200) {
        let parsedResponse = operationRes.bodyAsJson as { [key: string]: any };
        try {
          if (parsedResponse !== null && parsedResponse !== undefined) {
            let resultMapper = Mappers.DictionaryWrapper;
            operationRes.bodyAsJson = client.serializer.deserialize(resultMapper, parsedResponse, 'operationRes.bodyAsJson');
          }
        } catch (error) {
          let deserializationError = new msRest.RestError(`Error ${error} occurred in deserializing the responseBody - ${operationRes.bodyAsText}`);
          deserializationError.request = msRest.stripRequest(httpRequest);
          deserializationError.response = msRest.stripResponse(response);
          return Promise.reject(deserializationError);
        }
      }

    } catch(err) {
      return Promise.reject(err);
    }

    return Promise.resolve(operationRes);
  }

  /**
   * Put complex types with dictionary property which is empty
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.defaultProgram]
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
  async putEmptyWithHttpOperationResponse(options?: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;
    let defaultProgram = (options && options.defaultProgram !== undefined) ? options.defaultProgram : undefined;
    // Validate
    try {
      if (defaultProgram && typeof defaultProgram === 'object') {
        for(let valueElement in defaultProgram) {
          if (defaultProgram[valueElement] !== null && defaultProgram[valueElement] !== undefined && typeof defaultProgram[valueElement].valueOf() !== 'string') {
            throw new Error('defaultProgram[valueElement] must be of type string.');
          }
        }
      }
    } catch (error) {
      return Promise.reject(error);
    }
    let complexBody: any
    if (defaultProgram !== null && defaultProgram !== undefined) {
      complexBody = {};
      complexBody.defaultProgram = defaultProgram;
    }

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/empty';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'PUT';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
    if(options && options.customHeaders) {
      for(let headerName in options.customHeaders) {
        if (options.customHeaders.hasOwnProperty(headerName)) {
          httpRequest.headers[headerName] = options.customHeaders[headerName];
        }
      }
    }
    // Serialize Request
    let requestContent = null;
    let requestModel = null;
    try {
      if (complexBody !== null && complexBody !== undefined) {
        let requestModelMapper = Mappers.DictionaryWrapper;
        requestModel = client.serializer.serialize(requestModelMapper, complexBody, 'complexBody');
        requestContent = JSON.stringify(requestModel);
      }
    } catch (error) {
      let serializationError = new Error(`Error "${error.message}" occurred in serializing the ` +
          `payload - ${JSON.stringify(complexBody, null, 2)}.`);
      return Promise.reject(serializationError);
    }
    httpRequest.body = requestContent;
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
   * Get complex types with dictionary property which is null
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<DictionaryWrapper>} - The deserialized result object.
   *
   * @reject {Error|ServiceError} - The error object.
   */
  async getNullWithHttpOperationResponse(options?: { customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/null';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'GET';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
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
      // Deserialize Response
      if (statusCode === 200) {
        let parsedResponse = operationRes.bodyAsJson as { [key: string]: any };
        try {
          if (parsedResponse !== null && parsedResponse !== undefined) {
            let resultMapper = Mappers.DictionaryWrapper;
            operationRes.bodyAsJson = client.serializer.deserialize(resultMapper, parsedResponse, 'operationRes.bodyAsJson');
          }
        } catch (error) {
          let deserializationError = new msRest.RestError(`Error ${error} occurred in deserializing the responseBody - ${operationRes.bodyAsText}`);
          deserializationError.request = msRest.stripRequest(httpRequest);
          deserializationError.response = msRest.stripResponse(response);
          return Promise.reject(deserializationError);
        }
      }

    } catch(err) {
      return Promise.reject(err);
    }

    return Promise.resolve(operationRes);
  }

  /**
   * Get complex types with dictionary property while server doesn't provide a
   * response payload
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<DictionaryWrapper>} - The deserialized result object.
   *
   * @reject {Error|ServiceError} - The error object.
   */
  async getNotProvidedWithHttpOperationResponse(options?: { customHeaders? : { [headerName: string]: string; } }): Promise<msRest.HttpOperationResponse> {
    let client = this.client;

    // Construct URL
    let baseUrl = this.client.baseUri;
    let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'complex/dictionary/typed/notprovided';

    // Create HTTP transport objects
    let httpRequest = new WebResource();
    httpRequest.method = 'GET';
    httpRequest.url = requestUrl;
    httpRequest.headers = {};
    // Set Headers
    httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
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
      // Deserialize Response
      if (statusCode === 200) {
        let parsedResponse = operationRes.bodyAsJson as { [key: string]: any };
        try {
          if (parsedResponse !== null && parsedResponse !== undefined) {
            let resultMapper = Mappers.DictionaryWrapper;
            operationRes.bodyAsJson = client.serializer.deserialize(resultMapper, parsedResponse, 'operationRes.bodyAsJson');
          }
        } catch (error) {
          let deserializationError = new msRest.RestError(`Error ${error} occurred in deserializing the responseBody - ${operationRes.bodyAsText}`);
          deserializationError.request = msRest.stripRequest(httpRequest);
          deserializationError.response = msRest.stripResponse(response);
          return Promise.reject(deserializationError);
        }
      }

    } catch(err) {
      return Promise.reject(err);
    }

    return Promise.resolve(operationRes);
  }

  /**
   * Get complex types with dictionary property
   *
   * @param {object} [options] Optional Parameters.
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
   *                      {DictionaryWrapper} [result]   - The deserialized result object if an error did not occur.
   *                      See {@link DictionaryWrapper} for more information.
   *
   *                      {WebResource} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {http.IncomingMessage} [response] - The HTTP Response stream if an error did not occur.
   */
  getValid(): Promise<Models.DictionaryWrapper>;
  getValid(options: { customHeaders? : { [headerName: string]: string; } }): Promise<Models.DictionaryWrapper>;
  getValid(callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getValid(options: { customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getValid(options?: { customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<Models.DictionaryWrapper>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<Models.DictionaryWrapper>;
    if (!callback) {
      return this.getValidWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as Models.DictionaryWrapper);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.getValidWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as Models.DictionaryWrapper;
        return cb(err, result, data.request, data.response);
      });
    }
  }

  /**
   * Put complex types with dictionary property
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.defaultProgram]
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
  putValid(): Promise<void>;
  putValid(options: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }): Promise<void>;
  putValid(callback: msRest.ServiceCallback<void>): void;
  putValid(options: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<void>): void;
  putValid(options?: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<void>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<void>;
    if (!callback) {
      return this.putValidWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as void);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.putValidWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as void;
        return cb(err, result, data.request, data.response);
      });
    }
  }

  /**
   * Get complex types with dictionary property which is empty
   *
   * @param {object} [options] Optional Parameters.
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
   *                      {DictionaryWrapper} [result]   - The deserialized result object if an error did not occur.
   *                      See {@link DictionaryWrapper} for more information.
   *
   *                      {WebResource} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {http.IncomingMessage} [response] - The HTTP Response stream if an error did not occur.
   */
  getEmpty(): Promise<Models.DictionaryWrapper>;
  getEmpty(options: { customHeaders? : { [headerName: string]: string; } }): Promise<Models.DictionaryWrapper>;
  getEmpty(callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getEmpty(options: { customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getEmpty(options?: { customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<Models.DictionaryWrapper>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<Models.DictionaryWrapper>;
    if (!callback) {
      return this.getEmptyWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as Models.DictionaryWrapper);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.getEmptyWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as Models.DictionaryWrapper;
        return cb(err, result, data.request, data.response);
      });
    }
  }

  /**
   * Put complex types with dictionary property which is empty
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.defaultProgram]
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
  putEmpty(): Promise<void>;
  putEmpty(options: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }): Promise<void>;
  putEmpty(callback: msRest.ServiceCallback<void>): void;
  putEmpty(options: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<void>): void;
  putEmpty(options?: { defaultProgram? : { [propertyName: string]: string }, customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<void>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<void>;
    if (!callback) {
      return this.putEmptyWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as void);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.putEmptyWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as void;
        return cb(err, result, data.request, data.response);
      });
    }
  }

  /**
   * Get complex types with dictionary property which is null
   *
   * @param {object} [options] Optional Parameters.
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
   *                      {DictionaryWrapper} [result]   - The deserialized result object if an error did not occur.
   *                      See {@link DictionaryWrapper} for more information.
   *
   *                      {WebResource} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {http.IncomingMessage} [response] - The HTTP Response stream if an error did not occur.
   */
  getNull(): Promise<Models.DictionaryWrapper>;
  getNull(options: { customHeaders? : { [headerName: string]: string; } }): Promise<Models.DictionaryWrapper>;
  getNull(callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getNull(options: { customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getNull(options?: { customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<Models.DictionaryWrapper>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<Models.DictionaryWrapper>;
    if (!callback) {
      return this.getNullWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as Models.DictionaryWrapper);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.getNullWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as Models.DictionaryWrapper;
        return cb(err, result, data.request, data.response);
      });
    }
  }

  /**
   * Get complex types with dictionary property while server doesn't provide a
   * response payload
   *
   * @param {object} [options] Optional Parameters.
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
   *                      {DictionaryWrapper} [result]   - The deserialized result object if an error did not occur.
   *                      See {@link DictionaryWrapper} for more information.
   *
   *                      {WebResource} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {http.IncomingMessage} [response] - The HTTP Response stream if an error did not occur.
   */
  getNotProvided(): Promise<Models.DictionaryWrapper>;
  getNotProvided(options: { customHeaders? : { [headerName: string]: string; } }): Promise<Models.DictionaryWrapper>;
  getNotProvided(callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getNotProvided(options: { customHeaders? : { [headerName: string]: string; } }, callback: msRest.ServiceCallback<Models.DictionaryWrapper>): void;
  getNotProvided(options?: { customHeaders? : { [headerName: string]: string; } }, callback?: msRest.ServiceCallback<Models.DictionaryWrapper>): any {
    if (!callback && typeof options === 'function') {
      callback = options;
      options = undefined;
    }
    let cb = callback as msRest.ServiceCallback<Models.DictionaryWrapper>;
    if (!callback) {
      return this.getNotProvidedWithHttpOperationResponse(options).then((operationRes: msRest.HttpOperationResponse) => {
        return Promise.resolve(operationRes.bodyAsJson as Models.DictionaryWrapper);
      }).catch((err: Error) => {
        return Promise.reject(err);
      });
    } else {
      msRest.promiseToCallback(this.getNotProvidedWithHttpOperationResponse(options))((err: Error, data: msRest.HttpOperationResponse) => {
        if (err) {
          return cb(err);
        }
        let result = data.bodyAsJson as Models.DictionaryWrapper;
        return cb(err, result, data.request, data.response);
      });
    }
  }

}
