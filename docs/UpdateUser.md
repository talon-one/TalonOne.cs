# TalonOne.Model.UpdateUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the user. | [optional] 
**State** | **string** | The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user.  | [optional] 
**IsAdmin** | **bool** | Indicates whether the user is an &#x60;admin&#x60;. | [optional] 
**Policy** | **string** | Indicates the access level of the user. | [optional] 
**Roles** | **List&lt;int&gt;** | A list of the IDs of the roles assigned to the user.  **Note**: Use the [List roles](https://docs.talon.one/management-api#tag/Roles/operation/getAllRoles) endpoint to find the ID of a role.  | [optional] 
**ApplicationNotificationSubscriptions** | [**Object**](.md) | Application notifications that the user is subscribed to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

