
# TalonOne.Model.InventoryCoupon

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | 
**Value** | **string** | The actual coupon code. | 
**UsageLimit** | **int** | The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply.  | 
**DiscountLimit** | **decimal** | The amount of discounts that can be given with this coupon code.  | [optional] 
**StartDate** | **DateTime** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative. | [optional] 
**UsageCounter** | **int** | The number of times this coupon has been successfully used. | 
**DiscountCounter** | **decimal** | The amount of discounts given on rules redeeming this coupon. Only usable if a coupon discount budget was set for this coupon. | [optional] 
**DiscountRemainder** | **decimal** | The remaining discount this coupon can give. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item | [optional] 
**ReferralId** | **int** | The integration ID of the referring customer (if any) for whom this coupon was created as an effect. | [optional] 
**RecipientIntegrationId** | **string** | The Integration ID of the customer that is allowed to redeem this coupon. | [optional] 
**ImportId** | **int** | The ID of the Import which created this coupon. | [optional] 
**Reservation** | **bool** | This value controls what reservations mean to a coupon. If set to true the coupon reservation is used to mark it as a favorite, if set to false the coupon reservation is used as a requirement of usage. This value defaults to true if not specified. | [optional] 
**BatchId** | **string** | The id of the batch the coupon belongs to. | [optional] 
**ProfileRedemptionCount** | **int** | The number of times the coupon was redeemed by the profile. | 
**State** | **string** | Can be either active, used, expired, pending or disabled. active: reserved coupons that are neither pending nor used nor expired, and have a non-exhausted limit counter. used: coupons that are not pending, and have reached their redemption limit or were redeemed by the profile before expiration. expired: all non-pending, non-active, non-used coupons that were not redeemed by the profile. pending: coupons that have a start date in the future. disabled: coupons of non-active campaigns.  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

