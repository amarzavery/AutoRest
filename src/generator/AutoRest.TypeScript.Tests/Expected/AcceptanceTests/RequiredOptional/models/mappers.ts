/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

var internalMappers: any = {};

internalMappers.ErrorModel = {
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

internalMappers.IntWrapper = {
  required: false,
  serializedName: 'int-wrapper',
  type: {
    name: 'Composite',
    className: 'IntWrapper',
    modelProperties: {
      value: {
        required: true,
        serializedName: 'value',
        type: {
          name: 'Number'
        }
      }
    }
  }
};

internalMappers.IntOptionalWrapper = {
  required: false,
  serializedName: 'int-optional-wrapper',
  type: {
    name: 'Composite',
    className: 'IntOptionalWrapper',
    modelProperties: {
      value: {
        required: false,
        serializedName: 'value',
        type: {
          name: 'Number'
        }
      }
    }
  }
};

internalMappers.StringWrapper = {
  required: false,
  serializedName: 'string-wrapper',
  type: {
    name: 'Composite',
    className: 'StringWrapper',
    modelProperties: {
      value: {
        required: true,
        serializedName: 'value',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.StringOptionalWrapper = {
  required: false,
  serializedName: 'string-optional-wrapper',
  type: {
    name: 'Composite',
    className: 'StringOptionalWrapper',
    modelProperties: {
      value: {
        required: false,
        serializedName: 'value',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.ArrayWrapper = {
  required: false,
  serializedName: 'array-wrapper',
  type: {
    name: 'Composite',
    className: 'ArrayWrapper',
    modelProperties: {
      value: {
        required: true,
        serializedName: 'value',
        type: {
          name: 'Sequence',
          element: {
              required: false,
              serializedName: 'stringElementType',
              type: {
                name: 'String'
              }
          }
        }
      }
    }
  }
};

internalMappers.ArrayOptionalWrapper = {
  required: false,
  serializedName: 'array-optional-wrapper',
  type: {
    name: 'Composite',
    className: 'ArrayOptionalWrapper',
    modelProperties: {
      value: {
        required: false,
        serializedName: 'value',
        type: {
          name: 'Sequence',
          element: {
              required: false,
              serializedName: 'stringElementType',
              type: {
                name: 'String'
              }
          }
        }
      }
    }
  }
};

internalMappers.Product = {
  required: false,
  serializedName: 'product',
  type: {
    name: 'Composite',
    className: 'Product',
    modelProperties: {
      id: {
        required: true,
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
      }
    }
  }
};

internalMappers.ClassWrapper = {
  required: false,
  serializedName: 'class-wrapper',
  type: {
    name: 'Composite',
    className: 'ClassWrapper',
    modelProperties: {
      value: {
        required: true,
        serializedName: 'value',
        type: {
          name: 'Composite',
          className: 'Product'
        }
      }
    }
  }
};

internalMappers.ClassOptionalWrapper = {
  required: false,
  serializedName: 'class-optional-wrapper',
  type: {
    name: 'Composite',
    className: 'ClassOptionalWrapper',
    modelProperties: {
      value: {
        required: false,
        serializedName: 'value',
        type: {
          name: 'Composite',
          className: 'Product'
        }
      }
    }
  }
};
export const Mappers = internalMappers;
