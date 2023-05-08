# TalonOne.Model.NewLoyaltyProgram
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display title for the Loyalty Program. | 
**Description** | **string** | Description of our Loyalty Program. | [optional] 
**SubscribedApplications** | **List&lt;int&gt;** | A list containing the IDs of all applications that are subscribed to this Loyalty Program. | [optional] 
**DefaultValidity** | **string** | The default duration after which new loyalty points should expire. Can be &#39;unlimited&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month.  | 
**DefaultPending** | **string** | The default duration of the pending time after which points should be valid. Can be &#39;immediate&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month.  | 
**AllowSubledger** | **bool** | Indicates if this program supports subledgers inside the program. | 
**UsersPerCardLimit** | **int** | The max amount of user profiles with whom a card can be shared. This can be set to 0 for no limit. This property is only used when &#x60;cardBased&#x60; is &#x60;true&#x60;.  | [optional] 
**Sandbox** | **bool** | Indicates if this program is a live or sandbox program. Programs of a given type can only be connected to Applications of the same type. | 
**Name** | **string** | The internal name for the Loyalty Program. This is an immutable value. | 
**Tiers** | [**List&lt;NewLoyaltyTier&gt;**](NewLoyaltyTier.md) | The tiers in this loyalty program. | [optional] 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | 
**CardBased** | **bool** | Defines the type of loyalty program: - &#x60;true&#x60;: the program is a card-based. - &#x60;false&#x60;: the program is profile-based.  | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

