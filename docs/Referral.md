
# TalonOne.Model.Referral

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**CampaignId** | **int** | ID of the campaign from which the referral received the referral code. | 
**AdvocateProfileIntegrationId** | **string** | The Integration Id of the Advocate&#39;s Profile | 
**FriendProfileIntegrationId** | **string** | An optional Integration ID of the Friend&#39;s Profile | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the referral code becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative. | [optional] 
**Code** | **string** | The actual referral code. | 
**UsageCounter** | **int** | The number of times this referral code has been successfully used. | 
**UsageLimit** | **int** | The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

