# TalonOne.Model.CardLedgerTransactionLogEntry
Log entry for a given loyalty card transaction.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionUUID** | **string** | Unique identifier of the transaction in the UUID format. | 
**Created** | **DateTime** | Date and time the loyalty card transaction occurred. | 
**ProgramId** | **long** | ID of the loyalty program. | 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | [optional] 
**SessionId** | **long** | The **internal** ID of the session.  | [optional] 
**CustomerSessionId** | **string** | ID of the customer session where the transaction occurred. | [optional] 
**Type** | **string** | Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points.  | 
**Name** | **string** | Name or reason of the loyalty ledger transaction. | 
**StartDate** | **string** | When points become active. Possible values:   - &#x60;immediate&#x60;: Points are immediately active.   - a timestamp value: Points become active at a given date and time.  | 
**ExpiryDate** | **string** | Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points become active from the given date.  | 
**SubledgerId** | **string** | ID of the subledger. | 
**Amount** | **decimal** | Amount of loyalty points added or deducted in the transaction. | 
**Id** | **long** | ID of the loyalty ledger entry. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

