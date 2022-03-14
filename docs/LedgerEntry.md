# TalonOne.Model.LedgerEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ProfileId** | **string** | ID of the customers profile as used within this Talon.One account.  **Note:** If the customer does not yet have a known profileId, we recommend you use a guest profileId.  | 
**AccountId** | **int** | The ID of the Talon.One account that owns this profile. | 
**LoyaltyProgramId** | **int** | ID of the ledger | 
**EventId** | **int** | ID of the related event | 
**Amount** | **int** | Amount of loyalty points | 
**Reason** | **string** | reason for awarding/deducting points | 
**ExpiryDate** | **DateTime** | Expiry date of the points | 
**ReferenceId** | **int** | The ID of the balancing ledgerEntry | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

