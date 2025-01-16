# TalonOne.Model.CouponDeletionFilters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 
**CreatedAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 
**StartsAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 
**StartsBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 
**Valid** | **string** | - &#x60;expired&#x60;: Matches coupons in which the expiration date is set and in the past. - &#x60;validNow&#x60;: Matches coupons in which the start date is null or in the past and the expiration date is null or in the future. - &#x60;validFuture&#x60;: Matches coupons in which the start date is set and in the future.  | [optional] 
**Usable** | **bool** | - &#x60;true&#x60;: only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned. - &#x60;false&#x60;: only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60; will be returned. - This field cannot be used in conjunction with the &#x60;usable&#x60; query parameter.  | [optional] 
**Redeemed** | **bool** | - &#x60;true&#x60;: only coupons where &#x60;usageCounter &gt; 0&#x60; will be returned. - &#x60;false&#x60;: only coupons where &#x60;usageCounter &#x3D; 0&#x60; will be returned.  **Note:** This field cannot be used in conjunction with the &#x60;usable&#x60; query parameter.  | [optional] 
**RecipientIntegrationId** | **string** | Filter results by match with a profile id specified in the coupon&#39;s &#x60;RecipientIntegrationId&#x60; field.  | [optional] 
**ExactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
**Value** | **string** | Filter results by the coupon code | [optional] 
**BatchId** | **string** | Filter results by batches of coupons | [optional] 
**ReferralId** | **int** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
**ExpiresAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 
**ExpiresBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

