# TalonOne.Model.ApplicationCampaignAnalytics
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start of the aggregation time frame in UTC. | 
**EndTime** | **DateTime** | The end of the aggregation time frame in UTC. | 
**CampaignId** | **int** | The ID of the campaign. | 
**CampaignName** | **string** | The name of the campaign. | 
**CampaignTags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**CampaignState** | **string** | The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons.  | 
**TotalRevenue** | [**AnalyticsDataPointWithTrendAndInfluencedRate**](AnalyticsDataPointWithTrendAndInfluencedRate.md) |  | [optional] 
**SessionsCount** | [**AnalyticsDataPointWithTrendAndInfluencedRate**](AnalyticsDataPointWithTrendAndInfluencedRate.md) |  | [optional] 
**AvgItemsPerSession** | [**AnalyticsDataPointWithTrendAndUplift**](AnalyticsDataPointWithTrendAndUplift.md) |  | [optional] 
**AvgSessionValue** | [**AnalyticsDataPointWithTrendAndUplift**](AnalyticsDataPointWithTrendAndUplift.md) |  | [optional] 
**TotalDiscounts** | [**AnalyticsDataPointWithTrend**](AnalyticsDataPointWithTrend.md) |  | [optional] 
**CouponsCount** | [**AnalyticsDataPointWithTrend**](AnalyticsDataPointWithTrend.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

