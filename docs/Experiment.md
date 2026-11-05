# TalonOne.Model.Experiment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**AssignmentType** | **string** | Controls how customers are assigned to experiment variants. - &#x60;random&#x60;: Talon.One assigns customers randomly based on variant weights. - &#x60;external&#x60;: Variant assignment is handled externally. - &#x60;audience&#x60;: Each variant targets a specific audience; customers are assigned based on audience membership.  | [optional] 
**IsVariantAssignmentExternal** | **bool** | Deprecated. Use &#x60;assignmentType&#x60; instead. - false - The variant assignment is handled internally by Talon.One. - true - The variant assignment is handled externally.  | [optional] 
**Campaign** | [**Campaign**](Campaign.md) |  | [optional] 
**Activated** | **DateTime** | The date and time the experiment was activated.  | [optional] 
**State** | **string** | A disabled experiment is not evaluated for rules or coupons.  | [default to StateEnum.Disabled]
**Variants** | [**List&lt;ExperimentVariant&gt;**](ExperimentVariant.md) |  | [optional] 
**GoalType** | **string** | The goal of the experiment. Determines which single metric is used to decide the winning variant. When set to &#x60;other&#x60;, multiple metrics are used.  | 
**GoalDescription** | **string** | A description of the experiment goal. Provides context for the AI summary and helps it interpret the outcome of the experiment against the stated goal.  | [optional] 
**Deletedat** | **DateTime** | The date and time the experiment was deleted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

