# TalonOne.Model.RevisionVersion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints. | 
**AccountId** | **int** |  | 
**ApplicationId** | **int** |  | 
**CampaignId** | **int** |  | 
**Created** | **DateTime** |  | 
**CreatedBy** | **int** |  | 
**RevisionId** | **int** |  | 
**Version** | **int** |  | 
**Name** | **string** | A user-facing name for this campaign. | [optional] 
**StartTime** | **DateTime?** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime?** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**ActiveRulesetId** | **int?** | The ID of the ruleset this campaign template will use. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign template. | [optional] 
**CouponSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**ReferralSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | The set of limits that will operate for this campaign version. | [optional] 
**Features** | **List&lt;string&gt;** | A list of features for the campaign template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

