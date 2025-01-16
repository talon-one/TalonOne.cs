# TalonOne.Model.LoyaltyBalanceWithTier
Point balance of a ledger in the Loyalty Program.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivePoints** | **decimal** | Total amount of points awarded to this customer and available to spend. | [optional] 
**PendingPoints** | **decimal** | Total amount of points awarded to this customer but not available until their start date. | [optional] 
**SpentPoints** | **decimal** | Total amount of points already spent by this customer. | [optional] 
**ExpiredPoints** | **decimal** | Total amount of points awarded but never redeemed. They cannot be used anymore. | [optional] 
**CurrentTier** | [**Tier**](Tier.md) |  | [optional] 
**ProjectedTier** | [**ProjectedTier**](ProjectedTier.md) |  | [optional] 
**PointsToNextTier** | **decimal** | The number of points required to move up a tier. | [optional] 
**NextTierName** | **string** | The name of the tier consecutive to the current tier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

