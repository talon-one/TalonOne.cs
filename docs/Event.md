# TalonOne.Model.Event
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**ApplicationId** | **int** | The ID of the application that owns this entity. | 
**ProfileId** | **string** | ID of the customers profile as used within this Talon.One account.  **Note:** If the customer does not yet have a known profileId, we recommend you use a guest profileId.  | [optional] 
**Type** | **string** | A string representing the event. Must not be a reserved event name. | 
**Attributes** | [**Object**](.md) | Arbitrary additional JSON data associated with the event. | 
**SessionId** | **string** | The ID of the session that this event occurred in. | [optional] 
**Effects** | **List&lt;Object&gt;** | An array of \&quot;effects\&quot; that must be applied in response to this event. See the list of [effects](/docs/dev/integration-api/api-effects).  | 
**LedgerEntries** | [**List&lt;LedgerEntry&gt;**](LedgerEntry.md) | Ledger entries for the event. | 
**Meta** | [**Meta**](Meta.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

