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
    /// Telemetry Entry.
    /// </summary>
    [DataContract(Name = "TelemetryEntry")]
    public partial class TelemetryEntry : IEquatable<TelemetryEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryEntry" /> class.
        /// </summary>
        /// <param name="requestId">Request Id.</param>
        /// <param name="timestamp">Timestamp of the entry, in milliseconds elapsed since UNIX epoch..</param>
        /// <param name="execution">Execution time in milliseconds..</param>
        /// <param name="features">features.</param>
        public TelemetryEntry(string requestId = default(string), long timestamp = default(long), int execution = default(int), TelemetryFeatures features = default(TelemetryFeatures))
        {
            this.RequestId = requestId;
            this.Timestamp = timestamp;
            this.Execution = execution;
            this.Features = features;
        }

        /// <summary>
        /// Request Id
        /// </summary>
        /// <value>Request Id</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Timestamp of the entry, in milliseconds elapsed since UNIX epoch.
        /// </summary>
        /// <value>Timestamp of the entry, in milliseconds elapsed since UNIX epoch.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// Execution time in milliseconds.
        /// </summary>
        /// <value>Execution time in milliseconds.</value>
        [DataMember(Name = "execution", EmitDefaultValue = false)]
        public int Execution { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public TelemetryFeatures Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelemetryEntry {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Execution: ").Append(Execution).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as TelemetryEntry);
        }

        /// <summary>
        /// Returns true if TelemetryEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of TelemetryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelemetryEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.Execution == input.Execution ||
                    this.Execution.Equals(input.Execution)
                ) && 
                (
                    this.Features == input.Features ||
                    (this.Features != null &&
                    this.Features.Equals(input.Features))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                hashCode = hashCode * 59 + this.Execution.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
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
