# TalonOne.Model.IntegrationHubEventRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | ID of the event record. | 
**FlowId** | **long** | ID of the integration hub flow. | 
**IntegrationName** | **string** | Name of the integration. | [optional] 
**InstanceName** | **string** | Name of the integration instance. | [optional] 
**EventType** | **IntegrationHubEventType** |  | 
**PublishedAt** | **DateTime** | Timestamp when the event was published. | 
**ProcessedAt** | **DateTime** | Timestamp when the event was processed. | [optional] 
**DeliveredAt** | **DateTime** | Timestamp when the event was delivered. | [optional] 
**ScheduledTo** | **DateTime** | Timestamp after which the event is scheduled to be processed. | 
**Retry** | **long** | Number of delivery retries attempted. | 
**Payload** | **string** | The event payload as a formatted JSON string. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

