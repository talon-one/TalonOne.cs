# TalonOne.Model.CreateCouponBlock
A block that creates a coupon code.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**CampaignId** | [**Object**](.md) | The ID of the campaign in which the coupon code is created. | 
**RecipientId** | **string** | The integration ID of the customer that is allowed to redeem this coupon. | 
**StoreInSession** | **bool** | When &#x60;true&#x60;, the coupon is stored in the session. | 
**UsageLimit** | [**Object**](.md) | The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions, but any campaign usage limits still apply. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time.  | [optional] 
**DiscountLimit** | [**Object**](.md) | The total discount value that the code can give. Typically used to represent a gift card value. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time.  | [optional] 
**StartDate** | [**Object**](.md) | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | [**Object**](.md) | Expiration date of the coupon. Coupon never expires if this is omitted. | [optional] 
**Attributes** | [**Object**](.md) | Custom attributes associated with this coupon code. | [optional] 
**ValidCharacters** | **string** | Characters used to generate the random parts of a code. | [optional] 
**Pattern** | **string** | The pattern used to generate codes, such as coupon codes, referral codes, and loyalty cards. The character &#x60;#&#x60; is a placeholder and is replaced by a random character from the &#x60;validCharacters&#x60; set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

