# TalonOne.Model.CouponFailureSummary
Summary of the reasons for coupon redemption failure.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | ID of the evaluation record. | 
**EventID** | **long** | ID of the event. | 
**SessionID** | **string** | ID of the customer session set by your integration layer. | [optional] 
**ProfileID** | **string** | ID of the customer profile set by your integration layer. | [optional] 
**Status** | **string** | Status defines if the coupon code was applied or rejected. | 
**CouponCode** | **string** | Coupon code passed for evaluation. | 
**Language** | **string** | Language of the summary. | 
**Summary** | **string** | A summary of the reasons for coupon redemption failure. | 
**CreatedAt** | **DateTime** | Timestamp when the request was made. | 
**UpdatedAt** | **DateTime** | Timestamp when the request was last updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

