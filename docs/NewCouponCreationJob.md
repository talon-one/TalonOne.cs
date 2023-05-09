# TalonOne.Model.NewCouponCreationJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsageLimit** | **int** | The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  | 
**DiscountLimit** | **decimal** | The total discount value that the code can give. Typically used to represent a gift card value.  | [optional] 
**ReservationLimit** | **int** | The number of reservations that can be made with this coupon code.  | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**NumberOfCoupons** | **int** | The number of new coupon codes to generate for the campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with coupons. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

