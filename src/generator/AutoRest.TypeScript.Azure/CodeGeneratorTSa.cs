// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.TypeScript.Azure.Model;
using AutoRest.TypeScript.Azure.Properties;
using AutoRest.TypeScript.Azure.Templates;
using AutoRest.TypeScript.Templates;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.TypeScript.Azure
{
    public class CodeGeneratorTSa : TypeScript.CodeGeneratorTS
    {
        private const string ClientRuntimePackage = "ms-rest-azure-ts version 0.1.0";

        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
            Resources.UsageInformation, ClientRuntimePackage);

        public override string ImplementationFileExtension => ".ts";


        /// <summary>
        /// Generate Azure TypeScript client code 
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public override async Task Generate(CodeModel cm)
        {
            var codeModel = cm as CodeModelTSa;
            if (codeModel == null)
            {
                throw new InvalidCastException("CodeModel is not a Azure TypeScript code model.");
            }

            // Service client
            var serviceClientTemplate = new AzureServiceClientTemplate { Model = codeModel };
            await Write(serviceClientTemplate, codeModel.Name.ToCamelCase() + ".ts");

            //Models
            if (codeModel.ModelTemplateModels.Any())
            {
                var modelIndexTemplate = new AzureModelIndexTemplate { Model = codeModel };
                await Write(modelIndexTemplate, Path.Combine("models", "index.ts"));
                var mapperIndexTemplate = new AzureMapperIndexTemplate { Model = codeModel };
                await Write(mapperIndexTemplate, Path.Combine("models", "mappers.ts"));
            }

            //MethodGroups
            if (codeModel.MethodGroupModels.Any())
            {
                var methodGroupIndexTemplate = new MethodGroupIndexTemplate { Model = codeModel };
                await Write(methodGroupIndexTemplate, Path.Combine("operations", "index.ts"));
                
                foreach (var methodGroupModel in codeModel.MethodGroupModels)
                {
                    var methodGroupTemplate = new AzureMethodGroupTemplate { Model = methodGroupModel };
                    await Write(methodGroupTemplate, Path.Combine("operations", methodGroupModel.TypeName.ToCamelCase() + ".ts"));
                }
            }
        }
    }
}
