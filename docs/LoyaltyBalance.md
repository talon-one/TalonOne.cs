# TalonOne.Model.LoyaltyBalance
Point balance of a ledger in the Loyalty Program.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivePoints** | **decimal** | Total amount of points awarded to this customer and available to spend. | [optional] 
**PendingPoints** | **decimal** | Total amount of points awarded to this customer but not available until their start date. | [optional] 
**SpentPoints** | **decimal** | Total amount of points already spent by this customer. | [optional] 
**ExpiredPoints** | **decimal** | Total amount of points awarded but never redeemed. They cannot be used anymore. | [optional] 
**NegativePoints** | **decimal** | Total amount of negative points. This implies that &#x60;activePoints&#x60; is &#x60;0&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

