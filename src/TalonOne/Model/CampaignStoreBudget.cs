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
    /// CampaignStoreBudget
    /// </summary>
    [DataContract]
    public partial class CampaignStoreBudget :  IEquatable<CampaignStoreBudget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignStoreBudget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignStoreBudget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignStoreBudget" /> class.
        /// </summary>
        /// <param name="id">The internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        /// <param name="storeId">The ID of the store. (required).</param>
        /// <param name="limits">The set of budget limits for stores linked to the campaign. (required).</param>
        public CampaignStoreBudget(int id = default(int), DateTime created = default(DateTime), int campaignId = default(int), int storeId = default(int), List<CampaignStoreBudgetLimitConfig> limits = default(List<CampaignStoreBudgetLimitConfig>))
        {
            this.Id = id;
            this.Created = created;
            this.CampaignId = campaignId;
            this.StoreId = storeId;
            // to ensure "limits" is required (not null)
            this.Limits = limits ?? throw new ArgumentNullException("limits is a required property for CampaignStoreBudget and cannot be null");
        }
        
        /// <summary>
        /// The internal ID of this entity.
        /// </summary>
        /// <value>The internal ID of this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The time this entity was created.
        /// </summary>
        /// <value>The time this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the campaign that owns this entity.
        /// </summary>
        /// <value>The ID of the campaign that owns this entity.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// The ID of the store.
        /// </summary>
        /// <value>The ID of the store.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public int StoreId { get; set; }

        /// <summary>
        /// The set of budget limits for stores linked to the campaign.
        /// </summary>
        /// <value>The set of budget limits for stores linked to the campaign.</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<CampaignStoreBudgetLimitConfig> Limits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignStoreBudget {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
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
            return this.Equals(input as CampaignStoreBudget);
        }

        /// <summary>
        /// Returns true if CampaignStoreBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignStoreBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignStoreBudget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    this.StoreId.Equals(input.StoreId)
                ) && 
                (
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
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
