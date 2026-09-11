# TalonOne.Model.IntegrationHubEventPayloadLoyaltyProfileBasedPointsChangedNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **long** | The ID of the integration hub event. Return this value in the delivery-status callback to mark the event delivered or failed. | 
**ProfileIntegrationID** | **string** |  | 
**LoyaltyProgramID** | **long** |  | 
**LoyaltyProgramName** | **string** | The name of the loyalty program. | 
**SubledgerID** | **string** |  | 
**SourceOfEvent** | **string** |  | 
**CurrentTier** | **string** | The name of the customer&#39;s current tier. | 
**SessionIntegrationID** | **string** | The integration ID of the session through which the points were earned or lost. Only set when the change results from a rule engine execution; empty otherwise. | [optional] 
**EmployeeName** | **string** |  | [optional] 
**UserID** | **long** |  | [optional] 
**CurrentPoints** | **float** |  | 
**Actions** | [**List&lt;IntegrationHubEventPayloadLoyaltyProfileBasedPointsChangedNotificationAction&gt;**](IntegrationHubEventPayloadLoyaltyProfileBasedPointsChangedNotificationAction.md) |  | [optional] 
**PublishedAt** | **DateTime** | Timestamp when the event was published. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

