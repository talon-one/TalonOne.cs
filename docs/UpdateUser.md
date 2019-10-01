# TalonOne.Model.UpdateUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | The email address associated with your account. | 
**Name** | **string** | Your name. | [optional] 
**Password** | **string** | Your old password. | [optional] 
**NewPassword** | **string** | Your new password. | [optional] 
**Policy** | **string** | a blob of acl json | [optional] 
**State** | **string** | New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user. | [optional] 
**ReleaseUpdate** | **bool?** | Update the user via email | [optional] 
**LatestFeature** | **string** | The latest feature you&#39;ve been notified. | [optional] 
**Roles** | **List&lt;int?&gt;** | Update | [optional] 
**ApplicationNotificationSubscriptions** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

