# TalonOne.Api.IntegrationApi

All URIs are relative to *https://yourbaseurl.talon.one*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAudienceV2**](IntegrationApi.md#createaudiencev2) | **POST** /v2/audiences | Create audience
[**CreateCouponReservation**](IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create coupon reservation
[**CreateReferral**](IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create referral code for an advocate
[**CreateReferralsForMultipleAdvocates**](IntegrationApi.md#createreferralsformultipleadvocates) | **POST** /v1/referrals_for_multiple_advocates | Create referral codes for multiple advocates
[**DeleteAudienceMembershipsV2**](IntegrationApi.md#deleteaudiencemembershipsv2) | **DELETE** /v2/audiences/{audienceId}/memberships | Delete audience memberships
[**DeleteAudienceV2**](IntegrationApi.md#deleteaudiencev2) | **DELETE** /v2/audiences/{audienceId} | Delete audience
[**DeleteCouponReservation**](IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
[**DeleteCustomerData**](IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete customer&#39;s personal data
[**GetCustomerInventory**](IntegrationApi.md#getcustomerinventory) | **GET** /v1/customer_profiles/{integrationId}/inventory | List customer data
[**GetCustomerSession**](IntegrationApi.md#getcustomersession) | **GET** /v2/customer_sessions/{customerSessionId} | Get customer session
[**GetLoyaltyBalances**](IntegrationApi.md#getloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/balances | Get customer&#39;s loyalty points
[**GetLoyaltyCardBalances**](IntegrationApi.md#getloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/balances | Get card&#39;s point balances
[**GetLoyaltyCardTransactions**](IntegrationApi.md#getloyaltycardtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transactions | List card&#39;s transactions
[**GetLoyaltyProgramProfileTransactions**](IntegrationApi.md#getloyaltyprogramprofiletransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/transactions | List customer&#39;s loyalty transactions
[**GetReservedCustomers**](IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | List customers that have this coupon reserved
[**LinkLoyaltyCardToProfile**](IntegrationApi.md#linkloyaltycardtoprofile) | **POST** /v2/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/link_profile | Link customer profile to card
[**ReopenCustomerSession**](IntegrationApi.md#reopencustomersession) | **PUT** /v2/customer_sessions/{customerSessionId}/reopen | Reopen customer session
[**ReturnCartItems**](IntegrationApi.md#returncartitems) | **POST** /v2/customer_sessions/{customerSessionId}/returns | Return cart items
[**SyncCatalog**](IntegrationApi.md#synccatalog) | **PUT** /v1/catalogs/{catalogId}/sync | Sync cart item catalog
[**TrackEvent**](IntegrationApi.md#trackevent) | **POST** /v1/events | Track event
[**TrackEventV2**](IntegrationApi.md#trackeventv2) | **POST** /v2/events | Track event V2
[**UpdateAudienceCustomersAttributes**](IntegrationApi.md#updateaudiencecustomersattributes) | **PUT** /v2/audience_customers/{audienceId}/attributes | Update profile attributes for all customers in audience
[**UpdateAudienceV2**](IntegrationApi.md#updateaudiencev2) | **PUT** /v2/audiences/{audienceId} | Update audience name
[**UpdateCustomerProfileAudiences**](IntegrationApi.md#updatecustomerprofileaudiences) | **POST** /v2/customer_audiences | Update multiple customer profiles&#39; audiences
[**UpdateCustomerProfileV2**](IntegrationApi.md#updatecustomerprofilev2) | **PUT** /v2/customer_profiles/{integrationId} | Update customer profile
[**UpdateCustomerProfilesV2**](IntegrationApi.md#updatecustomerprofilesv2) | **PUT** /v2/customer_profiles | Update multiple customer profiles
[**UpdateCustomerSessionV2**](IntegrationApi.md#updatecustomersessionv2) | **PUT** /v2/customer_sessions/{customerSessionId} | Update customer session


<a name="createaudiencev2"></a>
# **CreateAudienceV2**
> Audience CreateAudienceV2 (NewAudience body)

Create audience

Create an audience. The audience can be created directly from scratch or can come from third party platforms.  **Note:** Audiences can also be created from scratch via the Campaign Manager. See the [docs](https://docs.talon.one/docs/product/audiences/creating-audiences).  To create an audience from an existing audience from a [technology partner](https://docs.talon.one/docs/dev/technology-partners/overview): 1. Set the `integration` property to `mparticle`, `segment` etc., depending on a third-party platform. 1. Set `integrationId` to the ID of this audience in a third-party platform.  To create an audience from an existing audience in another platform: 1. Do not use the `integration` property. 1. Set `integrationId` to the ID of this audience in the 3rd-party platform.  To create an audience from scratch: 1. Only set the `name` property.  Once you create your first audience, audience-specific rule conditions are enabled in the Rule Builder. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAudienceV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewAudience(); // NewAudience | body

            try
            {
                // Create audience
                Audience result = apiInstance.CreateAudienceV2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateAudienceV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewAudience**](NewAudience.md)| body | 

### Return type

[**Audience**](Audience.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. An Audience with this ID already exists for this integration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcouponreservation"></a>
# **CreateCouponReservation**
> Coupon CreateCouponReservation (string couponValue, CouponReservations body)

Create coupon reservation

Create a coupon reservation for specified customer profiles on the specified coupon. You can also create a reservation via the Campaign Manager using the [Create coupon code reservation effect](https://docs.talon.one/docs/product/rules/effects/using-effects#reserving-a-coupon-code).  Reserving a coupon allows you to associate a coupon code to a given customer(s). You can then list the reserved coupons of a given customer with the [List customer data](https://docs.talon.one/integration-api#operation/getCustomerInventory) endpoint.  If a coupon gets created for a specific user, it will automatically appear in their coupons.  When a user redeems a coupon, a reservation is automatically created after the redemption and the used coupon will be returned in the [List customer data](https://docs.talon.one/integration-api#operation/getCustomerInventory) endpoint.  For example, you can use this endpoint and `List customer data` to create a _coupon wallet_ by reserving coupon codes for a customer, and then displaying their coupon wallet when they visit your store.  <div class=\"redoc-section\">   <p class=\"title\">Important</p>    This endpoint creates a **soft** reservation. _Any_ customer   can use a reserved coupon code and proceed to checkout.    To create a hard reservation, you can:   - use the [Create coupons](https://docs.talon.one/management-api#operation/createCoupons) endpoint or,   - use the [Create coupons for multiple recipients](https://docs.talon.one/management-api#operation/createCouponsForMultipleRecipients)     endpoint setting the `recipientsIntegrationId` property or,   - create a coupon code with the **Reservation mandatory** option then use the [Create coupon code reservation effect](https://docs.talon.one/docs/product/rules/effects/using-effects#reserving-a-coupon-code). </div>  To delete a reservation, use the [Delete reservation](https://docs.talon.one/integration-api#tag/Coupons/operation/deleteCouponReservation) endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponReservationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The code of the coupon.
            var body = new CouponReservations(); // CouponReservations | body

            try
            {
                // Create coupon reservation
                Coupon result = apiInstance.CreateCouponReservation(couponValue, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateCouponReservation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The code of the coupon. | 
 **body** | [**CouponReservations**](CouponReservations.md)| body | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreferral"></a>
# **CreateReferral**
> Referral CreateReferral (NewReferral body)

Create referral code for an advocate

Creates a referral code for an advocate. The code will be valid for the referral campaign for which is created, indicated in the `campaignId` parameter, and will be associated with the profile specified in the `advocateProfileIntegrationId` parameter as the advocate's profile. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateReferralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewReferral(); // NewReferral | body

            try
            {
                // Create referral code for an advocate
                Referral result = apiInstance.CreateReferral(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateReferral: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewReferral**](NewReferral.md)| body | 

### Return type

[**Referral**](Referral.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreferralsformultipleadvocates"></a>
# **CreateReferralsForMultipleAdvocates**
> InlineResponse201 CreateReferralsForMultipleAdvocates (NewReferralsForMultipleAdvocates body, string silent = null)

Create referral codes for multiple advocates

Creates unique referral codes for multiple advocates. The code will be valid for the referral campaign for which it is created, indicated in the `campaignId` parameter, and one referral code will be associated with one advocate using the profile specified in the `advocateProfileIntegrationId` parameter as the advocate's profile. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateReferralsForMultipleAdvocatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewReferralsForMultipleAdvocates(); // NewReferralsForMultipleAdvocates | body
            var silent = silent_example;  // string | Possible values: `yes` or `no`. - `yes`: Increases the perfomance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Create referral codes for multiple advocates
                InlineResponse201 result = apiInstance.CreateReferralsForMultipleAdvocates(body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateReferralsForMultipleAdvocates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewReferralsForMultipleAdvocates**](NewReferralsForMultipleAdvocates.md)| body | 
 **silent** | **string**| Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the perfomance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;]

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaudiencemembershipsv2"></a>
# **DeleteAudienceMembershipsV2**
> void DeleteAudienceMembershipsV2 (int audienceId)

Delete audience memberships

Remove all members from this audience. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteAudienceMembershipsV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var audienceId = 56;  // int | The ID of the audience. You get it via the `id` property when [creating an audience](#operation/createAudienceV2).

            try
            {
                // Delete audience memberships
                apiInstance.DeleteAudienceMembershipsV2(audienceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteAudienceMembershipsV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceId** | **int**| The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2). | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaudiencev2"></a>
# **DeleteAudienceV2**
> void DeleteAudienceV2 (int audienceId)

Delete audience

Delete an audience created by a third-party integration.  **Warning:** This endpoint also removes any associations recorded between a customer profile and this audience.  **Note:** Audiences can also be deleted via the Campaign Manager. See the [docs](https://docs.talon.one/docs/product/audiences/managing-audiences#deleting-an-audience). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteAudienceV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var audienceId = 56;  // int | The ID of the audience. You get it via the `id` property when [creating an audience](#operation/createAudienceV2).

            try
            {
                // Delete audience
                apiInstance.DeleteAudienceV2(audienceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteAudienceV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceId** | **int**| The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2). | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponreservation"></a>
# **DeleteCouponReservation**
> void DeleteCouponReservation (string couponValue, CouponReservations body)

Delete coupon reservations

Remove all the coupon reservations from the provided customer profile integration IDs and the provided coupon code. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponReservationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The code of the coupon.
            var body = new CouponReservations(); // CouponReservations | body

            try
            {
                // Delete coupon reservations
                apiInstance.DeleteCouponReservation(couponValue, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteCouponReservation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The code of the coupon. | 
 **body** | [**CouponReservations**](CouponReservations.md)| body | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerdata"></a>
# **DeleteCustomerData**
> void DeleteCustomerData (string integrationId)

Delete customer's personal data

Delete all attributes on the customer profile and on entities that reference this customer profile.  **Important:** To preserve performance, we recommend avoiding deleting customer data during peak-traffic hours. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCustomerDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The integration ID of the customer profile. You can get the `integrationId` of a profile using: - A customer session integration Id with the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. - The Management API with the [List application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 

            try
            {
                // Delete customer's personal data
                apiInstance.DeleteCustomerData(integrationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteCustomerData: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The integration ID of the customer profile. You can get the &#x60;integrationId&#x60; of a profile using: - A customer session integration Id with the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. - The Management API with the [List application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinventory"></a>
# **GetCustomerInventory**
> CustomerInventory GetCustomerInventory (string integrationId, bool? profile = null, bool? referrals = null, bool? coupons = null, bool? loyalty = null, bool? giveaways = null)

List customer data

Return the customer inventory regarding entities referencing this customer profile's `integrationId`.  Typical entities returned are: customer profile information, referral codes, loyalty points, loyalty cards and reserved coupons. Reserved coupons also include redeemed coupons. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The integration ID of the customer profile. You can get the `integrationId` of a profile using: - A customer session integration Id with the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. - The Management API with the [List application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 
            var profile = true;  // bool? | Set to `true` to include customer profile information in the response. (optional) 
            var referrals = true;  // bool? | Set to `true` to include referral information in the response. (optional) 
            var coupons = true;  // bool? | Set to `true` to include coupon information in the response. (optional) 
            var loyalty = true;  // bool? | Set to `true` to include loyalty information in the response. (optional) 
            var giveaways = true;  // bool? | Set to `true` to include giveaways information in the response. (optional) 

            try
            {
                // List customer data
                CustomerInventory result = apiInstance.GetCustomerInventory(integrationId, profile, referrals, coupons, loyalty, giveaways);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetCustomerInventory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The integration ID of the customer profile. You can get the &#x60;integrationId&#x60; of a profile using: - A customer session integration Id with the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. - The Management API with the [List application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 
 **profile** | **bool?**| Set to &#x60;true&#x60; to include customer profile information in the response. | [optional] 
 **referrals** | **bool?**| Set to &#x60;true&#x60; to include referral information in the response. | [optional] 
 **coupons** | **bool?**| Set to &#x60;true&#x60; to include coupon information in the response. | [optional] 
 **loyalty** | **bool?**| Set to &#x60;true&#x60; to include loyalty information in the response. | [optional] 
 **giveaways** | **bool?**| Set to &#x60;true&#x60; to include giveaways information in the response. | [optional] 

### Return type

[**CustomerInventory**](CustomerInventory.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomersession"></a>
# **GetCustomerSession**
> IntegrationCustomerSessionResponse GetCustomerSession (string customerSessionId)

Get customer session

Get the details of the given customer session.  You can get the same data via other endpoints that also apply changes, which can help you save requests and increase performance. See:  - [Update customer session](#tag/Customer-sessions/operation/updateCustomerSessionV2) - [Update customer profile](#tag/Customer-profiles/operation/updateCustomerProfileV2) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The `integration ID` of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager's **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint. 

            try
            {
                // Get customer session
                IntegrationCustomerSessionResponse result = apiInstance.GetCustomerSession(customerSessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetCustomerSession: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerSessionId** | **string**| The &#x60;integration ID&#x60; of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager&#39;s **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint.  | 

### Return type

[**IntegrationCustomerSessionResponse**](IntegrationCustomerSessionResponse.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltybalances"></a>
# **GetLoyaltyBalances**
> LoyaltyBalances GetLoyaltyBalances (int loyaltyProgramId, string integrationId, DateTime? endDate = null)

Get customer's loyalty points

Retrieve loyalty ledger balances for the given Integration ID in the specified loyalty program. You can filter balances by date. If no filtering options are applied, you retrieve all loyalty balances on the current date for the given integration ID.  Loyalty balances are calculated when Talon.One receives your request using the points stored in our database, so retrieving a large number of balances at once can impact performance.  **Note:** For more information, see [our documentation on managing loyalty data](https://docs.talon.one/docs/product/loyalty-programs/managing-loyalty-data#obtaining-the-loyalty-balances-of-a-customer). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var integrationId = integrationId_example;  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  (optional) 

            try
            {
                // Get customer's loyalty points
                LoyaltyBalances result = apiInstance.GetLoyaltyBalances(loyaltyProgramId, integrationId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetLoyaltyBalances: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **integrationId** | **string**| The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  | 
 **endDate** | **DateTime?**| Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 

### Return type

[**LoyaltyBalances**](LoyaltyBalances.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycardbalances"></a>
# **GetLoyaltyCardBalances**
> LoyaltyBalances GetLoyaltyCardBalances (int loyaltyProgramId, string loyaltyCardId, DateTime? endDate = null)

Get card's point balances

Retrieve loyalty balances for the given loyalty card in the specified loyalty program with filtering options applied. If no filtering options are applied, all loyalty balances for the given loyalty card are returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  (optional) 

            try
            {
                // Get card's point balances
                LoyaltyBalances result = apiInstance.GetLoyaltyCardBalances(loyaltyProgramId, loyaltyCardId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetLoyaltyCardBalances: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **loyaltyCardId** | **string**| Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  | 
 **endDate** | **DateTime?**| Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 

### Return type

[**LoyaltyBalances**](LoyaltyBalances.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycardtransactions"></a>
# **GetLoyaltyCardTransactions**
> InlineResponse2001 GetLoyaltyCardTransactions (int loyaltyProgramId, string loyaltyCardId, string subledgerId = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, int? skip = null)

List card's transactions

Retrieve loyalty transaction logs for the given loyalty card in the specified loyalty program with filtering options applied. If no filtering options are applied, the last 50 loyalty transactions for the given loyalty card are returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var subledgerId = subledgerId_example;  // string | The ID of the subledger by which we filter the data. (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List card's transactions
                InlineResponse2001 result = apiInstance.GetLoyaltyCardTransactions(loyaltyProgramId, loyaltyCardId, subledgerId, startDate, endDate, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetLoyaltyCardTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **loyaltyCardId** | **string**| Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  | 
 **subledgerId** | **string**| The ID of the subledger by which we filter the data. | [optional] 
 **startDate** | **DateTime?**| Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **endDate** | **DateTime?**| Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltyprogramprofiletransactions"></a>
# **GetLoyaltyProgramProfileTransactions**
> InlineResponse2002 GetLoyaltyProgramProfileTransactions (int loyaltyProgramId, string integrationId, string subledgerId = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, int? skip = null)

List customer's loyalty transactions

Retrieve paginated results of loyalty transaction logs for the given Integration ID in the specified loyalty program.  You can filter transactions by date. If no filters are applied, the last 50 loyalty transactions for the given integration ID are returned.  **Note:** To retrieve all loyalty program transaction logs in a given loyalty program, use the [List loyalty program transactions](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyProgramTransactions) endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramProfileTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var integrationId = integrationId_example;  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var subledgerId = subledgerId_example;  // string | The ID of the subledger by which we filter the data. (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 50)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List customer's loyalty transactions
                InlineResponse2002 result = apiInstance.GetLoyaltyProgramProfileTransactions(loyaltyProgramId, integrationId, subledgerId, startDate, endDate, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetLoyaltyProgramProfileTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **integrationId** | **string**| The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  | 
 **subledgerId** | **string**| The ID of the subledger by which we filter the data. | [optional] 
 **startDate** | **DateTime?**| Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **endDate** | **DateTime?**| Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 50]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservedcustomers"></a>
# **GetReservedCustomers**
> InlineResponse200 GetReservedCustomers (string couponValue)

List customers that have this coupon reserved

Return all customers that have this coupon marked as reserved.  Coupons are reserved in the following ways: - To create a soft reservation (any customer can use the coupon), use the [Create coupon reservation](#operation/createCouponReservation) endpoint. - To create a hard reservation (only the given customer can use the coupon), create a coupon in the Campaign Manager for a given `recipientIntegrationId` or use the [Create coupons](https://docs.talon.one/management-api#operation/createCoupons) or [Create coupons for multiple recipients](https://docs.talon.one/management-api#operation/createCouponsForMultipleRecipients) endpoints. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReservedCustomersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The code of the coupon.

            try
            {
                // List customers that have this coupon reserved
                InlineResponse200 result = apiInstance.GetReservedCustomers(couponValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetReservedCustomers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The code of the coupon. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkloyaltycardtoprofile"></a>
# **LinkLoyaltyCardToProfile**
> LoyaltyCard LinkLoyaltyCardToProfile (int loyaltyProgramId, string loyaltyCardId, LoyaltyCardRegistration body)

Link customer profile to card

[Loyalty cards](https://docs.talon.one/docs/product/loyalty-programs/loyalty-cards/loyalty-card-overview) allow customers to collect and spend loyalty points within a [card-based loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview#loyalty-program-types). They are useful to gamify loyalty programs and can be used with or without customer profiles linked to them.  Link a customer profile to a given loyalty card for the card to be set as **Registered**. This affects how it can be used. See the [docs](https://docs.talon.one/docs/product/loyalty-programs/loyalty-cards/managing-loyalty-cards#linking-customer-profiles-to-a-loyalty-card).  **Note:** You can link as many customer profiles to a given loyalty card as the [**card user limit**](https://docs.talon.one/docs/product/loyalty-programs/creating-loyalty-programs#creating-card-based-loyalty-programs) allows. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class LinkLoyaltyCardToProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var body = new LoyaltyCardRegistration(); // LoyaltyCardRegistration | body

            try
            {
                // Link customer profile to card
                LoyaltyCard result = apiInstance.LinkLoyaltyCardToProfile(loyaltyProgramId, loyaltyCardId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.LinkLoyaltyCardToProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **loyaltyCardId** | **string**| Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  | 
 **body** | [**LoyaltyCardRegistration**](LoyaltyCardRegistration.md)| body | 

### Return type

[**LoyaltyCard**](LoyaltyCard.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reopencustomersession"></a>
# **ReopenCustomerSession**
> ReopenSessionResponse ReopenCustomerSession (string customerSessionId)

Reopen customer session

Reopen a closed [customer session](https://docs.talon.one/docs/dev/concepts/entities#customer-session). For example, if a session has been completed but still needs to be edited, you can reopen it with this endpoint. A reopen session is treated like a standard open session.  When reopening a session: - The `talon_session_reopened` event is triggered. You can see it in the **Events** view in the Campaign Manager. - The session state is updated to `open`. - Modified budgets and triggered effects when the session was closed are rolled back except for the list below.  <details>   <summary><strong>Effects and budgets unimpacted by a session reopening</strong></summary>   <div>     <p>The following effects and budgets are left the way they were once the session was originally closed:</p>     <ul>       <li>Add free item effect</li>       <li>Any <strong>not pending</strong> pending loyalty points.</li>       <li>Award giveaway</li>       <li>Coupon and referral creation</li>       <li>Coupon reservation</li>       <li>Custom effect</li>       <li>Update attribute value</li>       <li>Update cart item attribute value</li>     </ul>   </div> <p>To see an example of roll back, see the <a href=\"https://docs.talon.one/docs/dev/tutorials/rolling-back-effects\">Cancelling a session with campaign budgets tutorial</a>.</p> </details>  **Note:** If your order workflow requires you to create a new session instead of reopening a session, use the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint to cancel a closed session and create a new one. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ReopenCustomerSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The `integration ID` of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager's **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint. 

            try
            {
                // Reopen customer session
                ReopenSessionResponse result = apiInstance.ReopenCustomerSession(customerSessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ReopenCustomerSession: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerSessionId** | **string**| The &#x60;integration ID&#x60; of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager&#39;s **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint.  | 

### Return type

[**ReopenSessionResponse**](ReopenSessionResponse.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returncartitems"></a>
# **ReturnCartItems**
> IntegrationStateV2 ReturnCartItems (string customerSessionId, ReturnIntegrationRequest body, bool? dry = null)

Return cart items

Create a new return request for the specified cart items.  This endpoint automatically changes the session state from `closed` to `partially_returned`.  Its behavior depends on whether [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled for the Application.  **Note:** This will roll back any effects associated with these cart items. For more information, see [our documentation on session states](https://docs.talon.one/docs/dev/concepts/entities#customer-session-states) and [this tutorial](https://docs.talon.one/docs/dev/tutorials/partially-returning-a-session). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ReturnCartItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The `integration ID` of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager's **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint. 
            var body = new ReturnIntegrationRequest(); // ReturnIntegrationRequest | body
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`.  (optional) 

            try
            {
                // Return cart items
                IntegrationStateV2 result = apiInstance.ReturnCartItems(customerSessionId, body, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ReturnCartItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerSessionId** | **string**| The &#x60;integration ID&#x60; of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager&#39;s **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint.  | 
 **body** | [**ReturnIntegrationRequest**](ReturnIntegrationRequest.md)| body | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;.  | [optional] 

### Return type

[**IntegrationStateV2**](IntegrationStateV2.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="synccatalog"></a>
# **SyncCatalog**
> Catalog SyncCatalog (int catalogId, CatalogSyncRequest body)

Sync cart item catalog

Perform one or more of the following sync actions on this cart item catalog, up to 1000 actions:  - Add an item to the catalog. - Edit the attributes of an item in the catalog. - Edit the attributes of more than one item in the catalog. - Remove an item from the catalog. - Remove more than one item from the catalog.  **Note:** For more information, see [our documentation on managing cart item catalogs](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs).  ### Filtering cart items  Use [cart item attributes](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs#displaying-the-details-and-content-of-a-catalog) to filter items and select the ones you want to edit or delete when editing or deleting more than one item at a time.  The `filters` array contains an object with the following properties:  - `attr`: A [cart item attribute](https://docs.talon.one/docs/product/account/dev-tools/managing-attributes)   connected to the catalog. It is applied to all items in the catalog. - `op`: The filtering operator indicating the relationship between the value of each   cart item in the catalog and the value of the `value` property for the attribute selected   in `attr`.    The value of `op` can be one of the following:    - `EQ`: Equal to `value`   - `LT`: Less than `value`   - `LE`: Less than or equal to `value`   - `GT`: Greater than `value`   - `GE`: Greater than or equal to `value`   - `IN`: One of the comma-separated values that `value` is set to.    **Note:** `GE`, `LE`, `GT`, `LT` are for numeric values only.  - `value`: The value of the attribute selected in `attr`.  ### Payload examples  Synchronization actions are sent as `PUT` requests. See the structure for each action:  <details>   <summary><strong>Adding an item to the catalog</strong></summary>   <div>    ```json   {     \"actions\": [       {         \"payload\": {           \"attributes\": {             \"color\": \"Navy blue\",             \"type\": \"shoe\"           },           \"replaceIfExists\": true,           \"sku\": \"SKU1241028\",           \"price\": 100         },         \"type\": \"ADD\"       }     ]   }   ```   </div> </details>  <details>   <summary><strong>Editing the attributes of an item in the catalog</strong></summary>   <div>    ```json   {     \"actions\": [       {         \"payload\": {           \"attributes\": {             \"age\": 11,             \"origin\": \"germany\"           },           \"createIfNotExists\": false,           \"sku\": \"SKU1241028\"         },         \"type\": \"PATCH\"       }     ]   }   ```   </div> </details>  <details>   <summary><strong>Editing the attributes of several items at once</strong></summary>   <div>    ```json   {     \"actions\": [       {         \"payload\": {           \"attributes\": {             \"color\": \"red\"           },           \"filters\": [             {               \"attr\": \"color\",               \"op\": \"EQ\",               \"value\": \"blue\"             }           ]         },         \"type\": \"PATCH_MANY\"       }     ]   }   ```    </div> </details>  <details>   <summary><strong>Removing an item from the catalog</strong></summary>   <div>    ```json   {     \"actions\": [       {         \"payload\": {           \"sku\": \"SKU1241028\"         },         \"type\": \"REMOVE\"       }     ]   }   ```    </div> </details>  <details>   <summary><strong>Removing several items from the catalog at once</strong></summary>   <div>    ```json   {     \"actions\": [       {         \"payload\": {           \"filters\": [             {               \"attr\": \"color\",               \"op\": \"EQ\",               \"value\": \"blue\"             }           ]         },         \"type\": \"REMOVE_MANY\"       }     ]   }   ```   </div> </details>  <details>   <summary><strong>Removing shoes of sizes above 45 from the catalog</strong></summary>   <div>   <p>   Let's imagine that we have a shoe store and we have decided to stop selling   shoes larger than size 45. We can remove from the catalog all the shoes of sizes above 45   with a single action:</p>    ```json   {     \"actions\": [       {         \"payload\": {           \"filters\": [             {               \"attr\": \"size\",               \"op\": \"GT\",               \"value\": \"45\"             }           ]         },         \"type\": \"REMOVE_MANY\"       }     ]   }   ```   </div> </details> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SyncCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var catalogId = 56;  // int | The ID of the catalog. You can find the ID in the Campaign Manager in **Account** > **Tools** > **Cart item catalogs**.
            var body = new CatalogSyncRequest(); // CatalogSyncRequest | body

            try
            {
                // Sync cart item catalog
                Catalog result = apiInstance.SyncCatalog(catalogId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.SyncCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| The ID of the catalog. You can find the ID in the Campaign Manager in **Account** &gt; **Tools** &gt; **Cart item catalogs**. | 
 **body** | [**CatalogSyncRequest**](CatalogSyncRequest.md)| body | 

### Return type

[**Catalog**](Catalog.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackevent"></a>
# **TrackEvent**
> IntegrationState TrackEvent (NewEvent body, bool? dry = null)

Track event

<div class=\"redoc-section\">   <p class=\"title\">Deprecation warning</p>   <p>This endpoint is DEPRECATED and will be sunset on March 31st 2023.   Use <a href=\"https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2\">Track Event V2</a> instead.</p>   <p>See <a href=\"https://docs.talon.one/docs/dev/tutorials/migrating-to-v2\">Migrating to V2</a>.</p> </div>  Triggers a custom event in a customer session. You can then check this event in your rules.  Before using this endpoint, create your event as a custom attribute of type `event`.  An event is always part of a session. If either the profile or the session does not exist, a new empty profile/session is created. If the specified session already exists, it must belong to the same `profileId` or an error will be returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class TrackEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewEvent(); // NewEvent | body
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`.  (optional) 

            try
            {
                // Track event
                IntegrationState result = apiInstance.TrackEvent(body, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.TrackEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewEvent**](NewEvent.md)| body | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;.  | [optional] 

### Return type

[**IntegrationState**](IntegrationState.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **409** | Too many requests - Avoid parallel requests. See the [docs](https://docs.talon.one/docs/dev/tutorials/integrating-talon-one#managing-parallel-requests). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackeventv2"></a>
# **TrackEventV2**
> IntegrationStateV2 TrackEventV2 (IntegrationEventV2Request body, string silent = null, bool? dry = null)

Track event V2

Triggers a custom event. You can build a condition around this event in your rules.  Talon.One offers a set of [built-in events](https://docs.talon.one/docs/dev/concepts/events). Ensure you do not create a custom event when you can use a built-in event.  For example, use this endpoint to trigger an event when a customer shares a link to a product. See the [tutorial](https://docs.talon.one/docs/product/tutorials/referrals/incentivizing-product-link-sharing).  **Important:** - `profileId` is required. An event V2 is associated with a customer profile. - Before using this endpoint, create your event as a custom attribute of type `event`. See the [Developer docs](https://docs.talon.one/docs/dev/concepts/events#creating-a-custom-event).  When you successfully sent an event to Talon.One, you can list received events in the **Events** view in the Campaign Manager. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class TrackEventV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new IntegrationEventV2Request(); // IntegrationEventV2Request | body
            var silent = silent_example;  // string | Possible values: `yes` or `no`. - `yes`: Increases the perfomance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`.  (optional) 

            try
            {
                // Track event V2
                IntegrationStateV2 result = apiInstance.TrackEventV2(body, silent, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.TrackEventV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationEventV2Request**](IntegrationEventV2Request.md)| body | 
 **silent** | **string**| Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the perfomance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;]
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;.  | [optional] 

### Return type

[**IntegrationStateV2**](IntegrationStateV2.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaudiencecustomersattributes"></a>
# **UpdateAudienceCustomersAttributes**
> void UpdateAudienceCustomersAttributes (int audienceId, Object body)

Update profile attributes for all customers in audience

Update the specified profile attributes to the provided values for all customers in the specified audience. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAudienceCustomersAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var audienceId = 56;  // int | The ID of the audience. You get it via the `id` property when [creating an audience](#operation/createAudienceV2).
            var body = ;  // Object | body

            try
            {
                // Update profile attributes for all customers in audience
                apiInstance.UpdateAudienceCustomersAttributes(audienceId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateAudienceCustomersAttributes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceId** | **int**| The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2). | 
 **body** | **Object**| body | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaudiencev2"></a>
# **UpdateAudienceV2**
> Audience UpdateAudienceV2 (int audienceId, UpdateAudience body)

Update audience name

Update the name of the given audience created by a third-party integration. Sending a request to this endpoint does **not** trigger the rule engine.  To update the audience's members, use the [Update customer profile](#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAudienceV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var audienceId = 56;  // int | The ID of the audience. You get it via the `id` property when [creating an audience](#operation/createAudienceV2).
            var body = new UpdateAudience(); // UpdateAudience | body

            try
            {
                // Update audience name
                Audience result = apiInstance.UpdateAudienceV2(audienceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateAudienceV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceId** | **int**| The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2). | 
 **body** | [**UpdateAudience**](UpdateAudience.md)| body | 

### Return type

[**Audience**](Audience.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofileaudiences"></a>
# **UpdateCustomerProfileAudiences**
> void UpdateCustomerProfileAudiences (CustomerProfileAudienceRequest body)

Update multiple customer profiles' audiences

Update the specified customer profiles with the specified audiences. Use this endpoint when customers join or leave audiences.  The limit of customer profiles per request is 1000. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerProfileAudiencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new CustomerProfileAudienceRequest(); // CustomerProfileAudienceRequest | body

            try
            {
                // Update multiple customer profiles' audiences
                apiInstance.UpdateCustomerProfileAudiences(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerProfileAudiences: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerProfileAudienceRequest**](CustomerProfileAudienceRequest.md)| body | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofilev2"></a>
# **UpdateCustomerProfileV2**
> IntegrationStateV2 UpdateCustomerProfileV2 (string integrationId, CustomerProfileIntegrationRequestV2 body, bool? runRuleEngine = null, bool? dry = null)

Update customer profile

Update or create a [Customer Profile](https://docs.talon.one/docs/dev/concepts/entities#customer-profile). This endpoint triggers the Rule Builder.  You can use this endpoint to: - Set attributes on the given customer profile. Ensure you create the attributes in the Campaign Manager, first. - Modify the audience the customer profile is a member of.  <div class=\"redoc-section\">   <p class=\"title\">Performance tips</p>    Updating a customer profile returns a response with the requested integration state.    You can use the `responseContent` property to save yourself extra API calls. For example, you can get   the customer profile details directly without extra requests. </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerProfileV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var body = new CustomerProfileIntegrationRequestV2(); // CustomerProfileIntegrationRequestV2 | body
            var runRuleEngine = true;  // bool? | Indicates whether to run the Rule Engine.  If `true`, the response includes: - The effects generated by the triggered campaigns are returned in the `effects` property. - The created coupons and referral objects.  If `false`: - The rules are not executed and the `effects` property is always empty. - The response time improves. - You cannot use `responseContent` in the body.  (optional)  (default to false)
            var dry = true;  // bool? | (Only works when `runRuleEngine=true`) Indicates whether to persist the changes. Changes are ignored when `dry=true`.  When set to `true`, you can use the `evaluableCampaignIds` body property to select specific campaigns to run.  (optional) 

            try
            {
                // Update customer profile
                IntegrationStateV2 result = apiInstance.UpdateCustomerProfileV2(integrationId, body, runRuleEngine, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerProfileV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  | 
 **body** | [**CustomerProfileIntegrationRequestV2**](CustomerProfileIntegrationRequestV2.md)| body | 
 **runRuleEngine** | **bool?**| Indicates whether to run the Rule Engine.  If &#x60;true&#x60;, the response includes: - The effects generated by the triggered campaigns are returned in the &#x60;effects&#x60; property. - The created coupons and referral objects.  If &#x60;false&#x60;: - The rules are not executed and the &#x60;effects&#x60; property is always empty. - The response time improves. - You cannot use &#x60;responseContent&#x60; in the body.  | [optional] [default to false]
 **dry** | **bool?**| (Only works when &#x60;runRuleEngine&#x3D;true&#x60;) Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;.  When set to &#x60;true&#x60;, you can use the &#x60;evaluableCampaignIds&#x60; body property to select specific campaigns to run.  | [optional] 

### Return type

[**IntegrationStateV2**](IntegrationStateV2.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **409** | Too many requests - Avoid parallel requests. See the [docs](https://docs.talon.one/docs/dev/tutorials/integrating-talon-one#managing-parallel-requests). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofilesv2"></a>
# **UpdateCustomerProfilesV2**
> MultipleCustomerProfileIntegrationResponseV2 UpdateCustomerProfilesV2 (MultipleCustomerProfileIntegrationRequest body, string silent = null)

Update multiple customer profiles

Update (or create) up to 1000 [customer profiles](https://docs.talon.one/docs/dev/concepts/entities#customer-profile) in 1 request.  The `integrationId` must be any identifier that remains stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  A customer profile [can be linked to one or more sessions](https://docs.talon.one/integration-api#tag/Customer-sessions). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerProfilesV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new MultipleCustomerProfileIntegrationRequest(); // MultipleCustomerProfileIntegrationRequest | body
            var silent = silent_example;  // string | Possible values: `yes` or `no`. - `yes`: Increases the perfomance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Update multiple customer profiles
                MultipleCustomerProfileIntegrationResponseV2 result = apiInstance.UpdateCustomerProfilesV2(body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerProfilesV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultipleCustomerProfileIntegrationRequest**](MultipleCustomerProfileIntegrationRequest.md)| body | 
 **silent** | **string**| Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the perfomance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;]

### Return type

[**MultipleCustomerProfileIntegrationResponseV2**](MultipleCustomerProfileIntegrationResponseV2.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomersessionv2"></a>
# **UpdateCustomerSessionV2**
> IntegrationStateV2 UpdateCustomerSessionV2 (string customerSessionId, IntegrationRequest body, bool? dry = null)

Update customer session

Update or create a [customer session](https://docs.talon.one/docs/dev/concepts/entities#customer-session). The endpoint responds with the potential promotion rule [effects](https://docs.talon.one/docs/dev/integration-api/api-effects) that match the current cart. For example, use this endpoint to share the contents of a customer's cart with Talon.One.  **Note:** The currency for the session and the cart items in the session is the currency set for the Application that owns this session.  ### Session management  To use this endpoint, start by learning about [customer sessions](https://docs.talon.one/docs/dev/concepts/entities#customer-session) and their states and refer to the `state` parameter documentation the request body schema docs below.  ### Sessions and customer profiles  - To link a session to a customer profile, set the `profileId` parameter in the request body to a customer profile's `integrationId`. - While you can create an anonymous session with `profileId=\"\"`, we recommend you use a guest ID instead. - A profile can be linked to simultaneous sessions in different Applications. Either:   - Use unique session integration IDs or,   - Use the same session integration ID across all of the Applications.  **Note:** If the specified profile does not exist, an empty profile is **created automatically**. You can update it with [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2).  <div class=\"redoc-section\">   <p class=\"title\">Performance tips</p>    Updating a customer session returns a response with the new integration state. Use the `responseContent` property to save yourself extra API calls.   For example, you can get the customer profile details directly without extra requests. </div>  For more information, see: - The introductory video in [Getting started](https://docs.talon.one/docs/dev/getting-started/overview). - The [integration tutorial](https://docs.talon.one/docs/dev/tutorials/integrating-talon-one). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerSessionV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The `integration ID` of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager's **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint. 
            var body = new IntegrationRequest(); // IntegrationRequest | body
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`.  When set to `true`, you can use the `evaluableCampaignIds` body property to select specific campaigns to run.  (optional) 

            try
            {
                // Update customer session
                IntegrationStateV2 result = apiInstance.UpdateCustomerSessionV2(customerSessionId, body, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerSessionV2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerSessionId** | **string**| The &#x60;integration ID&#x60; of the customer session. You set this ID when you create a customer session.  You can see existing customer session integration IDs in the Campaign Manager&#39;s **Sessions** menu, or via the [List Application session](https://docs.talon.one/management-api#operation/getApplicationSessions) endpoint.  | 
 **body** | [**IntegrationRequest**](IntegrationRequest.md)| body | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;.  When set to &#x60;true&#x60;, you can use the &#x60;evaluableCampaignIds&#x60; body property to select specific campaigns to run.  | [optional] 

### Return type

[**IntegrationStateV2**](IntegrationStateV2.md)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **409** | Too many requests - Avoid parallel requests. See the [docs](https://docs.talon.one/docs/dev/tutorials/integrating-talon-one#managing-parallel-requests). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

