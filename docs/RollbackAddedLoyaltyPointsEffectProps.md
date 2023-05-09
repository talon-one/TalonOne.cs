# TalonOne.Model.RollbackAddedLoyaltyPointsEffectProps
The properties specific to the \"rollbackAddedLoyaltyPoints\" effect. This gets triggered whenever previously a closed session with an addLoyaltyPoints effect is cancelled.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **int** | The ID of the loyalty program where the points were originally added. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were originally added. | 
**Value** | **decimal** | The amount of points that were rolled back. | 
**RecipientIntegrationId** | **string** | The user for whom these points were originally added. | 
**TransactionUUID** | **string** | The identifier of &#39;deduction&#39; entry added to the ledger as the &#x60;addLoyaltyPoints&#x60; effect is rolled back. | 
**CartItemPosition** | **decimal** | The index of the item in the cart items for which the loyalty points were rolled back. | [optional] 
**CartItemSubPosition** | **decimal** | The sub-position is returned when [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled. It indicates to which item the loyalty points were rolled back, for cart items with &#x60;quantity&#x60; &gt; 1.  | [optional] 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

