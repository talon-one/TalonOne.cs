# TalonOne.Model.StrikethroughLabelingNotification
The strikethrough labels notification for an application.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **string** | The version of the strikethrough pricing notification. | [optional] 
**ValidFrom** | **DateTime** | Timestamp at which the strikethrough pricing update becomes valid. Set for **scheduled** strikethrough pricing updates (version: v2) only.  | [optional] 
**ApplicationId** | **long** | The ID of the Application to which the catalog items labels belongs. | 
**CurrentBatch** | **long** | The batch number of the notification. Notifications might be sent in different batches. | 
**TotalBatches** | **long** | The total number of batches for the notification. | 
**Trigger** | [**StrikethroughTrigger**](StrikethroughTrigger.md) |  | 
**ChangedItems** | [**List&lt;StrikethroughChangedItem&gt;**](StrikethroughChangedItem.md) |  | 
**NotificationType** | **string** | The type of the notification | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

