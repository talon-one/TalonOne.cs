# TalonOne.Model.BestPriorPriceRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Skus** | **List&lt;string&gt;** | List of product SKUs to check when determining the best prior price. | 
**TimeframeEndDate** | **DateTime** | The end date and time that defines the latest time for retrieving historical SKU prices. | 
**Timeframe** | **int** | The number of days prior to the timeframeEndDate. Only prices within this look back period are considered for the best prior price evaluation. | 
**StrictEndDate** | **bool** | Indicates whether the timeframe includes the start of the current sale. - When &#x60;false&#x60;, the timeframe includes the start date of the current sale. - When &#x60;true&#x60;, the timeframe striclty uses the number of days specified in &#x60;timeframe&#x60;.  | 
**Target** | [**BestPriorPriceRequestTarget**](BestPriorPriceRequestTarget.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

