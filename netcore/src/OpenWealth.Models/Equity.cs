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
    /// Equity, typically referred to as shareholders&#39; equity (or owners&#39; equity for privately held companies), represents the amount of money that would be returned to a company&#39;s shareholders if all of the assets were liquidated and all of the company&#39;s debt was paid off in the case of liquidation. 
    /// </summary>
    [DataContract]
    public partial class Equity : IEquatable<Equity>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=true)]
        public FinancialInstrumentType Type { get; set; }

        /// <summary>
        /// Name of the financial instrument in free format text.
        /// </summary>
        /// <value>Name of the financial instrument in free format text.</value>
        /// <example>Novartis AG</example>
        [Required]
        [MaxLength(170)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// List of identification objects.
        /// </summary>
        /// <value>List of identification objects.</value>
        [DataMember(Name="identificationList", EmitDefaultValue=false)]
        public List<FinancialInstrumentIdentification> IdentificationList { get; set; }

        /// <summary>
        /// Indicates the type of the financial instrument. Must follow the ISO 10962, which is also known as CFI (classification of financial instruments). At least indicate the CFI Category (1st character) and the CFI Group (2nd character). The CFI attributes 1-4 (3rd to 6th character in the string) are optional. 
        /// </summary>
        /// <value>Indicates the type of the financial instrument. Must follow the ISO 10962, which is also known as CFI (classification of financial instruments). At least indicate the CFI Category (1st character) and the CFI Group (2nd character). The CFI attributes 1-4 (3rd to 6th character in the string) are optional. </value>
        /// <example>ESVUFR</example>
        [RegularExpression("^[A-Z]{2,6}$")]
        [StringLength(6, MinimumLength=2)]
        [DataMember(Name="cfiCode", EmitDefaultValue=false)]
        public string? CfiCode { get; set; }

        /// <summary>
        /// ISO 4217 code.
        /// </summary>
        /// <value>ISO 4217 code.</value>
        /// <example>CHF</example>
        [RegularExpression("^[A-Z]{3}$")]
        [DataMember(Name="currencyOfDenomination", EmitDefaultValue=false)]
        public string? CurrencyOfDenomination { get; set; }

        /// <summary>
        /// Indicates if there is a factor present for this financial instrument. If this indicator is set to TRUE, but the factor attribute is not present, might indicate, that the factor cannot be delivered or is currently not available. 
        /// </summary>
        /// <value>Indicates if there is a factor present for this financial instrument. If this indicator is set to TRUE, but the factor attribute is not present, might indicate, that the factor cannot be delivered or is currently not available. </value>
        /// <example>true</example>
        [DataMember(Name="hasFactor", EmitDefaultValue=true)]
        public bool? HasFactor { get; set; }

        /// <summary>
        /// Information regarding the factor.
        /// </summary>
        /// <value>Information regarding the factor.</value>
        /// <example>0.85</example>
        [DataMember(Name="factor", EmitDefaultValue=true)]
        public decimal? Factor { get; set; }

        /// <summary>
        /// Provides additional information about the financial instrument in narrative form.
        /// </summary>
        /// <value>Provides additional information about the financial instrument in narrative form.</value>
        /// <example>Group contract number 129959961</example>
        [MaxLength(70)]
        [DataMember(Name="additionalDetails", EmitDefaultValue=false)]
        public string? AdditionalDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Equity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IdentificationList: ").Append(IdentificationList).Append("\n");
            sb.Append("  CfiCode: ").Append(CfiCode).Append("\n");
            sb.Append("  CurrencyOfDenomination: ").Append(CurrencyOfDenomination).Append("\n");
            sb.Append("  HasFactor: ").Append(HasFactor).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Equity)obj);
        }

        /// <summary>
        /// Returns true if Equity instances are equal
        /// </summary>
        /// <param name="other">Instance of Equity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Equity other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    IdentificationList == other.IdentificationList ||
                    IdentificationList != null &&
                    other.IdentificationList != null &&
                    IdentificationList.SequenceEqual(other.IdentificationList)
                ) && 
                (
                    CfiCode == other.CfiCode ||
                    CfiCode != null &&
                    CfiCode.Equals(other.CfiCode)
                ) && 
                (
                    CurrencyOfDenomination == other.CurrencyOfDenomination ||
                    CurrencyOfDenomination != null &&
                    CurrencyOfDenomination.Equals(other.CurrencyOfDenomination)
                ) && 
                (
                    HasFactor == other.HasFactor ||
                    
                    HasFactor.Equals(other.HasFactor)
                ) && 
                (
                    Factor == other.Factor ||
                    
                    Factor.Equals(other.Factor)
                ) && 
                (
                    AdditionalDetails == other.AdditionalDetails ||
                    AdditionalDetails != null &&
                    AdditionalDetails.Equals(other.AdditionalDetails)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (IdentificationList != null)
                    hashCode = hashCode * 59 + IdentificationList.GetHashCode();
                    if (CfiCode != null)
                    hashCode = hashCode * 59 + CfiCode.GetHashCode();
                    if (CurrencyOfDenomination != null)
                    hashCode = hashCode * 59 + CurrencyOfDenomination.GetHashCode();
                    
                    hashCode = hashCode * 59 + HasFactor.GetHashCode();
                    
                    hashCode = hashCode * 59 + Factor.GetHashCode();
                    if (AdditionalDetails != null)
                    hashCode = hashCode * 59 + AdditionalDetails.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Equity left, Equity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Equity left, Equity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
