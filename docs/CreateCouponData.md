# TalonOne.Model.CreateCouponData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;ExtendedCoupon&gt;**](ExtendedCoupon.md) | The array of coupons codes. If 1000 or fewer coupons are requested, all coupon data is sent. If 1001 or more coupons are requested, only &#x60;BatchID&#x60; is sent. | [optional] 
**TotalResultSize** | **long** |  | [optional] 
**BatchID** | **string** | The ID of the batch to which the coupon belongs.  **Note:** The Batch ID is generated when coupons are created.  | [optional] 
**TypeOfChange** | **string** |  | 
**Operation** | **string** |  | 
**EmployeeName** | **string** |  | 
**NotificationType** | **string** | The type of the not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

