# TalonOne.Model.CustomerActivityReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID for this entity sent to and used in the Talon.One system. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Name** | **string** | The name for this customer profile. | 
**CustomerId** | **int** | The internal Talon.One ID of the customer. | 
**LastActivity** | **DateTime** | The last activity of the customer. | [optional] 
**CouponRedemptions** | **int** | Number of coupon redemptions in all customer campaigns. | 
**CouponUseAttempts** | **int** | Number of coupon use attempts in all customer campaigns. | 
**CouponFailedAttempts** | **int** | Number of failed coupon use attempts in all customer campaigns. | 
**AccruedDiscounts** | **decimal** | Number of accrued discounts in all customer campaigns. | 
**AccruedRevenue** | **decimal** | Amount of accrued revenue in all customer campaigns. | 
**TotalOrders** | **int** | Number of orders in all customer campaigns. | 
**TotalOrdersNoCoupon** | **int** | Number of orders without coupon used in all customer campaigns. | 
**CampaignName** | **string** | The name of the campaign this customer belongs to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

