/*
 * Bonus Operations API for MobileAplication
 *
 * This microservice allows you to receive information about transactions in the MKB bonus
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Объект кнопки
    /// </summary>
    [DataContract]
    public partial class ExpandedOperationButtons : IEquatable<ExpandedOperationButtons>
    { 
        /// <summary>
        /// Заголовок заполянется из woodside
        /// </summary>
        /// <value>Заголовок заполянется из woodside</value>

        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>

        [DataMember(Name="icon")]
        public ExpandedOperationIcon1 Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandedOperationButtons {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ExpandedOperationButtons)obj);
        }

        /// <summary>
        /// Returns true if ExpandedOperationButtons instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpandedOperationButtons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpandedOperationButtons other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Icon == other.Icon ||
                    Icon != null &&
                    Icon.Equals(other.Icon)
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
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Icon != null)
                    hashCode = hashCode * 59 + Icon.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExpandedOperationButtons left, ExpandedOperationButtons right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExpandedOperationButtons left, ExpandedOperationButtons right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
