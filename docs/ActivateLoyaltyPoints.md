# TalonOne.Model.ActivateLoyaltyPoints
Activate loyalty points
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionUUIDs** | **List&lt;Guid&gt;** | An array of transaction UUIDs used to activate specific pending point transactions.  If provided, do not include the &#x60;sessionId&#x60; parameter.  | [optional] 
**SessionId** | **string** | The ID of the session containing the pending point transactions to activate.  If provided, do not include the &#x60;transactionUUIDs&#x60; parameter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

