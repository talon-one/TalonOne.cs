# TalonOne.Model.Event
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the Application that owns this entity. | 
**ProfileId** | **string** | ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;.  | [optional] 
**StoreIntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store. | [optional] 
**Type** | **string** | A string representing the event. Must not be a reserved event name. | 
**Attributes** | [**Object**](.md) | Arbitrary additional JSON data associated with the event. | 
**SessionId** | **string** | The ID of the session that this event occurred in. | [optional] 
**Effects** | **List&lt;Object&gt;** | An array of effects generated by the rules of the enabled campaigns of the Application.  You decide how to apply them in your system. See the list of [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects).  | 
**LedgerEntries** | [**List&lt;LedgerEntry&gt;**](LedgerEntry.md) | Ledger entries for the event. | [optional] 
**Meta** | [**Meta**](Meta.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

