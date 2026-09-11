# TalonOne.Model.Risk
A risk detected by the anomaly detection service for one Application group.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**NotificationId** | **long** | The ID of the risk notification rule that flagged this risk. | 
**FeatureDate** | **DateTime** | The date of the activity data in which this risk was detected. The anomaly detection pipeline scores complete 24-hour cycles, so this is always the day before the risk was reported, not the reporting date itself.  | 
**GroupKey** | **string** | The Application group this risk was detected in. Contains the Application ID, or &#x60;__GLOBAL__&#x60; for metrics that are not grouped by Application.  | 
**ApplicationId** | **long** | The ID of the Application this risk belongs to. Absent for global metrics. | [optional] 
**Status** | **string** | The triage lifecycle status of this risk. | 
**Criticality** | **string** | The critical classification bucket of this risk. | 
**Entity** | **string** | The entity type the risk was detected in. | 
**Activity** | **string** | The activity metric the risk was detected in. | 
**TimeFrame** | **string** | The rolling time window of the risk evaluation. | 
**ReportedDate** | **DateTime** | The time the ML service reported this risk. | 
**AffectedEntityCount** | **long** | The total number of entities affected by this risk. | 
**Description** | **string** | Human-readable description of the detected anomaly. | [optional] 
**DiscardReason** | **string** | The reason this risk was discarded. Only present on discarded risks. | [optional] 
**StatusComment** | **string** | The free-text details of the latest reclassification action: the description for resolving confirmed risks, or the details for discarding risks.  | [optional] 
**StatusChangedBy** | **long** | The ID of the user who performed the latest reclassification action. | [optional] 
**StatusChangedAt** | **DateTime** | The time of the latest reclassification action. | [optional] 
**Modified** | **DateTime** | Timestamp of the most recent update. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

