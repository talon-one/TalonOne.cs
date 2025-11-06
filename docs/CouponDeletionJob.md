# TalonOne.Model.CouponDeletionJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Filters** | [**CouponDeletionFilters**](CouponDeletionFilters.md) |  | 
**Status** | **string** | The current status of this request. Possible values: - &#x60;not_ready&#x60; - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60;  | 
**DeletedAmount** | **long** | The number of coupon codes that were already deleted for this request. | [optional] 
**FailCount** | **long** | The number of times this job failed. | 
**Errors** | **List&lt;string&gt;** | An array of individual problems encountered during the request. | 
**CreatedBy** | **long** | ID of the user who created this effect. | 
**Communicated** | **bool** | Indicates whether the user that created this job was notified of its final state. | 
**CampaignIDs** | **List&lt;long&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

