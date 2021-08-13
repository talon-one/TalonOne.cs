# TalonOne.Model.Giveaway
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**Code** | **string** | The code value of this giveaway. | 
**PoolId** | **int** | The ID of the pool to return giveaway codes from. | 
**StartDate** | **DateTime** | Timestamp at which point the giveaway becomes valid. | [optional] 
**EndDate** | **DateTime** | Timestamp at which point the giveaway becomes invalid. | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this giveaway. | [optional] 
**Used** | **bool** | Indicates whether this giveaway code was given before. | [optional] 
**ImportId** | **int** | The ID of the Import which created this giveaway. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

