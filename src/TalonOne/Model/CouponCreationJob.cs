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
    /// CouponCreationJob
    /// </summary>
    [DataContract]
    public partial class CouponCreationJob :  IEquatable<CouponCreationJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCreationJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CouponCreationJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCreationJob" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="usageLimit">The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  (required).</param>
        /// <param name="discountLimit">The total discount value that the code can give. Typically used to represent a gift card value. .</param>
        /// <param name="reservationLimit">The number of reservations that can be made with this coupon code. .</param>
        /// <param name="startDate">Timestamp at which point the coupon becomes valid..</param>
        /// <param name="expiryDate">Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative..</param>
        /// <param name="numberOfCoupons">The number of new coupon codes to generate for the campaign. (required).</param>
        /// <param name="couponSettings">couponSettings.</param>
        /// <param name="attributes">Arbitrary properties associated with coupons. (required).</param>
        /// <param name="batchId">The batch ID coupons created by this job will bear. (required).</param>
        /// <param name="status">The current status of this request. Possible values: - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60; - &#x60;coupon pattern full&#x60;  (required).</param>
        /// <param name="createdAmount">The number of coupon codes that were already created for this request. (required).</param>
        /// <param name="failCount">The number of times this job failed. (required).</param>
        /// <param name="errors">An array of individual problems encountered during the request. (required).</param>
        /// <param name="createdBy">ID of the user who created this effect. (required).</param>
        /// <param name="communicated">Whether or not the user that created this job was notified of its final state. (required).</param>
        /// <param name="chunkExecutionCount">The number of times an attempt to create a chunk of coupons was made during the processing of the job. (required).</param>
        /// <param name="chunkSize">The number of coupons that will be created in a single transactions. Coupons will be created in chunks until arriving at the requested amount..</param>
        public CouponCreationJob(int id = default(int), DateTime created = default(DateTime), int campaignId = default(int), int applicationId = default(int), int accountId = default(int), int usageLimit = default(int), decimal discountLimit = default(decimal), int reservationLimit = default(int), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), int numberOfCoupons = default(int), CodeGeneratorSettings couponSettings = default(CodeGeneratorSettings), Object attributes = default(Object), string batchId = default(string), string status = default(string), int createdAmount = default(int), int failCount = default(int), List<string> errors = default(List<string>), int createdBy = default(int), bool communicated = default(bool), int chunkExecutionCount = default(int), int chunkSize = default(int))
        {
            this.Id = id;
            this.Created = created;
            this.CampaignId = campaignId;
            this.ApplicationId = applicationId;
            this.AccountId = accountId;
            this.UsageLimit = usageLimit;
            this.NumberOfCoupons = numberOfCoupons;
            // to ensure "attributes" is required (not null)
            this.Attributes = attributes ?? throw new ArgumentNullException("attributes is a required property for CouponCreationJob and cannot be null");
            // to ensure "batchId" is required (not null)
            this.BatchId = batchId ?? throw new ArgumentNullException("batchId is a required property for CouponCreationJob and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for CouponCreationJob and cannot be null");
            this.CreatedAmount = createdAmount;
            this.FailCount = failCount;
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for CouponCreationJob and cannot be null");
            this.CreatedBy = createdBy;
            this.Communicated = communicated;
            this.ChunkExecutionCount = chunkExecutionCount;
            this.DiscountLimit = discountLimit;
            this.ReservationLimit = reservationLimit;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.CouponSettings = couponSettings;
            this.ChunkSize = chunkSize;
        }
        
        /// <summary>
        /// Internal ID of this entity.
        /// </summary>
        /// <value>Internal ID of this entity.</value>
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
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// The total discount value that the code can give. Typically used to represent a gift card value. 
        /// </summary>
        /// <value>The total discount value that the code can give. Typically used to represent a gift card value. </value>
        [DataMember(Name="discountLimit", EmitDefaultValue=false)]
        public decimal DiscountLimit { get; set; }

        /// <summary>
        /// The number of reservations that can be made with this coupon code. 
        /// </summary>
        /// <value>The number of reservations that can be made with this coupon code. </value>
        [DataMember(Name="reservationLimit", EmitDefaultValue=false)]
        public int ReservationLimit { get; set; }

        /// <summary>
        /// Timestamp at which point the coupon becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the coupon becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The number of new coupon codes to generate for the campaign.
        /// </summary>
        /// <value>The number of new coupon codes to generate for the campaign.</value>
        [DataMember(Name="numberOfCoupons", EmitDefaultValue=false)]
        public int NumberOfCoupons { get; set; }

        /// <summary>
        /// Gets or Sets CouponSettings
        /// </summary>
        [DataMember(Name="couponSettings", EmitDefaultValue=false)]
        public CodeGeneratorSettings CouponSettings { get; set; }

        /// <summary>
        /// Arbitrary properties associated with coupons.
        /// </summary>
        /// <value>Arbitrary properties associated with coupons.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The batch ID coupons created by this job will bear.
        /// </summary>
        /// <value>The batch ID coupons created by this job will bear.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// The current status of this request. Possible values: - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60; - &#x60;coupon pattern full&#x60; 
        /// </summary>
        /// <value>The current status of this request. Possible values: - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60; - &#x60;coupon pattern full&#x60; </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of coupon codes that were already created for this request.
        /// </summary>
        /// <value>The number of coupon codes that were already created for this request.</value>
        [DataMember(Name="createdAmount", EmitDefaultValue=false)]
        public int CreatedAmount { get; set; }

        /// <summary>
        /// The number of times this job failed.
        /// </summary>
        /// <value>The number of times this job failed.</value>
        [DataMember(Name="failCount", EmitDefaultValue=false)]
        public int FailCount { get; set; }

        /// <summary>
        /// An array of individual problems encountered during the request.
        /// </summary>
        /// <value>An array of individual problems encountered during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// ID of the user who created this effect.
        /// </summary>
        /// <value>ID of the user who created this effect.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// Whether or not the user that created this job was notified of its final state.
        /// </summary>
        /// <value>Whether or not the user that created this job was notified of its final state.</value>
        [DataMember(Name="communicated", EmitDefaultValue=false)]
        public bool Communicated { get; set; }

        /// <summary>
        /// The number of times an attempt to create a chunk of coupons was made during the processing of the job.
        /// </summary>
        /// <value>The number of times an attempt to create a chunk of coupons was made during the processing of the job.</value>
        [DataMember(Name="chunkExecutionCount", EmitDefaultValue=false)]
        public int ChunkExecutionCount { get; set; }

        /// <summary>
        /// The number of coupons that will be created in a single transactions. Coupons will be created in chunks until arriving at the requested amount.
        /// </summary>
        /// <value>The number of coupons that will be created in a single transactions. Coupons will be created in chunks until arriving at the requested amount.</value>
        [DataMember(Name="chunkSize", EmitDefaultValue=false)]
        public int ChunkSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponCreationJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  DiscountLimit: ").Append(DiscountLimit).Append("\n");
            sb.Append("  ReservationLimit: ").Append(ReservationLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  NumberOfCoupons: ").Append(NumberOfCoupons).Append("\n");
            sb.Append("  CouponSettings: ").Append(CouponSettings).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAmount: ").Append(CreatedAmount).Append("\n");
            sb.Append("  FailCount: ").Append(FailCount).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Communicated: ").Append(Communicated).Append("\n");
            sb.Append("  ChunkExecutionCount: ").Append(ChunkExecutionCount).Append("\n");
            sb.Append("  ChunkSize: ").Append(ChunkSize).Append("\n");
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
            return this.Equals(input as CouponCreationJob);
        }

        /// <summary>
        /// Returns true if CouponCreationJob instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponCreationJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponCreationJob input)
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
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.UsageLimit == input.UsageLimit ||
                    this.UsageLimit.Equals(input.UsageLimit)
                ) && 
                (
                    this.DiscountLimit == input.DiscountLimit ||
                    this.DiscountLimit.Equals(input.DiscountLimit)
                ) && 
                (
                    this.ReservationLimit == input.ReservationLimit ||
                    this.ReservationLimit.Equals(input.ReservationLimit)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.NumberOfCoupons == input.NumberOfCoupons ||
                    this.NumberOfCoupons.Equals(input.NumberOfCoupons)
                ) && 
                (
                    this.CouponSettings == input.CouponSettings ||
                    (this.CouponSettings != null &&
                    this.CouponSettings.Equals(input.CouponSettings))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAmount == input.CreatedAmount ||
                    this.CreatedAmount.Equals(input.CreatedAmount)
                ) && 
                (
                    this.FailCount == input.FailCount ||
                    this.FailCount.Equals(input.FailCount)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    this.CreatedBy.Equals(input.CreatedBy)
                ) && 
                (
                    this.Communicated == input.Communicated ||
                    this.Communicated.Equals(input.Communicated)
                ) && 
                (
                    this.ChunkExecutionCount == input.ChunkExecutionCount ||
                    this.ChunkExecutionCount.Equals(input.ChunkExecutionCount)
                ) && 
                (
                    this.ChunkSize == input.ChunkSize ||
                    this.ChunkSize.Equals(input.ChunkSize)
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
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationLimit.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfCoupons.GetHashCode();
                if (this.CouponSettings != null)
                    hashCode = hashCode * 59 + this.CouponSettings.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.FailCount.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.Communicated.GetHashCode();
                hashCode = hashCode * 59 + this.ChunkExecutionCount.GetHashCode();
                hashCode = hashCode * 59 + this.ChunkSize.GetHashCode();
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
            // UsageLimit (int) maximum
            if(this.UsageLimit > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value less than or equal to 999999.", new [] { "UsageLimit" });
            }

            // UsageLimit (int) minimum
            if(this.UsageLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value greater than or equal to 0.", new [] { "UsageLimit" });
            }

            // DiscountLimit (decimal) maximum
            if(this.DiscountLimit > (decimal)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountLimit, must be a value less than or equal to 999999.", new [] { "DiscountLimit" });
            }

            // DiscountLimit (decimal) minimum
            if(this.DiscountLimit < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountLimit, must be a value greater than or equal to 0.", new [] { "DiscountLimit" });
            }

            // ReservationLimit (int) maximum
            if(this.ReservationLimit > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReservationLimit, must be a value less than or equal to 999999.", new [] { "ReservationLimit" });
            }

            // ReservationLimit (int) minimum
            if(this.ReservationLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReservationLimit, must be a value greater than or equal to 0.", new [] { "ReservationLimit" });
            }

            // NumberOfCoupons (int) maximum
            if(this.NumberOfCoupons > (int)5000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfCoupons, must be a value less than or equal to 5000000.", new [] { "NumberOfCoupons" });
            }

            // NumberOfCoupons (int) minimum
            if(this.NumberOfCoupons < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfCoupons, must be a value greater than or equal to 1.", new [] { "NumberOfCoupons" });
            }

            yield break;
        }
    }

}
