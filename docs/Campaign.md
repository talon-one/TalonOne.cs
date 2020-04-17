
# TalonOne.Model.Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**UserId** | **int** | The ID of the account that owns this entity. | 
**Name** | **string** | A friendly name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | 
**StartTime** | **DateTime** | Datetime when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Datetime when the campaign will become in-active. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign | [optional] 
**State** | **string** | A disabled or archived campaign is not evaluated for rules or coupons.  | [default to StateEnum.Enabled]
**ActiveRulesetId** | **int** | ID of Ruleset this campaign applies on customer session evaluation. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | A list of features for the campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of limits that will operate for this campaign | 
**CouponRedemptionCount** | **int** | Number of coupons redeemed in the campaign. | [optional] 
**ReferralRedemptionCount** | **int** | Number of referral codes redeemed in the campaign. | [optional] 
**DiscountCount** | **int** | Total amount of discounts redeemed in the campaign. | [optional] 
**DiscountEffectCount** | **int** | Total number of times discounts were redeemed in this campaign. | [optional] 
**CouponCreationCount** | **int** | Total number of coupons created by rules in this campaign. | [optional] 
**LastActivity** | **DateTime** | Timestamp of the most recent event received by this campaign. | [optional] 
**Updated** | **DateTime** | Timestamp of the most recent update to the campaign or any of its elements. | [optional] 
**CreatedBy** | **string** | Name of the user who created this campaign if available. | [optional] 
**UpdatedBy** | **string** | Name of the user who last updated this campaign if available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

