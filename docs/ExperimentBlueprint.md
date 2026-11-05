# TalonOne.Model.ExperimentBlueprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this experiment blueprint. | 
**AccountId** | **long** | The ID of the account that owns this experiment blueprint. | 
**ApplicationId** | **long** | The ID of the Application that owns this experiment blueprint. | 
**Title** | **string** | A short description of the experiment blueprint. | 
**Description** | **string** | A longer, more detailed description of the experiment blueprint. | [optional] 
**Category** | **string** | Category used to group experiment blueprints. | 
**Source** | **string** | Indicates whether the experiment blueprint is custom or shipped by Talon.One. | 
**Variants** | [**List&lt;ExperimentBlueprintVariant&gt;**](ExperimentBlueprintVariant.md) | Array of experiment variant templates in this experiment blueprint. Variants only contain name, weight, ruleset and the primary flag. | 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Array of cart item filter templates in this experiment blueprint. Cart item filters only contain name (no description, as description is at the experiment blueprint level). | 
**Created** | **DateTime** | Timestamp when the experiment blueprint was created. | 
**CreatedBy** | **long** | ID of the user who created the experiment blueprint. | 
**Modified** | **DateTime** | Timestamp when the experiment blueprint was last updated. | [optional] 
**ModifiedBy** | **long** | ID of the user who last updated the experiment blueprint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

