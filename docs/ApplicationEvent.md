# TalonOne.Model.ApplicationEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique ID for this entity. | 
**Created** | **DateTime?** | The exact moment this entity was created. | 
**ApplicationId** | **int?** | The ID of the application that owns this entity. | 
**ProfileId** | **int?** | The globally unique Talon.One ID of the customer that created this entity. | [optional] 
**SessionId** | **int?** | The globally unique Talon.One ID of the session that contains this event. | [optional] 
**Type** | **string** | A string representing the event. Must not be a reserved event name. | 
**Attributes** | **Object** | Additional JSON serialized data associated with the event. | 
**Effects** | **List&lt;Object&gt;** | An array containing the effects that were applied as a result of this event. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

