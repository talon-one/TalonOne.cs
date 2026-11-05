# TalonOne.Model.ExpiringCardPointsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiryDate** | **DateTime** | The expiration date of loyalty points. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**AmountOfExpiringPoints** | **decimal** | The amount of loyalty points that will be expired soon. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**CardIdentifier** | **string** | The identifier of the loyalty card, &#x60;which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | 
**UsersPerCardLimit** | **long** | The maximum number of customer profiles with which a card can be shared. This can be set to &#x60;0&#x60; for no limit.  | 
**Profiles** | **List&lt;string&gt;** | The integration IDs of the customer profiles linked to the card. | 
**Created** | **DateTime** | The timestamp when the loyalty transaction occurred. | [optional] 
**AwaitsActivation** | **bool** | Indicates whether the points have an action-based start date. This property is returned only for point transactions with an action-based start date. | [optional] 
**ValidityDuration** | **string** | The duration for which the points remain active, relative to the activation date.  **Note**: This only applies to points for which &#x60;AwaitsActivation&#x60; is &#x60;true&#x60; and &#x60;ExpiryDate&#x60; is not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

