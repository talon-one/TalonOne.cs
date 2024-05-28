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
    /// InventoryCoupon
    /// </summary>
    [DataContract]
    public partial class InventoryCoupon :  IEquatable<InventoryCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryCoupon" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryCoupon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryCoupon" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        /// <param name="value">The coupon code. (required).</param>
        /// <param name="usageLimit">The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  (required).</param>
        /// <param name="discountLimit">The total discount value that the code can give. Typically used to represent a gift card value. .</param>
        /// <param name="reservationLimit">The number of reservations that can be made with this coupon code. .</param>
        /// <param name="startDate">Timestamp at which point the coupon becomes valid..</param>
        /// <param name="expiryDate">Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative..</param>
        /// <param name="limits">Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. .</param>
        /// <param name="usageCounter">The number of times the coupon has been successfully redeemed. (required).</param>
        /// <param name="discountCounter">The amount of discounts given on rules redeeming this coupon. Only usable if a coupon discount budget was set for this coupon..</param>
        /// <param name="discountRemainder">The remaining discount this coupon can give..</param>
        /// <param name="reservationCounter">The number of times this coupon has been reserved..</param>
        /// <param name="attributes">Custom attributes associated with this coupon..</param>
        /// <param name="referralId">The integration ID of the referring customer (if any) for whom this coupon was created as an effect..</param>
        /// <param name="recipientIntegrationId">The Integration ID of the customer that is allowed to redeem this coupon..</param>
        /// <param name="importId">The ID of the Import which created this coupon..</param>
        /// <param name="reservation">Defines the type of reservation: - &#x60;true&#x60;: The reservation is a soft reservation. Any customer can use the coupon. This is done via the [Create coupon reservation](https://docs.talon.one/integration-api#operation/createCouponReservation) endpoint. - &#x60;false&#x60;: The reservation is a hard reservation. Only the associated customer (&#x60;recipientIntegrationId&#x60;) can use the coupon. This is done via the Campaign Manager when you create a coupon for a given &#x60;recipientIntegrationId&#x60;, the [Create coupons](https://docs.talon.one/management-api#operation/createCoupons) endpoint or [Create coupons for multiple recipients](https://docs.talon.one/management-api#operation/createCouponsForMultipleRecipients) endpoint.  (default to true).</param>
        /// <param name="batchId">The id of the batch the coupon belongs to..</param>
        /// <param name="isReservationMandatory">Whether the reservation effect actually created a new reservation. (default to false).</param>
        /// <param name="implicitlyReserved">An indication of whether the coupon is implicitly reserved for all customers..</param>
        /// <param name="profileRedemptionCount">The number of times the coupon was redeemed by the profile. (required).</param>
        /// <param name="state">Can be:  - &#x60;active&#x60;: The coupon can be used. It is a reserved coupon that is not pending, used, or expired, and it has a non-exhausted limit counter.    **Note:** This coupon state is returned for [scheduled campaigns](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-schedule), but the coupon cannot be used until the campaign is **running**. - &#x60;used&#x60;: The coupon has been redeemed and cannot be used again. It is not pending and has reached its redemption limit or was redeemed by the profile before expiration. - &#x60;expired&#x60;: The coupon was never redeemed, and it is now expired. It is non-pending, non-active, and non-used by the profile. - &#x60;pending&#x60;: The coupon will be usable in the future. - &#x60;disabled&#x60;: The coupon is part of a non-active campaign.  (required).</param>
        public InventoryCoupon(int id = default(int), DateTime created = default(DateTime), int campaignId = default(int), string value = default(string), int usageLimit = default(int), decimal discountLimit = default(decimal), int reservationLimit = default(int), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), List<LimitConfig> limits = default(List<LimitConfig>), int usageCounter = default(int), decimal discountCounter = default(decimal), decimal discountRemainder = default(decimal), decimal reservationCounter = default(decimal), Object attributes = default(Object), int referralId = default(int), string recipientIntegrationId = default(string), int importId = default(int), bool reservation = true, string batchId = default(string), bool isReservationMandatory = false, bool implicitlyReserved = default(bool), int profileRedemptionCount = default(int), string state = default(string))
        {
            this.Id = id;
            this.Created = created;
            this.CampaignId = campaignId;
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for InventoryCoupon and cannot be null");
            this.UsageLimit = usageLimit;
            this.UsageCounter = usageCounter;
            this.ProfileRedemptionCount = profileRedemptionCount;
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for InventoryCoupon and cannot be null");
            this.DiscountLimit = discountLimit;
            this.ReservationLimit = reservationLimit;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.Limits = limits;
            this.DiscountCounter = discountCounter;
            this.DiscountRemainder = discountRemainder;
            this.ReservationCounter = reservationCounter;
            this.Attributes = attributes;
            this.ReferralId = referralId;
            this.RecipientIntegrationId = recipientIntegrationId;
            this.ImportId = importId;
            this.Reservation = reservation;
            this.BatchId = batchId;
            this.IsReservationMandatory = isReservationMandatory;
            this.ImplicitlyReserved = implicitlyReserved;
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
        /// The coupon code.
        /// </summary>
        /// <value>The coupon code.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

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
        /// Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. 
        /// </summary>
        /// <value>Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. </value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitConfig> Limits { get; set; }

        /// <summary>
        /// The number of times the coupon has been successfully redeemed.
        /// </summary>
        /// <value>The number of times the coupon has been successfully redeemed.</value>
        [DataMember(Name="usageCounter", EmitDefaultValue=false)]
        public int UsageCounter { get; set; }

        /// <summary>
        /// The amount of discounts given on rules redeeming this coupon. Only usable if a coupon discount budget was set for this coupon.
        /// </summary>
        /// <value>The amount of discounts given on rules redeeming this coupon. Only usable if a coupon discount budget was set for this coupon.</value>
        [DataMember(Name="discountCounter", EmitDefaultValue=false)]
        public decimal DiscountCounter { get; set; }

        /// <summary>
        /// The remaining discount this coupon can give.
        /// </summary>
        /// <value>The remaining discount this coupon can give.</value>
        [DataMember(Name="discountRemainder", EmitDefaultValue=false)]
        public decimal DiscountRemainder { get; set; }

        /// <summary>
        /// The number of times this coupon has been reserved.
        /// </summary>
        /// <value>The number of times this coupon has been reserved.</value>
        [DataMember(Name="reservationCounter", EmitDefaultValue=false)]
        public decimal ReservationCounter { get; set; }

        /// <summary>
        /// Custom attributes associated with this coupon.
        /// </summary>
        /// <value>Custom attributes associated with this coupon.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The integration ID of the referring customer (if any) for whom this coupon was created as an effect.
        /// </summary>
        /// <value>The integration ID of the referring customer (if any) for whom this coupon was created as an effect.</value>
        [DataMember(Name="referralId", EmitDefaultValue=false)]
        public int ReferralId { get; set; }

        /// <summary>
        /// The Integration ID of the customer that is allowed to redeem this coupon.
        /// </summary>
        /// <value>The Integration ID of the customer that is allowed to redeem this coupon.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// The ID of the Import which created this coupon.
        /// </summary>
        /// <value>The ID of the Import which created this coupon.</value>
        [DataMember(Name="importId", EmitDefaultValue=false)]
        public int ImportId { get; set; }

        /// <summary>
        /// Defines the type of reservation: - &#x60;true&#x60;: The reservation is a soft reservation. Any customer can use the coupon. This is done via the [Create coupon reservation](https://docs.talon.one/integration-api#operation/createCouponReservation) endpoint. - &#x60;false&#x60;: The reservation is a hard reservation. Only the associated customer (&#x60;recipientIntegrationId&#x60;) can use the coupon. This is done via the Campaign Manager when you create a coupon for a given &#x60;recipientIntegrationId&#x60;, the [Create coupons](https://docs.talon.one/management-api#operation/createCoupons) endpoint or [Create coupons for multiple recipients](https://docs.talon.one/management-api#operation/createCouponsForMultipleRecipients) endpoint. 
        /// </summary>
        /// <value>Defines the type of reservation: - &#x60;true&#x60;: The reservation is a soft reservation. Any customer can use the coupon. This is done via the [Create coupon reservation](https://docs.talon.one/integration-api#operation/createCouponReservation) endpoint. - &#x60;false&#x60;: The reservation is a hard reservation. Only the associated customer (&#x60;recipientIntegrationId&#x60;) can use the coupon. This is done via the Campaign Manager when you create a coupon for a given &#x60;recipientIntegrationId&#x60;, the [Create coupons](https://docs.talon.one/management-api#operation/createCoupons) endpoint or [Create coupons for multiple recipients](https://docs.talon.one/management-api#operation/createCouponsForMultipleRecipients) endpoint. </value>
        [DataMember(Name="reservation", EmitDefaultValue=false)]
        public bool Reservation { get; set; }

        /// <summary>
        /// The id of the batch the coupon belongs to.
        /// </summary>
        /// <value>The id of the batch the coupon belongs to.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Whether the reservation effect actually created a new reservation.
        /// </summary>
        /// <value>Whether the reservation effect actually created a new reservation.</value>
        [DataMember(Name="isReservationMandatory", EmitDefaultValue=false)]
        public bool IsReservationMandatory { get; set; }

        /// <summary>
        /// An indication of whether the coupon is implicitly reserved for all customers.
        /// </summary>
        /// <value>An indication of whether the coupon is implicitly reserved for all customers.</value>
        [DataMember(Name="implicitlyReserved", EmitDefaultValue=false)]
        public bool ImplicitlyReserved { get; set; }

        /// <summary>
        /// The number of times the coupon was redeemed by the profile.
        /// </summary>
        /// <value>The number of times the coupon was redeemed by the profile.</value>
        [DataMember(Name="profileRedemptionCount", EmitDefaultValue=false)]
        public int ProfileRedemptionCount { get; set; }

        /// <summary>
        /// Can be:  - &#x60;active&#x60;: The coupon can be used. It is a reserved coupon that is not pending, used, or expired, and it has a non-exhausted limit counter.    **Note:** This coupon state is returned for [scheduled campaigns](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-schedule), but the coupon cannot be used until the campaign is **running**. - &#x60;used&#x60;: The coupon has been redeemed and cannot be used again. It is not pending and has reached its redemption limit or was redeemed by the profile before expiration. - &#x60;expired&#x60;: The coupon was never redeemed, and it is now expired. It is non-pending, non-active, and non-used by the profile. - &#x60;pending&#x60;: The coupon will be usable in the future. - &#x60;disabled&#x60;: The coupon is part of a non-active campaign. 
        /// </summary>
        /// <value>Can be:  - &#x60;active&#x60;: The coupon can be used. It is a reserved coupon that is not pending, used, or expired, and it has a non-exhausted limit counter.    **Note:** This coupon state is returned for [scheduled campaigns](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-schedule), but the coupon cannot be used until the campaign is **running**. - &#x60;used&#x60;: The coupon has been redeemed and cannot be used again. It is not pending and has reached its redemption limit or was redeemed by the profile before expiration. - &#x60;expired&#x60;: The coupon was never redeemed, and it is now expired. It is non-pending, non-active, and non-used by the profile. - &#x60;pending&#x60;: The coupon will be usable in the future. - &#x60;disabled&#x60;: The coupon is part of a non-active campaign. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryCoupon {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  DiscountLimit: ").Append(DiscountLimit).Append("\n");
            sb.Append("  ReservationLimit: ").Append(ReservationLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  UsageCounter: ").Append(UsageCounter).Append("\n");
            sb.Append("  DiscountCounter: ").Append(DiscountCounter).Append("\n");
            sb.Append("  DiscountRemainder: ").Append(DiscountRemainder).Append("\n");
            sb.Append("  ReservationCounter: ").Append(ReservationCounter).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ReferralId: ").Append(ReferralId).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
            sb.Append("  Reservation: ").Append(Reservation).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  IsReservationMandatory: ").Append(IsReservationMandatory).Append("\n");
            sb.Append("  ImplicitlyReserved: ").Append(ImplicitlyReserved).Append("\n");
            sb.Append("  ProfileRedemptionCount: ").Append(ProfileRedemptionCount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as InventoryCoupon);
        }

        /// <summary>
        /// Returns true if InventoryCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryCoupon input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
                ) && 
                (
                    this.UsageCounter == input.UsageCounter ||
                    this.UsageCounter.Equals(input.UsageCounter)
                ) && 
                (
                    this.DiscountCounter == input.DiscountCounter ||
                    this.DiscountCounter.Equals(input.DiscountCounter)
                ) && 
                (
                    this.DiscountRemainder == input.DiscountRemainder ||
                    this.DiscountRemainder.Equals(input.DiscountRemainder)
                ) && 
                (
                    this.ReservationCounter == input.ReservationCounter ||
                    this.ReservationCounter.Equals(input.ReservationCounter)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.ReferralId == input.ReferralId ||
                    this.ReferralId.Equals(input.ReferralId)
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.ImportId == input.ImportId ||
                    this.ImportId.Equals(input.ImportId)
                ) && 
                (
                    this.Reservation == input.Reservation ||
                    this.Reservation.Equals(input.Reservation)
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.IsReservationMandatory == input.IsReservationMandatory ||
                    this.IsReservationMandatory.Equals(input.IsReservationMandatory)
                ) && 
                (
                    this.ImplicitlyReserved == input.ImplicitlyReserved ||
                    this.ImplicitlyReserved.Equals(input.ImplicitlyReserved)
                ) && 
                (
                    this.ProfileRedemptionCount == input.ProfileRedemptionCount ||
                    this.ProfileRedemptionCount.Equals(input.ProfileRedemptionCount)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationLimit.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                hashCode = hashCode * 59 + this.UsageCounter.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountCounter.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountRemainder.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationCounter.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                hashCode = hashCode * 59 + this.ReferralId.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                hashCode = hashCode * 59 + this.ImportId.GetHashCode();
                hashCode = hashCode * 59 + this.Reservation.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                hashCode = hashCode * 59 + this.IsReservationMandatory.GetHashCode();
                hashCode = hashCode * 59 + this.ImplicitlyReserved.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileRedemptionCount.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
            // Value (string) minLength
            if(this.Value != null && this.Value.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 4.", new [] { "Value" });
            }

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

            // RecipientIntegrationId (string) maxLength
            if(this.RecipientIntegrationId != null && this.RecipientIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientIntegrationId, length must be less than 1000.", new [] { "RecipientIntegrationId" });
            }

            yield break;
        }
    }

}
