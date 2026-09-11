# TalonOne.Model.UnlockRewardEffectProps
The properties specific to the \"unlockReward\" effect. This gets triggered whenever a validated rule unlocks a reward for a customer profile.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID assigned to the customer reward unlock. | 
**RewardId** | **long** | The internal ID of the reward that was unlocked. | 
**ApplicationId** | **long** | The internal ID of the application the reward belongs to. | 
**ProfileIntegrationId** | **string** | The integration ID of the customer profile that unlocked the reward. | 
**UnlockedAt** | **DateTime** | The time the reward was unlocked. | 
**CardIdentifier** | **string** | The identifier of the loyalty card, which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

