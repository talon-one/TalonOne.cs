# TalonOne.Model.RejectCouponEffectProps
The properties specific to the \"rejectCoupon\" effect. This gets triggered whenever the coupon was rejected. See rejectionReason for more info on why.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The coupon code that was rejected. | 
**RejectionReason** | **string** | The reason why this coupon was rejected. | 
**ConditionIndex** | **long** | The index of the condition that caused the rejection of the coupon. | [optional] 
**EffectIndex** | **long** | The index of the effect that caused the rejection of the coupon. | [optional] 
**Details** | **string** | More details about the failure. | [optional] 
**CampaignExclusionReason** | **string** | The reason why the campaign was not applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

