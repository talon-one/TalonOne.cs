# TalonOne.Model.IntegrationHubFlowResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | ID of the integration hub flow. | 
**IntegrationName** | **string** | Name of the integration. | [optional] 
**InstanceName** | **string** | Name of the integration instance. | [optional] 
**CreatedAt** | **DateTime** | Timestamp when the flow was created. | 
**DisabledUntil** | **DateTime?** | Timestamp until which the flow is disabled. Null when the flow is active. | [optional] 
**ApplicationId** | **long** | ID of the application the flow is registered for. | [optional] 
**LoyaltyProgramId** | **long** | ID of the loyalty program the flow is registered for. | [optional] 
**EventType** | **string** | The event type we want to register a flow for. | 
**Config** | [**IntegrationHubFlowConfigResponse**](IntegrationHubFlowConfigResponse.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

