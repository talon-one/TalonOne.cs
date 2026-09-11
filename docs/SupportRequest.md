# TalonOne.Model.SupportRequest
Summary of a support request created by a customer support agent.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Identifier of the support request. | 
**ApplicationId** | **long** | Identifier of the Application connected to the loyalty program or the campaign. It is displayed in your Talon.One deployment URL. | 
**CampaignId** | **long** | Identifier of the campaign where the coupon or gift card is created. | [optional] 
**LoyaltyProgramId** | **long** | Identifier of the loyalty program where the points are added or deducted. | [optional] 
**SubledgerId** | **long** | Identifier of the subledger the points are added to or deducted from. If there is no existing subledger with this ID, the subledger is created automatically. | [optional] 
**CreatedByUser** | **string** | Email address of the customer support agent who created the support request. | 
**CreatedAt** | **DateTime** | Timestamp when the request was made. | 
**CustomerProfileId** | **string** | Integration ID of the customer profile linked to the support request. | 
**RequestType** | **string** | Type of reward requested, including gift cards, personal coupons, and loyalty point additions or deductions. | 
**RequestValue** | **float** | Requested monetary balance of the gift card or the number of loyalty points to be added or deducted. | [optional] 
**RequestNote** | **string** | Notes attached to the support request. | 
**RequestStatus** | **string** | Current status of the support request. | 
**ProcessedAt** | **DateTime** | Timestamp when the request was approved or rejected. | [optional] 
**ProcessingNote** | **string** | Notes attached by the admin when rejecting or approving a request. | [optional] 
**ProcessedByUser** | **string** | Email address of the admin who approved or rejected the support request. | [optional] 
**CouponCode** | **string** | Coupon code associated with the approved support request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

