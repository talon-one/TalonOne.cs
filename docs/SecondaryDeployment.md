# TalonOne.Model.SecondaryDeployment
The record of the secondary deployment.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints. | 
**Name** | **string** | The name of the deployment. Used as subdomain, e.g. experimental.your-company.europe-west1.talon.one | 
**UserId** | **long** | The ID of the user who created the deployment. | 
**Status** | **string** | The status of the deployment. | 
**CreatedAt** | **DateTime** | Timestamp when the deployment was created. | 
**ActiveAt** | **DateTime** | Timestamp when the deployment became active. | [optional] 
**FailedAt** | **DateTime** | Timestamp when the deployment failed. | [optional] 
**DeletedAt** | **DateTime** | Timestamp when the deployment was deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

