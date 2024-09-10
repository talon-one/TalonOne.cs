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
    /// The properties specific to the \&quot;rollbackIncreasedAchievementProgress\&quot; effect. This gets triggered whenever a closed session where the &#x60;increaseAchievementProgress&#x60; effect was triggered is cancelled. This is applicable only when the customer has not completed the achievement.
    /// </summary>
    [DataContract]
    public partial class RollbackIncreasedAchievementProgressEffectProps :  IEquatable<RollbackIncreasedAchievementProgressEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackIncreasedAchievementProgressEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RollbackIncreasedAchievementProgressEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackIncreasedAchievementProgressEffectProps" /> class.
        /// </summary>
        /// <param name="achievementId">The internal ID of the achievement. (required).</param>
        /// <param name="achievementName">The name of the achievement. (required).</param>
        /// <param name="progressTrackerId">The internal ID of the achievement progress tracker. (required).</param>
        /// <param name="decreaseProgressBy">The value by which the customer&#39;s current progress in the achievement is decreased. (required).</param>
        /// <param name="currentProgress">The current progress of the customer in the achievement. (required).</param>
        /// <param name="target">The target value to complete the achievement. (required).</param>
        public RollbackIncreasedAchievementProgressEffectProps(int achievementId = default(int), string achievementName = default(string), int progressTrackerId = default(int), decimal decreaseProgressBy = default(decimal), decimal currentProgress = default(decimal), decimal target = default(decimal))
        {
            this.AchievementId = achievementId;
            // to ensure "achievementName" is required (not null)
            this.AchievementName = achievementName ?? throw new ArgumentNullException("achievementName is a required property for RollbackIncreasedAchievementProgressEffectProps and cannot be null");
            this.ProgressTrackerId = progressTrackerId;
            this.DecreaseProgressBy = decreaseProgressBy;
            this.CurrentProgress = currentProgress;
            this.Target = target;
        }
        
        /// <summary>
        /// The internal ID of the achievement.
        /// </summary>
        /// <value>The internal ID of the achievement.</value>
        [DataMember(Name="achievementId", EmitDefaultValue=false)]
        public int AchievementId { get; set; }

        /// <summary>
        /// The name of the achievement.
        /// </summary>
        /// <value>The name of the achievement.</value>
        [DataMember(Name="achievementName", EmitDefaultValue=false)]
        public string AchievementName { get; set; }

        /// <summary>
        /// The internal ID of the achievement progress tracker.
        /// </summary>
        /// <value>The internal ID of the achievement progress tracker.</value>
        [DataMember(Name="progressTrackerId", EmitDefaultValue=false)]
        public int ProgressTrackerId { get; set; }

        /// <summary>
        /// The value by which the customer&#39;s current progress in the achievement is decreased.
        /// </summary>
        /// <value>The value by which the customer&#39;s current progress in the achievement is decreased.</value>
        [DataMember(Name="decreaseProgressBy", EmitDefaultValue=false)]
        public decimal DecreaseProgressBy { get; set; }

        /// <summary>
        /// The current progress of the customer in the achievement.
        /// </summary>
        /// <value>The current progress of the customer in the achievement.</value>
        [DataMember(Name="currentProgress", EmitDefaultValue=false)]
        public decimal CurrentProgress { get; set; }

        /// <summary>
        /// The target value to complete the achievement.
        /// </summary>
        /// <value>The target value to complete the achievement.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public decimal Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollbackIncreasedAchievementProgressEffectProps {\n");
            sb.Append("  AchievementId: ").Append(AchievementId).Append("\n");
            sb.Append("  AchievementName: ").Append(AchievementName).Append("\n");
            sb.Append("  ProgressTrackerId: ").Append(ProgressTrackerId).Append("\n");
            sb.Append("  DecreaseProgressBy: ").Append(DecreaseProgressBy).Append("\n");
            sb.Append("  CurrentProgress: ").Append(CurrentProgress).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as RollbackIncreasedAchievementProgressEffectProps);
        }

        /// <summary>
        /// Returns true if RollbackIncreasedAchievementProgressEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of RollbackIncreasedAchievementProgressEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RollbackIncreasedAchievementProgressEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AchievementId == input.AchievementId ||
                    this.AchievementId.Equals(input.AchievementId)
                ) && 
                (
                    this.AchievementName == input.AchievementName ||
                    (this.AchievementName != null &&
                    this.AchievementName.Equals(input.AchievementName))
                ) && 
                (
                    this.ProgressTrackerId == input.ProgressTrackerId ||
                    this.ProgressTrackerId.Equals(input.ProgressTrackerId)
                ) && 
                (
                    this.DecreaseProgressBy == input.DecreaseProgressBy ||
                    this.DecreaseProgressBy.Equals(input.DecreaseProgressBy)
                ) && 
                (
                    this.CurrentProgress == input.CurrentProgress ||
                    this.CurrentProgress.Equals(input.CurrentProgress)
                ) && 
                (
                    this.Target == input.Target ||
                    this.Target.Equals(input.Target)
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
                hashCode = hashCode * 59 + this.AchievementId.GetHashCode();
                if (this.AchievementName != null)
                    hashCode = hashCode * 59 + this.AchievementName.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressTrackerId.GetHashCode();
                hashCode = hashCode * 59 + this.DecreaseProgressBy.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentProgress.GetHashCode();
                hashCode = hashCode * 59 + this.Target.GetHashCode();
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