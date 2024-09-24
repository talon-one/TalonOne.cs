# TalonOne.Model.UpdateReferral
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FriendProfileIntegrationId** | **string** | An optional Integration ID of the Friend&#39;s Profile. | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the referral code becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiration date of the referral code. Referral never expires if this is omitted. | [optional] 
**UsageLimit** | **int** | The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

