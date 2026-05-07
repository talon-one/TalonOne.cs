# TalonOne.Model.RoleV2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Name** | **string** | Name of the role. | [optional] 
**Description** | **string** | Description of the role. | [optional] 
**Permissions** | [**RoleV2Permissions**](RoleV2Permissions.md) |  | [optional] 
**Members** | **List&lt;long&gt;** | A list of user IDs the role is assigned to. | [optional] 
**IsReadonly** | **bool** | Identifies if the role is read-only. For read-only roles, you can only assign or unassign users. You cannot edit any other properties, such as the name, description, or permissions. The &#39;isReadonly&#39; property cannot be set for new or existing roles. It is reserved for predefined roles, such as the Talon.One support role. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

