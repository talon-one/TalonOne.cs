# TalonOne.Model.CardAddedDeductedPointsNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileIntegrationIDs** | **List&lt;string&gt;** | The integration ID of the customer profile to whom points were added or deducted. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added or deducted. | 
**Amount** | **decimal** | The amount of added or deducted loyalty points. | 
**Reason** | **string** | The reason for the points addition or deduction. | 
**TypeOfChange** | **string** | The notification source, that is, it indicates whether the points were added or deducted via one of the following routes:  - [The Campaign Manager](/docs/product/getting-started)  - [Management API](/management-api#tag/Loyalty)  - [Rule Engine](/docs/product/applications/evaluation-order-for-rules-and-filters)  | 
**EmployeeName** | **string** | The name of the employee who added or deducted points. | 
**UserID** | **long** | The ID of the employee who added or deducted points. | 
**Operation** | **string** | The action (addition or deduction) made with loyalty points. | 
**StartDate** | **DateTime** | The start date for loyalty points. | [optional] 
**ExpiryDate** | **DateTime** | The expiration date for loyalty points. | [optional] 
**SessionIntegrationID** | **string** | The integration ID of the session through which the points were earned or lost. | 
**NotificationType** | **string** | The type of notification. | 
**CardIdentifier** | **string** | Loyalty card identification number. | 
**UsersPerCardLimit** | **long** | The max amount of user profiles with whom a card can be shared. This can be set to &#x60;0&#x60; for no limit. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

