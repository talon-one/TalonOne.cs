# TalonOne.Model.StartAchievementProgressEffectProps
This effect indicates that the customer's progress in an achievement was started during the current session. The progress value is set to 0. It is triggered when a rule using the [Start achievement progress](https://docs.talon.one/docs/product/rules/effects/use-effects#start-achievement-progress) effect is successfully validated.  This effect only marks the start of progress tracking. It can fire together with `increaseAchievementProgress` when progress starts and increases at the same time. In that case, both effects share the same `progressTrackerId`, `startDate`, and `endDate`.  For [on-completion achievements](https://docs.talon.one/docs/product/campaigns/achievements/overview#recurring-on-completion-achievements), each iteration also gets its own `startDate` and `endDate`. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The ID of the customer&#39;s progress tracker for this achievement.  For [on-completion achievements](https://docs.talon.one/docs/product/campaigns/achievements/overview#recurring-on-completion-achievements), this effect generates a unique ID for each iteration. | [optional] 
**Target** | **decimal** | The target value to complete the achievement. | 
**StartDate** | **DateTime** | Timestamp at which the customer&#39;s progress started. | 
**EndDate** | **DateTime** | Timestamp at which this progress period ends.  Only returned for achievements that have a fixed end date. [On-completion achievements](https://docs.talon.one/docs/product/campaigns/achievements/overview#recurring-on-completion-achievements) have no end date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

