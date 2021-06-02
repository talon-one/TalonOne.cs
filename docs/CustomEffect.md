
# TalonOne.Model.CustomEffect

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**Name** | **string** | The name of this effect. | 
**Title** | **string** | The title of this effect. | 
**Payload** | **string** | The JSON payload of this effect. | 
**Description** | **string** | The description of this effect. | [optional] 
**Enabled** | **bool** | Determines if this effect is active. | 
**SubscribedApplicationsIds** | **List&lt;int&gt;** | A list of the IDs of the applications that this effect is enabled for | [optional] 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions | [optional] 
**ModifiedBy** | **int** | ID of the user who last updated this effect if available. | [optional] 
**CreatedBy** | **int** | ID of the user who created this effect. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

