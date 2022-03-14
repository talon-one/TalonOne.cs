# TalonOne.Model.Collection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**Description** | **string** | A short description of the purpose of this collection. | [optional] 
**SubscribedApplicationsIds** | **List&lt;int&gt;** | A list of the IDs of the Applications where this collection is enabled. | [optional] 
**Name** | **string** | The name of this collection. | 
**Payload** | **List&lt;string&gt;** | The content of the collection. If this property&#39;s value is &#x60;null&#x60;, the collection&#39;s content is too large to be returned in this property.  Instead, use the [export collection endpoint](https://docs.talon.one/management-api/#operation/exportCollectionItems) to get the content of the collection.  | [optional] 
**ModifiedBy** | **int** | ID of the user who last updated this effect if available. | [optional] 
**CreatedBy** | **int** | ID of the user who created this effect. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | [optional] 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

