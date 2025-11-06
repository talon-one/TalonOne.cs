# TalonOne.Model.CustomerActivityReport
A summary report of customer activity for a given time range.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID set by your integration layer. | 
**Created** | **DateTime** | The time this entity was created. | 
**Name** | **string** | The name for this customer profile. | 
**CustomerId** | **long** | The internal Talon.One ID of the customer. | 
**LastActivity** | **DateTime** | The last activity of the customer. | [optional] 
**CouponRedemptions** | **long** | Number of coupon redemptions in all customer campaigns. | 
**CouponUseAttempts** | **long** | Number of coupon use attempts in all customer campaigns. | 
**CouponFailedAttempts** | **long** | Number of failed coupon use attempts in all customer campaigns. | 
**AccruedDiscounts** | **decimal** | Number of accrued discounts in all customer campaigns. | 
**AccruedRevenue** | **decimal** | Amount of accrued revenue in all customer campaigns. | 
**TotalOrders** | **long** | Number of orders in all customer campaigns. | 
**TotalOrdersNoCoupon** | **long** | Number of orders without coupon used in all customer campaigns. | 
**CampaignName** | **string** | The name of the campaign this customer belongs to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

