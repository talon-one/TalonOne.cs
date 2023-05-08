# TalonOne.Model.DeductLoyaltyPointsEffectProps
The properties specific to the \"deductLoyaltyPoints\" effect. This gets triggered whenever a validated rule contained a condition to only trigger when the given number of loyalty points could be deduced. These points are automatically stored and managed inside Talon.One.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleTitle** | **string** | The title of the rule that contained triggered this points deduction. | 
**ProgramId** | **int** | The ID of the loyalty program where these points were added. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**Value** | **decimal** | The amount of points that were deducted. | 
**TransactionUUID** | **string** | The identifier of this deduction in the loyalty ledger. | 
**Name** | **string** | The name property gets one of the following two values. It can be the loyalty program name or it can represent a reason for the respective deduction of loyalty points. The latter is an optional value defined in a deduction rule.  | 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

