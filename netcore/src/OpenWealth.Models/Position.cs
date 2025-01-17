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
    /// Position entity.
    /// </summary>
    [DataContract]
    public partial class Position : IEquatable<Position>
    {
        /// <summary>
        /// Identification for the position given by the bank.
        /// </summary>
        /// <value>Identification for the position given by the bank.</value>
        /// <example>876-543219</example>
        [Required]
        [MaxLength(128)]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FinancialInstrument
        /// </summary>
        [Required]
        [DataMember(Name="financialInstrument", EmitDefaultValue=false)]
        public FinancialInstrument FinancialInstrument { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [Required]
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Account Account { get; set; }

        /// <summary>
        /// Name of the position.
        /// </summary>
        /// <value>Name of the position.</value>
        /// <example>Stark Industries Inc.</example>
        [MaxLength(80)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string? Name { get; set; }

        /// <summary>
        /// ISO 4217 code.
        /// </summary>
        /// <value>ISO 4217 code.</value>
        /// <example>CHF</example>
        [RegularExpression("^[A-Z]{3}$")]
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string? Currency { get; set; }

        /// <summary>
        /// BIC of the place where the securities are safe-kept, physically or notionally.
        /// </summary>
        /// <value>BIC of the place where the securities are safe-kept, physically or notionally.</value>
        /// <example>INSECHZZXXX</example>
        [RegularExpression("^[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}$")]
        [DataMember(Name="safekeepingPlace", EmitDefaultValue=false)]
        public string? SafekeepingPlace { get; set; }

        /// <summary>
        /// Used for special use cases where safekeepingPlace is not sufficient. BIC of the place where the securities are safe-kept, physically or notionally. 
        /// </summary>
        /// <value>Used for special use cases where safekeepingPlace is not sufficient. BIC of the place where the securities are safe-kept, physically or notionally. </value>
        /// <example>INSECHZZXXX</example>
        [RegularExpression("^[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}$")]
        [DataMember(Name="additionalCustodianInformation", EmitDefaultValue=false)]
        public string? AdditionalCustodianInformation { get; set; }

        /// <summary>
        /// Provides additional information on the position.
        /// </summary>
        /// <value>Provides additional information on the position.</value>
        /// <example>Belongs to contract 129959959</example>
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
            sb.Append("class Position {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FinancialInstrument: ").Append(FinancialInstrument).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SafekeepingPlace: ").Append(SafekeepingPlace).Append("\n");
            sb.Append("  AdditionalCustodianInformation: ").Append(AdditionalCustodianInformation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Position)obj);
        }

        /// <summary>
        /// Returns true if Position instances are equal
        /// </summary>
        /// <param name="other">Instance of Position to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Position other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    FinancialInstrument == other.FinancialInstrument ||
                    FinancialInstrument != null &&
                    FinancialInstrument.Equals(other.FinancialInstrument)
                ) && 
                (
                    Account == other.Account ||
                    Account != null &&
                    Account.Equals(other.Account)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    SafekeepingPlace == other.SafekeepingPlace ||
                    SafekeepingPlace != null &&
                    SafekeepingPlace.Equals(other.SafekeepingPlace)
                ) && 
                (
                    AdditionalCustodianInformation == other.AdditionalCustodianInformation ||
                    AdditionalCustodianInformation != null &&
                    AdditionalCustodianInformation.Equals(other.AdditionalCustodianInformation)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (FinancialInstrument != null)
                    hashCode = hashCode * 59 + FinancialInstrument.GetHashCode();
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (SafekeepingPlace != null)
                    hashCode = hashCode * 59 + SafekeepingPlace.GetHashCode();
                    if (AdditionalCustodianInformation != null)
                    hashCode = hashCode * 59 + AdditionalCustodianInformation.GetHashCode();
                    if (AdditionalDetails != null)
                    hashCode = hashCode * 59 + AdditionalDetails.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Position left, Position right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
