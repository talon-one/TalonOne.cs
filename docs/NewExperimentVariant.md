# TalonOne.Model.NewExperimentVariant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this variant. | 
**Weight** | **long** | The percentage split of this variant. For &#x60;random&#x60; assignment, the split must be between 1 and 99 and the sum across all variants must equal 100. Ignored for &#x60;audience&#x60; and &#x60;external&#x60; assignment.  | 
**Ruleset** | [**NewRuleset**](NewRuleset.md) |  | 
**IsPrimary** | **bool** |  | 
**AudienceId** | **long** | The ID of the audience this variant targets. Only used when the experiment &#x60;assignmentType&#x60; is &#x60;audience&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

