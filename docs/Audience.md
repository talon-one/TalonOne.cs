# TalonOne.Model.Audience
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Name** | **string** | The human-friendly display name for this audience. | 
**Sandbox** | **bool** | Indicates if this is a live or sandbox Application. | [optional] 
**Description** | **string** | A description of the audience. | [optional] 
**Integration** | **string** | The Talon.One-supported [3rd-party platform](https://docs.talon.one/docs/dev/technology-partners/overview) that this audience was created in.  For example, &#x60;mParticle&#x60;, &#x60;Segment&#x60;, &#x60;Selligent&#x60;, &#x60;Braze&#x60;, or &#x60;Iterable&#x60;.  **Note:** If you do not integrate with any of these platforms, do not use this property.  | [optional] 
**IntegrationId** | **string** | The ID of this audience in the third-party integration.  **Note:** To create an audience that doesn&#39;t come from a 3rd party platform, do not use this property.  | [optional] 
**CreatedIn3rdParty** | **bool** | Determines if this audience is a 3rd party audience or not. | [optional] 
**LastUpdate** | **DateTime** | The last time that the audience memberships changed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

