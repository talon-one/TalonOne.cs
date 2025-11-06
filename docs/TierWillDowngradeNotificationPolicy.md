# TalonOne.Model.TierWillDowngradeNotificationPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the notification. | 
**BatchingEnabled** | **bool** | Indicates whether batching is activated. | [optional] [default to true]
**BatchSize** | **long** | The required size of each batch of data. This value applies only when &#x60;batchingEnabled&#x60; is &#x60;true&#x60;. | [optional] [default to 1000]
**Triggers** | [**List&lt;TierWillDowngradeNotificationTrigger&gt;**](TierWillDowngradeNotificationTrigger.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

