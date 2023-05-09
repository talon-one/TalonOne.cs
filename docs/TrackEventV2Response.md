# TalonOne.Model.TrackEventV2Response
This is the response type returned by the trackEventV2 endpoint. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerProfile** | [**CustomerProfile**](CustomerProfile.md) |  | [optional] 
**Event** | [**Event**](Event.md) |  | [optional] 
**Loyalty** | [**Loyalty**](Loyalty.md) |  | [optional] 
**TriggeredCampaigns** | [**List&lt;Campaign&gt;**](Campaign.md) |  | [optional] 
**RuleFailureReasons** | [**List&lt;RuleFailureReason&gt;**](RuleFailureReason.md) |  | [optional] 
**AwardedGiveaways** | [**List&lt;Giveaway&gt;**](Giveaway.md) |  | [optional] 
**Effects** | [**List&lt;Effect&gt;**](Effect.md) | The effects generated by the rules in your running campaigns. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). | 
**CreatedCoupons** | [**List&lt;Coupon&gt;**](Coupon.md) |  | 
**CreatedReferrals** | [**List&lt;Referral&gt;**](Referral.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
