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
    /// CampaignEvaluationGroup
    /// </summary>
    [DataContract]
    public partial class CampaignEvaluationGroup :  IEquatable<CampaignEvaluationGroup>, IValidatableObject
    {
        /// <summary>
        /// The mode by which campaigns in the campaign evaluation group are evaluated.
        /// </summary>
        /// <value>The mode by which campaigns in the campaign evaluation group are evaluated.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EvaluationModeEnum
        {
            /// <summary>
            /// Enum Stackable for value: stackable
            /// </summary>
            [EnumMember(Value = "stackable")]
            Stackable = 1,

            /// <summary>
            /// Enum ListOrder for value: listOrder
            /// </summary>
            [EnumMember(Value = "listOrder")]
            ListOrder = 2,

            /// <summary>
            /// Enum LowestDiscount for value: lowestDiscount
            /// </summary>
            [EnumMember(Value = "lowestDiscount")]
            LowestDiscount = 3,

            /// <summary>
            /// Enum HighestDiscount for value: highestDiscount
            /// </summary>
            [EnumMember(Value = "highestDiscount")]
            HighestDiscount = 4

        }

        /// <summary>
        /// The mode by which campaigns in the campaign evaluation group are evaluated.
        /// </summary>
        /// <value>The mode by which campaigns in the campaign evaluation group are evaluated.</value>
        [DataMember(Name="evaluationMode", EmitDefaultValue=false)]
        public EvaluationModeEnum EvaluationMode { get; set; }
        /// <summary>
        /// The evaluation scope of the campaign evaluation group.
        /// </summary>
        /// <value>The evaluation scope of the campaign evaluation group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EvaluationScopeEnum
        {
            /// <summary>
            /// Enum CartItem for value: cartItem
            /// </summary>
            [EnumMember(Value = "cartItem")]
            CartItem = 1,

            /// <summary>
            /// Enum Session for value: session
            /// </summary>
            [EnumMember(Value = "session")]
            Session = 2

        }

        /// <summary>
        /// The evaluation scope of the campaign evaluation group.
        /// </summary>
        /// <value>The evaluation scope of the campaign evaluation group.</value>
        [DataMember(Name="evaluationScope", EmitDefaultValue=false)]
        public EvaluationScopeEnum EvaluationScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignEvaluationGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignEvaluationGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignEvaluationGroup" /> class.
        /// </summary>
        /// <param name="applicationId">The ID of the Application that owns this entity. (required).</param>
        /// <param name="name">The name of the campaign evaluation group. (required).</param>
        /// <param name="parentId">The ID of the parent group that contains the campaign evaluation group. (required).</param>
        /// <param name="description">A description of the campaign evaluation group..</param>
        /// <param name="evaluationMode">The mode by which campaigns in the campaign evaluation group are evaluated. (required).</param>
        /// <param name="evaluationScope">The evaluation scope of the campaign evaluation group. (required).</param>
        /// <param name="locked">An indicator of whether the campaign evaluation group is locked for modification. (required).</param>
        /// <param name="id">Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints. (required).</param>
        public CampaignEvaluationGroup(int applicationId = default(int), string name = default(string), int parentId = default(int), string description = default(string), EvaluationModeEnum evaluationMode = default(EvaluationModeEnum), EvaluationScopeEnum evaluationScope = default(EvaluationScopeEnum), bool locked = default(bool), int id = default(int))
        {
            this.ApplicationId = applicationId;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CampaignEvaluationGroup and cannot be null");
            this.ParentId = parentId;
            this.EvaluationMode = evaluationMode;
            this.EvaluationScope = evaluationScope;
            this.Locked = locked;
            this.Id = id;
            this.Description = description;
        }
        
        /// <summary>
        /// The ID of the Application that owns this entity.
        /// </summary>
        /// <value>The ID of the Application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The name of the campaign evaluation group.
        /// </summary>
        /// <value>The name of the campaign evaluation group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the parent group that contains the campaign evaluation group.
        /// </summary>
        /// <value>The ID of the parent group that contains the campaign evaluation group.</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int ParentId { get; set; }

        /// <summary>
        /// A description of the campaign evaluation group.
        /// </summary>
        /// <value>A description of the campaign evaluation group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An indicator of whether the campaign evaluation group is locked for modification.
        /// </summary>
        /// <value>An indicator of whether the campaign evaluation group is locked for modification.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool Locked { get; set; }

        /// <summary>
        /// Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints.
        /// </summary>
        /// <value>Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignEvaluationGroup {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EvaluationMode: ").Append(EvaluationMode).Append("\n");
            sb.Append("  EvaluationScope: ").Append(EvaluationScope).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CampaignEvaluationGroup);
        }

        /// <summary>
        /// Returns true if CampaignEvaluationGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignEvaluationGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignEvaluationGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    this.ParentId.Equals(input.ParentId)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EvaluationMode == input.EvaluationMode ||
                    this.EvaluationMode.Equals(input.EvaluationMode)
                ) && 
                (
                    this.EvaluationScope == input.EvaluationScope ||
                    this.EvaluationScope.Equals(input.EvaluationScope)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
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
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.EvaluationMode.GetHashCode();
                hashCode = hashCode * 59 + this.EvaluationScope.GetHashCode();
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
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
            // ParentId (int) minimum
            if(this.ParentId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentId, must be a value greater than or equal to 1.", new [] { "ParentId" });
            }

            yield break;
        }
    }

}
