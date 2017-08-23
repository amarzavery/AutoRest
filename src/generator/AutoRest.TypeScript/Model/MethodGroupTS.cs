// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using Newtonsoft.Json;

namespace AutoRest.TypeScript.Model
{
    public class MethodGroupTS : MethodGroup
    {
        protected MethodGroupTS() : base()
        {
        }

        protected MethodGroupTS(string name): base(name)
        {
        }

        public override string NameForProperty => CodeNamer.Instance.GetPropertyName(TypeName);
        [JsonIgnore]
        public IEnumerable<MethodTS> MethodTemplateModels => Methods.Cast<MethodTS>();

        [JsonIgnore]
        public bool ContainsTimeSpan
        {
            get
            {
                Method method = this.MethodTemplateModels.FirstOrDefault(m => m.Parameters.FirstOrDefault(p =>
                    p.ModelType.IsPrimaryType(KnownPrimaryType.TimeSpan) ||
                    (p.ModelType is Core.Model.SequenceType && (p.ModelType as Core.Model.SequenceType).ElementType.IsPrimaryType(KnownPrimaryType.TimeSpan)) ||
                    (p.ModelType is Core.Model.DictionaryType && (p.ModelType as Core.Model.DictionaryType).ValueType.IsPrimaryType(KnownPrimaryType.TimeSpan)) ||
                    (p.ModelType is CompositeType && (p.ModelType as CompositeType).ContainsTimeSpan())) != null);
                return  method != null;
            }
        }

        [JsonIgnore]
        public bool ContainsStream
        {
            get {
                return this.Methods.Any(m => m.Parameters.FirstOrDefault(p => p.ModelType.IsPrimaryType(KnownPrimaryType.Stream)) != null ||
                        m.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream)); }
        }

        public bool ContainsCompositeTypeInParametersOrReturnType()
        {
            bool parameters = this.MethodTemplateModels.Any(m => m.Parameters.FirstOrDefault(
                p => p.ModelType is CompositeType ||
                (p.ModelType is SequenceType && (p.ModelType as SequenceType).ElementType is CompositeType) ||
                (p.ModelType is DictionaryType && (p.ModelType as DictionaryType).ValueType is CompositeType)) != null);
            if (!parameters)
            {
                return this.MethodTemplateModels.Any(m => m.ReturnType.Body is CompositeType ||
                (m.ReturnType.Body is SequenceType && (m.ReturnType.Body as SequenceType).ElementType is CompositeType) ||
                (m.ReturnType.Body is DictionaryType && (m.ReturnType.Body as DictionaryType).ValueType is CompositeType));
            }
            return parameters;
        }
    }
}