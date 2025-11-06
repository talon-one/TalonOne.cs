# TalonOne.Model.UpdateCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A user-facing name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | A disabled or archived campaign is not evaluated for rules or coupons.  | [optional] [default to StateEnum.Enabled]
**ActiveRulesetId** | **long** | [ID of Ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation.  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | A list of features for the campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of limits that will operate for this campaign. | 
**CampaignGroups** | **List&lt;long&gt;** | The IDs of the [campaign groups](https://docs.talon.one/docs/product/account/account-settings/managing-campaign-groups) this campaign belongs to.  | [optional] 
**EvaluationGroupId** | **long** | The ID of the campaign evaluation group the campaign belongs to. | [optional] 
**Type** | **string** | The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items.  | [optional] [default to TypeEnum.Advanced]
**LinkedStoreIds** | **List&lt;long&gt;** | A list of store IDs that you want to link to the campaign.  **Note:** - Campaigns with linked store IDs will only be evaluated when there is a [customer session update](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) that references a linked store. - If you linked stores to the campaign by uploading a CSV file, you cannot use this property and it should be empty. - Use of this property is limited to 50 stores. To link more than 50 stores, upload them via a CSV file.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

