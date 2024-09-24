# TalonOne.Model.AchievementProgress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **int** | The internal ID of the achievement. | 
**Name** | **string** | The internal name of the achievement used in API requests.  | 
**Title** | **string** | The display name of the achievement in the Campaign Manager. | 
**Description** | **string** | The description of the achievement in the Campaign Manager. | 
**CampaignId** | **int** | The ID of the campaign the achievement belongs to. | 
**Status** | **string** | The status of the achievement. | 
**Target** | **decimal** | The required number of actions or the transactional milestone to complete the achievement. | [optional] 
**Progress** | **decimal** | The current progress of the customer in the achievement. | 
**StartDate** | **DateTime** | Timestamp at which the customer started the achievement. | 
**CompletionDate** | **DateTime** | Timestamp at which point the customer completed the achievement. | [optional] 
**EndDate** | **DateTime** | Timestamp at which point the achievement ends and resets for the customer. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

