/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    /// The properties specific to the \&quot;awardGiveaway\&quot; effect. This effect contains information on the giveaway item, and which profile it was awarded to.
    /// </summary>
    [DataContract]
    public partial class AwardGiveawayEffectProps :  IEquatable<AwardGiveawayEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwardGiveawayEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AwardGiveawayEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AwardGiveawayEffectProps" /> class.
        /// </summary>
        /// <param name="poolId">The ID of the giveaways pool the code was taken from. (required).</param>
        /// <param name="poolName">The name of the giveaways pool the code was taken from. (required).</param>
        /// <param name="recipientIntegrationId">The integration ID of the profile that was awarded the giveaway. (required).</param>
        /// <param name="giveawayId">The internal ID for the giveaway that was awarded. (required).</param>
        /// <param name="code">The giveaway code that was awarded. (required).</param>
        public AwardGiveawayEffectProps(int poolId = default(int), string poolName = default(string), string recipientIntegrationId = default(string), int giveawayId = default(int), string code = default(string))
        {
            // to ensure "poolId" is required (not null)
            if (poolId == null)
            {
                throw new InvalidDataException("poolId is a required property for AwardGiveawayEffectProps and cannot be null");
            }
            else
            {
                this.PoolId = poolId;
            }
            
            // to ensure "poolName" is required (not null)
            if (poolName == null)
            {
                throw new InvalidDataException("poolName is a required property for AwardGiveawayEffectProps and cannot be null");
            }
            else
            {
                this.PoolName = poolName;
            }
            
            // to ensure "recipientIntegrationId" is required (not null)
            if (recipientIntegrationId == null)
            {
                throw new InvalidDataException("recipientIntegrationId is a required property for AwardGiveawayEffectProps and cannot be null");
            }
            else
            {
                this.RecipientIntegrationId = recipientIntegrationId;
            }
            
            // to ensure "giveawayId" is required (not null)
            if (giveawayId == null)
            {
                throw new InvalidDataException("giveawayId is a required property for AwardGiveawayEffectProps and cannot be null");
            }
            else
            {
                this.GiveawayId = giveawayId;
            }
            
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for AwardGiveawayEffectProps and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
        }
        
        /// <summary>
        /// The ID of the giveaways pool the code was taken from.
        /// </summary>
        /// <value>The ID of the giveaways pool the code was taken from.</value>
        [DataMember(Name="poolId", EmitDefaultValue=true)]
        public int PoolId { get; set; }

        /// <summary>
        /// The name of the giveaways pool the code was taken from.
        /// </summary>
        /// <value>The name of the giveaways pool the code was taken from.</value>
        [DataMember(Name="poolName", EmitDefaultValue=true)]
        public string PoolName { get; set; }

        /// <summary>
        /// The integration ID of the profile that was awarded the giveaway.
        /// </summary>
        /// <value>The integration ID of the profile that was awarded the giveaway.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=true)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// The internal ID for the giveaway that was awarded.
        /// </summary>
        /// <value>The internal ID for the giveaway that was awarded.</value>
        [DataMember(Name="giveawayId", EmitDefaultValue=true)]
        public int GiveawayId { get; set; }

        /// <summary>
        /// The giveaway code that was awarded.
        /// </summary>
        /// <value>The giveaway code that was awarded.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AwardGiveawayEffectProps {\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  PoolName: ").Append(PoolName).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  GiveawayId: ").Append(GiveawayId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as AwardGiveawayEffectProps);
        }

        /// <summary>
        /// Returns true if AwardGiveawayEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of AwardGiveawayEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwardGiveawayEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
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
                ) && 
                (
                    this.GiveawayId == input.GiveawayId ||
                    (this.GiveawayId != null &&
                    this.GiveawayId.Equals(input.GiveawayId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.PoolName != null)
                    hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.GiveawayId != null)
                    hashCode = hashCode * 59 + this.GiveawayId.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
