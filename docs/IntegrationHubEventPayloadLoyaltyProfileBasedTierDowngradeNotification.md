# TalonOne.Model.IntegrationHubEventPayloadLoyaltyProfileBasedTierDowngradeNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **long** | The ID of the integration hub event. Return this value in the delivery-status callback to mark the event delivered or failed. | 
**ProfileIntegrationID** | **string** |  | 
**LoyaltyProgramID** | **long** |  | 
**LoyaltyProgramName** | **string** | The name of the loyalty program. | 
**SubledgerID** | **string** |  | 
**SourceOfEvent** | **string** |  | 
**CurrentTier** | **string** | The name of the customer&#39;s current tier, or null if the customer was downgraded below all tiers. | [optional] 
**CurrentPoints** | **float** |  | 
**OldTier** | **string** |  | [optional] 
**TierExpirationDate** | **DateTime** |  | [optional] 
**TimestampOfTierChange** | **DateTime** |  | [optional] 
**PublishedAt** | **DateTime** | Timestamp when the event was published. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

