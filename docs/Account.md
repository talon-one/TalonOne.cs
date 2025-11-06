# TalonOne.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**CompanyName** | **string** |  | 
**DomainName** | **string** | Subdomain Name for yourcompany.talon.one. | 
**State** | **string** | State of the account (active, deactivated). | 
**BillingEmail** | **string** | The billing email address associated with your company account. | 
**PlanName** | **string** | The name of your booked plan. | [optional] 
**PlanExpires** | **DateTime** | The point in time at which your current plan expires. | [optional] 
**ApplicationLimit** | **long** | The maximum number of Applications covered by your plan. | [optional] 
**UserLimit** | **long** | The maximum number of Campaign Manager Users covered by your plan. | [optional] 
**CampaignLimit** | **long** | The maximum number of Campaigns covered by your plan. | [optional] 
**ApiLimit** | **long** | The maximum number of Integration API calls covered by your plan per billing period. | [optional] 
**ApplicationCount** | **long** | The current number of Applications in your account. | 
**UserCount** | **long** | The current number of Campaign Manager Users in your account. | 
**CampaignsActiveCount** | **long** | The current number of active Campaigns in your account. | 
**CampaignsInactiveCount** | **long** | The current number of inactive Campaigns in your account. | 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

