# TalonOne.Model.ExpiringCouponsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CouponValue** | **string** | The coupon code. | 
**CreatedDate** | **DateTime** | Timestamp at which point the coupon was created. | [optional] 
**ValidFrom** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ValidUntil** | **DateTime** | Timestamp at which point the coupon expires. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**CampaignId** | **long** | The ID of the campaign to which the coupon belongs. | 
**CustomerProfileId** | **string** | The Integration ID of the customer that is allowed to redeem this coupon. | [optional] 
**UsageLimit** | **long** | The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  | 
**UsageCounter** | **long** | The number of times the coupon has been successfully redeemed. | 
**BatchId** | **string** | The ID of the batch the coupon belongs to. | [optional] 
**Attributes** | [**Object**](.md) | Custom attributes associated with this coupon. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

