# TalonOne.Model.CampaignRulesetChangedNotificationItem
A notification regarding a campaign whose ruleset was changed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | The type of the event. Can be one of the following: [&#39;campaign_state_changed&#39;, &#39;campaign_ruleset_changed&#39;, &#39;campaign_edited&#39;, &#39;campaign_created&#39;, &#39;campaign_deleted&#39;]  | 
**Campaign** | [**Campaign**](Campaign.md) |  | 
**OldRuleset** | [**Ruleset**](Ruleset.md) |  | [optional] 
**OldPlaceholders** | [**List&lt;PlaceholderDetails&gt;**](PlaceholderDetails.md) | The previous details of the placeholders before the ruleset was changed. | [optional] 
**Ruleset** | [**Ruleset**](Ruleset.md) |  | [optional] 
**Placeholders** | [**List&lt;PlaceholderDetails&gt;**](PlaceholderDetails.md) | The current details of the [placeholders](https://docs.talon.one/docs/product/campaigns/templates/create-templates#use-placeholders) in the campaign. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

