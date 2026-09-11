# TalonOne.Model.RollbackDiscountEffectProps
This effect indicates that a discounted session, cart item, or additional cost has been cancelled or partially returned. This effect can only happen when you set the status of a session to `cancel` or the status changes to `partially_returned`.  If the session contains some cart items with _quantity > 1_, use the `cartItemSubPosition` property to identify the specific item unit in its line item. See the example below.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the discount effect that was rolled back. | 
**Value** | **decimal** | The monetary value of the discount that was rolled back. | 
**CartItemPosition** | **decimal** | The index of the item in the &#x60;cartItem&#x60; object whose discount was rolled back, or the unit containing the additional cost whose discount was rolled back. | [optional] 
**CartItemSubPosition** | **decimal** | The index of the item unit in its line item for which the discount was rolled back. | [optional] 
**AdditionalCostId** | **long** | _Only when rolling back [setDiscountPerAdditionalCost](https://docs.talon.one/docs/dev/integration-api/api-effects#setdiscountperadditionalcost) and [setDiscountPerAdditionalCostPerItem](https://docs.talon.one/docs/dev/integration-api/api-effects#setdiscountperadditionalcostperitem)_ The ID of the additional cost to be discounted. | [optional] 
**AdditionalCost** | **string** | The API name of the additional cost whose discount was rolled back. | [optional] 
**Scope** | **string** | The scope of the rolled back discount.  - For a discount per session, it can be one of &#x60;cartItems&#x60;, &#x60;additionalCosts&#x60; or &#x60;sessionTotal&#x60; - For a discount per item, it can be one of &#x60;price&#x60;, &#x60;additionalCosts&#x60; or &#x60;itemTotal&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

