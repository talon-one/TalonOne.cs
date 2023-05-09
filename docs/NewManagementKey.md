# TalonOne.Model.NewManagementKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name for management key. | 
**ExpiryDate** | **DateTime** | The date the management key expires. | 
**Endpoints** | [**List&lt;Endpoint&gt;**](Endpoint.md) | The list of endpoints that can be accessed with the key | 
**AllowedApplicationIds** | **List&lt;int&gt;** | A list of Application IDs that you can access with the management key. An empty or missing list means the management key can be used for all Applications in the account.  | [optional] 
**Id** | **int** | ID of the management key. | 
**CreatedBy** | **int** | ID of the user who created it. | 
**AccountID** | **int** | ID of account the key is used for. | 
**Created** | **DateTime** | The date the management key was created. | 
**Key** | **string** | The management key. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

