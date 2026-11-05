# TalonOne.Model.RollbackIncreasedAchievementProgressPerItemEffectProps
This effect schema is returned when you cancel or [reopen a customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession) that previously validated the **Update customer progress per item** effect.  It indicates that the customer's progress in an achievement was rolled back for a specific cart item.  If your list of cart items is a [bundle definition](https://docs.talon.one/docs/product/rules/create-and-manage-bundles), use the `bundleIndex` and `bundleName` properties to identify the bundle containing the item whose progress was rolled back.  If the session contains cart items with _quantity > 1_, use the `cartItemSubPosition` property to identify the specific unit within the item's line item.  The effect is also triggered for completed achievements if the **Allow progress rollback for completed achievements** setting is enabled. You can enable this through the [Campaign Manager](https://docs.talon.one/docs/product/achievements/manage-achievements) or the [Management API](https://docs.talon.one/management-api#tag/Achievements/operation/createAchievement) by setting the `achievementAllowRollbackAfterCompletion` property to `true`. This setting only applies to one-time and recurring on expiration achievements.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The internal ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The internal ID of the achievement progress tracker. | 
**DecreaseProgressBy** | **decimal** | The value by which the customer&#39;s current progress in the achievement has decreased. | 
**CurrentProgress** | **decimal** | The current progress of the customer in the achievement. | 
**Target** | **decimal** | The target value to complete the achievement. | 
**CartItemPosition** | **decimal** | The index of the item in the &#x60;cartItem&#x60; object on which the customer&#39;s progress in the achievement was updated. | 
**CartItemSubPosition** | **decimal** | For cart items with &#x60;quantity&#x60; &gt; 1, indicates which specific unit of the item the effect applies to. | [optional] 
**BundleIndex** | **long** | _(With bundles only)_ The position of the specific bundle in the list of bundles created from the same bundle definition. For example, if a customer creates two identical bundles, the first has index &#x60;0&#x60; and the second has index &#x60;1&#x60;. | [optional] 
**BundleName** | **string** | _(With bundles only)_ The name of the bundle definition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

