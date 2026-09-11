# TalonOne.Model.ChangeLoyaltyTierLevelEffectProps
This effect indicates that a customer's loyalty tier has been upgraded.  This effect is generated only when the [Add loyalty points](https://docs.talon.one/docs/product/rules/effects/use-effects#add-loyalty-points) and the [Add loyalty points per cart item](https://docs.talon.one/docs/product/rules/effects/use-effects#add-loyalty-points-per-cart-item) effects are triggered for a particular customer, and, as a result, the customer's loyalty tier is upgraded.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleTitle** | **string** | The title of the rule that triggered the tier upgrade. | 
**ProgramId** | **long** | The ID of the loyalty program where the points were added. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where the points were added. | 
**PreviousTierName** | **string** | The name of the tier from which the user was upgraded. | [optional] 
**NewTierName** | **string** | The name of the tier to which the user has been upgraded. | 
**ExpiryDate** | **DateTime** | The expiration date of the new tier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

