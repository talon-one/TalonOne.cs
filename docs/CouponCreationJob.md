# TalonOne.Model.CouponCreationJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**UsageLimit** | **int** | The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | 
**DiscountLimit** | **decimal** | The amount of discounts that can be given with this coupon code.  | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**NumberOfCoupons** | **int** | The number of new coupon codes to generate for the campaign. Must be between 20,001 and 5,000,000. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with coupons | 
**BatchId** | **string** | The batch ID coupons created by this job will bear | 
**Status** | **string** | The current status of this request. The value should be either &#39;pending&#39;, &#39;completed&#39; or &#39;failed&#39; | 
**CreatedAmount** | **int** | The number of coupon codes that were already created for this request | 
**FailCount** | **int** | The number of times this job failed | 
**Errors** | **List&lt;string&gt;** | An array of individual problems encountered during the request. | 
**CreatedBy** | **int** | ID of the user who created this effect. | 
**Communicated** | **bool** | Whether or not the user that created this job was notified of its final state | 
**BatchExecutionCount** | **int** | The number of times an attempt to create a batch of coupons was made during the processing of the job | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

