# TalonOne.Model.ScimBaseGroup
Define the schema for base fields in a group using the SCIM provisioning protocol. Talon.One uses this schema to create roles.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the group (Talon.One role). | [optional] 
**Members** | [**List&lt;ScimGroupMember&gt;**](ScimGroupMember.md) | List of members to assign to the new Talon.One role. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

