# TalonOne.Model.UpdateExperiment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsVariantAssignmentExternal** | **bool** | The source of the assignment. - false - The variant assignment is handled internally by Talon.One. - true - The variant assignment is handled externally.  | 
**Campaign** | [**UpdateCampaign**](UpdateCampaign.md) |  | 
**GoalType** | **string** | The goal of the experiment. Determines which single metric is used to decide the winning variant. When set to &#x60;other&#x60;, multiple metrics are used. If omitted, the current value is preserved.  | [optional] 
**GoalDescription** | **string** | A description of the experiment goal. Provides context for the AI summary and helps it interpret the outcome of the experiment against the stated goal. If omitted, the current value is preserved.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

