# TalonOne.Model.SetDiscountPerAdditionalCostPerItemEffectProps
The properties specific to the \"setDiscountPerAdditionalCostPerItem\" effect. This gets triggered whenever a validated rule contained a \"set discount per additional cost per item\" effect. This is a discount that should be applied on a specific additional cost in a specific item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name / description of this discount | 
**AdditionalCostId** | **int** | The ID of the additional cost. | 
**Value** | **decimal** | The total monetary value of the discount. | 
**Position** | **decimal** | The index of the item in the cart item list containing the additional cost to be discounted. | 
**SubPosition** | **decimal** | Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/managing-general-settings#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1.  | [optional] 
**AdditionalCost** | **string** | The name of the additional cost. | 
**DesiredValue** | **decimal** | Only with [partial discounts enabled](https://docs.talon.one/docs/product/campaigns/campaign-evaluation/#partial-discounts). Represents the monetary value of the discount to be applied to additional discount without considering budget limitations.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

