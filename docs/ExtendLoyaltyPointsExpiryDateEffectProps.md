# TalonOne.Model.ExtendLoyaltyPointsExpiryDateEffectProps
The properties specific to the \"extendLoyaltyPointsExpiryDate\" effect. This gets triggered when a validated rule contains the \"extend expiry date\" effect. The current expiry date gets extended by the time frame given in the effect. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **int** | ID of the loyalty program that contains these points. | 
**SubLedgerId** | **string** | API name of the loyalty program subledger that contains these points. added. | 
**ExtensionDuration** | **string** | Time frame by which the expiry date extends.  The time format is either: - immediate, or - an **integer** followed by a letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year.  | 
**TransactionUUIDs** | **List&lt;string&gt;** | The list of identifiers of transactions affected affected by the extension. | [optional] 
**PreviousExpirationDate** | **DateTime** | Expiry date before applying the extension. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

