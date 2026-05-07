# TalonOne.Model.BestPriorPriceRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Skus** | **List&lt;string&gt;** | List of product SKUs to check when determining the best prior price. | 
**TimeframeEndDate** | **DateTime** | The end date and time that defines the latest time for retrieving historical SKU prices. | 
**Timeframe** | **string** | The number of days prior to the timeframeEndDate. Only prices within this look back period are considered for the best prior price evaluation. | 
**TimeframeEndDateType** | **string** | Sets the timeframe for retrieving historical pricing data. Can be one of the following values: - &#x60;strict&#x60;: The timeframe ends at the &#x60;timeframeEndDate&#x60; value. - &#x60;price&#x60;: The timeframe ends at the start of current price value and takes the prices prior to the start of the current price value into account. - &#x60;sale&#x60;:  The timeframe ends at the start of current &#x60;contextId&#x60; and takes the prices prior to the start of the &#x60;contextId&#x60; into account.  | 
**Target** | [**BestPriorTarget**](BestPriorTarget.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

