# TalonOne.Model.PendingActivePointsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoyaltyProgramID** | **long** | The ID of the loyalty program. | 
**SubledgerID** | **string** | The ID of the subledger, when applicable. If this field is empty, the main ledger is used. | [default to ""]
**CustomerProfileID** | **string** | The integration ID of the customer profile whose loyalty points are becoming active. | 
**Points** | **decimal** | The amount of pending loyalty points becoming active. | 
**ActiveOn** | **DateTime** | The date and time the loyalty points become active. | [optional] 
**ExpireOn** | **DateTime** | The date and time the loyalty points expire. | [optional] 
**SessionIntegrationID** | **string** | The integration ID of the session through which the points were earned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

