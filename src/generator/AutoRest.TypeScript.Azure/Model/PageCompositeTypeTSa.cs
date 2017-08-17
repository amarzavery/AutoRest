// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.TypeScript.Azure.Properties;
using System;
using AutoRest.TypeScript.Model;

namespace AutoRest.TypeScript.Azure.Model
{
    public class PageCompositeTypeTSa : CompositeTypeTS
    {
        public PageCompositeTypeTSa(string nextLinkName, string itemName) 
        {
            NextLinkName = nextLinkName;
            ItemName = itemName;
        }

        public string NextLinkName { get; private set; }

        public string ItemName { get; private set; }

        public IModelType ItemType { 
            get 
            {
                if (Properties == null)
                {
                    return null;
                }
                var property = Properties.FirstOrDefault(p => p.ModelType is SequenceTypeTS);
                if (property != null)
                {
                    return ((SequenceTypeTS)property.ModelType).ElementType;
                }
                else
                {
                    throw new Exception(string.Format(Resources.PageModelDoesnotHaveAnArrayProperty, Name));
                }
            }
        }

        public string ConstructTSItemTypeName()
        {
            var builder = new IndentedStringBuilder("  ");
            builder.AppendFormat("<{0}>", ClientModelExtensions.TSType(ItemType, true));
            return builder.ToString();
        }

        public override string ConstructModelMapper()
        {
            var modelMapper = this.ConstructMapper(SerializedName, null, true, true);
            var builder = new IndentedStringBuilder("  ");
            builder.AppendLine("export const {0} = {{{1}}};", Name, modelMapper);
            return builder.ToString();
        }
    }
}
