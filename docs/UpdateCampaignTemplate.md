# TalonOne.Model.UpdateCampaignTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The campaign template name. | 
**Description** | **string** | Customer-facing text that explains the objective of the template. | 
**Instructions** | **string** | Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign. | 
**CampaignAttributes** | [**Object**](.md) | The campaign attributes that campaigns created from this template will have by default. | [optional] 
**CouponAttributes** | [**Object**](.md) | The campaign attributes that coupons created from this template will have by default. | [optional] 
**State** | **string** | Only campaign templates in &#39;available&#39; state may be used to create campaigns. | 
**ActiveRulesetId** | **int** | The ID of the ruleset this campaign template will use. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign template. | [optional] 
**Features** | **List&lt;string&gt;** | A list of features for the campaign template. | [optional] 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**CouponReservationSettings** | [**CampaignTemplateCouponReservationSettings**](CampaignTemplateCouponReservationSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;TemplateLimitConfig&gt;**](TemplateLimitConfig.md) | The set of limits that operate for this campaign template. | [optional] 
**TemplateParams** | [**List&lt;CampaignTemplateParams&gt;**](CampaignTemplateParams.md) | Fields which can be used to replace values in a rule. | [optional] 
**ApplicationsIds** | **List&lt;int&gt;** | A list of IDs of the Applications that are subscribed to this campaign template. | 
**CampaignCollections** | [**List&lt;CampaignTemplateCollection&gt;**](CampaignTemplateCollection.md) | The campaign collections from the blueprint campaign for the template. | [optional] 
**DefaultCampaignGroupId** | **int** | The default campaign group ID. | [optional] 
**CampaignType** | **string** | The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items.  | [optional] [default to CampaignTypeEnum.Advanced]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

