# TalonOne.Model.UpdateCouponBatch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsageLimit** | **int** | The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  | [optional] 
**DiscountLimit** | **decimal** | The total discount value that the code can give. Typically used to represent a gift card value.  | [optional] 
**ReservationLimit** | **int** | The number of reservations that can be made with this coupon code.  | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**Attributes** | [**Object**](.md) | Optional property to set the value of custom coupon attributes. They are defined in the Campaign Manager, see [Managing attributes](https://docs.talon.one/docs/product/account/dev-tools/managing-attributes).  Coupon attributes can also be set to _mandatory_ in your Application [settings](https://docs.talon.one/docs/product/applications/using-attributes#making-attributes-mandatory). If your Application uses mandatory attributes, you must use this property to set their value.  | [optional] 
**BatchID** | **string** | The ID of the batch the coupon(s) belong to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

