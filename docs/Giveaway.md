# TalonOne.Model.Giveaway
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Code** | **string** | The code value of this giveaway. | 
**PoolId** | **int** | The ID of the pool to return giveaway codes from. | 
**StartDate** | **DateTime** | Timestamp at which point the giveaway becomes valid. | [optional] 
**EndDate** | **DateTime** | Timestamp at which point the giveaway becomes invalid. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this giveaway. | [optional] 
**Used** | **bool** | Indicates whether this giveaway code was given before. | [optional] 
**ImportId** | **int** | The ID of the Import which created this giveaway. | [optional] 
**ProfileIntegrationId** | **string** | The third-party integration ID of the customer profile that was awarded the giveaway, if the giveaway was awarded. | [optional] 
**ProfileId** | **int** | The internal ID of the customer profile that was awarded the giveaway, if the giveaway was awarded and an internal ID exists. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

