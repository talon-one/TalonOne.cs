# TalonOne.Model.LoyaltyCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**ProgramID** | **int** | The ID of the loyalty program that owns this entity. | 
**CurrentBalance** | **decimal** | Sum of currently active points | 
**PendingBalance** | **decimal** | Sum of pending points | 
**ExpiredBalance** | **decimal** | Sum of expired points | 
**SpentBalance** | **decimal** | Sum of spent points | 
**TentativeCurrentBalance** | **decimal** | Sum of currently active points, including points added and deducted in open sessions | 
**CurrentTier** | [**Tier**](Tier.md) |  | [optional] 
**PointsToNextTier** | **decimal** | Points required to move up a tier. | [optional] 
**Projection** | [**LoyaltyProjection**](LoyaltyProjection.md) |  | [optional] 
**Status** | **string** | Status of the loyalty card. Can be one of: [&#39;active&#39;, &#39;disabled&#39;]  | 
**Identifier** | **string** | Identifier of the loyalty card. | 
**UsersPerCardLimit** | **int** | The max amount of user profiles a card can be shared with. 0 means unlimited.  | 
**Profiles** | [**List&lt;LoyaltyCardProfileRegistration&gt;**](LoyaltyCardProfileRegistration.md) | Integration IDs of the customers associated with the card. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

