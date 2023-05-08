# TalonOne.Model.Campaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**UserId** | **int** | The ID of the user associated with this entity. | 
**Name** | **string** | A user-facing name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | A disabled or archived campaign is not evaluated for rules or coupons.  | [default to StateEnum.Enabled]
**ActiveRulesetId** | **int** | [ID of Ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation.  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | The features enabled in this campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of [budget limits](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets) for this campaign.  | 
**CampaignGroups** | **List&lt;int&gt;** | The IDs of the [campaign groups](https://docs.talon.one/docs/product/account/managing-campaign-groups) this campaign belongs to.  | [optional] 
**CouponRedemptionCount** | **int** | Number of coupons redeemed in the campaign. | [optional] 
**ReferralRedemptionCount** | **int** | Number of referral codes redeemed in the campaign. | [optional] 
**DiscountCount** | **decimal** | Total amount of discounts redeemed in the campaign. | [optional] 
**DiscountEffectCount** | **int** | Total number of times discounts were redeemed in this campaign. | [optional] 
**CouponCreationCount** | **int** | Total number of coupons created by rules in this campaign. | [optional] 
**CustomEffectCount** | **int** | Total number of custom effects triggered by rules in this campaign. | [optional] 
**ReferralCreationCount** | **int** | Total number of referrals created by rules in this campaign. | [optional] 
**AddFreeItemEffectCount** | **int** | Total number of times triggering add free item effext is allowed in this campaign. | [optional] 
**AwardedGiveawaysCount** | **int** | Total number of giveaways awarded by rules in this campaign. | [optional] 
**CreatedLoyaltyPointsCount** | **decimal** | Total number of loyalty points created by rules in this campaign. | [optional] 
**CreatedLoyaltyPointsEffectCount** | **int** | Total number of loyalty point creation effects triggered by rules in this campaign. | [optional] 
**RedeemedLoyaltyPointsCount** | **decimal** | Total number of loyalty points redeemed by rules in this campaign. | [optional] 
**RedeemedLoyaltyPointsEffectCount** | **int** | Total number of loyalty point redemption effects triggered by rules in this campaign. | [optional] 
**CallApiEffectCount** | **int** | Total number of webhook triggered by rules in this campaign. | [optional] 
**ReservecouponEffectCount** | **int** | Total number of reserve coupon effects triggered by rules in this campaign. | [optional] 
**LastActivity** | **DateTime** | Timestamp of the most recent event received by this campaign. | [optional] 
**Updated** | **DateTime** | Timestamp of the most recent update to the campaign&#39;s property. Updates to external entities used in this campaign are **not** registered by this property, such as collection or coupon updates.  | [optional] 
**CreatedBy** | **string** | Name of the user who created this campaign if available. | [optional] 
**UpdatedBy** | **string** | Name of the user who last updated this campaign if available. | [optional] 
**TemplateId** | **int** | The ID of the Campaign Template this Campaign was created from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

