# TalonOne.Model.SamlConnection
A SAML 2.0 connection.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssertionConsumerServiceURL** | **string** | The location where the SAML assertion is sent with a HTTP POST. | 
**AccountId** | **int** | The ID of the account that owns this entity. | 
**Name** | **string** | ID of the SAML service. | 
**Enabled** | **bool** | Determines if this SAML connection active. | 
**Issuer** | **string** | Identity Provider Entity ID. | 
**SignOnURL** | **string** | Single Sign-On URL. | 
**SignOutURL** | **string** | Single Sign-Out URL. | [optional] 
**MetadataURL** | **string** | Metadata URL. | [optional] 
**AudienceURI** | **string** | The application-defined unique identifier that is the intended audience of the SAML assertion. This is most often the SP Entity ID of your application. When not specified, the ACS URL will be used.  | 
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

