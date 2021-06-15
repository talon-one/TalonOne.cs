# TalonOne.Model.LoyaltySubLedger
Ledger of Balance in Loyalty Program for a Customer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal** | ⚠️ Deprecated: Use &#39;totalActivePoints&#39; property instead. Total amount of currently active and available points in the customer&#39;s balance  | 
**TotalActivePoints** | **decimal** | Total amount of currently active and available points in the customer&#39;s balance | 
**TotalPendingPoints** | **decimal** | Total amount of pending points, which are not active yet but will become active in the future | 
**TotalSpentPoints** | **decimal** | Total amount of points already spent by this customer | 
**TotalExpiredPoints** | **decimal** | Total amount of points, that expired without ever being spent | 
**Transactions** | [**List&lt;LoyaltyLedgerEntry&gt;**](LoyaltyLedgerEntry.md) | List of all events that have happened such as additions, subtractions and expiries | [optional] 
**ExpiringPoints** | [**List&lt;LoyaltyLedgerEntry&gt;**](LoyaltyLedgerEntry.md) | List of all points that will expire | [optional] 
**ActivePoints** | [**List&lt;LoyaltyLedgerEntry&gt;**](LoyaltyLedgerEntry.md) | List of all currently active points | [optional] 
**PendingPoints** | [**List&lt;LoyaltyLedgerEntry&gt;**](LoyaltyLedgerEntry.md) | List of all points pending activation | [optional] 
**ExpiredPoints** | [**List&lt;LoyaltyLedgerEntry&gt;**](LoyaltyLedgerEntry.md) | List of expired points | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

