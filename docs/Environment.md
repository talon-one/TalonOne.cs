# TalonOne.Model.Environment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **int** | The ID of the Application that owns this entity. | 
**Slots** | [**List&lt;SlotDef&gt;**](SlotDef.md) | The slots defined for this application. | 
**Functions** | [**List&lt;FunctionDef&gt;**](FunctionDef.md) | The functions defined for this application. | 
**Templates** | [**List&lt;TemplateDef&gt;**](TemplateDef.md) | The templates defined for this application. | 
**Variables** | **string** | A stringified version of the environment&#39;s Talang variables scope. | 
**GiveawaysPools** | [**List&lt;GiveawaysPool&gt;**](GiveawaysPool.md) | The giveaways pools that the application is subscribed to. | [optional] 
**LoyaltyPrograms** | [**List&lt;LoyaltyProgram&gt;**](LoyaltyProgram.md) | The loyalty programs that the application is subscribed to. | [optional] 
**Achievements** | [**List&lt;Achievement&gt;**](Achievement.md) | The achievements, linked to the campaigns, belonging to the application. | [optional] 
**Attributes** | [**List&lt;Attribute&gt;**](Attribute.md) | The attributes that the application is subscribed to. | [optional] 
**AdditionalCosts** | [**List&lt;AccountAdditionalCost&gt;**](AccountAdditionalCost.md) | The additional costs that the application is subscribed to. | [optional] 
**Audiences** | [**List&lt;Audience&gt;**](Audience.md) | The audiences contained in the account which the application belongs to. | [optional] 
**Collections** | **List&lt;Collection&gt;** | The account-level collections that the application is subscribed to. | [optional] 
**ApplicationCartItemFilters** | [**List&lt;ApplicationCIF&gt;**](ApplicationCIF.md) | The cart item filters belonging to the Application. | [optional] 
**PriceTypes** | [**List&lt;PriceType&gt;**](PriceType.md) | The price types that this Application can use. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

