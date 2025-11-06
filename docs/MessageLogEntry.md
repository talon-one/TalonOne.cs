# TalonOne.Model.MessageLogEntry
Message Log.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the message. | 
**Service** | **string** | Name of the service that generated the log entry. | 
**ChangeType** | **string** | Type of change that triggered the notification. | [optional] 
**NotificationId** | **long** | ID of the notification. | [optional] 
**NotificationName** | **string** | The name of the notification. | [optional] 
**WebhookId** | **long** | ID of the webhook. | [optional] 
**WebhookName** | **string** | The name of the webhook. | [optional] 
**Request** | [**MessageLogRequest**](MessageLogRequest.md) |  | [optional] 
**Response** | [**MessageLogResponse**](MessageLogResponse.md) |  | [optional] 
**CreatedAt** | **DateTime** | Timestamp when the log entry was created. | 
**EntityType** | **string** | The entity type the log is related to.  | 
**Url** | **string** | The target URL of the request. | [optional] 
**ApplicationId** | **long** | Identifier of the Application. | [optional] 
**LoyaltyProgramId** | **long** | Identifier of the loyalty program. | [optional] 
**CampaignId** | **long** | Identifier of the campaign. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

