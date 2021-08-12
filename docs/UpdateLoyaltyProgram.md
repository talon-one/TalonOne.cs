# TalonOne.Model.UpdateLoyaltyProgram
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display title for the Loyalty Program. | [optional] 
**Description** | **string** | Description of our Loyalty Program. | [optional] 
**SubscribedApplications** | **List&lt;int&gt;** | A list containing the IDs of all applications that are subscribed to this Loyalty Program. | [optional] 
**DefaultValidity** | **string** | Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;. | [optional] 
**DefaultPending** | **string** | Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;. | [optional] 
**AllowSubledger** | **bool** | Indicates if this program supports subledgers inside the program | [optional] 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | [optional] 
**Tiers** | [**List&lt;NewLoyaltyTier&gt;**](NewLoyaltyTier.md) | The tiers in this loyalty program | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

