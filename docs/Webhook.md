# TalonOne.Model.Webhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**ApplicationIds** | **List&lt;int&gt;** | The IDs of the Applications in which this webhook is available. An empty array means the webhook is available in &#x60;All Applications&#x60;.  | 
**Title** | **string** | Name or title for this webhook. | 
**Description** | **string** | A description of the webhook. | [optional] 
**Draft** | **bool** | Indicates if the webhook is a draft. | 
**Verb** | **string** | API method for this webhook. | 
**Url** | **string** | API URL (supports templating using parameters) for this webhook. | 
**Headers** | **List&lt;string&gt;** | List of API HTTP headers for this webhook. | 
**Payload** | **string** | API payload (supports templating using parameters) for this webhook. | [optional] 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions. | 
**Enabled** | **bool** | Enables or disables webhook from showing in the Rule Builder. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

