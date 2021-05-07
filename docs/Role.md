
# TalonOne.Model.Role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**CampaignGroupID** | **int** | The ID of the Campaign Group this role was created for. | [optional] 
**Name** | **string** | Name of the role | 
**Description** | **string** | Description of the role | [optional] 
**Members** | **List&lt;int&gt;** | A list of user identifiers assigned to this role | [optional] 
**Acl** | [**Object**](.md) | Role ACL Policy | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

