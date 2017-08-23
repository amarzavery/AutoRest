/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import { BaseResource, CloudError, AzureServiceClientOptions } from "ms-rest-azure";;

export { BaseResource, CloudError };


/**
 * @class
 * Initializes a new instance of the ErrorModel class.
 * @constructor
 * @member {number} [status]
 * @member {string} [message]
 */
export interface ErrorModel {
  status?: number;
  message?: string;
}

/**
 * @class
 * Initializes a new instance of the AutoRestParameterizedHostTestClientOptions class.
 * @constructor
 * @member {string} [host] A string value that is used as a global part of the
 * parameterized host. Default value: 'host' .
 */
export interface AutoRestParameterizedHostTestClientOptions extends AzureServiceClientOptions {
  host?: string;
}

