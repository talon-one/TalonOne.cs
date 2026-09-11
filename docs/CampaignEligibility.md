# TalonOne.Model.CampaignEligibility
A list of campaigns and their evaluation status for the current customer session.  For experiment campaigns, the experiment and variant assigned to the customer profile are returned through the `experiment` field. Customer profiles with no variant assignment are not included.  **Note**:  - This response can **only** be included if the `dry` parameter in the query is set to `true`.  - Do not include `triggeredCampaigns` or `ruleFailureReasons` in `responseContent` to avoid duplicate results. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**Id** | **long** | Unique ID of Campaign. | 
**Name** | **string** | The name of the campaign. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | The state of the campaign.  | [default to StateEnum.Enabled]
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | The features enabled in this campaign. | 
**Eligibility** | [**List&lt;CampaignEligibilityDetails&gt;**](CampaignEligibilityDetails.md) | The customer&#39;s eligibility for each campaign in the current customer session. | 
**Rules** | [**List&lt;RuleMetadataEligibility&gt;**](RuleMetadataEligibility.md) | A list of rules containing customer-facing details of the rewards defined in the campaign. | 
**Experiment** | [**CampaignEligibilityExperiment**](CampaignEligibilityExperiment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

