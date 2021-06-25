# TalonOne.Model.Change
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**UserId** | **int** | The ID of the account that owns this entity. | 
**ApplicationId** | **int** | ID of application associated with change | [optional] 
**Entity** | **string** | API endpoint on which the change was initiated. | 
**Old** | [**Object**](.md) | Resource before the change occurred. | [optional] 
**New** | [**Object**](.md) | Resource after the change occurred. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

