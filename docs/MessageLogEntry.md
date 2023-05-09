# TalonOne.Model.MessageLogEntry
Message Log.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the message. | 
**Service** | **string** | Name of the service that generated the log entry. | 
**ChangeType** | **string** | Type of change that triggered the notification. | [optional] 
**NotificationId** | **int** | ID of the notification. | [optional] 
**NotificationName** | **string** | The name of the notification. | [optional] 
**Request** | [**MessageLogRequest**](MessageLogRequest.md) |  | [optional] 
**Response** | [**MessageLogResponse**](MessageLogResponse.md) |  | [optional] 
**CreatedAt** | **DateTime** | Timestamp when the log entry was created. | 
**EntityType** | **string** | The entity type the notification is related to.  | [optional] 
**ApplicationId** | **int** | Identifier of the Application. | [optional] 
**LoyaltyProgramId** | **int** | Identifier of the loyalty program. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

