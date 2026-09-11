# TalonOne.Model.AcceptCouponEffectProps
This effect indicates that the coupon code supplied was valid.  You should handle this effect by clearing any messages from previous `rejectCoupon` effects and informing the user that the coupon is valid.  The code is automatically redeemed when you close the session.  Other effects, such as [setDiscount](https://docs.talon.one/docs/dev/integration-api/api-effects#setdiscount), provide more information about the actual rewards received.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The coupon code that was accepted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

