# TalonOne.Model.IncreaseAchievementProgressEffectProps
This effect indicates that the customer's progress in an achievement was updated during the current session. It is triggered when a rule using the [Update customer progress](https://docs.talon.one/docs/product/rules/effects/use-effects#update-customer-progress) effect is successfully validated.  For [on-completion achievements](https://docs.talon.one/docs/product/achievements/overview#recurring-on-completion-achievements), any customer progress exceeding the target automatically starts a new iteration. This generates a new `progressTrackerId` for each iteration, and there can be multiple progress updates for the same achievement from a single validation of this effect.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The internal ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The internal ID of the customer progress tracker. For [on-completion achievements](https://docs.talon.one/docs/product/achievements/overview#recurring-on-completion-achievements), this effect generates a unique ID for each iteration. | [optional] 
**Delta** | **decimal** | The value by which the customer&#39;s current progress in the achievement has increased. | 
**Value** | **decimal** | The current progress of the customer in the achievement. | 
**Target** | **decimal** | The target value to complete the achievement. | 
**IsJustCompleted** | **bool** | Indicates if the customer has completed the achievement in the current session. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

