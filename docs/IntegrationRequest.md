
# TalonOne.Model.IntegrationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerSession** | [**NewCustomerSessionV2**](NewCustomerSessionV2.md) |  | 
**ResponseContent** | **List&lt;string&gt;** | Optional list of requested information to be present on the response related to the customer session update.  Currently supported: \&quot;customerSession\&quot;, \&quot;customerProfile\&quot;, \&quot;coupons\&quot;, \&quot;triggeredCampaigns\&quot;, \&quot;referral\&quot;, \&quot;loyalty\&quot;, \&quot;event\&quot;, \&quot;awardedGiveaways\&quot; and \&quot;ruleFailureReasons\&quot;.  **Note:** &#x60;ruleFailureReasons&#x60; is always part of the response when the Application type is &#x60;sandbox&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

