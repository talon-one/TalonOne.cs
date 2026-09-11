# TalonOne.Model.AwardDiscountBundleTarget
Applies the discount to items belonging to a named bundle.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A target discriminator of type &#x60;bundle&#x60;. | 
**Name** | **string** | Name of the bundle binding the discount targets. | 
**Item** | [**Object**](.md) | Selects which slot inside a bundle a discount applies to. The &#x60;type&#x60; field picks the selection mode. | [optional] 
**Prorated** | **bool** | Whether to distribute the discount proportionally across the bundle&#39;s items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

