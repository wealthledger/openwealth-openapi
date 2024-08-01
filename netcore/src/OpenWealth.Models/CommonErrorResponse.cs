/*
 * Custody Services
 *
 * This API is part of the OpenWealth APIs for the connectivity between custody banks and WealthTechs (e.g. Portfolio Management Systems). This API allows the user to receive data from custody banks regarding accounts and positions. The API is designed to be used for either update end of day data batches or single near-realtime account/position information. Furthermore, this API allows the user to receive data from custody banks regarding transactions. In this version (2.0) only transactions which include effective cash or securities movements are in scope and corporate actions without any cash impact are delivered only on a informative basis. 
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: openwealth@synpulse.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using OpenWealth.Converters;

namespace OpenWealth.Models
{ 
    /// <summary>
    /// Common error response.
    /// </summary>
    [DataContract]
    public partial class CommonErrorResponse : IEquatable<CommonErrorResponse>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public CommonErrorType Type { get; set; }

        /// <summary>
        /// Title of the error response.
        /// </summary>
        /// <value>Title of the error response.</value>
        /// <example>This is the general problem description</example>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string? Title { get; set; }

        /// <summary>
        /// Detailed description of the error response.
        /// </summary>
        /// <value>Detailed description of the error response.</value>
        /// <example>Detailed problem description with respect to the current request</example>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string? Detail { get; set; }

        /// <summary>
        /// Entity instance that threw the error.
        /// </summary>
        /// <value>Entity instance that threw the error.</value>
        /// <example>path/to/corresponding/resource</example>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        public string? Instance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonErrorResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CommonErrorResponse)obj);
        }

        /// <summary>
        /// Returns true if CommonErrorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonErrorResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Detail == other.Detail ||
                    Detail != null &&
                    Detail.Equals(other.Detail)
                ) && 
                (
                    Instance == other.Instance ||
                    Instance != null &&
                    Instance.Equals(other.Instance)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Detail != null)
                    hashCode = hashCode * 59 + Detail.GetHashCode();
                    if (Instance != null)
                    hashCode = hashCode * 59 + Instance.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommonErrorResponse left, CommonErrorResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonErrorResponse left, CommonErrorResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
