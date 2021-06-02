
# TalonOne.Model.CustomerSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntegrationId** | **string** | The integration ID for this entity sent to and used in the Talon.One system. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**ProfileId** | **string** | ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID. | 
**Coupon** | **string** | Any coupon code entered. | 
**Referral** | **string** | Any referral code entered. | 
**State** | **string** | Indicates the current state of the session. All sessions must start in the \&quot;open\&quot; state, after which valid transitions are...  1. open -&gt; closed 2. open -&gt; cancelled 3. closed -&gt; cancelled  | [default to StateEnum.Open]
**CartItems** | [**List&lt;CartItem&gt;**](CartItem.md) | Serialized JSON representation. | 
**Identifiers** | **List&lt;string&gt;** | Identifiers for the customer, this can be used for limits on values such as device ID. | [optional] 
**Total** | **decimal** | The total sum of the cart in one session. | 
**Attributes** | [**Object**](.md) | A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings.  | 
**FirstSession** | **bool** | Indicates whether this is the first session for the customer&#39;s profile. Will always be true for anonymous sessions. | 
**Discounts** | **Dictionary&lt;string, decimal&gt;** | A map of labelled discount values, values will be in the same currency as the application associated with the session. | 
**Updated** | **DateTime** | Timestamp of the most recent event received on this session | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

