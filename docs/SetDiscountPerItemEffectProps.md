# TalonOne.Model.SetDiscountPerItemEffectProps
The properties specific to the `setDiscountPerItem` effect, triggered whenever a validated rule contained a \"set per item discount\" effect. This is a discount that will be applied either on a specific item, on a specific item + additional cost or on all additional costs per item. This depends on the chosen scope. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the discount. Contains a hashtag character indicating the index of the position of the item the discount applies to. It is identical to the value of the &#x60;position&#x60; property.  | 
**Value** | **decimal** | The total monetary value of the discount. | 
**Position** | **decimal** | The index of the item in the cart items list on which this discount should be applied. | 
**SubPosition** | **decimal** | Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1.  | [optional] 
**DesiredValue** | **decimal** | The original value of the discount. | [optional] 
**Scope** | **string** | The scope of the discount: - &#x60;additionalCosts&#x60;: The discount applies to all the additional costs of the item. - &#x60;itemTotal&#x60;: The discount applies to the price of the item + the additional costs of the item. - &#x60;price&#x60;: The discount applies to the price of the item.  | [optional] 
**TotalDiscount** | **decimal** | The total discount given if this effect is a result of a prorated discount. | [optional] 
**DesiredTotalDiscount** | **decimal** | The original total discount to give if this effect is a result of a prorated discount. | [optional] 
**BundleIndex** | **int** | The position of the bundle in a list of item bundles created from the same bundle definition. | [optional] 
**BundleName** | **string** | The name of the bundle definition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

