# TalonOne.Model.Return
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**ReturnedCartItems** | [**List&lt;ReturnedCartItem&gt;**](ReturnedCartItem.md) | List of cart items to be returned. | 
**EventId** | **long** | The event ID of that was generated for this return. | 
**SessionId** | **long** | The internal ID of the session this return was requested on. | 
**SessionIntegrationId** | **string** | The integration ID of the session this return was requested on. | 
**ProfileId** | **long** | The internal ID of the profile this return was requested on. | [optional] 
**ProfileIntegrationId** | **string** | The integration ID of the profile this return was requested on. | [optional] 
**CreatedBy** | **long** | ID of the user who requested this return. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

