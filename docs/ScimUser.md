# TalonOne.Model.ScimUser
Schema definition for users that have been provisioned using the SCIM protocol with an identity provider, for example, Microsoft Entra ID.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Status of the user. | [optional] 
**DisplayName** | **string** | Display name of the user. | [optional] 
**UserName** | **string** | Unique identifier of the user. This is usually an email address. | [optional] 
**Name** | [**ScimBaseUserName**](ScimBaseUserName.md) |  | [optional] 
**Id** | **string** | ID of the user. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

