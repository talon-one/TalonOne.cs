# TalonOne.Model.CheckCouponBlock
A block that validates the coupon code value and date.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | A block discriminator of type &#x60;checkCoupon&#x60;. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Redeem** | **bool** | When &#x60;true&#x60;, the coupon code is redeemed. | 
**OnFailure** | **List&lt;Object&gt;** | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

