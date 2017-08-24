/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import {CloudErrorMapper, BaseResourceMapper } from "ms-rest-azure-ts";

export const CloudError = CloudErrorMapper;
export const BaseResource = BaseResourceMapper;

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

export const ParameterGroupingPostRequiredParameters = {
  required: false,
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostRequiredParameters',
    modelProperties: {
      body: {
        required: true,
        type: {
          name: 'Number'
        }
      },
      customHeader: {
        required: false,
        type: {
          name: 'String'
        }
      },
      query: {
        required: false,
        defaultValue: 30,
        type: {
          name: 'Number'
        }
      },
      path: {
        required: true,
        type: {
          name: 'String'
        }
      }
    }
  }
};

export const ParameterGroupingPostOptionalParameters = {
  required: false,
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostOptionalParameters',
    modelProperties: {
      customHeader: {
        required: false,
        type: {
          name: 'String'
        }
      },
      query: {
        required: false,
        defaultValue: 30,
        type: {
          name: 'Number'
        }
      }
    }
  }
};

export const FirstParameterGroup = {
  required: false,
  type: {
    name: 'Composite',
    className: 'FirstParameterGroup',
    modelProperties: {
      headerOne: {
        required: false,
        type: {
          name: 'String'
        }
      },
      queryOne: {
        required: false,
        defaultValue: 30,
        type: {
          name: 'Number'
        }
      }
    }
  }
};

export const ParameterGroupingPostMultiParamGroupsSecondParamGroup = {
  required: false,
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostMultiParamGroupsSecondParamGroup',
    modelProperties: {
      headerTwo: {
        required: false,
        type: {
          name: 'String'
        }
      },
      queryTwo: {
        required: false,
        defaultValue: 30,
        type: {
          name: 'Number'
        }
      }
    }
  }
};

export const ParameterGroupingPostOptionalOptionalParams = {
  required: false,
  serializedName: 'PostOptionalOptions',
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostOptionalOptionalParams',
    modelProperties: {
      parameterGroupingPostOptionalParameters: {
        required: false,
        serializedName: '',
        type: {
          name: 'Composite',
          className: 'ParameterGroupingPostOptionalParameters'
        }
      }
    }
  }
};

export const ParameterGroupingPostMultiParamGroupsOptionalParams = {
  required: false,
  serializedName: 'PostMultiParamGroupsOptions',
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostMultiParamGroupsOptionalParams',
    modelProperties: {
      firstParameterGroup: {
        required: false,
        serializedName: '',
        type: {
          name: 'Composite',
          className: 'FirstParameterGroup'
        }
      },
      parameterGroupingPostMultiParamGroupsSecondParamGroup: {
        required: false,
        serializedName: '',
        type: {
          name: 'Composite',
          className: 'ParameterGroupingPostMultiParamGroupsSecondParamGroup'
        }
      }
    }
  }
};

export const ParameterGroupingPostSharedParameterGroupObjectOptionalParams = {
  required: false,
  serializedName: 'PostSharedParameterGroupObjectOptions',
  type: {
    name: 'Composite',
    className: 'ParameterGroupingPostSharedParameterGroupObjectOptionalParams',
    modelProperties: {
      firstParameterGroup: {
        required: false,
        serializedName: '',
        type: {
          name: 'Composite',
          className: 'FirstParameterGroup'
        }
      }
    }
  }
};
