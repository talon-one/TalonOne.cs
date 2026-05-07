# TalonOne.Model.Blueprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this blueprint. | 
**AccountId** | **long** | The ID of the account that owns this blueprint. | 
**ApplicationId** | **long** | The ID of the Application that owns this blueprint. | 
**Title** | **string** | A short description of the blueprint. | 
**Description** | **string** | A longer, more detailed description of the blueprint. | [optional] 
**Category** | **string** | Category used to group blueprints. | 
**Source** | **string** | Indicates whether the blueprint is custom or shipped by Talon.One. | 
**Rules** | [**List&lt;CatalogRule&gt;**](CatalogRule.md) | Array of rule templates in this blueprint. Rules only contain title (no description, as description is at the blueprint level). | 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Array of cart item filter templates in this blueprint. Cart item filters only contain name (no description, as description is at the blueprint level). | 
**Created** | **DateTime** | Timestamp when the blueprint was created. | 
**CreatedBy** | **long** | ID of the user who created the blueprint. | 
**Modified** | **DateTime** | Timestamp when the blueprint was last updated. | [optional] 
**ModifiedBy** | **long** | ID of the user who last updated the blueprint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

