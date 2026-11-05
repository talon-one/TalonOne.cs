# TalonOne.Model.AwardLoyaltyPointsBlock
A block that adds loyalty points to a loyalty program and subledger for a recipient. The `target` field determines what the award is based on (the whole cart, a subset of items, or a bundle); the `value` field is the number of awarded points.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Name** | **string** | The human-readable label attached to the awarded points. | 
**Program** | [**AwardLoyaltyPointsBlockProgram**](AwardLoyaltyPointsBlockProgram.md) |  | 
**Recipient** | **string** | The customer profile that receives the points. &#x60;Current&#x60; targets the customer in the current session; &#x60;Advocate&#x60; targets the person who invited their friend via referral program. | 
**Subledger** | **string** | The name of the subledger to add points to. Can be empty if this block adds points to the loyalty program&#39;s main ledger instead of a subledger. | 
**Target** | [**Object**](.md) | Identifies the scope over which loyalty points are awarded. The &#x60;type&#x60; field selects the target variant. | 
**Value** | [**Object**](.md) | Number of points to award. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time. | 
**Partial** | **bool** | When &#x60;true&#x60;, applies a partial points reward when the requested value exceeds the configured budget. | [optional] 
**AwaitsActivation** | **bool** | When &#x60;true&#x60;, the awarded points require manual or delayed activation before becoming active. Mutually exclusive with &#x60;startDate&#x60;. | [optional] 
**StartDate** | [**Object**](.md) | Timestamp at which the awarded points become active. Mutually exclusive with &#x60;awaitsActivation&#x60;. | [optional] 
**ValidityDuration** | **string** | Relative duration (e.g. &#x60;30D&#x60;) after which the awarded points expire. Mutually exclusive with &#x60;expiryDate&#x60;. | [optional] 
**ExpiryDate** | [**Object**](.md) | Timestamp at which the awarded points expire. Mutually exclusive with &#x60;validityDuration&#x60;. | [optional] 
**PendingDuration** | **string** | Relative duration (e.g. &#x60;3D&#x60;) the awarded points remain pending before activation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

