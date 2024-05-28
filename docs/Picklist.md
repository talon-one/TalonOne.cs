# TalonOne.Model.Picklist
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Type** | **string** | The type of allowed values in the picklist. If the type &#x60;time&#x60; is chosen, it must be an RFC3339 timestamp string. | 
**Values** | **List&lt;string&gt;** | The list of allowed values provided by this picklist. | 
**ModifiedBy** | **int** | ID of the user who last updated this effect if available. | [optional] 
**CreatedBy** | **int** | ID of the user who created this effect. | 
**AccountId** | **int** | The ID of the account that owns this entity. | [optional] 
**Imported** | **bool** | Imported flag shows that a picklist is imported by a CSV file or not | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

