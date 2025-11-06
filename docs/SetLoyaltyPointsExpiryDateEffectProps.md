# TalonOne.Model.SetLoyaltyPointsExpiryDateEffectProps
The properties specific to the \"setLoyaltyPointsExpiryDate\" effect. This gets triggered when a validated rule contains the \"set expiry date\" effect. The current expiry date gets set to the date given in the effect. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **long** | ID of the loyalty program that contains these points. | 
**SubLedgerId** | **string** | API name of the loyalty program subledger that contains these points. | 
**NewExpiryDate** | **DateTime** | The specified expiry date and time for all active and pending point transactions in the loyalty program subledger. | 
**AffectedTransactions** | [**List&lt;LoyaltyLedgerEntryExpiryDateChange&gt;**](LoyaltyLedgerEntryExpiryDateChange.md) | List of transactions affected by the expiry date update. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

