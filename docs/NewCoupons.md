# TalonOne.Model.NewCoupons
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsageLimit** | **int?** | The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | 
**StartDate** | **DateTime?** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime?** | Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**ValidCharacters** | **List&lt;string&gt;** | Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp). | 
**CouponPattern** | **string** | The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set.  | 
**NumberOfCoupons** | **int?** | The number of new coupon codes to generate for the campaign. Must be at least 1. | 
**UniquePrefix** | **string** | A unique prefix to prepend to all generated coupons. | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this item | [optional] 
**RecipientIntegrationId** | **string** | The integration ID for this coupon&#39;s beneficiary&#39;s profile | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

