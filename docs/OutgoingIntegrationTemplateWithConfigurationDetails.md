# TalonOne.Model.OutgoingIntegrationTemplateWithConfigurationDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**IntegrationType** | **int** | Unique ID of outgoing integration type. | 
**Title** | **string** | The title of the integration template. | 
**Description** | **string** | The description of the specific outgoing integration template. | 
**Payload** | **string** | The API payload (supports templating using parameters) for this integration template. | 
**Method** | **string** | API method for this webhook. | 
**RelativeUrl** | **string** | The relative URL corresponding to each integration template. | 
**Headers** | **List&lt;string&gt;** | The list of HTTP headers for this integration template. | 
**Policy** | [**Object**](.md) | The outgoing integration policy specific to each integration type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

