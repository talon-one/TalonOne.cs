
# TalonOne.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**ApplicationIds** | **List&lt;int&gt;** | The IDs of the applications that are related to this entity. The IDs of the applications that are related to this entity. | 
**Title** | **string** | Friendly title for this webhook | 
**Verb** | **string** | API method for this webhook | 
**Url** | **string** | API url (supports templating using parameters) for this webhook | 
**Headers** | **List&lt;string&gt;** | List of API HTTP headers for this webhook | 
**Payload** | **string** | API payload (supports templating using parameters) for this webhook | [optional] 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions | 
**Enabled** | **bool** | Enables or disables webhook from showing in rule builder | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

