# TalonOne.Model.CustomEffect
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**ApplicationIds** | **List&lt;int&gt;** | The IDs of the Applications that are related to this entity. | 
**IsPerItem** | **bool** | Indicates if this effect is per item or not. | [optional] 
**Name** | **string** | The name of this effect. | 
**Title** | **string** | The title of this effect. | 
**Payload** | **string** | The JSON payload of this effect. | 
**Description** | **string** | The description of this effect. | [optional] 
**Enabled** | **bool** | Determines if this effect is active. | 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions. | [optional] 
**ModifiedBy** | **int** | ID of the user who last updated this effect if available. | [optional] 
**CreatedBy** | **int** | ID of the user who created this effect. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

