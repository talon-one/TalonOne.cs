# TalonOne.Model.UpdateAchievementProgressBlock
A block that updates the progress of a customer in an achievement.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Operator** | **string** |  | 
**Value** | **string** | The value to update the progress by. Supports template placeholders (e.g. \&quot;{{$Session.Total / 2}}\&quot;) for dynamic quantities. | 
**Achievement** | [**UpdateAchievementProgressBlockAchievement**](UpdateAchievementProgressBlockAchievement.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

