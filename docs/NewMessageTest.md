# TalonOne.Model.NewMessageTest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Headers** | **Dictionary&lt;string, string&gt;** | List of API HTTP headers for the given message. | [optional] 
**Verb** | **string** | API method for this message. | 
**Url** | **string** | API URL for the given message. | 
**Payload** | **string** | API payload of this message. | [optional] 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions. | [optional] 
**ApplicationIds** | **List&lt;long&gt;** | The IDs of the Applications in which this webhook is available. An empty array means the webhook is available in &#x60;All Applications&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

