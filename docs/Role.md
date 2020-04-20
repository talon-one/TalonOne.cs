
# TalonOne.Model.Role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the role corresponding to the DB row | 
**AccountID** | **int** | The ID of the Talon.One account that owns this role. | 
**Name** | **string** | Name of the role | [optional] 
**Description** | **string** | Description of the role | [optional] 
**Members** | **List&lt;int&gt;** | A list of user identifiers assigned to this role | [optional] 
**Acl** | **string** | Role Policy this should be a stringified blob of json | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

