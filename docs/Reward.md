# TalonOne.Model.Reward
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Name** | **string** | The name of the reward. | 
**ApiName** | **string** | A unique identifier used to reference the reward in API integrations. | 
**Description** | **string** | A description of the reward. | [optional] 
**ApplicationIds** | **List&lt;long&gt;** | The IDs of the Applications this reward is connected to.   **Note**: Currently, a reward can only be connected to one Application.  | 
**Sandbox** | **bool** | Indicates if this is a live or sandbox reward. Rewards of a given type can only be connected to Applications of the same type. | 
**Status** | **string** | The status of the reward. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

