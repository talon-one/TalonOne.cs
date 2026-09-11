# TalonOne.Model.WillAwardGiveawayEffectProps
The equivalent of the `awardGiveaway` effect but returned when updating a session with any state other than `closed`. This ensures no giveaway codes are leaked when they are still not guaranteed to be awarded.  For more information about session states, see [Manage the session's state](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions#manage-the-sessions-state).
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PoolId** | **long** | The internal ID of the giveaway pool. | 
**PoolName** | **string** | The name of the giveaway pool. | 
**RecipientIntegrationId** | **string** | The integration ID of the customer that receives the giveaway. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

