# TalonOne.Model.IntegrationUnlockRewardRequest
The request body for unlocking a reward for a customer profile, optionally using the balance of one of the customer's loyalty cards. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID to assign to the created customer reward unlock. | 
**ProfileIntegrationId** | **string** | The integration ID of the customer profile unlocking the reward. | 
**CardIdentifier** | **string** | The identifier of the loyalty card, which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | [optional] 
**LoyaltyProgramId** | **long** | The ID of the loyalty program from which points will be deducted. Required when the reward has &#x60;pointsRequired&#x60; configured. | [optional] 
**SubledgerId** | **string** | The ID of the subledger from which points will be deducted. Required when the reward has &#x60;pointsRequired&#x60; configured.  To specify the main ledger, provide an empty string (\&quot;\&quot;).  | [optional] 
**ResponseContent** | **List&lt;string&gt;** | Determines which data is included in the response. Add any of the following optional values to the array to get that data in the response: &#x60;customerProfile&#x60;, &#x60;ruleFailureReasons&#x60;, &#x60;loyalty&#x60;. &#x60;effects&#x60; is always returned regardless of whether it is included here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

