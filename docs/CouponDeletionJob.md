# TalonOne.Model.CouponDeletionJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Filters** | [**CouponDeletionFilters**](CouponDeletionFilters.md) |  | 
**Status** | **string** | The current status of this request. Possible values: - &#x60;not_ready&#x60; - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60;  | 
**DeletedAmount** | **int** | The number of coupon codes that were already deleted for this request. | [optional] 
**FailCount** | **int** | The number of times this job failed. | 
**Errors** | **List&lt;string&gt;** | An array of individual problems encountered during the request. | 
**CreatedBy** | **int** | ID of the user who created this effect. | 
**Communicated** | **bool** | Indicates whether the user that created this job was notified of its final state. | 
**CampaignIDs** | **List&lt;int&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

