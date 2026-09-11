# TalonOne.Model.RewardWithUnlocks
A reward and details of each time a customer profile has unlocked it.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique ID of the reward. | 
**IntegrationId** | **string** | A unique identifier used to reference the reward in API integrations. | 
**Name** | **string** | The customer-facing name of the reward. | 
**Description** | **string** | Customer-facing description of the reward. | [optional] 
**Rule** | [**RuleMetadata**](RuleMetadata.md) |  | 
**Unlocked** | [**List&lt;CustomerReward&gt;**](CustomerReward.md) | The customer profile&#39;s unlocks of this reward that are not yet &#x60;used&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

