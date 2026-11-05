# TalonOne.Model.OutboundMessage
Outbound notification or webhook message with its shared request details.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **Guid** | UUID of the outbound message. | 
**NotificationId** | **long** | ID of the notification that produced the outbound request. | [optional] 
**NotificationName** | **string** | Name of the notification that produced the outbound request. | [optional] 
**WebhookId** | **long** | ID of the webhook that produced the outbound request. | [optional] 
**WebhookName** | **string** | The name of the webhook that produced the outbound request. | [optional] 
**NotificationType** | **string** | Type of notification that produced the outbound request. | 
**ApplicationId** | **long** | ID of the Application associated with the outbound request. | [optional] 
**LoyaltyProgramId** | **long** | ID of the loyalty program associated with the outbound request. | [optional] 
**Request** | [**OutboundLogRequest**](OutboundLogRequest.md) |  | 
**FirstLogAt** | **DateTime** | Timestamp of the first log entry for this message. | 
**LastLogAt** | **DateTime** | Timestamp of the last log entry for this message. | 
**LastResponseCode** | **long** | HTTP status code from the latest response. | [optional] 
**Status** | **string** |  | 
**RetryCount** | **long** | Number of retries. | [optional] 
**Responses** | [**List&lt;OutboundMessageResponse&gt;**](OutboundMessageResponse.md) | Log entries for this message. Omitted when &#x60;includeLogs&#x3D;false&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

