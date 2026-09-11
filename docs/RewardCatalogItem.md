# TalonOne.Model.RewardCatalogItem
A reward returned by the rewards catalog Integration API endpoint.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique ID of the reward. | 
**Name** | **string** | The customer-facing name of the reward. | 
**Description** | **string** | The customer-facing description of the reward. | [optional] 
**PointsRequired** | [**List&lt;RewardPointsRequired&gt;**](RewardPointsRequired.md) | The loyalty points required to activate the reward. | [optional] 
**Rule** | [**RuleMetadata**](RuleMetadata.md) |  | 
**Eligibility** | [**RewardEligibility**](RewardEligibility.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

