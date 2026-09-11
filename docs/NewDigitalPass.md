# TalonOne.Model.NewDigitalPass
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoyaltyProgramId** | **long** | The ID of the associated loyalty program. | 
**PassTemplateId** | **string** | The ID of the digital pass template used to generate the pass.  | 
**ProfileId** | **string** | The integration ID of the customer profile the pass is issued for. | 
**LoyaltyCardId** | **string** | The identifier of the loyalty card the pass is issued for.  **Note**: Only applicable for card-based loyalty programs.  | [optional] 
**Platform** | **string** | The wallet platform the pass is generated for. | 
**Attributes** | **Dictionary&lt;string, string&gt;** | A map of placeholder values that you provide to fill in the pass template. These values are not validated against the template.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

