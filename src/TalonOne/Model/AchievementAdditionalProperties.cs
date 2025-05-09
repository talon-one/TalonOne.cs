/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// AchievementAdditionalProperties
    /// </summary>
    [DataContract]
    public partial class AchievementAdditionalProperties :  IEquatable<AchievementAdditionalProperties>, IValidatableObject
    {
        /// <summary>
        /// The status of the achievement.
        /// </summary>
        /// <value>The status of the achievement.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Inprogress for value: inprogress
            /// </summary>
            [EnumMember(Value = "inprogress")]
            Inprogress = 1,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 2,

            /// <summary>
            /// Enum Notstarted for value: not_started
            /// </summary>
            [EnumMember(Value = "not_started")]
            Notstarted = 3,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 4

        }

        /// <summary>
        /// The status of the achievement.
        /// </summary>
        /// <value>The status of the achievement.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementAdditionalProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AchievementAdditionalProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementAdditionalProperties" /> class.
        /// </summary>
        /// <param name="campaignId">The ID of the campaign the achievement belongs to. (required).</param>
        /// <param name="userId">ID of the user that created this achievement. (required).</param>
        /// <param name="createdBy">Name of the user that created the achievement.  **Note**: This is not available if the user has been deleted. .</param>
        /// <param name="hasProgress">Indicates if a customer has made progress in the achievement..</param>
        /// <param name="status">The status of the achievement..</param>
        public AchievementAdditionalProperties(int campaignId = default(int), int userId = default(int), string createdBy = default(string), bool hasProgress = default(bool), StatusEnum? status = default(StatusEnum?))
        {
            this.CampaignId = campaignId;
            this.UserId = userId;
            this.CreatedBy = createdBy;
            this.HasProgress = hasProgress;
            this.Status = status;
        }
        
        /// <summary>
        /// The ID of the campaign the achievement belongs to.
        /// </summary>
        /// <value>The ID of the campaign the achievement belongs to.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// ID of the user that created this achievement.
        /// </summary>
        /// <value>ID of the user that created this achievement.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Name of the user that created the achievement.  **Note**: This is not available if the user has been deleted. 
        /// </summary>
        /// <value>Name of the user that created the achievement.  **Note**: This is not available if the user has been deleted. </value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Indicates if a customer has made progress in the achievement.
        /// </summary>
        /// <value>Indicates if a customer has made progress in the achievement.</value>
        [DataMember(Name="hasProgress", EmitDefaultValue=false)]
        public bool HasProgress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchievementAdditionalProperties {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  HasProgress: ").Append(HasProgress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AchievementAdditionalProperties);
        }

        /// <summary>
        /// Returns true if AchievementAdditionalProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AchievementAdditionalProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchievementAdditionalProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.HasProgress == input.HasProgress ||
                    this.HasProgress.Equals(input.HasProgress)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.HasProgress.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
