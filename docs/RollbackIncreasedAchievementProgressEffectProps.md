# TalonOne.Model.RollbackIncreasedAchievementProgressEffectProps
The properties specific to the \"rollbackIncreasedAchievementProgress\" effect. This gets triggered whenever a closed session where the `increaseAchievementProgress` effect was triggered is cancelled. This is applicable only when the customer has not completed the achievement.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The internal ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The internal ID of the achievement progress tracker. | 
**DecreaseProgressBy** | **decimal** | The value by which the customer&#39;s current progress in the achievement is decreased. | 
**CurrentProgress** | **decimal** | The current progress of the customer in the achievement. | 
**Target** | **decimal** | The target value to complete the achievement. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

