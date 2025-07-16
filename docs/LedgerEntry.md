# TalonOne.Model.LedgerEntry
Entry in the point ledger.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ProfileId** | **string** | ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;.  | 
**AccountId** | **int** | The ID of the Talon.One account that owns this profile. | 
**LoyaltyProgramId** | **int** | ID of the ledger. | 
**EventId** | **int** | ID of the related event. | 
**Amount** | **int** | Amount of loyalty points. | 
**Reason** | **string** | reason for awarding/deducting points. | 
**ExpiryDate** | **DateTime** | Expiration date of the points. | 
**ReferenceId** | **int** | The ID of the balancing ledgerEntry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

