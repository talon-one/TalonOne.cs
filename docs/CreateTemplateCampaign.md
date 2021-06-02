
# TalonOne.Model.CreateTemplateCampaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A user-facing name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**TemplateId** | **int** | The ID of the Campaign Template which will be used in order to create the Campaign. | 
**CampaignAttributesOverrides** | [**Object**](.md) | Custom Campaign Attributes. If the the Campaign Template defines the same values, they will be overridden. | [optional] 
**TemplateParamValues** | [**List&lt;Binding&gt;**](Binding.md) | Actual values to replace the template placeholder values in the Ruleset bindings. Values for all Template Parameters must be provided. | [optional] 
**LimitOverrides** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | Limits for this Campaign. If the Campaign Template or Application define default values for the same limits, they will be overridden. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

