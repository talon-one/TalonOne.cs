# TalonOne.Model.LedgerPointsEntryIntegrationAPI
Loyalty profile points with start and expiry dates.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the transaction that adds loyalty points. | 
**Created** | **DateTime** | Date and time the loyalty points were added. | 
**ProgramId** | **int** | ID of the loyalty program. | 
**CustomerSessionId** | **string** | ID of the customer session where points were added. | [optional] 
**Name** | **string** | Name or reason of the transaction that adds loyalty points. | 
**StartDate** | **string** | When points become active. Possible values:   - &#x60;immediate&#x60;: Points are active immediately.   - &#x60;timestamp value&#x60;: Points become active at a given date and time.  | 
**ExpiryDate** | **string** | Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points expire on the given date and time.  | 
**SubledgerId** | **string** | ID of the subledger. | 
**Amount** | **decimal** | Amount of loyalty points added in the transaction. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

