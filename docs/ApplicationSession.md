# TalonOne.Model.ApplicationSession
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. The time this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**ProfileId** | **int** | The globally unique Talon.One ID of the customer that created this entity. | [optional] 
**IntegrationId** | **string** | The integration ID set by your integration layer. | 
**Profileintegrationid** | **string** | Integration ID of the customer for the session. | [optional] 
**Coupon** | **string** | Any coupon code entered. | 
**Referral** | **string** | Any referral code entered. | 
**State** | **string** | Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;. The state transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60; or &#x60;partially_returned&#x60; 4. &#x60;partially_returned&#x60; → &#x60;cancelled&#x60;  For more information, see [Customer session states](https://docs.talon.one/docs/dev/concepts/entities#customer-session).  | 
**CartItems** | [**List&lt;CartItem&gt;**](CartItem.md) | Serialized JSON representation. | 
**Discounts** | **Dictionary&lt;string, decimal&gt;** | **API V1 only.** A map of labeled discount values, in the same currency as the session.  If you are using the V2 endpoints, refer to the &#x60;totalDiscounts&#x60; property instead.  | 
**TotalDiscounts** | **decimal** | The total sum of the discounts applied to this session. | 
**Total** | **decimal** | The total sum of the session before any discounts applied. | 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

