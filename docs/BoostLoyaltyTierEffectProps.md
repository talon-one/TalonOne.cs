# TalonOne.Model.BoostLoyaltyTierEffectProps
This effect indicates that the customer was temporarily placed in a higher loyalty tier for a specified period, without any change to their points balance.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **long** | The ID of the loyalty program. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program. | 
**TierName** | **string** | The name of the tier to which the customer is temporarily boosted. | 
**Reason** | **string** | A reason for the tier boost. | [optional] 
**ExpiryDate** | **DateTime** | The date when the tier boost expires. | 
**BoostUuid** | **Guid** | The unique identifier of the tier boost. Used to match the boost to its rollback effect when a session is cancelled. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

