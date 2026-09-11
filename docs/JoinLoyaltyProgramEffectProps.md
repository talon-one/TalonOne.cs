# TalonOne.Model.JoinLoyaltyProgramEffectProps
This effect indicates that a customer profile was joined to a profile-based loyalty program with the specified join date.  > [!note] **Note** > - This effect requires a customer profile. It does not work for anonymous sessions. > - The effect fails if the customer profile has already joined the loyalty program. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **long** | The ID of the loyalty program the customer profile is joined to. | 
**JoinDate** | **DateTime** | The date and time when the customer profile joined the loyalty program. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

