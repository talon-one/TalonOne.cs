# TalonOne.Model.RoleV2RolesGroup
A map of target entities to their permission sets.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applications** | [**Dictionary&lt;string, RoleV2ApplicationDetails&gt;**](RoleV2ApplicationDetails.md) | A map of the link between the Application, campaign, or draft campaign-related permission set and the Application ID the permissions apply to. | [optional] 
**LoyaltyPrograms** | **Dictionary&lt;string, string&gt;** | A map of the link between the loyalty program-related permission set and the loyalty program ID the permissions apply to. | [optional] 
**CampaignAccessGroups** | **Dictionary&lt;string, string&gt;** | A map of the link between the campaign access group-related permission set and the campaign access group ID the permissions apply to. | [optional] 
**Account** | **string** | Name of the account-level permission set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

