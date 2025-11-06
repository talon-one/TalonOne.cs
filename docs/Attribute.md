# TalonOne.Model.Attribute
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Entity** | **string** | The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type. | 
**EventType** | **string** |  | [optional] 
**Name** | **string** | The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload. | 
**Title** | **string** | The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique. | 
**Type** | **string** | The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format. | 
**Description** | **string** | A description of this attribute. | 
**Suggestions** | **List&lt;string&gt;** | A list of suggestions for the attribute. | 
**HasAllowedList** | **bool** | Whether or not this attribute has an allowed list of values associated with it. | [optional] [default to false]
**RestrictedBySuggestions** | **bool** | Whether or not this attribute&#39;s value is restricted by suggestions (&#x60;suggestions&#x60; property) or by an allowed list of value (&#x60;hasAllowedList&#x60; property).  | [optional] [default to false]
**Editable** | **bool** | Whether or not this attribute can be edited. | 
**SubscribedApplicationsIds** | **List&lt;long&gt;** | A list of the IDs of the applications where this attribute is available. | [optional] 
**SubscribedCatalogsIds** | **List&lt;long&gt;** | A list of the IDs of the catalogs where this attribute is available. | [optional] 
**AllowedSubscriptions** | **List&lt;string&gt;** | A list of allowed subscription types for this attribute.  **Note:** This only applies to attributes associated with the &#x60;CartItem&#x60; entity.  | [optional] 
**EventTypeId** | **long** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

