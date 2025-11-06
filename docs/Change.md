# TalonOne.Model.Change
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**UserId** | **long** | The ID of the user associated with this entity. | 
**ApplicationId** | **long** | ID of application associated with change. | [optional] 
**Entity** | **string** | API endpoint on which the change was initiated. | 
**Old** | [**Object**](.md) | Resource before the change occurred. | [optional] 
**New** | [**Object**](.md) | Resource after the change occurred. | [optional] 
**ManagementKeyId** | **long** | ID of management key used to perform changes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

