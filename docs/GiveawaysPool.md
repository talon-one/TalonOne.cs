# TalonOne.Model.GiveawaysPool
Giveaways pools is an entity for managing multiple similar giveaways.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Name** | **string** | The name of this giveaways pool. | 
**Description** | **string** | The description of this giveaways pool. | [optional] 
**SubscribedApplicationsIds** | **List&lt;long&gt;** | A list of the IDs of the applications that this giveaways pool is enabled for. | [optional] 
**Sandbox** | **bool** | Indicates if this program is a live or sandbox program. Programs of a given type can only be connected to Applications of the same type. | 
**Modified** | **DateTime** | Timestamp of the most recent update to the giveaways pool. | [optional] 
**CreatedBy** | **long** | ID of the user who created this giveaways pool. | 
**ModifiedBy** | **long** | ID of the user who last updated this giveaways pool if available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

