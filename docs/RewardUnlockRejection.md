# TalonOne.Model.RewardUnlockRejection
Returned when a reward unlock is rejected by the Rule Engine, for example because the customer already unlocked this reward, the customer has insufficient points, or the reward's eligibility conditions are not met. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | A human-readable summary of why the reward unlock was rejected. | 
**RuleFailureReasons** | [**List&lt;RuleFailureReason&gt;**](RuleFailureReason.md) | The reasons why the reward could not be unlocked. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

