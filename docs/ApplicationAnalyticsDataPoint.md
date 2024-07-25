# TalonOne.Model.ApplicationAnalyticsDataPoint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start of the aggregation time frame in UTC. | 
**EndTime** | **DateTime** | The end of the aggregation time frame in UTC. | 
**TotalRevenue** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) |  | [optional] 
**SessionsCount** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) |  | [optional] 
**AvgItemsPerSession** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) |  | [optional] 
**AvgSessionValue** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) |  | [optional] 
**TotalDiscounts** | **decimal** | The total value of discounts given for cart items in influenced sessions. | [optional] 
**CouponsCount** | **decimal** | The number of times a coupon was successfully redeemed in influenced sessions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

