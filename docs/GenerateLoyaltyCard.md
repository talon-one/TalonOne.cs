# TalonOne.Model.GenerateLoyaltyCard
The parameters necessary to generate a loyalty card.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the loyalty card. | [optional] [default to StatusEnum.Active]
**CustomerProfileIds** | **List&lt;string&gt;** | Integration IDs of the customer profiles linked to the card. | [optional] 
**CardIdentifier** | **string** | The identifier of the loyalty card, which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

