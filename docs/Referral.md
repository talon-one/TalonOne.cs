# TalonOne.Model.Referral
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**StartDate** | **DateTime** | Timestamp at which point the referral code becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative. | [optional] 
**UsageLimit** | **int** | The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | 
**CampaignId** | **int** | ID of the campaign from which the referral received the referral code. | 
**AdvocateProfileIntegrationId** | **string** | The Integration ID of the Advocate&#39;s Profile. | 
**FriendProfileIntegrationId** | **string** | An optional Integration ID of the Friend&#39;s Profile | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. | [optional] 
**ImportId** | **int** | The ID of the Import which created this referral. | [optional] 
**Code** | **string** | The actual referral code. | 
**UsageCounter** | **int** | The number of times this referral code has been successfully used. | 
**BatchId** | **string** | The ID of the batch the referrals belong to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

