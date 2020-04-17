
# TalonOne.Model.NewCustomerSessionV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID. | [optional] 
**CouponCodes** | **List&lt;string&gt;** | Any coupon codes entered. | [optional] 
**ReferralCode** | **string** | Any referral code entered. | [optional] 
**State** | **string** | Indicates the current state of the session. All sessions must start in the \&quot;open\&quot; state, after which valid transitions are...  1. open -&gt; closed 2. open -&gt; cancelled 3. closed -&gt; cancelled  | [optional] [default to StateEnum.Open]
**CartItems** | [**List&lt;CartItem&gt;**](CartItem.md) | All items the customer will be purchasing in this session | [optional] 
**AdditionalCosts** | [**Dictionary&lt;string, AdditionalCost&gt;**](AdditionalCost.md) | Any costs associated with the session that can not be explicitly attributed to cart items. Examples include shipping costs and service fees. | [optional] 
**Identifiers** | **List&lt;string&gt;** | Identifiers for the customer, this can be used for limits on values such as device ID. | [optional] 
**Attributes** | [**Object**](.md) | A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

