# TalonOne.Model.CampaignVersions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveRevisionId** | **int** | ID of the revision that was last activated on this campaign.  | [optional] 
**ActiveRevisionVersionId** | **int** | ID of the revision version that is active on the campaign.  | [optional] 
**Version** | **int** | Incrementing number representing how many revisions have been activated on this campaign, starts from 0 for a new campaign.  | [optional] 
**CurrentRevisionId** | **int** | ID of the revision currently being modified for the campaign.  | [optional] 
**CurrentRevisionVersionId** | **int** | ID of the latest version applied on the current revision.  | [optional] 
**StageRevision** | **bool** | Flag for determining whether we use current revision when sending requests with staging API key.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

