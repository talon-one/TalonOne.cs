# TalonOne.Model.Campaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**UserId** | **long** | The ID of the user associated with this entity. | 
**Name** | **string** | A user-facing name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | A disabled or archived campaign is not evaluated for rules or coupons.  | [default to StateEnum.Enabled]
**ActiveRulesetId** | **long** | [ID of Ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation.  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | The features enabled in this campaign. | 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of [budget limits](https://docs.talon.one/docs/product/campaigns/settings/managing-campaign-budgets) for this campaign.  | 
**CampaignGroups** | **List&lt;long&gt;** | The IDs of the [campaign groups](https://docs.talon.one/docs/product/account/managing-campaign-groups) this campaign belongs to.  | [optional] 
**Type** | **string** | The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items.  | [default to TypeEnum.Advanced]
**LinkedStoreIds** | **List&lt;long&gt;** | A list of store IDs that you want to link to the campaign.  **Note:** Campaigns with linked store IDs will only be evaluated when there is a [customer session update](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) that references a linked store.  | [optional] 
**Budgets** | [**List&lt;CampaignBudget&gt;**](CampaignBudget.md) | A list of all the budgets that are defined by this campaign and their usage.  **Note:** Budgets that are not defined do not appear in this list and their usage is not counted until they are defined.  | [optional] 
**CouponRedemptionCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Number of coupons redeemed in the campaign.  | [optional] 
**ReferralRedemptionCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Number of referral codes redeemed in the campaign.  | [optional] 
**DiscountCount** | **decimal** | This property is **deprecated**. The count should be available under *budgets* property. Total amount of discounts redeemed in the campaign.  | [optional] 
**DiscountEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of times discounts were redeemed in this campaign.  | [optional] 
**CouponCreationCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of coupons created by rules in this campaign.  | [optional] 
**CustomEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of custom effects triggered by rules in this campaign.  | [optional] 
**ReferralCreationCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of referrals created by rules in this campaign.  | [optional] 
**AddFreeItemEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of times the [add free item effect](https://docs.talon.one/docs/dev/integration-api/api-effects#addfreeitem) can be triggered in this campaign.  | [optional] 
**AwardedGiveawaysCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of giveaways awarded by rules in this campaign.  | [optional] 
**CreatedLoyaltyPointsCount** | **decimal** | This property is **deprecated**. The count should be available under *budgets* property. Total number of loyalty points created by rules in this campaign.  | [optional] 
**CreatedLoyaltyPointsEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of loyalty point creation effects triggered by rules in this campaign.  | [optional] 
**RedeemedLoyaltyPointsCount** | **decimal** | This property is **deprecated**. The count should be available under *budgets* property. Total number of loyalty points redeemed by rules in this campaign.  | [optional] 
**RedeemedLoyaltyPointsEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of loyalty point redemption effects triggered by rules in this campaign.  | [optional] 
**CallApiEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of webhooks triggered by rules in this campaign.  | [optional] 
**ReservecouponEffectCount** | **long** | This property is **deprecated**. The count should be available under *budgets* property. Total number of reserve coupon effects triggered by rules in this campaign.  | [optional] 
**LastActivity** | **DateTime** | Timestamp of the most recent event received by this campaign. | [optional] 
**Updated** | **DateTime** | Timestamp of the most recent update to the campaign&#39;s property. Updates to external entities used in this campaign are **not** registered by this property, such as collection or coupon updates.  | [optional] 
**CreatedBy** | **string** | Name of the user who created this campaign if available. | [optional] 
**UpdatedBy** | **string** | Name of the user who last updated this campaign if available. | [optional] 
**TemplateId** | **long** | The ID of the Campaign Template this Campaign was created from. | [optional] 
**FrontendState** | **string** | The campaign state displayed in the Campaign Manager. | 
**StoresImported** | **bool** | Indicates whether the linked stores were imported via a CSV file. | 
**ValueMapsIds** | **List&lt;long&gt;** | A list of value map IDs for the campaign. | [optional] 
**RevisionFrontendState** | **string** | The campaign revision state displayed in the Campaign Manager. | [optional] 
**ActiveRevisionId** | **long** | ID of the revision that was last activated on this campaign.  | [optional] 
**ActiveRevisionVersionId** | **long** | ID of the revision version that is active on the campaign.  | [optional] 
**Version** | **long** | Incrementing number representing how many revisions have been activated on this campaign, starts from 0 for a new campaign.  | [optional] 
**CurrentRevisionId** | **long** | ID of the revision currently being modified for the campaign.  | [optional] 
**CurrentRevisionVersionId** | **long** | ID of the latest version applied on the current revision.  | [optional] 
**StageRevision** | **bool** | Flag for determining whether we use current revision when sending requests with staging API key.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

