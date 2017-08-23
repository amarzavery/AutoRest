// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.TypeScript.Model;
using AutoRest.TypeScript.Properties;
using AutoRest.TypeScript.Templates;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.TypeScript
{
    public class CodeGeneratorTS : CodeGenerator
    {
        private const string ClientRuntimePackage = "ms-rest-ts version 0.1.0";


        public override string ImplementationFileExtension => ".ts";


        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
            Resources.UsageInformation, ClientRuntimePackage);

        /// <summary>
        ///     Generate TypeScript client code 
        /// </summary>
        /// <param name="serviceClient"></param>
        /// <returns></returns>
        public override async Task Generate(CodeModel cm)
        {
            var codeModel = cm as CodeModelTS;
            if (codeModel == null)
            {
                throw new InvalidCastException("CodeModel is not a TypeScript code model.");
            }

            // Service client
            var serviceClientTemplate = new ServiceClientTemplate {Model = codeModel};
            await Write(serviceClientTemplate, codeModel.Name.ToCamelCase() + ".ts");

            //Models
            if (codeModel.ModelTypes.Any())
            {
                var modelIndexTemplate = new ModelIndexTemplate {Model = codeModel};
                await Write(modelIndexTemplate, Path.Combine("models", "index.ts"));
                var mapperIndexTemplate = new MapperIndexTemplate {Model = codeModel};
                await Write(mapperIndexTemplate, Path.Combine("models", "mappers.ts"));
            }

            //MethodGroups
            if (codeModel.MethodGroupModels.Any())
            {
                var methodGroupIndexTemplate = new MethodGroupIndexTemplate {Model = codeModel};
                await Write(methodGroupIndexTemplate, Path.Combine("operations", "index.ts"));

                foreach (var methodGroupModel in codeModel.MethodGroupModels)
                {
                    var methodGroupTemplate = new MethodGroupTemplate {Model = methodGroupModel};
                    await Write(methodGroupTemplate, Path.Combine("operations", methodGroupModel.TypeName.ToCamelCase() + ".ts"));
                }
            }
        }
    }
}
