/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the Basic class.
 * @constructor
 * @member {number} [id] Basic Id
 *
 * @member {string} [name] Name property with a very long description that does
 * not fit on a single line and a line break.
 *
 * @member {string} [color] Possible values include: 'cyan', 'Magenta',
 * 'YELLOW', 'blacK'
 *
 */
class Basic {
  constructor() {
  }

  /**
   * Defines the metadata of Basic
   *
   * @returns {object} metadata of Basic
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'basic',
      type: {
        name: 'Composite',
        className: 'Basic',
        modelProperties: {
          id: {
            required: false,
            serializedName: 'id',
            type: {
              name: 'Number'
            }
          },
          name: {
            required: false,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          color: {
            required: false,
            serializedName: 'color',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = Basic;
