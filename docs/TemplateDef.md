# TalonOne.Model.TemplateDef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**Title** | **string** | Campaigner-friendly name for the template that will be shown in the rule editor. | 
**Description** | **string** | A short description of the template that will be shown in the rule editor. | 
**Help** | **string** | Extended help text for the template. | 
**Category** | **string** | Used for grouping templates in the rule editor sidebar. | 
**Expr** | **List&lt;Object&gt;** | A Talang expression that contains variable bindings referring to args. | 
**Args** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | An array of argument definitions. | 
**Expose** | **bool** | A flag to control exposure in Rule Builder. | [optional] [default to false]
**Name** | **string** | The template name used in Talang. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

