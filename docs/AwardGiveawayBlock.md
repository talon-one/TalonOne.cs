# TalonOne.Model.AwardGiveawayBlock
A block that awards a giveaway item from a configured giveaway pool to the specified customer profile.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**GiveawayPool** | [**GiveawayPoolReference**](GiveawayPoolReference.md) |  | 
**Profile** | **string** | The customer profile to award the giveaway to. &#x60;Current&#x60; targets the customer in the current session; &#x60;Advocate&#x60; targets the person who invited their friend via referral program. | 
**OnFailure** | **List&lt;Object&gt;** | Blocks evaluated when this block fails or returns false. | [optional] 
**OnError** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | Named error handlers evaluated when a specific error occurs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

