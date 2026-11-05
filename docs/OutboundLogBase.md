# TalonOne.Model.OutboundLogBase
Shared details of an outbound notification or webhook message.
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
**Request** | [**OutboundLogRequest**](OutboundLogRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

