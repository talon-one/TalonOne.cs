# TalonOne.Model.ExpiringPointsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiryDate** | **DateTime** | The expiration date of loyalty points. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**CustomerProfileID** | **string** | The integration ID of the customer profile that has expiring points. | 
**AmountOfExpiringPoints** | **decimal** | The amount of loyalty points that will be expired soon. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**Created** | **DateTime** | The timestamp when the loyalty transaction occurred. | [optional] 
**AwaitsActivation** | **bool** | Indicates whether the points have an action-based start date. This property is returned only for point transactions with an action-based start date. | [optional] 
**ValidityDuration** | **string** | The duration for which the points remain active, relative to the activation date.  **Note**: This only applies to points for which &#x60;AwaitsActivation&#x60; is &#x60;true&#x60; and &#x60;ExpiryDate&#x60; is not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

