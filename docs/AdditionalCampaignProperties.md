# TalonOne.Model.AdditionalCampaignProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

