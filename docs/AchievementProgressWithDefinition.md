# TalonOne.Model.AchievementProgressWithDefinition
The current progress of the customer in the achievement.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the achievement. | 
**Progress** | **decimal** | The current progress of the customer in the achievement. | 
**StartDate** | **DateTime** | Timestamp at which the customer started the achievement. | [optional] 
**CompletionDate** | **DateTime** | Timestamp at which point the customer completed the achievement. | [optional] 
**EndDate** | **DateTime** | Timestamp at which point the achievement ends and resets for the customer. | [optional] 
**AchievementId** | **int** | The internal ID of the achievement. | 
**Name** | **string** | The internal name of the achievement used in API requests.  | 
**Title** | **string** | The display name of the achievement in the Campaign Manager. | 
**Description** | **string** | The description of the achievement in the Campaign Manager. | 
**CampaignId** | **int** | The ID of the campaign the achievement belongs to. | 
**Target** | **decimal** | The required number of actions or the transactional milestone to complete the achievement. | [optional] 
**AchievementRecurrencePolicy** | **string** | The policy that determines if and how the achievement recurs. - &#x60;no_recurrence&#x60;: The achievement can be completed only once. - &#x60;on_expiration&#x60;: The achievement resets after it expires and becomes available again.  | 
**AchievementActivationPolicy** | **string** | The policy that determines how the achievement starts, ends, or resets. - &#x60;user_action&#x60;: The achievement ends or resets relative to when the customer started the achievement. - &#x60;fixed_schedule&#x60;: The achievement starts, ends, or resets for all customers following a fixed schedule.  | 
**AchievementFixedStartDate** | **DateTime** | The achievement&#39;s start date when &#x60;achievementActivationPolicy&#x60; is equal to &#x60;fixed_schedule&#x60;.  **Note:** It is an RFC3339 timestamp string.  | [optional] 
**AchievementEndDate** | **DateTime** | The achievement&#39;s end date. If defined, customers cannot participate in the achievement after this date.  **Note:** It is an RFC3339 timestamp string.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

