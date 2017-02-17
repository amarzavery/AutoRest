// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.PetstoreV2.Models
{
    using Fixtures.PetstoreV2;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for loginUser operation.
    /// </summary>
    public partial class LoginUserHeaders
    {
        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        public LoginUserHeaders() { }

        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        /// <param name="xRateLimit">calls per hour allowed by the user</param>
        /// <param name="xExpiresAfter">date in UTC when toekn expires</param>
        public LoginUserHeaders(int? xRateLimit = default(int?), System.DateTime? xExpiresAfter = default(System.DateTime?))
        {
            XRateLimit = xRateLimit;
            XExpiresAfter = xExpiresAfter;
        }

        /// <summary>
        /// Gets or sets calls per hour allowed by the user
        /// </summary>
        [JsonProperty(PropertyName = "X-Rate-Limit")]
        public int? XRateLimit { get; set; }

        /// <summary>
        /// Gets or sets date in UTC when toekn expires
        /// </summary>
        [JsonProperty(PropertyName = "X-Expires-After")]
        public System.DateTime? XExpiresAfter { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != XRateLimit )
            {
                result.Add(new XElement("X-Rate-Limit", XRateLimit) );
            }
            if( null != XExpiresAfter )
            {
                result.Add(new XElement("X-Expires-After", XExpiresAfter) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of LoginUserHeaders
        /// </summary>
        internal static LoginUserHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static LoginUserHeaders XmlDeserialize(XElement payload)
        {
            var result = new LoginUserHeaders();
            var deserializeXRateLimit = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultXRateLimit;
            if (deserializeXRateLimit(payload, "X-Rate-Limit", out resultXRateLimit))
            {
                result.XRateLimit = resultXRateLimit;
            }
            var deserializeXExpiresAfter = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultXExpiresAfter;
            if (deserializeXExpiresAfter(payload, "X-Expires-After", out resultXExpiresAfter))
            {
                result.XExpiresAfter = resultXExpiresAfter;
            }
            return result;
        }
    }
}
