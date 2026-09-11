# TalonOne.Model.CheckAttributeBlock
Shared shape for attribute-comparison blocks: a single attribute evaluated by a named operator. The operator determines which additional fields are required: - `scalar` requires `value`. - `between` requires `min` and `max` values. - `list` requires `values`. - `list-with-count` requires `values` and `count`. - `unary` requires no extra fields.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | A block discriminator of type &#x60;checkAttribute&#x60;. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Operator** | **string** | The comparison operator applied to the attribute. | 
**Attribute** | [**Object**](.md) | The attribute path identifier (e.g. \&quot;$Session.Total\&quot;). | 
**Value** | [**Object**](.md) | The comparison value for scalar operators. | [optional] 
**Min** | [**Object**](.md) | The minimum value allowed for the &#x60;between&#x60; operator. | [optional] 
**Max** | [**Object**](.md) | The maximum value allowed for the &#x60;between&#x60; operator. | [optional] 
**Start** | [**Object**](.md) | The start value for the &#x60;within&#x60; operator. | [optional] 
**End** | [**Object**](.md) | The end value for the &#x60;within&#x60; operator. | [optional] 
**StartInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;start&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**EndInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;end&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**TimezoneInsensitive** | **bool** | Indicates whether the &#x60;within&#x60; operator ignores time zones and compares the wall-clock time only. When &#x60;false&#x60;, time zones are taken into account. | [optional] 
**Values** | [**Object**](.md) | The set of values to match against for list operators. For location operators (&#x60;in&#x60;, &#x60;not(in)&#x60;), an array of objects with a &#x60;geometry&#x60; (see &#x60;GeoJSONGeometry&#x60;) and an optional &#x60;name&#x60;, or a string reference to a list attribute. | [optional] 
**Count** | [**Object**](.md) | The count threshold for &#x60;containsAtLeast&#x60; and &#x60;containsExactly&#x60; operators. | [optional] 
**OnFailure** | **List&lt;Object&gt;** | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

