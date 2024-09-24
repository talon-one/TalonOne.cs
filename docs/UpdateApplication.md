# TalonOne.Model.UpdateApplication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this application. | 
**Description** | **string** | A longer description of the application. | [optional] 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | 
**Currency** | **string** | The default currency for new customer sessions. | 
**CaseSensitivity** | **string** | The case sensitivity behavior to check coupon codes in the campaigns of this Application. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | Default limits for campaigns created in this application. | [optional] 
**DefaultDiscountScope** | **string** | The default scope to apply &#x60;setDiscount&#x60; effects on if no scope was provided with the effect.  | [optional] 
**EnableCascadingDiscounts** | **bool** | Indicates if discounts should cascade for this Application. | [optional] 
**EnableFlattenedCartItems** | **bool** | Indicates if cart items of quantity larger than one should be separated into different items of quantity one.  | [optional] 
**AttributesSettings** | [**AttributesSettings**](AttributesSettings.md) |  | [optional] 
**Sandbox** | **bool** | Indicates if this is a live or sandbox Application. | [optional] 
**EnablePartialDiscounts** | **bool** | Indicates if this Application supports partial discounts. | [optional] 
**DefaultDiscountAdditionalCostPerItemScope** | **string** | The default scope to apply &#x60;setDiscountPerItem&#x60; effects on if no scope was provided with the effect.  | [optional] 
**DefaultEvaluationGroupId** | **int** | The ID of the default campaign evaluation group to which new campaigns will be added unless a different group is selected when creating the campaign. | [optional] 
**DefaultCartItemFilterId** | **int** | The ID of the default Cart-Item-Filter for this application. | [optional] 
**EnableCampaignStateManagement** | **bool** | Indicates whether the campaign staging and revisions feature is enabled for the Application.  **Important:** After this feature is enabled, it cannot be disabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

