// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System;
using System.Linq;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.Extensions;
using AutoRest.TypeScript.Model;
using static AutoRest.Core.Utilities.DependencyInjection;
using System.Collections.Generic;

namespace AutoRest.TypeScript
{
    public class TransformerTS : CodeModelTransformer<CodeModelTS>
    {
        public override CodeModelTS TransformCodeModel(CodeModel cm)
        {
            var codeModel = cm as CodeModelTS;

            // we're guaranteed to be in our language-specific context here.
            SwaggerExtensions.NormalizeClientModel(codeModel);
            PopulateAdditionalProperties(codeModel);
            NormalizeOdataFilterParameter(codeModel);
            PerformParameterMapping(codeModel);
            CreateModelTypeForOptionalClientProperties(codeModel);
            return codeModel;
        }

        public void PerformParameterMapping(CodeModelTS cm)
        {
            foreach (var method in cm.Methods)
            {
                foreach (var parameterTransformation in method.InputParameterTransformation)
                {
                    parameterTransformation.OutputParameter.Name =
                        method.GetUniqueName(
                            CodeNamer.Instance.GetParameterName(parameterTransformation.OutputParameter.GetClientName()));

                    foreach (var parameterMapping in parameterTransformation.ParameterMappings)
                    {
                        if (parameterMapping.InputParameterProperty != null)
                        {
                            parameterMapping.InputParameterProperty =
                                CodeNamer.Instance.GetPropertyName(parameterMapping.InputParameterProperty);
                        }

                        if (parameterMapping.OutputParameterProperty != null)
                        {
                            parameterMapping.OutputParameterProperty =
                                CodeNamer.Instance.GetPropertyName(parameterMapping.OutputParameterProperty);
                        }
                    }
                }
            }
        }

        public void CreateModelTypeForOptionalClientProperties(CodeModelTS cm)
        {
            List<string> predefinedOptionalProperties = new List<string>() { "requestOptions", "filters", "noRetryPolicy" };
            var optionalProperitesOnClient = cm.Properties.Where(
                p => (!p.IsRequired || p.IsRequired && !string.IsNullOrEmpty(p.DefaultValue))
                && !p.IsConstant && !predefinedOptionalProperties.Contains(p.Name));
            if (optionalProperitesOnClient.Count() > 0)
            {
                string modelTypeName = cm.Name + "Options";
                var modelType = new CompositeTypeTS(modelTypeName);
                modelType.BaseModelType = New<CompositeType>(new { Name = "ServiceClientOptions", SerializedName = "ServiceClientOptions" });
                // We could end up having a property that is required but has a default value based on the above condition. If so then make it optional.
                optionalProperitesOnClient.Where(p => p.IsRequired && !string.IsNullOrEmpty(p.DefaultValue)).ForEach(prop => prop.IsRequired = false);
                modelType.AddRange(optionalProperitesOnClient);
                cm.Add(modelType);
                cm.OptionalParameterTypeForClientConstructor = "Models." + modelTypeName;
            }
        }

        /// <summary>
        ///     Normalize odata filter parameter to PrimaryType.String
        /// </summary>
        /// <param name="client">Service Client</param>
        public void NormalizeOdataFilterParameter(CodeModelTS client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            foreach (var method in client.Methods)
            {
                foreach (var parameter in method.Parameters)
                {
                    if (parameter.SerializedName.EqualsIgnoreCase("$filter") &&
                        (parameter.Location == ParameterLocation.Query) &&
                        parameter.ModelType is CompositeType)
                    {
                        parameter.ModelType = New<PrimaryType>(KnownPrimaryType.String);
                    }
                }
            }
        }


        private void PopulateAdditionalProperties(CodeModel codeModel)
        {
            if (Settings.Instance.AddCredentials)
            {
                if (!codeModel.Properties.Any(p => p.ModelType.IsPrimaryType(KnownPrimaryType.Credentials)))
                {
                    codeModel.Add(New<Property>(new
                    {
                        Name = "credentials",
                        SerializedName = "credentials",
                        ModelType = New<PrimaryType>(KnownPrimaryType.Credentials),
                        IsRequired = true,
                        Documentation = "Subscription credentials which uniquely identify client subscription."
                    }));
                }
            }
        }
    }
}