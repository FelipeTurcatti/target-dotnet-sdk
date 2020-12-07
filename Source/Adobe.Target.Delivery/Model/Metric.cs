// <auto-generated/>
/*
 * Copyright 2020 Adobe. All rights reserved.
 * This file is licensed to you under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
 * OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adobe.Target.Delivery.Client.OpenAPIDateConverter;

namespace Adobe.Target.Delivery.Model
{
    /// <summary>
    /// Metric
    /// </summary>
    [DataContract(Name = "Metric")]
    public partial class Metric : IEquatable<Metric>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MetricType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="selector">The selector.</param>
        /// <param name="eventToken">The event token that should be sent with the notifications in case the click occurred..</param>
        public Metric(MetricType? type = default(MetricType?), string selector = default(string), string eventToken = default(string))
        {
            this.Type = type;
            this.Selector = selector;
            this.EventToken = eventToken;
        }

        /// <summary>
        /// The selector
        /// </summary>
        /// <value>The selector</value>
        [DataMember(Name = "selector", EmitDefaultValue = false)]
        public string Selector { get; set; }

        /// <summary>
        /// The event token that should be sent with the notifications in case the click occurred.
        /// </summary>
        /// <value>The event token that should be sent with the notifications in case the click occurred.</value>
        [DataMember(Name = "eventToken", EmitDefaultValue = false)]
        public string EventToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metric {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  EventToken: ").Append(EventToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Metric);
        }

        /// <summary>
        /// Returns true if Metric instances are equal
        /// </summary>
        /// <param name="input">Instance of Metric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metric input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Selector == input.Selector ||
                    (this.Selector != null &&
                    this.Selector.Equals(input.Selector))
                ) && 
                (
                    this.EventToken == input.EventToken ||
                    (this.EventToken != null &&
                    this.EventToken.Equals(input.EventToken))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Selector != null)
                    hashCode = hashCode * 59 + this.Selector.GetHashCode();
                if (this.EventToken != null)
                    hashCode = hashCode * 59 + this.EventToken.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
