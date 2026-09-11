# TalonOne.Model.RedeemLoyaltyPointsBlock
A block that deducts a specified amount of points from a customer's loyalty program balance, optionally from a named subledger.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Program** | [**RedeemLoyaltyPointsBlockProgram**](RedeemLoyaltyPointsBlockProgram.md) |  | 
**Subledger** | **string** | The name of the subledger to deduct points from. Can be empty if this block deducts from the loyalty program&#39;s main ledger instead of a subledger. | 
**Value** | [**Object**](.md) | Number of points to deduct. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time. | 
**Name** | **string** | A custom description recorded as the reason for the point deduction. | [optional] 
**OnFailure** | **List&lt;Object&gt;** | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

