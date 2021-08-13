# TalonOne.Model.IntegrationRequest
The body of a V2 integration API request (customer session update). Next to the customer session details, this contains an optional listing of extra properties that should be returned in the response.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerSession** | [**NewCustomerSessionV2**](NewCustomerSessionV2.md) |  | 
**ResponseContent** | **List&lt;string&gt;** | Optional list of requested information to be present on the response related to the customer session update.  **Note:** &#x60;ruleFailureReasons&#x60; is always part of the response when the Application type is &#x60;sandbox&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

