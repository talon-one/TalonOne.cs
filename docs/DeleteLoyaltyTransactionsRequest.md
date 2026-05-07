# TalonOne.Model.DeleteLoyaltyTransactionsRequest
Request to delete transactions based on the specified scope.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | &#x60;AllSubledgers&#x60; deletes all transactions for the specified customer profile from all ledgers in the loyalty program.  &#x60;SelectedSubledgers&#x60; deletes all transactions for the specified customer profile only from the given ledgers in the loyalty program.  | 
**SubledgerIds** | **List&lt;string&gt;** | The IDs of the ledgers from which to delete the customer&#39;s transactions. This parameter is required if the &#x60;scope&#x60; is set to &#x60;SelectedSubledgers&#x60;.  To specify the main ledger, provide an empty string (\&quot;\&quot;).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

