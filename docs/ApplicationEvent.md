# TalonOne.Model.ApplicationEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**ProfileId** | **long** | The globally unique Talon.One ID of the customer that created this entity. | [optional] 
**StoreId** | **long** | The ID of the store. | [optional] 
**StoreIntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store. | [optional] 
**IntegrationId** | **string** | The unique ID of the event. Only one event with this ID can be registered.  | [optional] 
**SessionId** | **long** | The globally unique Talon.One ID of the session that contains this event. | [optional] 
**Type** | **string** | The name of the event. Must be a [custom event](https://docs.talon.one/docs/dev/concepts/entities/events#custom-events), not a built-in event. | 
**Attributes** | [**Object**](.md) | Additional JSON serialized data associated with the event. | 
**Effects** | [**List&lt;Effect&gt;**](Effect.md) | An array containing the effects that were applied as a result of this event. | 
**RuleFailureReasons** | [**List&lt;RuleFailureReason&gt;**](RuleFailureReason.md) | An array containing the rule failure reasons which happened during this event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

