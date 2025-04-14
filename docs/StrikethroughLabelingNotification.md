# TalonOne.Model.StrikethroughLabelingNotification
The strikethrough labels notification for an application.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **string** | The version of the strikethrough pricing notification. | [optional] 
**ApplicationId** | **int** | The ID of the Application to which the catalog items labels belongs. | 
**CurrentBatch** | **int** | The batch number of the notification. Notifications might be sent in different batches. | 
**TotalBatches** | **int** | The total number of batches for the notification. | 
**Trigger** | [**StrikethroughTrigger**](StrikethroughTrigger.md) |  | 
**ChangedItems** | [**List&lt;StrikethroughChangedItem&gt;**](StrikethroughChangedItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

