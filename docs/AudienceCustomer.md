# TalonOne.Model.AudienceCustomer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of the customer profile. | 
**Created** | **DateTime** | The time this entity was created. | 
**IntegrationId** | **string** | The integration ID set by your integration layer. | 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. | 
**AccountId** | **long** | The ID of the Talon.One account that owns this profile. | 
**ClosedSessions** | **long** | The total number of closed sessions. Does not include closed sessions that have been cancelled or reopened. See the [docs](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions#customer-session-states). | 
**TotalSales** | **decimal** | The total amount of money spent by the customer **before** discounts are applied.  The total sales amount excludes the following: - Cancelled or reopened sessions. - Returned items.  | 
**LoyaltyMemberships** | [**List&lt;LoyaltyMembership&gt;**](LoyaltyMembership.md) | **DEPRECATED. Always returns &#x60;null&#x60;.** A list of loyalty programs joined by the customer.  | [optional] 
**AudienceMemberships** | [**List&lt;AudienceMembership&gt;**](AudienceMembership.md) | The audiences the customer belongs to. | [optional] 
**LastActivity** | **DateTime** | Timestamp of the most recent event received from this customer. This field is updated on calls that trigger the Rule Engine and that are not [dry requests](https://docs.talon.one/docs/dev/integration-api/dry-requests/#overlay).  For example, [reserving a coupon](https://docs.talon.one/integration-api#operation/createCouponReservation) for a customer doesn&#39;t impact this field.  | 
**Sandbox** | **bool** | An indicator of whether the customer is part of a sandbox or live Application. See the [docs](https://docs.talon.one/docs/product/applications/overview#application-environments).  | [optional] 
**ConnectedApplicationsIds** | **List&lt;long&gt;** | A list of the IDs of the Applications that are connected to this customer profile. | [optional] 
**ConnectedAudiences** | **List&lt;long&gt;** | A list of the IDs of the audiences that are connected to this customer profile. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

