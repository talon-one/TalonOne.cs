# TalonOne.Model.Application
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Name** | **string** | The name of this application. | 
**Description** | **string** | A longer description of the application. | [optional] 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | 
**Currency** | **string** | The default currency for new customer sessions. | 
**CaseSensitivity** | **string** | The case sensitivity behavior to check coupon codes in the campaigns of this Application. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | Default limits for campaigns created in this application. | [optional] 
**CampaignPriority** | **string** | Default [priority](https://docs.talon.one/docs/product/applications/setting-up-campaign-priorities) for campaigns created in this Application.  | [optional] [default to CampaignPriorityEnum.Universal]
**ExclusiveCampaignsStrategy** | **string** | The strategy used when choosing exclusive campaigns for evaluation. | [optional] [default to ExclusiveCampaignsStrategyEnum.ListOrder]
**DefaultDiscountScope** | **string** | The default scope to apply &#x60;setDiscount&#x60; effects on if no scope was provided with the effect.  | [optional] 
**EnableCascadingDiscounts** | **bool** | Indicates if discounts should cascade for this Application. | [optional] 
**EnableFlattenedCartItems** | **bool** | Indicates if cart items of quantity larger than one should be separated into different items of quantity one. See [the docs](https://docs.talon.one/docs/product/campaigns/campaign-evaluation/#flattened-cart-items).  | [optional] 
**AttributesSettings** | [**AttributesSettings**](AttributesSettings.md) |  | [optional] 
**Sandbox** | **bool** | Indicates if this is a live or sandbox Application. | [optional] 
**EnablePartialDiscounts** | **bool** | Indicates if this Application supports partial discounts. | [optional] 
**LoyaltyPrograms** | [**List&lt;LoyaltyProgram&gt;**](LoyaltyProgram.md) | An array containing all the loyalty programs to which this application is subscribed | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

