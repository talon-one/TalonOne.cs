# TalonOne.Model.ExperimentVariantResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VariantId** | **long** | The ID of the variant. | [optional] 
**VariantName** | **string** | The name of the variant. | [optional] 
**VariantWeight** | **long** | The weight of the variant. | [optional] 
**IsWinner** | **bool** | Calculated flag if the variant is the winner. | [optional] 
**TotalRevenue** | **decimal** | The total, pre-discount value of all items purchased in a customer session. | [optional] 
**SessionsCount** | **decimal** | The number of all closed sessions. | [optional] 
**AvgItemsPerSession** | **decimal** | The number of items from sessions divided by the number of sessions. | [optional] 
**AvgSessionValue** | **decimal** | The average customer session value, calculated by dividing the revenue value by the number of sessions. | [optional] 
**AvgDiscountedSessionValue** | **decimal** | The average customer session value, calculated by dividing the revenue value by the number of sessions. | [optional] 
**TotalDiscounts** | **decimal** | The total value of discounts given for cart items in sessions. | [optional] 
**CouponsCount** | **decimal** | The number of times a coupon was successfully redeemed in sessions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

