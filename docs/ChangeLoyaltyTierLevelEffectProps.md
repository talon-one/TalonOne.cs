# TalonOne.Model.ChangeLoyaltyTierLevelEffectProps
The properties specific to the \"changeLoyaltyTierLevel\" effect. This is triggered whenever the user's loyalty tier is upgraded due to a validated rule that contained an \"addLoyaltyPoints\" effect. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleTitle** | **string** | The title of the rule that triggered the tier upgrade. | 
**ProgramId** | **long** | The ID of the loyalty program where these points were added. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**PreviousTierName** | **string** | The name of the tier from which the user was upgraded. | [optional] 
**NewTierName** | **string** | The name of the tier to which the user has been upgraded. | 
**ExpiryDate** | **DateTime** | The expiration date of the new tier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

