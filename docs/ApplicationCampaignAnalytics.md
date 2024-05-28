# TalonOne.Model.ApplicationCampaignAnalytics
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start of the aggregation time frame in UTC. | [optional] 
**EndTime** | **DateTime** | The end of the aggregation time frame in UTC. | [optional] 
**CampaignId** | **int** | The ID of the campaign. | [optional] 
**CampaignName** | **string** | The name of the campaign. | [optional] 
**CampaignTags** | **List&lt;string&gt;** | A list of tags for the campaign. | [optional] 
**CampaignState** | **string** | The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons.  | [optional] [default to CampaignStateEnum.Enabled]
**CampaignActiveRulesetId** | **int** | The [ID of the ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation.  | [optional] 
**CampaignStartTime** | **DateTime** | Date and time when the campaign becomes active. | [optional] 
**CampaignEndTime** | **DateTime** | Date and time when the campaign becomes inactive. | [optional] 
**TotalRevenue** | [**ApplicationCampaignAnalyticsTotalRevenue**](ApplicationCampaignAnalyticsTotalRevenue.md) |  | [optional] 
**SessionsCount** | [**ApplicationCampaignAnalyticsSessionsCount**](ApplicationCampaignAnalyticsSessionsCount.md) |  | [optional] 
**AvgItemsPerSession** | [**ApplicationCampaignAnalyticsAvgItemsPerSession**](ApplicationCampaignAnalyticsAvgItemsPerSession.md) |  | [optional] 
**AvgSessionValue** | [**ApplicationCampaignAnalyticsAvgSessionValue**](ApplicationCampaignAnalyticsAvgSessionValue.md) |  | [optional] 
**TotalDiscounts** | [**ApplicationCampaignAnalyticsTotalDiscounts**](ApplicationCampaignAnalyticsTotalDiscounts.md) |  | [optional] 
**CouponsCount** | [**ApplicationCampaignAnalyticsCouponsCount**](ApplicationCampaignAnalyticsCouponsCount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

