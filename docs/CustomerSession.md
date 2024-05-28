# TalonOne.Model.CustomerSession
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID set by your integration layer. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**ProfileId** | **string** | ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;.  | 
**Coupon** | **string** | Any coupon code entered. | 
**Referral** | **string** | Any referral code entered. | 
**State** | **string** | Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60; or &#x60;partially_returned&#x60; 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions).  | [default to StateEnum.Open]
**CartItems** | [**List&lt;CartItem&gt;**](CartItem.md) | Serialized JSON representation. | 
**Identifiers** | **List&lt;string&gt;** | Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. See the [tutorial](https://docs.talon.one/docs/dev/tutorials/using-identifiers).  | [optional] 
**Total** | **decimal** | The total sum of the cart in one session. | 
**Attributes** | [**Object**](.md) | A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings.  | 
**FirstSession** | **bool** | Indicates whether this is the first session for the customer&#39;s profile. Will always be true for anonymous sessions. | 
**Discounts** | **Dictionary&lt;string, decimal&gt;** | A map of labelled discount values, values will be in the same currency as the application associated with the session. | 
**Updated** | **DateTime** | Timestamp of the most recent event received on this session. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

