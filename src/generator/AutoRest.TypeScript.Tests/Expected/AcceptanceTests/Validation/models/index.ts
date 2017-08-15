/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */



/**
 * @class
 * Initializes a new instance of the ChildProduct class.
 * @constructor
 * The product documentation.
 *
 * @member {number} [count] Count
 */
export interface ChildProduct {
  count?: number;
}

/**
 * @class
 * Initializes a new instance of the ConstantProduct class.
 * @constructor
 * The product documentation.
 *
 */
export interface ConstantProduct {
}

/**
 * @class
 * Initializes a new instance of the Product class.
 * @constructor
 * The product documentation.
 *
 * @member {array} [displayNames] Non required array of unique items from 0 to
 * 6 elements.
 * @member {number} [capacity] Non required int betwen 0 and 100 exclusive.
 * @member {string} [image] Image URL representing the product.
 * @member {object} child
 * @member {number} [child.count] Count
 * @member {string} [constStringAsEnum] Constant string as Enum. Possible
 * values include: 'constant_string_as_enum'
 */
export interface Product {
  displayNames?: string[];
  capacity?: number;
  image?: string;
  child: ChildProduct;
  constStringAsEnum?: string;
}

/**
 * @class
 * Initializes a new instance of the ErrorModel class.
 * @constructor
 * @member {number} [code]
 * @member {string} [message]
 * @member {string} [fields]
 */
export interface ErrorModel {
  code?: number;
  message?: string;
  fields?: string;
}
