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
    /// The representation of the customer session.
    /// </summary>
    [DataContract]
    public partial class NewCustomerSessionV2 :  IEquatable<NewCustomerSessionV2>, IValidatableObject
    {
        /// <summary>
        /// Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. Either:    - &#x60;closed&#x60; → &#x60;cancelled&#x60; (**only** via [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2)) or    - &#x60;closed&#x60; → &#x60;partially_returned&#x60; (**only** via [Return cart items](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/returnCartItems))    - &#x60;closed&#x60; → &#x60;open&#x60; (**only** via [Reopen customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession)) 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions). 
        /// </summary>
        /// <value>Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. Either:    - &#x60;closed&#x60; → &#x60;cancelled&#x60; (**only** via [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2)) or    - &#x60;closed&#x60; → &#x60;partially_returned&#x60; (**only** via [Return cart items](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/returnCartItems))    - &#x60;closed&#x60; → &#x60;open&#x60; (**only** via [Reopen customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession)) 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions). </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Partiallyreturned for value: partially_returned
            /// </summary>
            [EnumMember(Value = "partially_returned")]
            Partiallyreturned = 3,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 4

        }

        /// <summary>
        /// Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. Either:    - &#x60;closed&#x60; → &#x60;cancelled&#x60; (**only** via [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2)) or    - &#x60;closed&#x60; → &#x60;partially_returned&#x60; (**only** via [Return cart items](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/returnCartItems))    - &#x60;closed&#x60; → &#x60;open&#x60; (**only** via [Reopen customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession)) 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions). 
        /// </summary>
        /// <value>Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. Either:    - &#x60;closed&#x60; → &#x60;cancelled&#x60; (**only** via [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2)) or    - &#x60;closed&#x60; → &#x60;partially_returned&#x60; (**only** via [Return cart items](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/returnCartItems))    - &#x60;closed&#x60; → &#x60;open&#x60; (**only** via [Reopen customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession)) 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions). </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerSessionV2" /> class.
        /// </summary>
        /// <param name="profileId">ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;. .</param>
        /// <param name="storeIntegrationId">The integration ID of the store. You choose this ID when you create a store..</param>
        /// <param name="evaluableCampaignIds">When using the &#x60;dry&#x60; query parameter, use this property to list the campaign to be evaluated by the Rule Engine.  These campaigns will be evaluated, even if they are disabled, allowing you to test specific campaigns before activating them. .</param>
        /// <param name="couponCodes">Any coupon codes entered.  **Important - for requests only**:  - If you [create a coupon budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a coupon code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty array discards any previous coupons. To avoid this, provide &#x60;\&quot;couponCodes\&quot;: null&#x60; or omit the parameter entirely. .</param>
        /// <param name="referralCode">Any referral code entered.  **Important - for requests only**:  - If you [create a referral budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a referral code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty value discards the previous referral code. To avoid this, provide &#x60;\&quot;referralCode\&quot;: null&#x60; or omit the parameter entirely. .</param>
        /// <param name="loyaltyCards">Identifier of a loyalty card..</param>
        /// <param name="state">Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. Either:    - &#x60;closed&#x60; → &#x60;cancelled&#x60; (**only** via [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2)) or    - &#x60;closed&#x60; → &#x60;partially_returned&#x60; (**only** via [Return cart items](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/returnCartItems))    - &#x60;closed&#x60; → &#x60;open&#x60; (**only** via [Reopen customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession)) 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions).  (default to StateEnum.Open).</param>
        /// <param name="cartItems">The items to add to this session. **Do not exceed 1000 items** and ensure the sum of all cart item&#39;s &#x60;quantity&#x60; **does not exceed 10.000** per request. .</param>
        /// <param name="additionalCosts">Use this property to set a value for the additional costs of this session, such as a shipping cost.  They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). .</param>
        /// <param name="identifiers">Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. See the [tutorial](https://docs.talon.one/docs/dev/tutorials/using-identifiers).  **Important**: Ensure the session contains an identifier by the time you close it if: - You [create a unique identifier budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign. - Your campaign has [coupons](https://docs.talon.one/docs/product/campaigns/coupons/coupon-page-overview). .</param>
        /// <param name="attributes">Use this property to set a value for the attributes of your choice. Attributes represent any information to attach to your session, like the shipping city.  You can use [built-in attributes](https://docs.talon.one/docs/dev/concepts/attributes#built-in-attributes) or [custom ones](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes). Custom attributes must be created in the Campaign Manager before you set them with this property. .</param>
        public NewCustomerSessionV2(string profileId = default(string), string storeIntegrationId = default(string), List<int> evaluableCampaignIds = default(List<int>), List<string> couponCodes = default(List<string>), string referralCode = default(string), List<string> loyaltyCards = default(List<string>), StateEnum? state = StateEnum.Open, List<CartItem> cartItems = default(List<CartItem>), Dictionary<string, AdditionalCost> additionalCosts = default(Dictionary<string, AdditionalCost>), List<string> identifiers = default(List<string>), Object attributes = default(Object))
        {
            this.ProfileId = profileId;
            this.StoreIntegrationId = storeIntegrationId;
            this.EvaluableCampaignIds = evaluableCampaignIds;
            this.CouponCodes = couponCodes;
            this.ReferralCode = referralCode;
            this.LoyaltyCards = loyaltyCards;
            this.State = state;
            this.CartItems = cartItems;
            this.AdditionalCosts = additionalCosts;
            this.Identifiers = identifiers;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;. 
        /// </summary>
        /// <value>ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;. </value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// The integration ID of the store. You choose this ID when you create a store.
        /// </summary>
        /// <value>The integration ID of the store. You choose this ID when you create a store.</value>
        [DataMember(Name="storeIntegrationId", EmitDefaultValue=false)]
        public string StoreIntegrationId { get; set; }

        /// <summary>
        /// When using the &#x60;dry&#x60; query parameter, use this property to list the campaign to be evaluated by the Rule Engine.  These campaigns will be evaluated, even if they are disabled, allowing you to test specific campaigns before activating them. 
        /// </summary>
        /// <value>When using the &#x60;dry&#x60; query parameter, use this property to list the campaign to be evaluated by the Rule Engine.  These campaigns will be evaluated, even if they are disabled, allowing you to test specific campaigns before activating them. </value>
        [DataMember(Name="evaluableCampaignIds", EmitDefaultValue=false)]
        public List<int> EvaluableCampaignIds { get; set; }

        /// <summary>
        /// Any coupon codes entered.  **Important - for requests only**:  - If you [create a coupon budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a coupon code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty array discards any previous coupons. To avoid this, provide &#x60;\&quot;couponCodes\&quot;: null&#x60; or omit the parameter entirely. 
        /// </summary>
        /// <value>Any coupon codes entered.  **Important - for requests only**:  - If you [create a coupon budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a coupon code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty array discards any previous coupons. To avoid this, provide &#x60;\&quot;couponCodes\&quot;: null&#x60; or omit the parameter entirely. </value>
        [DataMember(Name="couponCodes", EmitDefaultValue=false)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Any referral code entered.  **Important - for requests only**:  - If you [create a referral budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a referral code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty value discards the previous referral code. To avoid this, provide &#x60;\&quot;referralCode\&quot;: null&#x60; or omit the parameter entirely. 
        /// </summary>
        /// <value>Any referral code entered.  **Important - for requests only**:  - If you [create a referral budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign, ensure the session contains a referral code by the time you close it. - In requests where &#x60;dry&#x3D;false&#x60;, providing an empty value discards the previous referral code. To avoid this, provide &#x60;\&quot;referralCode\&quot;: null&#x60; or omit the parameter entirely. </value>
        [DataMember(Name="referralCode", EmitDefaultValue=false)]
        public string ReferralCode { get; set; }

        /// <summary>
        /// Identifier of a loyalty card.
        /// </summary>
        /// <value>Identifier of a loyalty card.</value>
        [DataMember(Name="loyaltyCards", EmitDefaultValue=false)]
        public List<string> LoyaltyCards { get; set; }

        /// <summary>
        /// The items to add to this session. **Do not exceed 1000 items** and ensure the sum of all cart item&#39;s &#x60;quantity&#x60; **does not exceed 10.000** per request. 
        /// </summary>
        /// <value>The items to add to this session. **Do not exceed 1000 items** and ensure the sum of all cart item&#39;s &#x60;quantity&#x60; **does not exceed 10.000** per request. </value>
        [DataMember(Name="cartItems", EmitDefaultValue=false)]
        public List<CartItem> CartItems { get; set; }

        /// <summary>
        /// Use this property to set a value for the additional costs of this session, such as a shipping cost.  They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). 
        /// </summary>
        /// <value>Use this property to set a value for the additional costs of this session, such as a shipping cost.  They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). </value>
        [DataMember(Name="additionalCosts", EmitDefaultValue=false)]
        public Dictionary<string, AdditionalCost> AdditionalCosts { get; set; }

        /// <summary>
        /// Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. See the [tutorial](https://docs.talon.one/docs/dev/tutorials/using-identifiers).  **Important**: Ensure the session contains an identifier by the time you close it if: - You [create a unique identifier budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign. - Your campaign has [coupons](https://docs.talon.one/docs/product/campaigns/coupons/coupon-page-overview). 
        /// </summary>
        /// <value>Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. See the [tutorial](https://docs.talon.one/docs/dev/tutorials/using-identifiers).  **Important**: Ensure the session contains an identifier by the time you close it if: - You [create a unique identifier budget](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets/#budget-types) for your campaign. - Your campaign has [coupons](https://docs.talon.one/docs/product/campaigns/coupons/coupon-page-overview). </value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// Use this property to set a value for the attributes of your choice. Attributes represent any information to attach to your session, like the shipping city.  You can use [built-in attributes](https://docs.talon.one/docs/dev/concepts/attributes#built-in-attributes) or [custom ones](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes). Custom attributes must be created in the Campaign Manager before you set them with this property. 
        /// </summary>
        /// <value>Use this property to set a value for the attributes of your choice. Attributes represent any information to attach to your session, like the shipping city.  You can use [built-in attributes](https://docs.talon.one/docs/dev/concepts/attributes#built-in-attributes) or [custom ones](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes). Custom attributes must be created in the Campaign Manager before you set them with this property. </value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomerSessionV2 {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  StoreIntegrationId: ").Append(StoreIntegrationId).Append("\n");
            sb.Append("  EvaluableCampaignIds: ").Append(EvaluableCampaignIds).Append("\n");
            sb.Append("  CouponCodes: ").Append(CouponCodes).Append("\n");
            sb.Append("  ReferralCode: ").Append(ReferralCode).Append("\n");
            sb.Append("  LoyaltyCards: ").Append(LoyaltyCards).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CartItems: ").Append(CartItems).Append("\n");
            sb.Append("  AdditionalCosts: ").Append(AdditionalCosts).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as NewCustomerSessionV2);
        }

        /// <summary>
        /// Returns true if NewCustomerSessionV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCustomerSessionV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCustomerSessionV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.StoreIntegrationId == input.StoreIntegrationId ||
                    (this.StoreIntegrationId != null &&
                    this.StoreIntegrationId.Equals(input.StoreIntegrationId))
                ) && 
                (
                    this.EvaluableCampaignIds == input.EvaluableCampaignIds ||
                    this.EvaluableCampaignIds != null &&
                    input.EvaluableCampaignIds != null &&
                    this.EvaluableCampaignIds.SequenceEqual(input.EvaluableCampaignIds)
                ) && 
                (
                    this.CouponCodes == input.CouponCodes ||
                    this.CouponCodes != null &&
                    input.CouponCodes != null &&
                    this.CouponCodes.SequenceEqual(input.CouponCodes)
                ) && 
                (
                    this.ReferralCode == input.ReferralCode ||
                    (this.ReferralCode != null &&
                    this.ReferralCode.Equals(input.ReferralCode))
                ) && 
                (
                    this.LoyaltyCards == input.LoyaltyCards ||
                    this.LoyaltyCards != null &&
                    input.LoyaltyCards != null &&
                    this.LoyaltyCards.SequenceEqual(input.LoyaltyCards)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.CartItems == input.CartItems ||
                    this.CartItems != null &&
                    input.CartItems != null &&
                    this.CartItems.SequenceEqual(input.CartItems)
                ) && 
                (
                    this.AdditionalCosts == input.AdditionalCosts ||
                    this.AdditionalCosts != null &&
                    input.AdditionalCosts != null &&
                    this.AdditionalCosts.SequenceEqual(input.AdditionalCosts)
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.StoreIntegrationId != null)
                    hashCode = hashCode * 59 + this.StoreIntegrationId.GetHashCode();
                if (this.EvaluableCampaignIds != null)
                    hashCode = hashCode * 59 + this.EvaluableCampaignIds.GetHashCode();
                if (this.CouponCodes != null)
                    hashCode = hashCode * 59 + this.CouponCodes.GetHashCode();
                if (this.ReferralCode != null)
                    hashCode = hashCode * 59 + this.ReferralCode.GetHashCode();
                if (this.LoyaltyCards != null)
                    hashCode = hashCode * 59 + this.LoyaltyCards.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CartItems != null)
                    hashCode = hashCode * 59 + this.CartItems.GetHashCode();
                if (this.AdditionalCosts != null)
                    hashCode = hashCode * 59 + this.AdditionalCosts.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
            // StoreIntegrationId (string) maxLength
            if(this.StoreIntegrationId != null && this.StoreIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreIntegrationId, length must be less than 1000.", new [] { "StoreIntegrationId" });
            }

            // StoreIntegrationId (string) minLength
            if(this.StoreIntegrationId != null && this.StoreIntegrationId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreIntegrationId, length must be greater than 1.", new [] { "StoreIntegrationId" });
            }

            // ReferralCode (string) maxLength
            if(this.ReferralCode != null && this.ReferralCode.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferralCode, length must be less than 100.", new [] { "ReferralCode" });
            }

            yield break;
        }
    }

}
