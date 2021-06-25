# TalonOne.Model.NewAdditionalCost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The additional cost name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;shipping\&quot;&#x60; then you would set the shipping additional cost by including an &#x60;additionalCosts.shipping&#x60; property in your request payload. | 
**Title** | **string** | The human-readable name for the additional cost that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique. | 
**Description** | **string** | A description of this additional cost. | 
**SubscribedApplicationsIds** | **List&lt;int&gt;** | A list of the IDs of the applications that are subscribed to this additional cost | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

