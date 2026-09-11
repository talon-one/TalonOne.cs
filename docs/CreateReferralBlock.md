# TalonOne.Model.CreateReferralBlock
A block that creates a referral code.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**CampaignId** | [**Object**](.md) | The ID of the campaign in which the referral code is created. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time. | 
**FriendId** | **string** | An optional integration ID of the friend&#39;s profile. | 
**StoreInSession** | **bool** | When &#x60;true&#x60;, the referral code is stored in the session. | 
**UsageLimit** | [**Object**](.md) | The number of times the referral code code can be redeemed. &#x60;0&#x60; means unlimited redemptions, but any campaign usage limits still apply. Either a numeric scalar or a &#x60;{{expression}}&#x60; string that resolves to a number at evaluation time.  | [optional] 
**StartDate** | [**Object**](.md) | Timestamp at which point the referral code becomes valid. | [optional] 
**ExpiryDate** | [**Object**](.md) | Expiration date of the referral code. Referral code never expires if this is omitted. | [optional] 
**Attributes** | [**Object**](.md) | Custom attributes associated with this referral code. | [optional] 
**ValidCharacters** | **string** | Characters used to generate the random parts of a code. | [optional] 
**Pattern** | **string** | The pattern used to generate codes, such as coupon codes, referral codes, and loyalty cards. The character &#x60;#&#x60; is a placeholder and is replaced by a random character from the &#x60;validCharacters&#x60; set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

