
# TalonOne.Model.WebhookLogEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID reference of the webhook request | 
**IntegrationRequestUuid** | **string** | UUID reference of the integration request linked to this webhook request | 
**WebhookId** | **int** | ID of the webhook that triggered the request | 
**ApplicationId** | **int** | ID of the application that triggered the webhook | [optional] 
**Url** | **string** | Target url of request | 
**Request** | **string** | Request message | 
**Response** | **string** | Response message | [optional] 
**Status** | **int** | HTTP status code of response | [optional] 
**RequestTime** | **DateTime** | Timestamp of request | 
**ResponseTime** | **DateTime** | Timestamp of response | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

