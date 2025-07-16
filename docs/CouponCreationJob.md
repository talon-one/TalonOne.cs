# TalonOne.Model.CouponCreationJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | 
**ApplicationId** | **int** | The ID of the Application that owns this entity. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**UsageLimit** | **int** | The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply.  | 
**DiscountLimit** | **decimal** | The total discount value that the code can give. Typically used to represent a gift card value.  | [optional] 
**ReservationLimit** | **int** | The number of reservations that can be made with this coupon code.  | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiration date of the coupon. Coupon never expires if this is omitted. | [optional] 
**NumberOfCoupons** | **int** | The number of new coupon codes to generate for the campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with coupons. | 
**BatchId** | **string** | The batch ID coupons created by this job will bear. | 
**Status** | **string** | The current status of this request. Possible values: - &#x60;pending verification&#x60; - &#x60;pending&#x60; - &#x60;completed&#x60; - &#x60;failed&#x60; - &#x60;coupon pattern full&#x60;  | 
**CreatedAmount** | **int** | The number of coupon codes that were already created for this request. | 
**FailCount** | **int** | The number of times this job failed. | 
**Errors** | **List&lt;string&gt;** | An array of individual problems encountered during the request. | 
**CreatedBy** | **int** | ID of the user who created this effect. | 
**Communicated** | **bool** | Whether or not the user that created this job was notified of its final state. | 
**ChunkExecutionCount** | **int** | The number of times an attempt to create a chunk of coupons was made during the processing of the job. | 
**ChunkSize** | **int** | The number of coupons that will be created in a single transactions. Coupons will be created in chunks until arriving at the requested amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

