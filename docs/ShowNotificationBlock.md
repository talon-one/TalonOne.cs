# TalonOne.Model.ShowNotificationBlock
A block that displays a notification to the customer with a configurable type, title, and optional body message.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**NotificationType** | **string** | The type of notification to display. | 
**Title** | **string** | The notification heading shown to the customer. | 
**Body** | **string** | The notification body text. Supports template placeholders (e.g. \&quot;{{$Session.Total}}\&quot;) evaluated at rule execution time. | [optional] 
**OnFailure** | **List&lt;Object&gt;** | Blocks evaluated when this block fails or returns false. | [optional] 
**OnError** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | Named error handlers evaluated when a specific error occurs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

