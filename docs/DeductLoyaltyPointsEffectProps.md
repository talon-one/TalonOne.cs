# TalonOne.Model.DeductLoyaltyPointsEffectProps
This effect is triggered when a customer redeems loyalty points. The points are deducted from their active point balance.  If the loyalty program is card-based, use the `cardIdentifier` property to identify the loyalty card from which these points are deducted.  The Rule Engine deducts points in this order:  - Points with the earliest expiry date are deducted first, regardless of when they were added. - Points with an unlimited expiry date are deducted last. - For points with an unlimited expiry date, the points awarded first are deducted first.  The points only persist when the session is closed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleTitle** | **string** | The title of the rule that contained triggered this points deduction. | 
**ProgramId** | **long** | The ID of the loyalty program from which these points were deducted. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program from which these points were deducted. | 
**Value** | **decimal** | The amount of points that were deducted. | 
**TransactionUUID** | **string** | The identifier of this loyalty point transaction. | 
**Name** | **string** | The reason of this loyalty points deduction. | 
**CardIdentifier** | **string** | The identifier of the loyalty card, which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

