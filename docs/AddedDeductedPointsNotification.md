# TalonOne.Model.AddedDeductedPointsNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeName** | **string** | The name of the employee who added or deducted points. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**NotificationType** | **string** | The type of notification. | 
**ProfileIntegrationID** | **string** | The integration ID of the customer profile to whom points were added or deducted. | 
**SessionIntegrationID** | **string** | The integration ID of the session through which the points were earned or lost. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**TypeOfChange** | **string** | The notification source, that is, it indicates whether the points were added or deducted via one of the following routes:  - [The Campaign Manager](/docs/product/getting-started)  - [Management API](/management-api#tag/Loyalty)  - [Rule Engine](/docs/product/applications/evaluation-order-for-rules-and-filters)  | 
**UserID** | **long** | The ID of the employee who added or deducted points. | 
**Amount** | **decimal** | The amount of added or deducted loyalty points. | 
**ExpiryDate** | **DateTime** | The expiration date for loyalty points. | [optional] 
**Operation** | **string** | The action (addition or subtraction) made with loyalty points. | 
**Reason** | **string** | The reason for the points addition or deduction. | 
**StartDate** | **DateTime** | The start date for loyalty points. | [optional] 
**TransactionUUID** | **Guid** | The identifier of the transaction in the loyalty ledger. | 
**Created** | **DateTime** | The timestamp when the loyalty transaction occurred. | [optional] 
**AwaitsActivation** | **bool** | Indicates whether the points have an action-based start date. This property is returned only for point transactions with an action-based start date. | [optional] 
**ValidityDuration** | **string** | The duration for which the points remain active, relative to the activation date.  **Note**: This only applies to points for which &#x60;AwaitsActivation&#x60; is &#x60;true&#x60; and &#x60;ExpiryDate&#x60; is not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

