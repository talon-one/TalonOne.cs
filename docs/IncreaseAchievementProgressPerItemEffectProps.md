# TalonOne.Model.IncreaseAchievementProgressPerItemEffectProps
This effect schema is returned when you use the **Update customer progress per item** effect in a rule.  It indicates that the customer's progress in an achievement was updated during the current session for a specific cart item.  If your list of cart items is a [bundle definition](https://docs.talon.one/docs/product/rules/create-and-manage-bundles), use the `bundleIndex` and `bundleName` properties to identify the bundle containing the item whose progress was updated.  If the cart item has a quantity greater than one, use the `cartItemSubPosition` property to identify the specific unit within the item's line item.  For [on-completion achievements](https://docs.talon.one/docs/product/achievements/overview#recurring-on-completion-achievements), any customer progress exceeding the target automatically starts a new iteration. This generates a new `progressTrackerId` for each iteration, and there can be multiple progress updates for the same achievement from a single validation of this effect.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AchievementId** | **long** | The internal ID of the achievement. | 
**AchievementName** | **string** | The name of the achievement. | 
**ProgressTrackerId** | **long** | The internal ID of the customer progress tracker. For [on-completion achievements](https://docs.talon.one/docs/product/achievements/overview#recurring-on-completion-achievements), this effect generates a unique ID for each iteration. | [optional] 
**Delta** | **decimal** | The value by which the customer&#39;s current progress in the achievement has increased. | 
**Value** | **decimal** | The current progress of the customer in the achievement. | 
**Target** | **decimal** | The target value to complete the achievement. | 
**IsJustCompleted** | **bool** | Indicates if the customer has completed the achievement in the current session. | 
**CartItemPosition** | **decimal** | The index of the item in the &#x60;cartItem&#x60; object on which the customer&#39;s progress in the achievement was updated. | 
**CartItemSubPosition** | **decimal** | For cart items with &#x60;quantity&#x60; &gt; 1, indicates which specific unit of the item the effect applies to. | [optional] 
**BundleIndex** | **long** | _(With bundles only)_ The position of the specific bundle in the list of bundles created from the same bundle definition. For example, if a customer creates two identical bundles, the first has index &#x60;0&#x60; and the second has index &#x60;1&#x60;. | [optional] 
**BundleName** | **string** | _(With bundles only)_ The name of the bundle definition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

