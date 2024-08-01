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
    /// Financial instrument identification in the form of a key value pair.
    /// </summary>
    [DataContract]
    public partial class FinancialInstrumentIdentification : IEquatable<FinancialInstrumentIdentification>
    {
        /// <summary>
        /// Instrument identification.
        /// </summary>
        /// <value>Instrument identification.</value>
        /// <example>CH0012005267</example>
        [Required]
        [MaxLength(128)]
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }


        /// <summary>
        /// Type of the instrument ID. isin is preferred.
        /// </summary>
        /// <value>Type of the instrument ID. isin is preferred.</value>

        public enum TypeEnum
        {

            /// <summary>
            /// Enum Isin for isin
            /// </summary>
            [EnumMember(Value = "isin")]
            Isin = 1,

            /// <summary>
            /// Enum Sedol for sedol
            /// </summary>
            [EnumMember(Value = "sedol")]
            Sedol = 2,

            /// <summary>
            /// Enum Cusip for cusip
            /// </summary>
            [EnumMember(Value = "cusip")]
            Cusip = 3,

            /// <summary>
            /// Enum Ric for ric
            /// </summary>
            [EnumMember(Value = "ric")]
            Ric = 4,

            /// <summary>
            /// Enum TickerSymbol for tickerSymbol
            /// </summary>
            [EnumMember(Value = "tickerSymbol")]
            TickerSymbol = 5,

            /// <summary>
            /// Enum Bloomberg for bloomberg
            /// </summary>
            [EnumMember(Value = "bloomberg")]
            Bloomberg = 6,

            /// <summary>
            /// Enum Cta for cta
            /// </summary>
            [EnumMember(Value = "cta")]
            Cta = 7,

            /// <summary>
            /// Enum Quick for quick
            /// </summary>
            [EnumMember(Value = "quick")]
            Quick = 8,

            /// <summary>
            /// Enum Wertpapier for wertpapier
            /// </summary>
            [EnumMember(Value = "wertpapier")]
            Wertpapier = 9,

            /// <summary>
            /// Enum Dutch for dutch
            /// </summary>
            [EnumMember(Value = "dutch")]
            Dutch = 10,

            /// <summary>
            /// Enum Valoren for valoren
            /// </summary>
            [EnumMember(Value = "valoren")]
            Valoren = 11,

            /// <summary>
            /// Enum Sicovam for sicovam
            /// </summary>
            [EnumMember(Value = "sicovam")]
            Sicovam = 12,

            /// <summary>
            /// Enum Belgian for belgian
            /// </summary>
            [EnumMember(Value = "belgian")]
            Belgian = 13,

            /// <summary>
            /// Enum Common for common
            /// </summary>
            [EnumMember(Value = "common")]
            Common = 14,

            /// <summary>
            /// Enum Iso3 for iso3
            /// </summary>
            [EnumMember(Value = "iso3")]
            Iso3 = 15,

            /// <summary>
            /// Enum OtherProprietaryIdentification for otherProprietaryIdentification
            /// </summary>
            [EnumMember(Value = "otherProprietaryIdentification")]
            OtherProprietaryIdentification = 16
        }

        /// <summary>
        /// Type of the instrument ID. isin is preferred.
        /// </summary>
        /// <value>Type of the instrument ID. isin is preferred.</value>
        /// <example>isin</example>
        [Required]
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialInstrumentIdentification {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FinancialInstrumentIdentification)obj);
        }

        /// <summary>
        /// Returns true if FinancialInstrumentIdentification instances are equal
        /// </summary>
        /// <param name="other">Instance of FinancialInstrumentIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialInstrumentIdentification other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Identifier == other.Identifier ||
                    Identifier != null &&
                    Identifier.Equals(other.Identifier)
                ) &&
                (
                    Type == other.Type ||

                    Type.Equals(other.Type)
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
                if (Identifier != null)
                    hashCode = hashCode * 59 + Identifier.GetHashCode();

                hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FinancialInstrumentIdentification left, FinancialInstrumentIdentification right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FinancialInstrumentIdentification left, FinancialInstrumentIdentification right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
