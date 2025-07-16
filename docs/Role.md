# TalonOne.Model.Role
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**CampaignGroupID** | **int** | The ID of the [Campaign Group](https://docs.talon.one/docs/product/account/account-settings/managing-campaign-groups) this role was created for.  | [optional] 
**Name** | **string** | Name of the role. | 
**Description** | **string** | Description of the role. | [optional] 
**Members** | **List&lt;int&gt;** | A list of user identifiers assigned to this role. | [optional] 
**Acl** | [**Object**](.md) | The &#x60;Access Control List&#x60; json defining the role of the user. This represents the access control on the user level. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

