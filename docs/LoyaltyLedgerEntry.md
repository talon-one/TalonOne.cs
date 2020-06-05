
# TalonOne.Model.LoyaltyLedgerEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime** |  | 
**ProgramID** | **int** |  | 
**CustomerProfileID** | **string** |  | 
**CustomerSessionID** | **string** |  | [optional] 
**EventID** | **int** |  | [optional] 
**Type** | **string** | The type of the ledger transaction. Possible values are addition, subtraction, expire or expiring (for expiring points ledgers)  | 
**Amount** | **decimal** |  | 
**ExpiryDate** | **DateTime** |  | [optional] 
**Name** | **string** | A name referencing the condition or effect that added this entry, or the specific name provided in an API call. | 
**SubLedgerID** | **string** | This specifies if we are adding loyalty points to the main ledger or a subledger | 
**UserID** | **int** | This is the ID of the user who created this entry, if the addition or subtraction was done manually. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

