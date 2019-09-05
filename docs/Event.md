# TalonOne.Model.Event
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique ID for this entity. | 
**Created** | **DateTime?** | The exact moment this entity was created. | 
**ApplicationId** | **int?** | The ID of the application that owns this entity. | 
**ProfileId** | **string** | ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID. | [optional] 
**SessionId** | **string** | The ID of the session that this event occurred in. | 
**Type** | **string** | A string representing the event. Must not be a reserved event name. | 
**Attributes** | **Object** | Arbitrary additional JSON data associated with the event. | 
**Effects** | **List&lt;Object&gt;** | An array of \&quot;effects\&quot; that must be applied in response to this event. Example effects include &#x60;addItemToCart&#x60; or &#x60;setDiscount&#x60;.  | 
**LedgerEntries** | [**List&lt;LedgerEntry&gt;**](LedgerEntry.md) | Ledger entries for the event. | 
**Meta** | [**Meta**](Meta.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

