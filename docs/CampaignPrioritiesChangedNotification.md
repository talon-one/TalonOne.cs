# TalonOne.Model.CampaignPrioritiesChangedNotification
Notification about an Application whose campaigns' priorities changed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Application** | [**Application**](Application.md) |  | 
**OldPriorities** | **Dictionary&lt;string, List&lt;int&gt;&gt;** | Campaign IDs for each priority. The priority can be one of: [&#39;universal&#39;, &#39;stackable&#39;, &#39;exclusive&#39;]  | [optional] 
**Priorities** | **Dictionary&lt;string, List&lt;int&gt;&gt;** | Campaign IDs for each priority. The priority can be one of: [&#39;universal&#39;, &#39;stackable&#39;, &#39;exclusive&#39;]  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

