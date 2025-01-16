# TalonOne.Model.LoyaltyCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ProgramID** | **int** | The ID of the loyalty program that owns this entity. | 
**ProgramName** | **string** | The integration name of the loyalty program that owns this entity. | [optional] 
**ProgramTitle** | **string** | The Campaign Manager-displayed name of the loyalty program that owns this entity. | [optional] 
**Status** | **string** | Status of the loyalty card. Can be &#x60;active&#x60; or &#x60;inactive&#x60;.  | 
**BlockReason** | **string** | Reason for transferring and blocking the loyalty card.  | [optional] 
**Identifier** | **string** | The alphanumeric identifier of the loyalty card.  | 
**UsersPerCardLimit** | **int** | The max amount of customer profiles that can be linked to the card. 0 means unlimited.  | 
**Profiles** | [**List&lt;LoyaltyCardProfileRegistration&gt;**](LoyaltyCardProfileRegistration.md) | Integration IDs of the customers profiles linked to the card. | [optional] 
**Ledger** | [**LedgerInfo**](LedgerInfo.md) |  | [optional] 
**Subledgers** | [**Dictionary&lt;string, LedgerInfo&gt;**](LedgerInfo.md) | Displays point balances of the card in the subledgers of the loyalty program. | [optional] 
**Modified** | **DateTime** | Timestamp of the most recent update of the loyalty card. | [optional] 
**OldCardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 
**NewCardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 
**BatchId** | **string** | The ID of the batch in which the loyalty card was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

