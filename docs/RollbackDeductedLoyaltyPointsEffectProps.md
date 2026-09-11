# TalonOne.Model.RollbackDeductedLoyaltyPointsEffectProps
This effect is triggered in the following cases:  - A session is _cancelled_ and this session deducted loyalty points. The rollback action returns the redeemed loyalty points to the customer. - A session is impacted by a _partial return_. Only added loyalty points that are still **pending** are rolled back. - A session in which loyalty points were spent is reopened.  See the [session states](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions#customer-session-states).  If you set custom activation and expiration dates for the loyalty points, use the `startDate` and `expiryDate` properties to identify when the reward will be active and when will expire.  If the loyalty program is [profile-based](https://docs.talon.one/docs/product/loyalty-programs/profile-based/profile-based-overview), use the `recipientIntegrationId` property to identify the user who receives the loyalty points. If the loyalty program is [card-based](https://docs.talon.one/docs/product/loyalty-programs/overview#loyalty-program-types), use the `cardIdentifier` property to identify the loyalty card where the points are reimbursed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **long** | The ID of the loyalty program where these points were reimbursed. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were reimbursed. | 
**Value** | **decimal** | The amount of points that were reimbursed. | 
**RecipientIntegrationId** | **string** | The user for whom these points were reimbursed. | 
**StartDate** | **DateTime** | The date after which the reimbursed points will be valid. | [optional] 
**ExpiryDate** | **DateTime** | The date after which the reimbursed points will expire. | [optional] 
**TransactionUUID** | **string** | The identifier of this loyalty point transaction. | 
**CardIdentifier** | **string** | The identifier of the loyalty card, which must match the regular expression &#x60;^[A-Za-z0-9._%+@-]+$&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

