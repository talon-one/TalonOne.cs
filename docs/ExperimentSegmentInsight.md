# TalonOne.Model.ExperimentSegmentInsight
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dimension** | **string** | The segmentation dimension used to group customers or purchases for analysis. | 
**Bucket** | **string** | The specific group within the segmentation dimension. | 
**Confidence** | **double** | The raw (unadjusted) confidence score expressed as a percentage. Only segments with a confidence score greater than or equal to 95% are returned.  | 
**WinnerVariantId** | **long** | The ID of the variant that performed better in this segment. | 
**Variants** | [**List&lt;ExperimentSegmentInsightVariant&gt;**](ExperimentSegmentInsightVariant.md) | Per-variant metric values for this segment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

