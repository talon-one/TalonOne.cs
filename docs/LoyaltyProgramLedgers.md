# TalonOne.Model.LoyaltyProgramLedgers
Customer-specific information about loyalty points.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of loyalty program. | 
**Title** | **string** | Visible name of loyalty program. | 
**Name** | **string** | Internal name of loyalty program. | 
**Ledger** | [**LedgerInfo**](LedgerInfo.md) |  | 
**SubLedgers** | [**Dictionary&lt;string, LedgerInfo&gt;**](LedgerInfo.md) | A map containing information about each loyalty subledger. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

