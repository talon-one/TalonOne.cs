# TalonOne.Model.LoyaltyProgramTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the loyalty ledger transaction. | 
**ProgramId** | **int** | ID of the loyalty program. | 
**Created** | **DateTime** | Date and time the loyalty transaction occurred. | 
**Type** | **string** | Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points.  | 
**Amount** | **decimal** | Amount of loyalty points added or deducted in the transaction. | 
**Name** | **string** | Name or reason for the loyalty ledger transaction. | 
**StartDate** | **string** | When points become active. Possible values:   - &#x60;immediate&#x60;: Points are immediately active.   - a timestamp value: Points become active at a given date and time.  | 
**ExpiryDate** | **string** | When points expire. Possible values:   - &#x60;unlimited&#x60;: Points have no expiration date.   - a timestamp value: Points expire at a given date and time.  | 
**CustomerProfileId** | **string** | Customer profile integration ID used in the loyalty program. | [optional] 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 
**SubledgerId** | **string** | ID of the subledger. | 
**CustomerSessionId** | **string** | ID of the customer session where the transaction occurred. | [optional] 
**ImportId** | **int** | ID of the import where the transaction occurred. | [optional] 
**UserId** | **int** | ID of the user who manually added or deducted points. Applies only for manual transactions. | [optional] 
**UserEmail** | **string** | The email of the user who manually added or deducted points. Applies only for manual transactions. | [optional] 
**RulesetId** | **int** | ID of the ruleset containing the rule that triggered the effect. Applies only for transactions that resulted from a customer session. | [optional] 
**RuleName** | **string** | Name of the rule that triggered the effect. Applies only for transactions that resulted from a customer session. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

