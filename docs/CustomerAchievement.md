# TalonOne.Model.CustomerAchievement
A customer's progress in an achievement, together with the achievement definition.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of the achievement. | 
**Name** | **string** | The internal name of the achievement used in API requests.  | 
**Title** | **string** | The display name of the achievement in the Campaign Manager. | 
**Description** | **string** | The description of the achievement in the Campaign Manager. | 
**Target** | **decimal** | The required number of actions or the transactional milestone to complete the achievement. | 
**RecurrencePolicy** | **string** | The policy that determines if and how the achievement recurs. - &#x60;no_recurrence&#x60;: The achievement can be completed only once. - &#x60;on_expiration&#x60;: The achievement resets after it expires and becomes available again. - &#x60;on_completion&#x60;: When the customer progress status reaches &#x60;completed&#x60;, the achievement resets and becomes available again.  | 
**ActivationPolicy** | **string** | The policy that determines how the achievement starts, ends, or resets. - &#x60;user_action&#x60;: The achievement ends or resets relative to when the customer started the achievement. - &#x60;fixed_schedule&#x60;: The achievement starts, ends, or resets for all customers following a fixed schedule.  | 
**FixedStartDate** | **DateTime** | The achievement&#39;s start date when &#x60;activationPolicy&#x60; is equal to &#x60;fixed_schedule&#x60;.  **Note:** It is an RFC3339 timestamp string.  | [optional] 
**EndDate** | **DateTime** | The achievement&#39;s end date. If defined, customers cannot participate in the achievement after this date.  **Note:** It is an RFC3339 timestamp string.  | [optional] 
**AllowRollbackAfterCompletion** | **bool** | When &#x60;true&#x60;, customer progress can be rolled back in completed achievements. | 
**CampaignId** | **long** | This property is **deprecated**. Use &#x60;referencedByCampaigns&#x60; instead. This field contains the first campaign ID from the related &#x60;referencedByCampaigns&#x60;, and is omitted when &#x60;referencedByCampaigns&#x60; is empty. | [optional] 
**CampaignIds** | **List&lt;long&gt;** | The IDs of the campaigns that reference this achievement, in ascending order. | 
**ReferencedByCampaigns** | [**List&lt;CampaignReference&gt;**](CampaignReference.md) | The campaigns that reference this achievement. They are sorted in ascending order by their &#x60;id&#x60;. | 
**CurrentProgress** | [**AchievementProgress**](AchievementProgress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

