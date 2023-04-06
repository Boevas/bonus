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
    /// 
    /// </summary>
    [DataContract]
    public partial class ExpandedOperationResponse : IEquatable<ExpandedOperationResponse>
    { 
        /// <summary>
        /// Gets or Sets Code
        /// </summary>

        [DataMember(Name="code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or Sets MessageTitle
        /// </summary>

        [DataMember(Name="messageTitle")]
        public string MessageTitle { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>

        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Rid
        /// </summary>

        [DataMember(Name="rid")]
        public string Rid { get; set; }

        /// <summary>
        /// Gets or Sets ExpandedOperation
        /// </summary>

        [DataMember(Name="ExpandedOperation")]
        public ExpandedOperation ExpandedOperation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandedOperationResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MessageTitle: ").Append(MessageTitle).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  ExpandedOperation: ").Append(ExpandedOperation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExpandedOperationResponse)obj);
        }

        /// <summary>
        /// Returns true if ExpandedOperationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpandedOperationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpandedOperationResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    MessageTitle == other.MessageTitle ||
                    MessageTitle != null &&
                    MessageTitle.Equals(other.MessageTitle)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    Rid == other.Rid ||
                    Rid != null &&
                    Rid.Equals(other.Rid)
                ) && 
                (
                    ExpandedOperation == other.ExpandedOperation ||
                    ExpandedOperation != null &&
                    ExpandedOperation.Equals(other.ExpandedOperation)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (MessageTitle != null)
                    hashCode = hashCode * 59 + MessageTitle.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (Rid != null)
                    hashCode = hashCode * 59 + Rid.GetHashCode();
                    if (ExpandedOperation != null)
                    hashCode = hashCode * 59 + ExpandedOperation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExpandedOperationResponse left, ExpandedOperationResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExpandedOperationResponse left, ExpandedOperationResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
