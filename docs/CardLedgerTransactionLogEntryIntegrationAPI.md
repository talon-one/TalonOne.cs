# TalonOne.Model.CardLedgerTransactionLogEntryIntegrationAPI
Log entry for a given loyalty card transaction.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime** | Date and time the loyalty card transaction occurred. | 
**ProgramId** | **int** | ID of the loyalty program. | 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | 
**CustomerSessionId** | **string** | ID of the customer session where the transaction occurred. | [optional] 
**Type** | **string** | Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points.  | 
**Name** | **string** | Name or reason of the loyalty ledger transaction. | 
**StartDate** | **string** | When points become active. Possible values:   - &#x60;immediate&#x60;: Points are active immediately.   - a timestamp value: Points become active at a given date and time.  | 
**ExpiryDate** | **string** | Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points expire on the given date.  | 
**SubledgerId** | **string** | ID of the subledger. | 
**Amount** | **decimal** | Amount of loyalty points added or deducted in the transaction. | 
**Id** | **int** | ID of the loyalty ledger transaction. | 
**RulesetId** | **int** | The ID of the ruleset containing the rule that triggered this effect. | [optional] 
**RuleName** | **string** | The name of the rule that triggered this effect. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

