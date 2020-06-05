
# TalonOne.Model.UpdateApplication

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this application. | 
**Description** | **string** | A longer description of the application. | [optional] 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | 
**Currency** | **string** | A string describing a default currency for new customer sessions. | 
**CaseSensitivity** | **string** | A string indicating how should campaigns in this application deal with case sensitivity on coupon codes. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this campaign | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | Default limits for campaigns created in this application | [optional] 
**CampaignPriority** | **string** | Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive) | [optional] 
**AttributesSettings** | [**AttributesSettings**](AttributesSettings.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

