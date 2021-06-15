# TalonOne.Model.AddLoyaltyPointsEffectProps
The properties specific to the \"addLoyaltyPoints\" effect. This gets triggered whenever a validated rule contained an \"add loyalty\" effect. These points are automatically stored and managed inside Talon.One.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name/description of this loyalty point addition | 
**ProgramId** | **int** | The ID of the loyalty program where these points were added | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were added | 
**Value** | **decimal** | The amount of points that were added | 
**RecipientIntegrationId** | **string** | The user for whom these points were added | 
**StartDate** | **DateTime** | Date after which points will be valid | [optional] 
**ExpiryDate** | **DateTime** | Date after which points will expire | [optional] 
**TransactionUUID** | **string** | The identifier of this addition in the loyalty ledger | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

