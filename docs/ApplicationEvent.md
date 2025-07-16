# TalonOne.Model.ApplicationEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the Application that owns this entity. | 
**ProfileId** | **int** | The globally unique Talon.One ID of the customer that created this entity. | [optional] 
**StoreId** | **int** | The ID of the store. | [optional] 
**StoreIntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store. | [optional] 
**SessionId** | **int** | The globally unique Talon.One ID of the session that contains this event. | [optional] 
**Type** | **string** | A string representing the event. Must not be a reserved event name. | 
**Attributes** | [**Object**](.md) | Additional JSON serialized data associated with the event. | 
**Effects** | [**List&lt;Effect&gt;**](Effect.md) | An array containing the effects that were applied as a result of this event. | 
**RuleFailureReasons** | [**List&lt;RuleFailureReason&gt;**](RuleFailureReason.md) | An array containing the rule failure reasons which happened during this event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

