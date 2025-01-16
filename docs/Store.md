# TalonOne.Model.Store
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Name** | **string** | The name of the store. | 
**Description** | **string** | The description of the store. | 
**Attributes** | [**Object**](.md) | The attributes of the store. | [optional] 
**IntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store.  **Note**: You cannot edit the &#x60;integrationId&#x60; after the store has been created.  | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**Updated** | **DateTime** | Timestamp of the most recent update on this entity. | 
**LinkedCampaignIds** | **List&lt;int&gt;** | A list of IDs of the campaigns that are linked with current store. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

