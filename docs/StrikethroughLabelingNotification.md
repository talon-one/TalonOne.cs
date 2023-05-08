# TalonOne.Model.StrikethroughLabelingNotification
The strikethrough labels notification for an application.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **int** | The ID of the application that catalog items labels belongs to. | 
**CurrentBatch** | **int** | The batch number of the notification. Notifications might be sent in different batches. | 
**TotalBatches** | **int** | The total number of batches for the notification. | 
**Trigger** | [**StrikethroughTrigger**](StrikethroughTrigger.md) |  | 
**ChangedItems** | [**List&lt;StrikethroughChangedItem&gt;**](StrikethroughChangedItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

