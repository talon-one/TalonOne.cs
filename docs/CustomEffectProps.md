# TalonOne.Model.CustomEffectProps
If you want to return data as an effect but no effect matches your use case, you can [create a custom effect](https://docs.talon.one/docs/dev/tutorials/create-custom-effects).  Custom effects can be used as both rule effects and failure effects.  The structure of a custom effect depends on your specifications but is always named `customEffect`.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectId** | **long** | The ID of the custom effect that was triggered. | 
**Name** | **string** | The type of the custom effect. | 
**CartItemPosition** | **decimal** | The index of the item in the cart item list to which the custom effect is applied. | [optional] 
**CartItemSubPosition** | **decimal** | For cart items with quantity &gt; 1, the sub position indicates to which item unit the custom effect is applied.  | [optional] 
**BundleIndex** | **long** | The position of the bundle in a list of item bundles created from the same bundle definition. | [optional] 
**BundleName** | **string** | The name of the bundle definition. | [optional] 
**Payload** | [**Object**](.md) | The JSON payload of the custom effect. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

