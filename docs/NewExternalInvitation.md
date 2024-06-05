# TalonOne.Model.NewExternalInvitation
Parameters for inviting a new user from an external identity provider.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the user. | [optional] 
**UserGroups** | **List&lt;string&gt;** | List of user groups in the external identity provider.  If there are roles in Talon.One whose names match these user groups, those roles will be automatically assigned to the user upon invitation.  | [optional] 
**Email** | **string** | Email address of the user. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

