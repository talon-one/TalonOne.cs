# TalonOne.Model.LedgerInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentBalance** | **decimal** | Sum of currently active points | 
**PendingBalance** | **decimal** | Sum of pending points | 
**ExpiredBalance** | **decimal** | Sum of expired points | 
**SpentBalance** | **decimal** | Sum of spent points | 
**TentativeCurrentBalance** | **decimal** | Sum of currently active points, including points added and deducted in open sessions | 
**CurrentTier** | [**Tier**](Tier.md) |  | [optional] 
**PointsToNextTier** | **decimal** | Points required to move up a tier. | [optional] 
**Projection** | [**LoyaltyProjection**](LoyaltyProjection.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

