# TalonOne.Api.IntegrationApi

All URIs are relative to *http://your_domain.your_region.talon.one*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponReservation**](IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create a new coupon reservation
[**CreateReferral**](IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create a referral code for an advocate
[**CreateReferralsForMultipleAdvocates**](IntegrationApi.md#createreferralsformultipleadvocates) | **POST** /v1/referrals_for_multiple_advocates | Create referral codes for multiple advocates
[**DeleteCouponReservation**](IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
[**DeleteCustomerData**](IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete the personal data of a customer
[**GetCustomerInventory**](IntegrationApi.md#getcustomerinventory) | **GET** /v1/customer_profiles/{integrationId}/inventory | Get an inventory of all data associated with a specific customer profile
[**GetReservedCustomers**](IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | Get the users that have this coupon reserved
[**TrackEvent**](IntegrationApi.md#trackevent) | **POST** /v1/events | Track an Event
[**UpdateCustomerProfile**](IntegrationApi.md#updatecustomerprofile) | **PUT** /v1/customer_profiles/{integrationId} | Update a Customer Profile V1
[**UpdateCustomerProfileAudiences**](IntegrationApi.md#updatecustomerprofileaudiences) | **POST** /v2/customer_audiences | Update a Customer Profile Audiences
[**UpdateCustomerProfileV2**](IntegrationApi.md#updatecustomerprofilev2) | **PUT** /v2/customer_profiles/{integrationId} | Update a Customer Profile
[**UpdateCustomerProfilesV2**](IntegrationApi.md#updatecustomerprofilesv2) | **PUT** /v2/customer_profiles | Update multiple Customer Profiles
[**UpdateCustomerSession**](IntegrationApi.md#updatecustomersession) | **PUT** /v1/customer_sessions/{customerSessionId} | Update a Customer Session V1
[**UpdateCustomerSessionV2**](IntegrationApi.md#updatecustomersessionv2) | **PUT** /v2/customer_sessions/{customerSessionId} | Update a Customer Session



## CreateCouponReservation

> Coupon CreateCouponReservation (string couponValue, CouponReservations couponReservations)

Create a new coupon reservation

Creates a coupon reservation for all passed customer profiles on this couponID 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var couponValue = couponValue_example;  // string | The value of a coupon
            var couponReservations = new CouponReservations(); // CouponReservations | 

            try
            {
                // Create a new coupon reservation
                Coupon result = apiInstance.CreateCouponReservation(couponValue, couponReservations);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **couponReservations** | [**CouponReservations**](CouponReservations.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateReferral

> Referral CreateReferral (NewReferral newReferral)

Create a referral code for an advocate

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var newReferral = new NewReferral(); // NewReferral | 

            try
            {
                // Create a referral code for an advocate
                Referral result = apiInstance.CreateReferral(newReferral);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **newReferral** | [**NewReferral**](NewReferral.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateReferralsForMultipleAdvocates

> InlineResponse201 CreateReferralsForMultipleAdvocates (NewReferralsForMultipleAdvocates newReferralsForMultipleAdvocates, string silent = null)

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var newReferralsForMultipleAdvocates = new NewReferralsForMultipleAdvocates(); // NewReferralsForMultipleAdvocates | 
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

            try
            {
                // Create referral codes for multiple advocates
                InlineResponse201 result = apiInstance.CreateReferralsForMultipleAdvocates(newReferralsForMultipleAdvocates, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **newReferralsForMultipleAdvocates** | [**NewReferralsForMultipleAdvocates**](NewReferralsForMultipleAdvocates.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCouponReservation

> void DeleteCouponReservation (string couponValue, CouponReservations couponReservations)

Delete coupon reservations

Removes all passed customer profiles reservation from this coupon 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var couponValue = couponValue_example;  // string | The value of a coupon
            var couponReservations = new CouponReservations(); // CouponReservations | 

            try
            {
                // Delete coupon reservations
                apiInstance.DeleteCouponReservation(couponValue, couponReservations);
            }
            catch (ApiException e)
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
 **couponReservations** | [**CouponReservations**](CouponReservations.md)|  | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCustomerData

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.

            try
            {
                // Delete the personal data of a customer
                apiInstance.DeleteCustomerData(integrationId);
            }
            catch (ApiException e)
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCustomerInventory

> CustomerInventory GetCustomerInventory (string integrationId, bool? profile = null, bool? referrals = null, bool? coupons = null, bool? loyalty = null, bool? giveaways = null)

Get an inventory of all data associated with a specific customer profile

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.
            var profile = true;  // bool? | optional flag to decide if you would like customer profile information in the response (optional) 
            var referrals = true;  // bool? | optional flag to decide if you would like referral information in the response (optional) 
            var coupons = true;  // bool? | optional flag to decide if you would like coupon information in the response (optional) 
            var loyalty = true;  // bool? | optional flag to decide if you would like loyalty information in the response (optional) 
            var giveaways = true;  // bool? | optional flag to decide if you would like giveaways information in the response (optional) 

            try
            {
                // Get an inventory of all data associated with a specific customer profile
                CustomerInventory result = apiInstance.GetCustomerInventory(integrationId, profile, referrals, coupons, loyalty, giveaways);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetReservedCustomers

> InlineResponse200 GetReservedCustomers (string couponValue)

Get the users that have this coupon reserved

Returns all users that have this coupon marked as reserved 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var couponValue = couponValue_example;  // string | The value of a coupon

            try
            {
                // Get the users that have this coupon reserved
                InlineResponse200 result = apiInstance.GetReservedCustomers(couponValue);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TrackEvent

> IntegrationState TrackEvent (NewEvent newEvent, bool? dry = null)

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var newEvent = new NewEvent(); // NewEvent | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Track an Event
                IntegrationState result = apiInstance.TrackEvent(newEvent, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **newEvent** | [**NewEvent**](NewEvent.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerProfile

> IntegrationState UpdateCustomerProfile (string integrationId, NewCustomerProfile newCustomerProfile, bool? dry = null)

Update a Customer Profile V1

⚠️ Deprecation Notice: Support for requests to this endpoint will end on 15.07.2021. We will not remove the endpoint, and it will still be accessible for you to use. For new features support, migrate to [API V2.0](/Getting-Started/APIV2).  Update (or create) a [Customer Profile](https://developers.talon.one/Getting-Started/entities#/customer-profile). This profile information can then be matched and/or updated by campaign [Rules][].  The `integrationId` may be any identifier that will remain stable for the customer. For example, you might use a database ID, an email, or a phone number as the `integrationId`. It is vital that this ID **not** change over time, so **don't** use any identifier that the customer can update themselves. E.g. if your application allows a customer to update their e-mail address, you should instead use a database ID.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  [Customer Profile]: /Getting-Started/entities#/customer-profile [Rules]: /Getting-Started/entities#/campaigns-rulesets-and-coupons 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.
            var newCustomerProfile = new NewCustomerProfile(); // NewCustomerProfile | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Update a Customer Profile V1
                IntegrationState result = apiInstance.UpdateCustomerProfile(integrationId, newCustomerProfile, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **newCustomerProfile** | [**NewCustomerProfile**](NewCustomerProfile.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerProfileAudiences

> void UpdateCustomerProfileAudiences (CustomerProfileAudienceRequest customerProfileAudienceRequest)

Update a Customer Profile Audiences

Update one ore multiple Customer Profiles with the specified Audiences 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure HTTP bearer authorization: manager_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationApi(Configuration.Default);
            var customerProfileAudienceRequest = new CustomerProfileAudienceRequest(); // CustomerProfileAudienceRequest | 

            try
            {
                // Update a Customer Profile Audiences
                apiInstance.UpdateCustomerProfileAudiences(customerProfileAudienceRequest);
            }
            catch (ApiException e)
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
 **customerProfileAudienceRequest** | [**CustomerProfileAudienceRequest**](CustomerProfileAudienceRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerProfileV2

> IntegrationStateV2 UpdateCustomerProfileV2 (string integrationId, CustomerProfileIntegrationRequestV2 customerProfileIntegrationRequestV2, bool? runRuleEngine = null, bool? dry = null)

Update a Customer Profile

Update (or create) a [Customer Profile](https://developers.talon.one/Getting-Started/entities#/customer-profile).  The `integrationId` must be any identifier that remains stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Updating a customer profile returns a response with the requested integration state. If `runRuleEngine` is set to `true`, the response includes:  - The effects generated by the triggered campaigns. - The created coupons and referral objects. - Any entity that was requested in the `responseContent` request parameter. 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var integrationId = integrationId_example;  // string | The custom identifier for this profile. Must be unique within the account.
            var customerProfileIntegrationRequestV2 = new CustomerProfileIntegrationRequestV2(); // CustomerProfileIntegrationRequestV2 | 
            var runRuleEngine = true;  // bool? | Indicates whether to run the rule engine. (optional)  (default to false)
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. Only used when `runRuleEngine` is set to `true`.  (optional) 

            try
            {
                // Update a Customer Profile
                IntegrationStateV2 result = apiInstance.UpdateCustomerProfileV2(integrationId, customerProfileIntegrationRequestV2, runRuleEngine, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **customerProfileIntegrationRequestV2** | [**CustomerProfileIntegrationRequestV2**](CustomerProfileIntegrationRequestV2.md)|  | 
 **runRuleEngine** | **bool?**| Indicates whether to run the rule engine. | [optional] [default to false]
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerProfilesV2

> MultipleCustomerProfileIntegrationResponseV2 UpdateCustomerProfilesV2 (MultipleCustomerProfileIntegrationRequest multipleCustomerProfileIntegrationRequest, string silent = null)

Update multiple Customer Profiles

Update (or create) up to 1000 [Customer Profiles](https://developers.talon.one/Getting-Started/entities#/customer-profile) in 1 request.  The `integrationId` must be any identifier that remains stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  A customer profile [can be linked to one or more sessions](https://developers.talon.one/Integration-API/API-Reference#updateCustomerSessionV2). 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var multipleCustomerProfileIntegrationRequest = new MultipleCustomerProfileIntegrationRequest(); // MultipleCustomerProfileIntegrationRequest | 
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

            try
            {
                // Update multiple Customer Profiles
                MultipleCustomerProfileIntegrationResponseV2 result = apiInstance.UpdateCustomerProfilesV2(multipleCustomerProfileIntegrationRequest, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **multipleCustomerProfileIntegrationRequest** | [**MultipleCustomerProfileIntegrationRequest**](MultipleCustomerProfileIntegrationRequest.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerSession

> IntegrationState UpdateCustomerSession (string customerSessionId, NewCustomerSession newCustomerSession, bool? dry = null)

Update a Customer Session V1

⚠️ Deprecation Notice: Support for requests to this endpoint will end on 15.07.2021. We will not remove the endpoint, and it will still be accessible for you to use. For new features support, migrate to [API V2.0](https://developers.talon.one/Getting-Started/APIV2).  Update (or create) a [Customer Session](https://developers.talon.one/Getting-Started/entities#/customer-session). For example, use this endpoint to represent which items are in the customer's cart.  The Talon.One platform supports multiple simultaneous sessions for the same profile. If you have multiple ways of accessing the same application you can either:  - Track multiple independent sessions or, - Use the same session across all of them.  You should share sessions when application access points share other state, such as the user's cart. If two points of access to the application have independent states, for example a user can have different items in their cart across the two) they should use independent customer session ID's.  To link a session to a customer profile, set the `profileId` parameter in the request body to a customer profile's `integrationId`. To track an anonymous session use the empty string (`\"\"`) as the `profileId`. **Note:** You do **not** have to create a customer profile first. If the specified profile does not exist, an empty profile is created automatically.  Updating a customer profile returns a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  The currency for the session and the cart items in the session is the same as that of the application with which the session is associated. 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var customerSessionId = customerSessionId_example;  // string | The custom identifier for this session, must be unique within the account.
            var newCustomerSession = new NewCustomerSession(); // NewCustomerSession | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Update a Customer Session V1
                IntegrationState result = apiInstance.UpdateCustomerSession(customerSessionId, newCustomerSession, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **newCustomerSession** | [**NewCustomerSession**](NewCustomerSession.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCustomerSessionV2

> IntegrationStateV2 UpdateCustomerSessionV2 (string customerSessionId, IntegrationRequest integrationRequest, bool? dry = null)

Update a Customer Session

Update (or create) a [Customer Session](https://developers.talon.one/Getting-Started/entities#/customer-session). For example, use this endpoint to represent which items are in the customer's cart.  The Talon.One platform supports multiple simultaneous sessions for the same profile. If you have multiple ways of accessing the same application you can either:  - Track multiple independent sessions or, - Use the same session across all of them.  You should share sessions when application access points share other state, such as the user's cart. If two points of access to the application have independent states, for example a user can have different items in their cart across the two) they should use independent customer session ID's.  To link a session to a customer profile, set the `profileId` parameter in the request body to a customer profile's `integrationId`. To track an anonymous session use the empty string (`\"\"`) as the `profileId`. **Note:** You do **not** have to create a customer profile first. If the specified profile does not exist, an empty profile is created automatically.  Updating a customer session returns a response with the requested integration state. If `runRuleEngine` is set to `true`, the response includes:  - The effects generated by the triggered campaigns. - The created coupons and referral objects. - Any entity that was requested in the `responseContent` request parameter.  The currency for the session and the cart items in the session is the same as that of the application with which the session is associated. 

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
            Configuration.Default.BasePath = "http://your_domain.your_region.talon.one";
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationApi(Configuration.Default);
            var customerSessionId = customerSessionId_example;  // string | The custom identifier for this session, must be unique within the account.
            var integrationRequest = new IntegrationRequest(); // IntegrationRequest | 
            var dry = true;  // bool? | Indicates whether to persist the changes. Changes are ignored when `dry=true`. (optional) 

            try
            {
                // Update a Customer Session
                IntegrationStateV2 result = apiInstance.UpdateCustomerSessionV2(customerSessionId, integrationRequest, dry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **integrationRequest** | [**IntegrationRequest**](IntegrationRequest.md)|  | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

