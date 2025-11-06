# TalonOne.Model.AddedDeductedPointsNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileIntegrationID** | **string** | The integration ID of the customer profile to whom points were added or deducted. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

