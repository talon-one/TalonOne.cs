# TalonOne.Model.NewExperimentBlueprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display name for the experiment blueprint. | 
**Description** | **string** | A longer, more detailed description of the experiment blueprint. | [optional] 
**Category** | **string** | Category used to group experiment blueprints. | [optional] [default to CategoryEnum.Custom]
**Variants** | [**List&lt;ExperimentBlueprintVariant&gt;**](ExperimentBlueprintVariant.md) | Array of experiment variant templates to store in this experiment blueprint. At least one variant or cart item filter is required. | [optional] 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Array of cart item filters to store in this experiment blueprint. If not provided, will be extracted from the variant rulesets. Cart item filters should only contain name (no description, as description is at the experiment blueprint level). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

