# TalonOne.Model.Experiment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**IsVariantAssignmentExternal** | **bool** | The source of the assignment. - false - The variant assignment is handled internally by Talon.One. - true - The variant assignment is handled externally.  | [optional] 
**Campaign** | [**Campaign**](Campaign.md) |  | [optional] 
**Activated** | **DateTime** | The date and time the experiment was activated.  | [optional] 
**State** | **string** | A disabled experiment is not evaluated for rules or coupons.  | [default to StateEnum.Disabled]
**Variants** | [**List&lt;ExperimentVariant&gt;**](ExperimentVariant.md) |  | [optional] 
**Deletedat** | **DateTime** | The date and time the experiment was deleted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

