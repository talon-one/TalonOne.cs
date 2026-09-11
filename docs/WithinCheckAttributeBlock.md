# TalonOne.Model.WithinCheckAttributeBlock
Variant of `CheckAttributeBlock` for the `within` and `not(within)` operators, which require both a start and end value.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **string** | The range comparison operator. Must be &#x60;within&#x60; or &#x60;not(within)&#x60;. | [optional] 
**Start** | [**Object**](.md) | The start value for the &#x60;within&#x60; operator. | 
**End** | [**Object**](.md) | The end value for the &#x60;within&#x60; operator. | 
**StartInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;start&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**EndInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;end&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**TimezoneInsensitive** | **bool** | Indicates whether the &#x60;within&#x60; operator ignores time zones and compares the wall-clock time only. When &#x60;false&#x60;, time zones are taken into account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

