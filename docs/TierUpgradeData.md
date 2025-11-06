# TalonOne.Model.TierUpgradeData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerProfileID** | **string** | The integration ID of the customer profile whose tier was upgraded. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**SubledgerID** | **string** | The ID of the subledger, when applicable. If this field is empty, the main ledger is used. | [default to ""]
**CurrentTier** | **string** | The name of the customer&#39;s current tier. | 
**CurrentPoints** | **decimal** | The number of points the customer had at the time of tier upgrade. | 
**OldTier** | **string** | The name of the customer&#39;s previous tier. | [optional] 
**PointsRequiredToTheNextTier** | **decimal** | The number of points needed for a customer to reach the next tier. | [optional] 
**NextTier** | **string** | The name of the customer&#39;s next tier. | [optional] 
**TierExpirationDate** | **DateTime** | The exact date and time the tier expires. | 
**TimestampOfTierChange** | **DateTime** | The exact date and time the tier was changed. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

