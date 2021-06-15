# TalonOne.Model.LoyaltyPoints
Points to add or deduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **decimal** | Amount of loyalty points | 
**Name** | **string** | Allows to specify a name for the addition or deduction | [optional] 
**ValidityDuration** | **string** | Indicates the duration after which the added loyalty points should expire. The format is a number followed by one letter indicating the time unit, like &#39;1h&#39; or &#39;40m&#39; (defined by Go time package). | [optional] 
**PendingDuration** | **string** | Indicates the amount of time before the points are considered valid. The format is a number followed by one letter indicating the time unit, like &#39;1h&#39; or &#39;40m&#39; (defined by Go time package). | [optional] 
**SubLedgerID** | **string** | This specifies if we are adding loyalty points to the main ledger or a subledger | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

