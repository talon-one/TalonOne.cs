# TalonOne.Model.NewPriceAdjustment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PriceType** | **string** | The price type (e.g. the price for members only) to apply to a given SKU. | 
**Price** | **decimal?** | The value of the price type applied to the SKU. When set to &#x60;null&#x60;, the defined price type no longer applies to the SKU. | [optional] 
**ReferenceId** | **string** | A unique reference identifier, e.g. a UUID. | 
**CalculatedAt** | **DateTime** | The time at which this price was calculated. If provided, this is used to determine the most recent price adjustment to choose if price adjustments overlap. Defaults to internal creation time if not provided. | [optional] 
**EffectiveFrom** | **DateTime** | The date and time from which the price adjustment is effective. | [optional] 
**EffectiveUntil** | **DateTime** | The date and time until which the price adjustment is effective. | [optional] 
**ContextId** | **string** | Identifier of the context of this price adjustment (e.g. summer sale). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

