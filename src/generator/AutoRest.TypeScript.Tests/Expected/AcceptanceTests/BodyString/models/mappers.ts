/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */


export const ErrorModel = {
  required: false,
  serializedName: 'Error',
  type: {
    name: 'Composite',
    className: 'ErrorModel',
    modelProperties: {
      status: {
        required: false,
        serializedName: 'status',
        type: {
          name: 'Number'
        }
      },
      message: {
        required: false,
        serializedName: 'message',
        type: {
          name: 'String'
        }
      }
    }
  }
};

export const RefColorConstant = {
  required: false,
  serializedName: 'RefColorConstant',
  type: {
    name: 'Composite',
    className: 'RefColorConstant',
    modelProperties: {
      colorConstant: {
        required: true,
        isConstant: true,
        serializedName: 'ColorConstant',
        defaultValue: 'green-color',
        type: {
          name: 'String'
        }
      },
      field1: {
        required: false,
        serializedName: 'field1',
        type: {
          name: 'String'
        }
      }
    }
  }
};
