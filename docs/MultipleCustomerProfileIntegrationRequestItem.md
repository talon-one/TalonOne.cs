# TalonOne.Model.MultipleCustomerProfileIntegrationRequestItem
The body of a V2 integration API request (customer profile update). Next to the customer profile details, this contains an optional listing of extra properties that should be returned in the response. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. | [optional] 
**IntegrationId** | **string** | The identifier of this profile, set by your integration layer. It must be unique within the account.  To get the &#x60;integrationId&#x60; of the profile from a &#x60;sessionId&#x60;, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

