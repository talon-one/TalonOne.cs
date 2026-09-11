# TalonOne.Model.RiskAffectedEntityItem
A single entity flagged as anomalous within a risk.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityId** | **string** | The integration ID of the affected entity. | 
**ActivityValue** | **double** | The observed value of the monitored activity metric for this entity. | 
**Threshold** | **double** | The anomaly threshold computed for the entity&#39;s Application group. | 
**SeverityRatio** | **double** | The ratio of the observed value to the threshold. | 
**Criticality** | **string** | The critical classification bucket of this entity. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

