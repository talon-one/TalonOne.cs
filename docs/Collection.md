# TalonOne.Model.Collection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**Description** | **string** | A short description of the purpose of this collection. | [optional] 
**SubscribedApplicationsIds** | **List&lt;long&gt;** | A list of the IDs of the Applications where this collection is enabled. | [optional] 
**Name** | **string** | The name of this collection. | 
**ModifiedBy** | **long** | ID of the user who last updated this effect if available. | [optional] 
**CreatedBy** | **long** | ID of the user who created this effect. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | [optional] 
**CampaignId** | **long** | The ID of the campaign that owns this entity. | [optional] 
**Payload** | **List&lt;string&gt;** | The content of the collection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

