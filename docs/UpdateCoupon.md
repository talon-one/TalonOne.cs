# TalonOne.Model.UpdateCoupon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsageLimit** | **int?** | The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | [optional] 
**StartDate** | **DateTime?** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime?** | Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**RecipientIntegrationId** | **string** | The integration ID for this coupon&#39;s beneficiary&#39;s profile | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

