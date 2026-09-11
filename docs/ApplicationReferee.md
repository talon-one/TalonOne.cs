# TalonOne.Model.ApplicationReferee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**SessionId** | **string** | Integration ID of the session in which the customer redeemed the referral. | 
**AdvancedEventIntegrationId** | **string** | The unique ID of the advanced event in which the customer redeemed the referral. Omitted when the referral was redeemed through a customer session rather than an advanced event. | [optional] 
**AdvocateIntegrationId** | **string** | Integration ID of the Advocate&#39;s Profile. | 
**FriendIntegrationId** | **string** | Integration ID of the Friend&#39;s Profile. | 
**Code** | **string** | Advocate&#39;s referral code. | 
**Created** | **DateTime** | Timestamp of the moment the customer redeemed the referral. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

