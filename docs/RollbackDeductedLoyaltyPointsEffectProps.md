# TalonOne.Model.RollbackDeductedLoyaltyPointsEffectProps
The properties specific to the \"rollbackDeductedLoyaltyPoints\" effect. This effect is triggered whenever a previously closed session is cancelled and a deductLoyaltyPoints effect was revoked.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **int** | The ID of the loyalty program where these points were reimbursed | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were reimbursed | 
**Value** | **decimal** | The amount of reimbursed points that were added | 
**RecipientIntegrationId** | **string** | The user for whom these points were reimbursed | 
**StartDate** | **DateTime** | Date after which the reimbursed points will be valid | [optional] 
**ExpiryDate** | **DateTime** | Date after which the reimbursed points will expire | [optional] 
**TransactionUUID** | **string** | The identifier of &#39;addition&#39; entries added to the ledger as the &#x60;deductLoyaltyPoints&#x60; effect is rolled back | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

