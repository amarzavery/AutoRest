// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using static AutoRest.Core.Utilities.DependencyInjection;
using AutoRest.Extensions;

namespace AutoRest.TypeScript.Model
{
    public class CompositeTypeTS : CompositeType
    {
        public CompositeTypeTS()
        {

        }

        public CompositeTypeTS(string name) : base(name)
        {

        }

        public override Property Add(Property item)
        {
            var result = base.Add(item);
            if (result != null)
            {
                AddPolymorphicPropertyIfNecessary();
            }
            return result;
        }

        public string NameAsFileName => Name.EqualsIgnoreCase("index") ? "IndexModelType" : (string)Name;

        /// <summary>
        /// Gets or sets the discriminator property for polymorphic types.
        /// </summary>
        public override string PolymorphicDiscriminator
        {
            get { return base.PolymorphicDiscriminator; }
            set
            {
                base.PolymorphicDiscriminator = value;
                AddPolymorphicPropertyIfNecessary();
            }
        }

        /// <summary>
        /// If PolymorphicDiscriminator is set, makes sure we have a PolymorphicDiscriminator property.
        /// </summary>
        private void AddPolymorphicPropertyIfNecessary()
        {
            if (!string.IsNullOrEmpty(PolymorphicDiscriminator) &&
                Properties.All(p => p.Name != PolymorphicDiscriminator))
            {
                base.Add(New<Core.Model.Property>(new
                {
                    IsRequired = true,
                    Name = this.PolymorphicDiscriminator,
                    SerializedName = this.PolymorphicDiscriminator,
                    Documentation = "Polymorphic Discriminator",
                    ModelType = New<PrimaryType>(KnownPrimaryType.String)
                }));
            }
        }

        public static string ConstructPropertyDocumentation(string propertyDocumentation)
        {
            var builder = new IndentedStringBuilder("  ");
            return builder.AppendLine(propertyDocumentation).ToString();
        }

        private bool ContainsCompositeType(IModelType type)
        {
            bool result = false;
            //base condition
            if (type is CompositeType || 
                type is Core.Model.SequenceType && (type as Core.Model.SequenceType).ElementType is CompositeType || 
                type is Core.Model.DictionaryType && (type as Core.Model.DictionaryType).ValueType is CompositeType)
            {
                result = true;
            }
            else if (type is Core.Model.SequenceType)
            {
                result = ContainsCompositeType((type as Core.Model.SequenceType).ElementType);
            }
            else if (type is Core.Model.DictionaryType)
            {
                result = ContainsCompositeType((type as Core.Model.DictionaryType).ValueType);
            }
            return result;
        }

        public bool ContainsDurationProperty()
        {
            Core.Model.Property prop = ComposedProperties.FirstOrDefault(p =>
                (p.ModelType is PrimaryTypeTS && (p.ModelType as PrimaryTypeTS).KnownPrimaryType == KnownPrimaryType.TimeSpan) ||
                (p.ModelType is Core.Model.SequenceType && (p.ModelType as Core.Model.SequenceType).ElementType.IsPrimaryType(KnownPrimaryType.TimeSpan)) ||
                (p.ModelType is Core.Model.DictionaryType && (p.ModelType as Core.Model.DictionaryType).ValueType.IsPrimaryType(KnownPrimaryType.TimeSpan)));
            return prop != null;
        }

        /// <summary>
        /// Returns the TypeScript string to define the specified property, including its type and whether it's optional or not
        /// </summary>
        /// <param name="property">Model property to query</param>
        /// <param name="inModelsModule">Pass true if generating the code for the models module, thus model types don't need a "models." prefix</param>
        /// <returns>TypeScript property definition</returns>
        public static string PropertyTS(Core.Model.Property property, bool inModelsModule) 
        {
            if (property == null) 
            {
                throw new ArgumentNullException(nameof(property));
            }

            string typeString = property.ModelType.TSType(inModelsModule);
            var propertyName = property.Name;
            if (property.IsReadOnly)
            {
                propertyName = "readonly " + propertyName;
            }
            if (!property.IsRequired)
                return propertyName + "?: " + typeString;
            else return propertyName + ": " + typeString;
        }

        public virtual string ConstructModelMapper()
        {
            var modelMapper = this.ConstructMapper(SerializedName, null, false, true);
            var builder = new IndentedStringBuilder("  ");
            builder.AppendLine("export const {0} = {{{1}}};", Name, modelMapper);
            return builder.ToString();
        }

        /// <summary>
        /// Provides the property name in the correct jsdoc notation depending on 
        /// whether it is required or optional
        /// </summary>
        /// <param name="property">Parameter to be documented</param>
        /// <returns>Parameter name in the correct jsdoc notation</returns>
        public static string GetPropertyDocumentationName(Core.Model.Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            return property.IsRequired ? (string) property.Name : $"[{property.Name}]";
        }

        /// <summary>
        /// Provides the property documentation string along with default value if any.
        /// </summary>
        /// <param name="property">Parameter to be documented</param>
        /// <returns>Parameter documentation string along with default value if any 
        /// in correct jsdoc notation</returns>
        public static string GetPropertyDocumentationString(Core.Model.Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            return property.DefaultValue.IsNullOrEmpty() ?
                $"{property.Summary.EnsureEndsWith(".")} {property.Documentation}".Trim() : 
                $"{property.Summary.EnsureEndsWith(".")} {property.Documentation.EnsureEndsWith(".")} Default value: {property.DefaultValue} .".Trim();
        }
    }
}