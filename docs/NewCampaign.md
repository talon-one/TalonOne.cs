# TalonOne.Model.NewCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A friendly name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**StartTime** | **DateTime?** | Datetime when the campaign will become active. | [optional] 
**EndTime** | **DateTime?** | Datetime when the campaign will become in-active. | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this campaign | [optional] 
**State** | **string** | A disabled or archived campaign is not evaluated for rules or coupons.  | [default to StateEnum.Enabled]
**ActiveRulesetId** | **int?** | ID of Ruleset this campaign applies on customer session evaluation. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | A list of features for the campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of limits that will operate for this campaign | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

