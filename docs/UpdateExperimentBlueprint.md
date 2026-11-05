# TalonOne.Model.UpdateExperimentBlueprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display name for the experiment blueprint. | [optional] 
**Description** | **string** | A longer, more detailed description of the experiment blueprint. | [optional] 
**Category** | **string** | Category used to group experiment blueprints. | [optional] 
**Variants** | [**List&lt;ExperimentBlueprintVariant&gt;**](ExperimentBlueprintVariant.md) | Replaces the stored experiment variant templates. | [optional] 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Replaces the stored cart item filters. Cart item filters should only contain name (no description, as description is at the experiment blueprint level). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

