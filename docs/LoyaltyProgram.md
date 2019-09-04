# TalonOne.Model.LoyaltyProgram
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The ID of loyalty program. | 
**AccountID** | **int?** | The ID of the Talon.One account that owns this program. | 
**Name** | **string** | The internal name for the Loyalty Program. | 
**Title** | **string** | The display title for the Loyalty Program. | 
**Description** | **string** | Description of our Loyalty Program. | 
**SubscribedApplications** | **List&lt;int?&gt;** | A list containing the IDs of all applications that are subscribed to this Loyalty Program. | 
**DefaultValidity** | **string** | Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39; or &#39;30d&#39;. | 
**AllowSubledger** | **bool?** | Indicates if this program supports subledgers inside the program | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

