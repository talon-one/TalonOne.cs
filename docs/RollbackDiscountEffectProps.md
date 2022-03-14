# TalonOne.Model.RollbackDiscountEffectProps
The properties specific to the \"rollbackDiscount\" effect. This gets triggered whenever previously closed session is now cancelled or partially returned and a setDiscount effect was cancelled on our internal discount limit counters.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the \&quot;setDiscount\&quot; effect that was rolled back | 
**Value** | **decimal** | The value of the discount that was rolled back. | 
**CartItemPosition** | **decimal** | The index of the item in the cart items for which the discount was rolled back. | [optional] 
**CartItemSubPosition** | **decimal** | The index of the item unit in its line item. It is only used for cart items with &#x60;quantity&#x60; &gt; 1 and is only returned when cart item flattening is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

