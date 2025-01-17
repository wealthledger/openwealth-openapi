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
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [DataContract]
    public partial class PlaceOfTrade : IEquatable<PlaceOfTrade>
    {
        /// <summary>
        /// Market Identifier Code. Identification of a financial market, as stipulated in the norm ISOMarket Identifier Code. Identification of a financial market, as stipulated in the norm ISO 10383 \&quot;Codes for exchanges and market identifications\&quot;. 
        /// </summary>
        /// <value>Market Identifier Code. Identification of a financial market, as stipulated in the norm ISOMarket Identifier Code. Identification of a financial market, as stipulated in the norm ISO 10383 \&quot;Codes for exchanges and market identifications\&quot;. </value>
        /// <example>XSWX</example>
        [MaxLength(4)]
        [DataMember(Name="marketIdentificationCode", EmitDefaultValue=false)]
        public string? MarketIdentificationCode { get; set; }

        /// <summary>
        /// Description of the market when no Market Identification Code is available.
        /// </summary>
        /// <value>Description of the market when no Market Identification Code is available.</value>
        /// <example>OTC</example>
        [MaxLength(70)]
        [DataMember(Name="marketDescription", EmitDefaultValue=false)]
        public string? MarketDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaceOfTrade {\n");
            sb.Append("  MarketIdentificationCode: ").Append(MarketIdentificationCode).Append("\n");
            sb.Append("  MarketDescription: ").Append(MarketDescription).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PlaceOfTrade)obj);
        }

        /// <summary>
        /// Returns true if PlaceOfTrade instances are equal
        /// </summary>
        /// <param name="other">Instance of PlaceOfTrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceOfTrade other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MarketIdentificationCode == other.MarketIdentificationCode ||
                    MarketIdentificationCode != null &&
                    MarketIdentificationCode.Equals(other.MarketIdentificationCode)
                ) && 
                (
                    MarketDescription == other.MarketDescription ||
                    MarketDescription != null &&
                    MarketDescription.Equals(other.MarketDescription)
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
                    if (MarketIdentificationCode != null)
                    hashCode = hashCode * 59 + MarketIdentificationCode.GetHashCode();
                    if (MarketDescription != null)
                    hashCode = hashCode * 59 + MarketDescription.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PlaceOfTrade left, PlaceOfTrade right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlaceOfTrade left, PlaceOfTrade right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
