# TalonOne.Model.RejectReferralEffectProps
The properties specific to the \"rejectReferral\" effect. This gets triggered whenever the referral code was rejected. See rejectionReason for more info on why.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The referral code that was rejected. | 
**RejectionReason** | **string** | The reason why this referral code was rejected. | 
**ConditionIndex** | **long** | The index of the condition that caused the rejection of the referral. | [optional] 
**EffectIndex** | **long** | The index of the effect that caused the rejection of the referral. | [optional] 
**Details** | **string** | More details about the failure. | [optional] 
**CampaignExclusionReason** | **string** | The reason why the campaign was not applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

