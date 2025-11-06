# TalonOne.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**Email** | **string** | The email address associated with the user profile. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Name** | **string** | Name of the user. | 
**State** | **string** | State of the user. | 
**InviteToken** | **string** | Invitation token of the user.  **Note**: If the user has already accepted their invitation, this is &#x60;null&#x60;.  | 
**IsAdmin** | **bool** | Indicates whether the user is an &#x60;admin&#x60;. | [optional] 
**Policy** | [**Object**](.md) | Access level of the user. | 
**Roles** | **List&lt;long&gt;** | A list of the IDs of the roles assigned to the user. | [optional] 
**AuthMethod** | **string** | Authentication method for this user. | [optional] 
**ApplicationNotificationSubscriptions** | [**Object**](.md) | Application notifications that the user is subscribed to. | [optional] 
**LastSignedIn** | **DateTime** | Timestamp when the user last signed in to Talon.One. | [optional] 
**LastAccessed** | **DateTime** | Timestamp of the user&#39;s last activity after signing in to Talon.One. | [optional] 
**LatestFeedTimestamp** | **DateTime** | Timestamp when the user was notified for feed. | [optional] 
**AdditionalAttributes** | [**Object**](.md) | Additional user attributes, created and used by external identity providers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

