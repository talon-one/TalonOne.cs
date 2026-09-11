# TalonOne.Model.RewardPointsRequired
The loyalty points required to activate a reward.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the &#x60;pointsRequired&#x60; entry. When updating a reward, include this property to update an existing entry. Omit it to create a new one.  | [optional] 
**Amount** | **decimal** | The number of loyalty points required to activate the reward. | 
**LoyaltyProgramId** | **long** | The ID of the associated loyalty program. | 
**SubledgerId** | **string** | The ID of the subledger within the loyalty program from which points are deducted when activating the reward.  To specify the main ledger, provide an empty string (\&quot;\&quot;).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

