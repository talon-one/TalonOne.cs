# TalonOne.Model.LoyaltyLedgerEntry
A single row of the ledger, describing one addition or deduction.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime** |  | 
**ProgramID** | **int** |  | 
**CustomerProfileID** | **string** |  | [optional] 
**CardID** | **int** |  | [optional] 
**CustomerSessionID** | **string** |  | [optional] 
**EventID** | **int** |  | [optional] 
**Type** | **string** | The type of the ledger transaction. Possible values are: - &#x60;addition&#x60; - &#x60;subtraction&#x60; - &#x60;expire&#x60; - &#x60;expiring&#x60; (for expiring points ledgers)  | 
**Amount** | **decimal** |  | 
**StartDate** | **DateTime** |  | [optional] 
**ExpiryDate** | **DateTime** |  | [optional] 
**Name** | **string** | A name referencing the condition or effect that added this entry, or the specific name provided in an API call. | 
**SubLedgerID** | **string** | This specifies if we are adding loyalty points to the main ledger or a subledger. | 
**UserID** | **int** | This is the ID of the user who created this entry, if the addition or subtraction was done manually. | [optional] 
**Archived** | **bool** | Indicates if the entry belongs to the archived session. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

