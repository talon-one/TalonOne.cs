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
    /// The properties specific to the \&quot;awardGiveaway\&quot; effect when the session is not closed yet. This effect replaces \&quot;awardGiveaway\&quot; only when updating a session with any state other than \&quot;closed\&quot;. This is to ensure no giveaway codes are leaked when they are still not guaranteed to be awarded.
    /// </summary>
    [DataContract]
    public partial class WillAwardGiveawayEffectProps :  IEquatable<WillAwardGiveawayEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WillAwardGiveawayEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WillAwardGiveawayEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WillAwardGiveawayEffectProps" /> class.
        /// </summary>
        /// <param name="poolId">The ID of the giveaways pool the code will be taken from. (required).</param>
        /// <param name="poolName">The name of the giveaways pool the code will be taken from. (required).</param>
        /// <param name="recipientIntegrationId">The integration ID of the profile that will be awarded the giveaway. (required).</param>
        public WillAwardGiveawayEffectProps(int poolId = default(int), string poolName = default(string), string recipientIntegrationId = default(string))
        {
            this.PoolId = poolId;
            // to ensure "poolName" is required (not null)
            this.PoolName = poolName ?? throw new ArgumentNullException("poolName is a required property for WillAwardGiveawayEffectProps and cannot be null");
            // to ensure "recipientIntegrationId" is required (not null)
            this.RecipientIntegrationId = recipientIntegrationId ?? throw new ArgumentNullException("recipientIntegrationId is a required property for WillAwardGiveawayEffectProps and cannot be null");
        }
        
        /// <summary>
        /// The ID of the giveaways pool the code will be taken from.
        /// </summary>
        /// <value>The ID of the giveaways pool the code will be taken from.</value>
        [DataMember(Name="poolId", EmitDefaultValue=false)]
        public int PoolId { get; set; }

        /// <summary>
        /// The name of the giveaways pool the code will be taken from.
        /// </summary>
        /// <value>The name of the giveaways pool the code will be taken from.</value>
        [DataMember(Name="poolName", EmitDefaultValue=false)]
        public string PoolName { get; set; }

        /// <summary>
        /// The integration ID of the profile that will be awarded the giveaway.
        /// </summary>
        /// <value>The integration ID of the profile that will be awarded the giveaway.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WillAwardGiveawayEffectProps {\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  PoolName: ").Append(PoolName).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
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
            return this.Equals(input as WillAwardGiveawayEffectProps);
        }

        /// <summary>
        /// Returns true if WillAwardGiveawayEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of WillAwardGiveawayEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WillAwardGiveawayEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    this.PoolId.Equals(input.PoolId)
                ) && 
                (
                    this.PoolName == input.PoolName ||
                    (this.PoolName != null &&
                    this.PoolName.Equals(input.PoolName))
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
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
                hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.PoolName != null)
                    hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
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
            // RecipientIntegrationId (string) maxLength
            if(this.RecipientIntegrationId != null && this.RecipientIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientIntegrationId, length must be less than 1000.", new [] { "RecipientIntegrationId" });
            }

            yield break;
        }
    }

}
