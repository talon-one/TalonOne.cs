# TalonOne.Model.ReduceSelectorStep
Aggregates items into a single value.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A step discriminator of type &#x60;reduce&#x60;. | 
**Operator** | **string** | The aggregation operator applied to the items produced by the preceding step: - &#x60;max&#x60;, &#x60;min&#x60;, and &#x60;sum&#x60; operate on numeric values. - &#x60;count&#x60; returns the number of items. - &#x60;empty&#x60; reports whether the list is empty.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

