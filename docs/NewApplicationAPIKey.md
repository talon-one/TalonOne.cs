# TalonOne.Model.NewApplicationAPIKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | Title of the API key. | 
**Expires** | **DateTime** | The date the API key expires. | 
**Platform** | **string** | The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer.  | [optional] 
**Type** | **string** | The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;.  | [optional] 
**TimeOffset** | **long** | A time offset in nanoseconds associated with the API key. When making a request using the API key, rule evaluation is based on a date that is calculated by adding the offset to the current date.  | [optional] 
**Id** | **long** | ID of the API Key. | 
**CreatedBy** | **long** | ID of user who created. | 
**AccountID** | **long** | ID of account the key is used for. | 
**ApplicationID** | **long** | ID of application the key is used for. | 
**Created** | **DateTime** | The date the API key was created. | 
**Key** | **string** | The API key. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

