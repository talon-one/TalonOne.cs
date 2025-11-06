# TalonOne.Model.IncreaseAchievementProgressEffectProps
The properties specific to the \"increaseAchievementProgress\" effect. This gets triggered whenever a validated rule contained an \"increase customer progress\" effect.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The internal ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The internal ID of the achievement progress tracker. | [optional] 
**Delta** | **decimal** | The value by which the customer&#39;s current progress in the achievement is increased. | 
**Value** | **decimal** | The current progress of the customer in the achievement. | 
**Target** | **decimal** | The target value to complete the achievement. | 
**IsJustCompleted** | **bool** | Indicates if the customer has completed the achievement in the current session. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

