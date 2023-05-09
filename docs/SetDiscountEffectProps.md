# TalonOne.Model.SetDiscountEffectProps
The properties specific to the \"setDiscount\" effect. This gets triggered whenever a validated rule contained a \"set discount\" effect. This is a discount that should be applied on the scope of defined with it.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name / description of this discount | 
**Value** | **decimal** | The total monetary value of the discount. | 
**Scope** | **string** | The scope which the discount was applied on, can be one of (cartItems,additionalCosts,sessionTotal). | [optional] 
**DesiredValue** | **decimal** | The original value of the discount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

