// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Extensions.Azure;
using AutoRest.TypeScript.Model;
using Newtonsoft.Json;
using AutoRest.Core.Utilities;

namespace AutoRest.TypeScript.Azure.Model
{
    
    public class CodeModelTSa : CodeModelTS
    {
        public CodeModelTSa()
            : base()
        {
        }
        [JsonIgnore]
        public override bool IsAzure => true;


        [JsonIgnore]
        public override IEnumerable<CompositeTypeTS> ModelTemplateModels => ModelTypes.Cast<CompositeTypeTS>().Concat(PageTemplateModels).Where(each => !PageTemplateModels.Any(ptm => ptm.Name.EqualsIgnoreCase(each.Name)));



        public override CompositeType Add(CompositeType item)
        {
            // Removing all models that contain the extension "x-ms-external", as they will be
            // generated in TypeScript client runtime for azure - "ms-rest-azure".
            if (item.Extensions.ContainsKey(AzureExtensions.PageableExtension) ||
                item.Extensions.ContainsKey(AzureExtensions.ExternalExtension))
            {
                return null;
            }

            return base.Add(item);
        }

        public IList<PageCompositeTypeTSa> PageTemplateModels { get; set; } = new List<PageCompositeTypeTSa>();

        public bool shouldOptionsInterfaceBeDeclared
        {
            get
            {
                List<string> predefinedOptionalParameters = new List<string>() { "apiVersion", "acceptLanguage", "longRunningOperationRetryTimeout", "generateClientRequestId", "rpRegistrationRetryTimeout" };
                var optionalParameters = this.Properties.Where(
                    p => (!p.IsRequired || p.IsRequired && !string.IsNullOrEmpty(p.DefaultValue)) 
                    && !p.IsConstant && !predefinedOptionalParameters.Contains(p.Name));
                return optionalParameters.Count() > 0;
            }
        }
    }
}