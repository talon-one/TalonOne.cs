# TalonOne.Model.SupportBalances
The loyalty points balance for a support agent and a specific customer profile.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Threshold** | **decimal** | The maximum number of loyalty points the support agent is allowed to award for this loyalty program. Not present if the agent has no configured limit.  | [optional] 
**AwardedPoints** | **decimal** | The total number of loyalty points already awarded to this customer profile by this support agent.  | 
**RemainingBalance** | **decimal** | The remaining number of loyalty points the support agent can still award to this customer profile. Not present if the agent has no configured limit.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

