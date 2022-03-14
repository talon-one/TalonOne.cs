# TalonOne.Model.Return
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**ReturnedCartItems** | [**List&lt;ReturnedCartItem&gt;**](ReturnedCartItem.md) | List of cart items to be returned | 
**EventId** | **int** | The event ID of that was generated for this return. | 
**SessionId** | **int** | The internal ID of the session this return was requested on. | 
**SessionIntegrationId** | **string** | The integration ID of the session this return was requested on. | 
**ProfileId** | **int** | The internal ID of the profile this return was requested on. | [optional] 
**ProfileIntegrationId** | **string** | The integration ID of the profile this return was requested on. | [optional] 
**CreatedBy** | **int** | ID of the user who requested this return. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

