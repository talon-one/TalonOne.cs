# TalonOne.Model.IntegrationCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Unique ID of Campaign. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**Name** | **string** | A user-facing name for this campaign. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | The state of the campaign.  | [default to StateEnum.Enabled]
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;string&gt;** | The features enabled in this campaign. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

