# TalonOne.Model.ExpiringCardPointsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiryDate** | **DateTime** | The expiration date of loyalty points. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**AmountOfExpiringPoints** | **decimal** | The amount of loyalty points that will be expired soon. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card. | 
**UsersPerCardLimit** | **long** | The maximum number of customer profiles with which a card can be shared. This can be set to &#x60;0&#x60; for no limit.  | 
**Profiles** | **List&lt;string&gt;** | The integration IDs of the customer profiles linked to the card. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

