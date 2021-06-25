# TalonOne.Api.IntegrationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponReservation**](IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create coupon reservation
[**CreateReferral**](IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create referral code for an advocate
[**CreateReferralsForMultipleAdvocates**](IntegrationApi.md#createreferralsformultipleadvocates) | **POST** /v1/referrals_for_multiple_advocates | Create referral codes for multiple advocates
[**DeleteCouponReservation**](IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
[**DeleteCustomerData**](IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete the personal data of a customer
[**GetCustomerInventory**](IntegrationApi.md#getcustomerinventory) | **GET** /v1/customer_profiles/{integrationId}/inventory | List all data associated with a specific customer profile
[**GetReservedCustomers**](IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | List users that have this coupon reserved
[**TrackEvent**](IntegrationApi.md#trackevent) | **POST** /v1/events | Track an Event
[**UpdateCustomerProfile**](IntegrationApi.md#updatecustomerprofile) | **PUT** /v1/customer_profiles/{integrationId} | Update customer profile V1
[**UpdateCustomerProfileV2**](IntegrationApi.md#updatecustomerprofilev2) | **PUT** /v2/customer_profiles/{integrationId} | Update customer profile
[**UpdateCustomerProfilesV2**](IntegrationApi.md#updatecustomerprofilesv2) | **PUT** /v2/customer_profiles | Update multiple customer profiles
[**UpdateCustomerSession**](IntegrationApi.md#updatecustomersession) | **PUT** /v1/customer_sessions/{customerSessionId} | Update customer session V1
[**UpdateCustomerSessionV2**](IntegrationApi.md#updatecustomersessionv2) | **PUT** /v2/customer_sessions/{customerSessionId} | Update customer session


<a name="createcouponreservation"></a>
# **CreateCouponReservation**
> Coupon CreateCouponReservation (string couponValue, CouponReservations body)

Create coupon reservation

Create a coupon reservation for all passed customer profiles on this couponID. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The value of a coupon
            var body = new CouponReservations(); // CouponReservations | 

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
 **couponValue** | **string**| The value of a coupon | 
 **body** | [**CouponReservations**](CouponReservations.md)|  | 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewReferral(); // NewReferral | 

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
 **body** | [**NewReferral**](NewReferral.md)|  | 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewReferralsForMultipleAdvocates(); // NewReferralsForMultipleAdvocates | 
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

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
 **body** | [**NewReferralsForMultipleAdvocates**](NewReferralsForMultipleAdvocates.md)|  | 
 **silent** | **string**| If set to &#x60;yes&#x60;, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponreservation"></a>
# **DeleteCouponReservation**
> void DeleteCouponReservation (string couponValue, CouponReservations body)

Delete coupon reservations

Remove all passed customer profiles reservation from this coupon. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The value of a coupon
            var body = new CouponReservations(); // CouponReservations | 

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
 **couponValue** | **string**| The value of a coupon | 
 **body** | [**CouponReservations**](CouponReservations.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerdata"></a>
# **DeleteCustomerData**
> void DeleteCustomerData (string integrationId)

Delete the personal data of a customer

Delete all attributes on the customer profile and on entities that reference that customer profile. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.

            try
            {
                // Delete the personal data of a customer
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
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinventory"></a>
# **GetCustomerInventory**
> CustomerInventory GetCustomerInventory (string integrationId, bool? profile = null, bool? referrals = null, bool? coupons = null, bool? loyalty = null, bool? giveaways = null)

List all data associated with a specific customer profile

Get information regarding entities referencing this customer profile's integrationId. Currently we support customer profile information, referral codes and reserved coupons. In the future, this will be expanded with loyalty points.

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.
            var profile = true;  // bool? | optional flag to decide if you would like customer profile information in the response (optional) 
            var referrals = true;  // bool? | optional flag to decide if you would like referral information in the response (optional) 
            var coupons = true;  // bool? | optional flag to decide if you would like coupon information in the response (optional) 
            var loyalty = true;  // bool? | optional flag to decide if you would like loyalty information in the response (optional) 
            var giveaways = true;  // bool? | optional flag to decide if you would like giveaways information in the response (optional) 

            try
            {
                // List all data associated with a specific customer profile
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
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 
 **profile** | **bool?**| optional flag to decide if you would like customer profile information in the response | [optional] 
 **referrals** | **bool?**| optional flag to decide if you would like referral information in the response | [optional] 
 **coupons** | **bool?**| optional flag to decide if you would like coupon information in the response | [optional] 
 **loyalty** | **bool?**| optional flag to decide if you would like loyalty information in the response | [optional] 
 **giveaways** | **bool?**| optional flag to decide if you would like giveaways information in the response | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservedcustomers"></a>
# **GetReservedCustomers**
> InlineResponse200 GetReservedCustomers (string couponValue)

List users that have this coupon reserved

Return all users that have this coupon marked as reserved. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var couponValue = couponValue_example;  // string | The value of a coupon

            try
            {
                // List users that have this coupon reserved
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
 **couponValue** | **string**| The value of a coupon | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackevent"></a>
# **TrackEvent**
> IntegrationState TrackEvent (NewEvent body, bool? dry = null)

Track an Event

Records an arbitrary event in a customer session. For example, an integration might record an event when a user updates their payment information.  The `sessionId` body parameter is required, an event is always part of a session. Much like updating a customer session, if either the profile or the session do not exist, a new empty one will be created. Note that if the specified session already exists, it must belong to the same `profileId` or an error will be returned.  As with customer sessions, you can use an empty string for `profileId` to indicate that this is an anonymous session.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new NewEvent(); // NewEvent | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Track an Event
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
 **body** | [**NewEvent**](NewEvent.md)|  | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofile"></a>
# **UpdateCustomerProfile**
> IntegrationState UpdateCustomerProfile (string integrationId, NewCustomerProfile body, bool? dry = null)

Update customer profile V1

⚠️ Deprecation Notice: Support for requests to this endpoint will end on 15.07.2021. We will not remove the endpoint, and it will still be accessible for you to use. For new features support, migrate to [API V2.0](/docs/dev/getting-started/apiv2).  Update (or create) a [Customer Profile](/docs/dev/concepts/entities#customer-profile). This profile information can then be matched and/or updated by campaign [Rules][].  The `integrationId` may be any identifier that will remain stable for the customer. For example, you might use a database ID, an email, or a phone number as the `integrationId`. It is vital that this ID **not** change over time, so **don't** use any identifier that the customer can update themselves. E.g. if your application allows a customer to update their e-mail address, you should instead use a database ID.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  [Customer Profile]: /Getting-Started/entities#customer-profile [Rules]: /Getting-Started/entities#campaigns-rulesets-and-coupons 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.
            var body = new NewCustomerProfile(); // NewCustomerProfile | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Update customer profile V1
                IntegrationState result = apiInstance.UpdateCustomerProfile(integrationId, body, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerProfile: " + e.Message );
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
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 
 **body** | [**NewCustomerProfile**](NewCustomerProfile.md)|  | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;. | [optional] 

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofilev2"></a>
# **UpdateCustomerProfileV2**
> IntegrationStateV2 UpdateCustomerProfileV2 (string integrationId, CustomerProfileIntegrationRequestV2 body, bool? runRuleEngine = null, bool? dry = null)

Update customer profile

Update (or create) a [Customer Profile](/docs/dev/concepts/entities#customer-profile).  The `integrationId` must be any identifier that remains stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  **Performance tips**  Updating a customer profile returns a response with the requested integration state.  You can use the `responseContent` property to save yourself extra API calls. For example, you can get the customer profile details directly without extra requests.  You can also set `runRuleEngine` to `false` to prevent unwanted rule executions. This allows you to improve response times.  If `runRuleEngine` is set to `true`, the response includes:  - The effects generated by the triggered campaigns. - The created coupons and referral objects. 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile. Must be unique within the account.
            var body = new CustomerProfileIntegrationRequestV2(); // CustomerProfileIntegrationRequestV2 | 
            var runRuleEngine = true;  // bool? | Indicates whether to run the rule engine. Setting this property to `false` improves response times. (optional)  (default to false)
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. Only used when `runRuleEngine` is set to `true`.  (optional) 

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
 **integrationId** | **string**| The custom identifier for this profile. Must be unique within the account. | 
 **body** | [**CustomerProfileIntegrationRequestV2**](CustomerProfileIntegrationRequestV2.md)|  | 
 **runRuleEngine** | **bool?**| Indicates whether to run the rule engine. Setting this property to &#x60;false&#x60; improves response times. | [optional] [default to false]
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;. Only used when &#x60;runRuleEngine&#x60; is set to &#x60;true&#x60;.  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofilesv2"></a>
# **UpdateCustomerProfilesV2**
> MultipleCustomerProfileIntegrationResponseV2 UpdateCustomerProfilesV2 (MultipleCustomerProfileIntegrationRequest body, string silent = null)

Update multiple customer profiles

Update (or create) up to 1000 [customer profiles](/docs/dev/concepts/entities#customer-profile) in 1 request.  The `integrationId` must be any identifier that remains stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  A customer profile [can be linked to one or more sessions](/integration-api/#tag/Customer-sessions). 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var body = new MultipleCustomerProfileIntegrationRequest(); // MultipleCustomerProfileIntegrationRequest | 
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

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
 **body** | [**MultipleCustomerProfileIntegrationRequest**](MultipleCustomerProfileIntegrationRequest.md)|  | 
 **silent** | **string**| If set to &#x60;yes&#x60;, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomersession"></a>
# **UpdateCustomerSession**
> IntegrationState UpdateCustomerSession (string customerSessionId, NewCustomerSession body, bool? dry = null)

Update customer session V1

⚠️ Deprecation Notice: Support for requests to this endpoint will end on 15.07.2021. We will not remove the endpoint, and it will still be accessible for you to use. For new features support, migrate to [API V2.0](/docs/dev/docs/dev/getting-started/apiv2#migrating-to-v2).  Update (or create) a [Customer Session](/docs/dev/concepts/entities#customer-session). For example, use this endpoint to represent which items are in the customer's cart.  The Talon.One platform supports multiple simultaneous sessions for the same profile. If you have multiple ways of accessing the same application you can either:  - Track multiple independent sessions or, - Use the same session across all of them.  You should share sessions when application access points share other state, such as the user's cart. If two points of access to the application have independent states, for example a user can have different items in their cart across the two) they should use independent customer session ID's.  To link a session to a customer profile, set the `profileId` parameter in the request body to a customer profile's `integrationId`. To track an anonymous session use the empty string (`\"\"`) as the `profileId`. **Note:** You do **not** have to create a customer profile first. If the specified profile does not exist, an empty profile is created automatically.  Updating a customer profile returns a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  The currency for the session and the cart items in the session is the same as that of the application with which the session is associated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The custom identifier for this session, must be unique within the account.
            var body = new NewCustomerSession(); // NewCustomerSession | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Update customer session V1
                IntegrationState result = apiInstance.UpdateCustomerSession(customerSessionId, body, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerSession: " + e.Message );
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
 **customerSessionId** | **string**| The custom identifier for this session, must be unique within the account. | 
 **body** | [**NewCustomerSession**](NewCustomerSession.md)|  | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;. | [optional] 

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomersessionv2"></a>
# **UpdateCustomerSessionV2**
> IntegrationStateV2 UpdateCustomerSessionV2 (string customerSessionId, IntegrationRequest body, bool? dry = null)

Update customer session

Update (or create) a [customer session](/docs/dev/concepts/entities#customer-session). For example, use this endpoint to share the content of a customer's cart with Talon.One and to check which promotion rules apply.  **Note:** The currency for the session and the cart items in the session is the same as the Application that owns this session.  **Session management**  The Talon.One platform supports multiple simultaneous sessions for the same profile. If you have multiple ways of accessing the same Application you can either:  - Track multiple independent sessions or, - Use the same session across all of them.  You should share sessions when application access points share other state, such as the user's cart. If two points of access to the application have independent states, for example a user can have different items in their cart across the two) they should use independent customer session ID's.  **Sessions and customer profiles**  To link a session to a customer profile, set the `profileId` parameter in the request body to a customer profile's `integrationId`. To track an anonymous session use the empty string (`\"\"`) as the `profileId`. **Note:** You do **not** have to create a customer profile first. If the specified profile does not exist, an empty profile is created automatically.  **Performance tips**  Updating a customer session returns a response with the requested integration state.  You can use the `responseContent` property to save yourself extra API calls. For example, you can get the customer profile details directly without extra requests.  You can also set `runRuleEngine` to `false` to prevent unwanted rule executions. This allows you to improve response times.  If `runRuleEngine` is set to `true`, the response also includes:  - The effects generated by the triggered campaigns. - The created coupons and referral objects.  See more information and tips about session management in [Entities](/docs/dev/concepts/entities#customer-session). 

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
            config.BasePath = "http://localhost";
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(config);
            var customerSessionId = customerSessionId_example;  // string | The custom identifier for this session, must be unique within the account.
            var body = new IntegrationRequest(); // IntegrationRequest | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

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
 **customerSessionId** | **string**| The custom identifier for this session, must be unique within the account. | 
 **body** | [**IntegrationRequest**](IntegrationRequest.md)|  | 
 **dry** | **bool?**| Indicates whether to persist the changes. Changes are ignored when &#x60;dry&#x3D;true&#x60;. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

