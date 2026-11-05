# TalonOne.Model.CheckAudienceBlock
A block that checks whether a given customer profile is a member of an audience.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Operator** | **string** | An indicator of how the block compares its elements. | 
**Profile** | **string** | The customer profile to check against the audience. &#x60;Current&#x60; targets the customer in the current session; &#x60;Advocate&#x60; targets the person who invited their friend via referral program. Only applies to the &#x60;member&#x60; and &#x60;not(member)&#x60; operators; ignored for &#x60;justJoined&#x60; and &#x60;justLeft&#x60;. | [optional] 
**Audience** | [**AudienceBlockReference**](AudienceBlockReference.md) |  | 
**OnFailure** | **List&lt;Object&gt;** | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

