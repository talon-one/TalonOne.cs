# TalonOne.Model.GeoJSONPolygon
A shape formed by one or more boundaries, following the GeoJSON format. The first boundary defines the outer edge of the shape; any additional boundaries define holes within the shape.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The geometry type discriminator. | 
**Coordinates** | **List&lt;List&lt;List&lt;decimal&gt;&gt;&gt;** | The boundaries that make up the shape. Each boundary is a closed loop of longitude and latitude points, where the first and last point are the same. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

