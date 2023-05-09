# TalonOne.Model.LoyaltyProgramBalance
The balance in a Loyalty Program for some Customer.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentBalance** | **decimal** | Sum of currently active points. | 
**PendingBalance** | **decimal** | Sum of pending points. | 
**ExpiredBalance** | **decimal** | **DEPRECATED** Value is shown as 0.  | 
**SpentBalance** | **decimal** | **DEPRECATED** Value is shown as 0.  | 
**TentativeCurrentBalance** | **decimal** | Sum of the tentative active points (including additions and deductions) inside the currently open session. The &#x60;currentBalance&#x60; is updated to this value when you close the session, and the effects are applied. | 
**TentativePendingBalance** | **decimal** | Sum of pending points (including additions and deductions) inside the currently open session. The &#x60;pendingBalance&#x60; is updated to this value when you close the session, and the effects are applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

