# TalonOne.Model.AccountAdditionalCost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Name** | **string** | The internal name used in API requests. | 
**Title** | **string** | The human-readable name for the additional cost that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique. | 
**Description** | **string** | A description of this additional cost. | 
**SubscribedApplicationsIds** | **List&lt;int&gt;** | A list of the IDs of the applications that are subscribed to this additional cost. | [optional] 
**Type** | **string** | The type of additional cost. Possible value: - &#x60;session&#x60;: Additional cost will be added per session. - &#x60;item&#x60;: Additional cost will be added per item. - &#x60;both&#x60;: Additional cost will be added per item and session.  | [optional] [default to TypeEnum.Session]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

