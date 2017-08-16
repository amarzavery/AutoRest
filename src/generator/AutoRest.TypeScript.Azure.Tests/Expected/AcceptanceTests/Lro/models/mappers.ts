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

internalMappers.Resource = {
  required: false,
  serializedName: 'Resource',
  type: {
    name: 'Composite',
    className: 'Resource',
    modelProperties: {
      id: {
        required: false,
        readOnly: true,
        serializedName: 'id',
        type: {
          name: 'String'
        }
      },
      type: {
        required: false,
        readOnly: true,
        serializedName: 'type',
        type: {
          name: 'String'
        }
      },
      tags: {
        required: false,
        serializedName: 'tags',
        type: {
          name: 'Dictionary',
          value: {
              required: false,
              serializedName: 'stringElementType',
              type: {
                name: 'String'
              }
          }
        }
      },
      location: {
        required: false,
        serializedName: 'location',
        type: {
          name: 'String'
        }
      },
      name: {
        required: false,
        readOnly: true,
        serializedName: 'name',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.Sku = {
  required: false,
  serializedName: 'Sku',
  type: {
    name: 'Composite',
    className: 'Sku',
    modelProperties: {
      name: {
        required: false,
        serializedName: 'name',
        type: {
          name: 'String'
        }
      },
      id: {
        required: false,
        serializedName: 'id',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.Product = {
  required: false,
  serializedName: 'Product',
  type: {
    name: 'Composite',
    className: 'Product',
    modelProperties: {
      id: {
        required: false,
        readOnly: true,
        serializedName: 'id',
        type: {
          name: 'String'
        }
      },
      type: {
        required: false,
        readOnly: true,
        serializedName: 'type',
        type: {
          name: 'String'
        }
      },
      tags: {
        required: false,
        serializedName: 'tags',
        type: {
          name: 'Dictionary',
          value: {
              required: false,
              serializedName: 'stringElementType',
              type: {
                name: 'String'
              }
          }
        }
      },
      location: {
        required: false,
        serializedName: 'location',
        type: {
          name: 'String'
        }
      },
      name: {
        required: false,
        readOnly: true,
        serializedName: 'name',
        type: {
          name: 'String'
        }
      },
      provisioningState: {
        required: false,
        serializedName: 'properties.provisioningState',
        type: {
          name: 'String'
        }
      },
      provisioningStateValues: {
        required: false,
        readOnly: true,
        serializedName: 'properties.provisioningStateValues',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.SubResource = {
  required: false,
  serializedName: 'SubResource',
  type: {
    name: 'Composite',
    className: 'SubResource',
    modelProperties: {
      id: {
        required: false,
        readOnly: true,
        serializedName: 'id',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.SubProduct = {
  required: false,
  serializedName: 'SubProduct',
  type: {
    name: 'Composite',
    className: 'SubProduct',
    modelProperties: {
      id: {
        required: false,
        readOnly: true,
        serializedName: 'id',
        type: {
          name: 'String'
        }
      },
      provisioningState: {
        required: false,
        serializedName: 'properties.provisioningState',
        type: {
          name: 'String'
        }
      },
      provisioningStateValues: {
        required: false,
        readOnly: true,
        serializedName: 'properties.provisioningStateValues',
        type: {
          name: 'String'
        }
      }
    }
  }
};

internalMappers.OperationResultError = {
  required: false,
  serializedName: 'OperationResult_error',
  type: {
    name: 'Composite',
    className: 'OperationResultError',
    modelProperties: {
      code: {
        required: false,
        serializedName: 'code',
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

internalMappers.OperationResult = {
  required: false,
  serializedName: 'OperationResult',
  type: {
    name: 'Composite',
    className: 'OperationResult',
    modelProperties: {
      status: {
        required: false,
        serializedName: 'status',
        type: {
          name: 'String'
        }
      },
      error: {
        required: false,
        serializedName: 'error',
        type: {
          name: 'Composite',
          className: 'OperationResultError'
        }
      }
    }
  }
};

export const Mappers = internalMappers;
