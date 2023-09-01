# TalonOne.Model.RoleV2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Name** | **string** | Name of the role. | [optional] 
**Description** | **string** | Description of the role. | [optional] 
**IsAdmin** | **bool** | Indicates whether the role grants admin permissions. | [optional] 
**Permissions** | [**RoleV2Permissions**](RoleV2Permissions.md) |  | [optional] 
**Members** | **List&lt;int&gt;** | A list of user identifiers the role is assigned to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

