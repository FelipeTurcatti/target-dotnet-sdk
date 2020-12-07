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
    /// Telemetry Features
    /// </summary>
    [DataContract(Name = "TelemetryFeatures")]
    public partial class TelemetryFeatures : IEquatable<TelemetryFeatures>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DecisioningMethod
        /// </summary>
        [DataMember(Name = "decisioningMethod", EmitDefaultValue = false)]
        public DecisioningMethod? DecisioningMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryFeatures" /> class.
        /// </summary>
        /// <param name="decisioningMethod">decisioningMethod.</param>
        public TelemetryFeatures(DecisioningMethod? decisioningMethod = default(DecisioningMethod?))
        {
            this.DecisioningMethod = decisioningMethod;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelemetryFeatures {\n");
            sb.Append("  DecisioningMethod: ").Append(DecisioningMethod).Append("\n");
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
            return this.Equals(input as TelemetryFeatures);
        }

        /// <summary>
        /// Returns true if TelemetryFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of TelemetryFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelemetryFeatures input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DecisioningMethod == input.DecisioningMethod ||
                    this.DecisioningMethod.Equals(input.DecisioningMethod)
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
                hashCode = hashCode * 59 + this.DecisioningMethod.GetHashCode();
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
