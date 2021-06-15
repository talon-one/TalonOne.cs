# TalonOne.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Modified** | **DateTime** | The exact moment this entity was last modified. | 
**Email** | **string** | The email address associated with your account. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**InviteToken** | **string** | Invite token, empty if the user as already accepted their invite. | 
**State** | **string** | Current user state. | 
**Name** | **string** | Full name | 
**Policy** | [**Object**](.md) | User ACL Policy | 
**LatestFeedTimestamp** | **DateTime** | Latest timestamp the user has been notified for feed. | [optional] 
**Roles** | **List&lt;int&gt;** | Contains a list of all roles the user is a member of | [optional] 
**ApplicationNotificationSubscriptions** | [**Object**](.md) |  | [optional] 
**AuthMethod** | **string** | The Authentication method for this user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

