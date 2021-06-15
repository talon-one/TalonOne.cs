# TalonOne.Model.WillAwardGiveawayEffectProps
The properties specific to the \"awardGiveaway\" effect when the session is not closed yet. This effect replaces \"awardGiveaway\" only when updating a session with any state other than \"closed\". This is to ensure no giveaway codes are leaked when they are still not guaranteed to be awarded.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PoolId** | **int** | The ID of the giveaways pool the code will be taken from. | 
**PoolName** | **string** | The name of the giveaways pool the code will be taken from. | 
**RecipientIntegrationId** | **string** | The integration ID of the profile that will be awarded the giveaway. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

