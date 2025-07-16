# TalonOne.Model.LedgerInfo
The balance in a Loyalty Program for some Customer.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentBalance** | **decimal** | Sum of currently active points. | 
**PendingBalance** | **decimal** | Sum of pending points. | 
**NegativeBalance** | **decimal** | Sum of negative points. This implies that &#x60;currentBalance&#x60; is &#x60;0&#x60;. | [optional] 
**ExpiredBalance** | **decimal** | **DEPRECATED** Value is shown as 0.  | 
**SpentBalance** | **decimal** | **DEPRECATED** Value is shown as 0.  | 
**TentativeCurrentBalance** | **decimal** | The tentative points balance, reflecting the &#x60;currentBalance&#x60; and all point additions and deductions within the current open customer session. When the session is closed, the effects are applied and the &#x60;currentBalance&#x60; is updated to this value.  **Note:** Tentative balances are specific to the current session and do not take into account other open sessions for the given customer.  | 
**TentativePendingBalance** | **decimal** | The tentative points balance, reflecting the &#x60;pendingBalance&#x60; and all point additions with a future activation date within the current open customer session. When the session is closed, the effects are applied and the &#x60;pendingBalance&#x60; is updated to this value.  **Note:** Tentative balances are specific to the current session and do not take into account other open sessions for the given customer.  | [optional] 
**TentativeNegativeBalance** | **decimal** | The tentative negative balance after all additions and deductions from the current customer session are applied to &#x60;negativeBalance&#x60;. When the session is closed, the tentative effects are applied and &#x60;negativeBalance&#x60; is updated to this value.  **Note:** Tentative balances are specific to the current session and do not take into account other open sessions for the given customer.  | [optional] 
**CurrentTier** | [**Tier**](Tier.md) |  | [optional] 
**PointsToNextTier** | **decimal** | Points required to move up a tier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

