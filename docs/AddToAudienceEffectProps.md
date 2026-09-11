# TalonOne.Model.AddToAudienceEffectProps
This effect is triggered when a rule containing an [Update audience](https://docs.talon.one/docs/product/rules/effects/use-effects#update-an-audience) effect with **Add customer to an audience** selected is validated. It indicates that a customer was added to an audience and is returned when a customer session is opened, updated, or closed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AudienceId** | **long** | The internal ID of the audience. | [optional] 
**AudienceName** | **string** | The name of the audience. | [optional] 
**ProfileIntegrationId** | **string** | The ID of the customer profile in the third-party integration platform. | [optional] 
**ProfileId** | **long** | The internal ID of the customer profile. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

