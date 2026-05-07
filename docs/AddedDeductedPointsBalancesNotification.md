# TalonOne.Model.AddedDeductedPointsBalancesNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeName** | **string** | The name of the employee who added or deducted points. | 
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**NotificationType** | **string** | The type of notification. | 
**ProfileIntegrationID** | **string** | The integration ID of the customer profile to whom points were added or deducted. | 
**SessionIntegrationID** | **string** | The integration ID of the session through which the points were earned or lost. | 
**SubledgerID** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**TypeOfChange** | **string** | The notification source, that is, it indicates whether the points were added or deducted via one of the following routes: - [The Campaign Manager](/docs/product/getting-started) - [Management API](/management-api#tag/Loyalty) - [Rule Engine](/docs/product/applications/evaluation-order-for-rules-and-filters)  | 
**UserID** | **long** | The ID of the employee who added or deducted points. | 
**Actions** | [**List&lt;AddedDeductedPointsBalancesAction&gt;**](AddedDeductedPointsBalancesAction.md) | The list of actions that have been triggered in the loyalty program. | 
**CurrentPoints** | **decimal** | The current points balance. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

