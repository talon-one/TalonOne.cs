# TalonOne.Model.ScimGroupsListResponse
List of groups created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Resources** | [**List&lt;ScimGroup&gt;**](ScimGroup.md) |  | 
**Schemas** | **List&lt;string&gt;** | SCIM schema for the given resource. | [optional] 
**TotalResults** | **long** | Number of results in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

