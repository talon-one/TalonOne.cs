# TalonOne.Model.AwardDiscountAdditionalCostTarget
Applies the discount to an additional cost. The `target` field determines which subset of cart items the additional cost contribution is applied to.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A target discriminator of type &#x60;additionalCost&#x60;. | 
**AdditionalCost** | [**AdditionalCostReference**](AdditionalCostReference.md) |  | 
**Target** | [**Object**](.md) | A subset of cart items whose additional cost the discount applies to. Cannot be another &#x60;additionalCost&#x60; target. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

