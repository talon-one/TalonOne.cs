# TalonOne.Model.TimePoint
The absolute duration after which the achievement ends and resets for a particular customer profile.  **Note**: The duration follows the time zone of the Application this achievement belongs to. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Month** | **int** | The achievement ends and resets in this month.  **Note**: Only applicable if the period is set to &#x60;Y&#x60;.  | [optional] 
**DayOfMonth** | **int** | The achievement ends and resets on this day of the month.  **Note**: Only applicable if the period is set to &#x60;Y&#x60; or &#x60;M&#x60;.  | [optional] 
**DayOfWeek** | **int** | The achievement ends and resets on this day of the week. &#x60;1&#x60; represents &#x60;Monday&#x60; and &#x60;7&#x60; represents &#x60;Sunday&#x60;.  **Note**: Only applicable if the period is set to &#x60;W&#x60;.  | [optional] 
**Hour** | **int** | The achievement ends and resets at this hour. | 
**Minute** | **int** | The achievement ends and resets at this minute. | 
**Second** | **int** | The achievement ends and resets at this second. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

