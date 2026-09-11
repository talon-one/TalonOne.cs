# TalonOne.Model.IntegrationCampaign
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
**Rules** | [**List&lt;RuleMetadata&gt;**](RuleMetadata.md) | A list of rules containing customer-facing details of the rewards defined in the campaign. | 
**LinkedStoreIds** | **List&lt;long&gt;** | A list of store IDs linked to this campaign. | [optional] 
**LinkedAudienceIds** | **List&lt;long&gt;** | A list of audience IDs linked to this campaign. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

