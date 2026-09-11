# TalonOne.Model.SupportRequestInput
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **long** | Identifier of the Application connected to the loyalty program or the campaign. It is displayed in your Talon.One deployment URL. | 
**CampaignId** | **long** | Identifier of the campaign where the coupon or gift card is created. | [optional] 
**LoyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. | [optional] 
**SubledgerId** | **long** | Identifier of the subledger the points are added to or deducted from. If there is no existing subledger with this ID, the subledger is created automatically. | [optional] 
**CustomerProfileId** | **string** | Integration ID of the customer profile linked to the support request. | 
**RequestType** | **string** | Type of reward requested, including gift cards, personal coupons, and loyalty point additions or deductions. | 
**RequestValue** | **float** | Requested monetary balance of the gift card or the number of loyalty points to be added or deducted. | [optional] 
**RequestNote** | **string** | Notes attached to the support request. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

