# TalonOne.Api.ManagementApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoyaltyPoints**](ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{programID}/profile/{integrationID}/add_points | Add points in a certain loyalty program for the specified customer
[**CopyCampaignToApplications**](ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into every specified application
[**CreateAdditionalCost**](ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Define a new additional cost
[**CreateAttribute**](ManagementApi.md#createattribute) | **POST** /v1/attributes | Define a new custom attribute
[**CreateCampaign**](ManagementApi.md#createcampaign) | **POST** /v1/applications/{applicationId}/campaigns | Create a Campaign
[**CreateCoupons**](ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create Coupons
[**CreatePasswordRecoveryEmail**](ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset
[**CreateRuleset**](ManagementApi.md#createruleset) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | Create a Ruleset
[**CreateSession**](ManagementApi.md#createsession) | **POST** /v1/sessions | Create a Session
[**DeleteCampaign**](ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete a Campaign
[**DeleteCoupon**](ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete one Coupon
[**DeleteCoupons**](ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete Coupons
[**DeleteReferral**](ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete one Referral
[**DeleteRuleset**](ManagementApi.md#deleteruleset) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Delete a Ruleset
[**GetAccessLogs**](ManagementApi.md#getaccesslogs) | **GET** /v1/applications/{applicationId}/access_logs | Get access logs for application (with total count)
[**GetAccessLogsWithoutTotalCount**](ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for application
[**GetAccount**](ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get Account Details
[**GetAccountAnalytics**](ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get Account Analytics
[**GetAdditionalCost**](ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get an additional cost
[**GetAdditionalCosts**](ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs
[**GetAllAccessLogs**](ManagementApi.md#getallaccesslogs) | **GET** /v1/access_logs | Get all access logs
[**GetAllRoles**](ManagementApi.md#getallroles) | **GET** /v1/roles | Get all roles.
[**GetApplication**](ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application
[**GetApplicationApiHealth**](ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get report of health of application API
[**GetApplicationCustomer**](ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get Application Customer
[**GetApplicationCustomers**](ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List Application Customers
[**GetApplicationCustomersByAttributes**](ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/application_customer_search | Get a list of the customer profiles that match the given attributes (with total count)
[**GetApplicationEventTypes**](ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications Event Types
[**GetApplicationEvents**](ManagementApi.md#getapplicationevents) | **GET** /v1/applications/{applicationId}/events | List Applications Events (with total count)
[**GetApplicationEventsWithoutTotalCount**](ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications Events
[**GetApplicationSession**](ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application Session
[**GetApplicationSessions**](ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application Sessions
[**GetApplications**](ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications
[**GetAttribute**](ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get a custom attribute
[**GetAttributes**](ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes
[**GetCampaign**](ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get a Campaign
[**GetCampaignAnalytics**](ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns
[**GetCampaignByAttributes**](ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | Get a list of all campaigns that match the given attributes
[**GetCampaigns**](ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List your Campaigns
[**GetChanges**](ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit log for an account
[**GetCoupons**](ManagementApi.md#getcoupons) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | List Coupons (with total count)
[**GetCouponsByAttributes**](ManagementApi.md#getcouponsbyattributes) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search | Get a list of the coupons that match the given attributes
[**GetCouponsByAttributesApplicationWide**](ManagementApi.md#getcouponsbyattributesapplicationwide) | **POST** /v1/applications/{applicationId}/coupons_search | Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)
[**GetCouponsWithoutTotalCount**](ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List Coupons
[**GetCustomerActivityReport**](ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get Activity Report for Single Customer
[**GetCustomerActivityReports**](ManagementApi.md#getcustomeractivityreports) | **GET** /v1/applications/{applicationId}/customer_activity_reports | Get Activity Reports for Application Customers (with total count)
[**GetCustomerActivityReportsWithoutTotalCount**](ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers
[**GetCustomerAnalytics**](ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get Analytics Report for a Customer
[**GetCustomerProfile**](ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get Customer Profile
[**GetCustomerProfiles**](ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List Customer Profiles
[**GetCustomersByAttributes**](ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | Get a list of the customer profiles that match the given attributes
[**GetEventTypes**](ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List Event Types
[**GetExports**](ManagementApi.md#getexports) | **GET** /v1/exports | Get Exports
[**GetImports**](ManagementApi.md#getimports) | **GET** /v1/imports | Get Imports
[**GetLoyaltyPoints**](ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{programID}/profile/{integrationID} | get the Loyalty Ledger for this integrationID
[**GetLoyaltyProgram**](ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{programID} | Get a loyalty program
[**GetLoyaltyPrograms**](ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List all loyalty Programs
[**GetReferrals**](ManagementApi.md#getreferrals) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals | List Referrals (with total count)
[**GetReferralsWithoutTotalCount**](ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List Referrals
[**GetRole**](ManagementApi.md#getrole) | **GET** /v1/roles/{roleId} | Get information for the specified role.
[**GetRuleset**](ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get a Ruleset
[**GetRulesets**](ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List Campaign Rulesets
[**GetUser**](ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get a single User
[**GetUsers**](ManagementApi.md#getusers) | **GET** /v1/users | List Users in your account
[**GetWebhook**](ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get Webhook
[**GetWebhookActivationLogs**](ManagementApi.md#getwebhookactivationlogs) | **GET** /v1/webhook_activation_logs | List Webhook activation Log Entries
[**GetWebhookLogs**](ManagementApi.md#getwebhooklogs) | **GET** /v1/webhook_logs | List Webhook Log Entries
[**GetWebhooks**](ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List Webhooks
[**RemoveLoyaltyPoints**](ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{programID}/profile/{integrationID}/deduct_points | Deduct points in a certain loyalty program for the specified customer
[**ResetPassword**](ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password
[**SearchCouponsAdvanced**](ManagementApi.md#searchcouponsadvanced) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced | Get a list of the coupons that match the given attributes (with total count)
[**SearchCouponsAdvancedApplicationWide**](ManagementApi.md#searchcouponsadvancedapplicationwide) | **POST** /v1/applications/{applicationId}/coupons_search_advanced | Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)
[**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | Get a list of the coupons that match the given attributes in all active campaigns of an application
[**SearchCouponsAdvancedWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | Get a list of the coupons that match the given attributes
[**UpdateAdditionalCost**](ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update an additional cost
[**UpdateAttribute**](ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update a custom attribute
[**UpdateCampaign**](ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update a Campaign
[**UpdateCoupon**](ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update a Coupon
[**UpdateCouponBatch**](ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update a Batch of Coupons
[**UpdateRuleset**](ManagementApi.md#updateruleset) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Update a Ruleset



## AddLoyaltyPoints

> void AddLoyaltyPoints (string programID, string integrationID, LoyaltyPoints body)

Add points in a certain loyalty program for the specified customer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class AddLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var programID = programID_example;  // string | 
            var integrationID = integrationID_example;  // string | 
            var body = new LoyaltyPoints(); // LoyaltyPoints | 

            try
            {
                // Add points in a certain loyalty program for the specified customer
                apiInstance.AddLoyaltyPoints(programID, integrationID, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.AddLoyaltyPoints: " + e.Message );
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
 **programID** | **string**|  | 
 **integrationID** | **string**|  | 
 **body** | [**LoyaltyPoints**](LoyaltyPoints.md)|  | 

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


## CopyCampaignToApplications

> InlineResponse2002 CopyCampaignToApplications (int applicationId, int campaignId, CampaignCopy body)

Copy the campaign into every specified application

Copy the campaign into every specified application.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CopyCampaignToApplicationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new CampaignCopy(); // CampaignCopy | 

            try
            {
                // Copy the campaign into every specified application
                InlineResponse2002 result = apiInstance.CopyCampaignToApplications(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CopyCampaignToApplications: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**CampaignCopy**](CampaignCopy.md)|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## CreateAdditionalCost

> AccountAdditionalCost CreateAdditionalCost (NewAdditionalCost body)

Define a new additional cost

Defines a new _additional cost_ in this account.  These additional costs are shared across all applications in your account, and are never required. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAdditionalCostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new NewAdditionalCost(); // NewAdditionalCost | 

            try
            {
                // Define a new additional cost
                AccountAdditionalCost result = apiInstance.CreateAdditionalCost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAdditionalCost: " + e.Message );
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
 **body** | [**NewAdditionalCost**](NewAdditionalCost.md)|  | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## CreateAttribute

> Attribute CreateAttribute (NewAttribute body)

Define a new custom attribute

Defines a new _custom attribute_ in this account. Custom attributes allow you to attach new fields to Talon.One domain objects like campaigns, coupons, customers and so on. These attributes can then be given values when creating / updating these objects, and these values can be used in your campaign rules. For example, you could define a `zipCode` field for customer sessions, and add a rule to your campaign that only allows certain ZIP codes.  These attributes are shared across all applications in your account, and are never required. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAttributeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new NewAttribute(); // NewAttribute | 

            try
            {
                // Define a new custom attribute
                Attribute result = apiInstance.CreateAttribute(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAttribute: " + e.Message );
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
 **body** | [**NewAttribute**](NewAttribute.md)|  | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## CreateCampaign

> Campaign CreateCampaign (int applicationId, NewCampaign body)

Create a Campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = new NewCampaign(); // NewCampaign | 

            try
            {
                // Create a Campaign
                Campaign result = apiInstance.CreateCampaign(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCampaign: " + e.Message );
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
 **applicationId** | **int**|  | 
 **body** | [**NewCampaign**](NewCampaign.md)|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## CreateCoupons

> InlineResponse2004 CreateCoupons (int applicationId, int campaignId, NewCoupons body, string silent = null)

Create Coupons

Create coupons according to some pattern. Up to 20.000 coupons can be created without a unique prefix. When a unique prefix is provided, up to 200.000 coupons can be created.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new NewCoupons(); // NewCoupons | 
            var silent = silent_example;  // string | If set to 'yes', response will be an empty 204, otherwise a list of the coupons generated (to to 1000). (optional) 

            try
            {
                // Create Coupons
                InlineResponse2004 result = apiInstance.CreateCoupons(applicationId, campaignId, body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCoupons: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**NewCoupons**](NewCoupons.md)|  | 
 **silent** | **string**| If set to &#39;yes&#39;, response will be an empty 204, otherwise a list of the coupons generated (to to 1000). | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePasswordRecoveryEmail

> NewPasswordEmail CreatePasswordRecoveryEmail (NewPasswordEmail body)

Request a password reset

Sends an email with a password recovery link to the email of an existing account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreatePasswordRecoveryEmailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new NewPasswordEmail(); // NewPasswordEmail | 

            try
            {
                // Request a password reset
                NewPasswordEmail result = apiInstance.CreatePasswordRecoveryEmail(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreatePasswordRecoveryEmail: " + e.Message );
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
 **body** | [**NewPasswordEmail**](NewPasswordEmail.md)|  | 

### Return type

[**NewPasswordEmail**](NewPasswordEmail.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateRuleset

> Ruleset CreateRuleset (int applicationId, int campaignId, NewRuleset body)

Create a Ruleset

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateRulesetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new NewRuleset(); // NewRuleset | 

            try
            {
                // Create a Ruleset
                Ruleset result = apiInstance.CreateRuleset(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateRuleset: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**NewRuleset**](NewRuleset.md)|  | 

### Return type

[**Ruleset**](Ruleset.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## CreateSession

> Session CreateSession (LoginParams body)

Create a Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new LoginParams(); // LoginParams | 

            try
            {
                // Create a Session
                Session result = apiInstance.CreateSession(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateSession: " + e.Message );
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
 **body** | [**LoginParams**](LoginParams.md)|  | 

### Return type

[**Session**](Session.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## DeleteCampaign

> void DeleteCampaign (int applicationId, int campaignId)

Delete a Campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 

            try
            {
                // Delete a Campaign
                apiInstance.DeleteCampaign(applicationId, campaignId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCampaign: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## DeleteCoupon

> void DeleteCoupon (int applicationId, int campaignId, string couponId)

Delete one Coupon

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var couponId = couponId_example;  // string | The ID of the coupon code to delete

            try
            {
                // Delete one Coupon
                apiInstance.DeleteCoupon(applicationId, campaignId, couponId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCoupon: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **couponId** | **string**| The ID of the coupon code to delete | 

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## DeleteCoupons

> void DeleteCoupons (int applicationId, int campaignId, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, DateTime startsAfter = null, DateTime startsBefore = null, DateTime expiresAfter = null, DateTime expiresBefore = null, string valid = null, string batchId = null, string usable = null, int referralId = null, string recipientIntegrationId = null, bool exactMatch = null)

Delete Coupons

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var startsAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var startsBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var expiresAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var expiresBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // Delete Coupons
                apiInstance.DeleteCoupons(applicationId, campaignId, value, createdBefore, createdAfter, startsAfter, startsBefore, expiresAfter, expiresBefore, valid, batchId, usable, referralId, recipientIntegrationId, exactMatch);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCoupons: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **startsAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **startsBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **expiresAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **expiresBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## DeleteReferral

> void DeleteReferral (int applicationId, int campaignId, string referralId)

Delete one Referral

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteReferralExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var referralId = referralId_example;  // string | The ID of the referral code to delete

            try
            {
                // Delete one Referral
                apiInstance.DeleteReferral(applicationId, campaignId, referralId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteReferral: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **referralId** | **string**| The ID of the referral code to delete | 

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## DeleteRuleset

> void DeleteRuleset (int applicationId, int campaignId, int rulesetId)

Delete a Ruleset

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteRulesetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var rulesetId = 56;  // int | 

            try
            {
                // Delete a Ruleset
                apiInstance.DeleteRuleset(applicationId, campaignId, rulesetId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteRuleset: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **rulesetId** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAccessLogs

> InlineResponse2009 GetAccessLogs (int applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int pageSize = null, int skip = null, string sort = null)

Get access logs for application (with total count)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccessLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var path = path_example;  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = method_example;  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get access logs for application (with total count)
                InlineResponse2009 result = apiInstance.GetAccessLogs(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccessLogs: " + e.Message );
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
 **applicationId** | **int**|  | 
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **path** | **string**| Only return results where the request path matches the given regular expression. | [optional] 
 **method** | **string**| Only return results where the request method matches the given regular expression. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAccessLogsWithoutTotalCount

> InlineResponse20010 GetAccessLogsWithoutTotalCount (int applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int pageSize = null, int skip = null, string sort = null)

Get access logs for application

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccessLogsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var path = path_example;  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = method_example;  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get access logs for application
                InlineResponse20010 result = apiInstance.GetAccessLogsWithoutTotalCount(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccessLogsWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **path** | **string**| Only return results where the request path matches the given regular expression. | [optional] 
 **method** | **string**| Only return results where the request method matches the given regular expression. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAccount

> Account GetAccount (int accountId)

Get Account Details

Return the details of your companies Talon.One account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var accountId = 56;  // int | 

            try
            {
                // Get Account Details
                Account result = apiInstance.GetAccount(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccount: " + e.Message );
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
 **accountId** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAccountAnalytics

> AccountAnalytics GetAccountAnalytics (int accountId)

Get Account Analytics

Return the analytics of your companies Talon.One account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountAnalyticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var accountId = 56;  // int | 

            try
            {
                // Get Account Analytics
                AccountAnalytics result = apiInstance.GetAccountAnalytics(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccountAnalytics: " + e.Message );
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
 **accountId** | **int**|  | 

### Return type

[**AccountAnalytics**](AccountAnalytics.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAdditionalCost

> AccountAdditionalCost GetAdditionalCost (int additionalCostId)

Get an additional cost

Returns additional cost for the account by its id. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAdditionalCostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var additionalCostId = 56;  // int | 

            try
            {
                // Get an additional cost
                AccountAdditionalCost result = apiInstance.GetAdditionalCost(additionalCostId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAdditionalCost: " + e.Message );
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
 **additionalCostId** | **int**|  | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAdditionalCosts

> InlineResponse20021 GetAdditionalCosts (int pageSize = null, int skip = null, string sort = null)

List additional costs

Returns all the defined additional costs for the account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAdditionalCostsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List additional costs
                InlineResponse20021 result = apiInstance.GetAdditionalCosts(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAdditionalCosts: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAllAccessLogs

> InlineResponse2009 GetAllAccessLogs (DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int pageSize = null, int skip = null, string sort = null)

Get all access logs

Fetches the access logs for the entire account. Sensitive requests (logins) are _always_ filtered from the logs. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAllAccessLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var path = path_example;  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = method_example;  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get all access logs
                InlineResponse2009 result = apiInstance.GetAllAccessLogs(rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAllAccessLogs: " + e.Message );
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **path** | **string**| Only return results where the request path matches the given regular expression. | [optional] 
 **method** | **string**| Only return results where the request method matches the given regular expression. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAllRoles

> InlineResponse20030 GetAllRoles ()

Get all roles.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAllRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);

            try
            {
                // Get all roles.
                InlineResponse20030 result = apiInstance.GetAllRoles();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAllRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplication

> Application GetApplication (int applicationId)

Get Application

Get the application specified by the ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 

            try
            {
                // Get Application
                Application result = apiInstance.GetApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplication: " + e.Message );
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
 **applicationId** | **int**|  | 

### Return type

[**Application**](Application.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationApiHealth

> ApplicationApiHealth GetApplicationApiHealth (int applicationId)

Get report of health of application API

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationApiHealthExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 

            try
            {
                // Get report of health of application API
                ApplicationApiHealth result = apiInstance.GetApplicationApiHealth(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationApiHealth: " + e.Message );
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
 **applicationId** | **int**|  | 

### Return type

[**ApplicationApiHealth**](ApplicationApiHealth.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationCustomer

> ApplicationCustomer GetApplicationCustomer (int applicationId, int customerId)

Get Application Customer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var customerId = 56;  // int | 

            try
            {
                // Get Application Customer
                ApplicationCustomer result = apiInstance.GetApplicationCustomer(applicationId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomer: " + e.Message );
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
 **applicationId** | **int**|  | 
 **customerId** | **int**|  | 

### Return type

[**ApplicationCustomer**](ApplicationCustomer.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationCustomers

> InlineResponse20012 GetApplicationCustomers (int applicationId)

List Application Customers

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 

            try
            {
                // List Application Customers
                InlineResponse20012 result = apiInstance.GetApplicationCustomers(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomers: " + e.Message );
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
 **applicationId** | **int**|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationCustomersByAttributes

> InlineResponse20013 GetApplicationCustomersByAttributes (ApplicationCustomerSearch body)

Get a list of the customer profiles that match the given attributes (with total count)

Gets a list of all the customer profiles for the account that exactly match a set of attributes.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request.  [Customer Profile]: https://help.talon.one/hc/en-us/articles/360005130739-Data-Model#CustomerProfile 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomersByAttributesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new ApplicationCustomerSearch(); // ApplicationCustomerSearch | 

            try
            {
                // Get a list of the customer profiles that match the given attributes (with total count)
                InlineResponse20013 result = apiInstance.GetApplicationCustomersByAttributes(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomersByAttributes: " + e.Message );
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
 **body** | [**ApplicationCustomerSearch**](ApplicationCustomerSearch.md)|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[integration_auth](../README.md#integration_auth)

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


## GetApplicationEventTypes

> InlineResponse20019 GetApplicationEventTypes (int applicationId, int pageSize = null, int skip = null, string sort = null)

List Applications Event Types

Get all of the distinct values of the Event `type` property for events recorded in the application.  See also: [Track an event](/integration-api/reference/#trackEvent) 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationEventTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Applications Event Types
                InlineResponse20019 result = apiInstance.GetApplicationEventTypes(applicationId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationEventTypes: " + e.Message );
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
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationEvents

> InlineResponse20017 GetApplicationEvents (int applicationId, int pageSize = null, int skip = null, string sort = null, string type = null, DateTime createdBefore = null, DateTime createdAfter = null, string session = null, string profile = null, string customerName = null, string customerEmail = null, string couponCode = null, string referralCode = null, string ruleQuery = null, string campaignQuery = null)

List Applications Events (with total count)

Lists all events recorded for an application. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var type = type_example;  // string | Comma-separated list of types by which to filter events. Must be exact match(es). (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Only return events created before this date (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Only return events created after this date (optional) 
            var session = session_example;  // string | Session integration ID filter for events. Must be exact match. (optional) 
            var profile = profile_example;  // string | Profile integration ID filter for events. Must be exact match. (optional) 
            var customerName = customerName_example;  // string | Customer name filter for events. Will match substrings case-insensitively. (optional) 
            var customerEmail = customerEmail_example;  // string | Customer e-mail address filter for events. Will match substrings case-insensitively. (optional) 
            var couponCode = couponCode_example;  // string | Coupon code (optional) 
            var referralCode = referralCode_example;  // string | Referral code (optional) 
            var ruleQuery = ruleQuery_example;  // string | Rule name filter for events (optional) 
            var campaignQuery = campaignQuery_example;  // string | Campaign name filter for events (optional) 

            try
            {
                // List Applications Events (with total count)
                InlineResponse20017 result = apiInstance.GetApplicationEvents(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationEvents: " + e.Message );
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
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **type** | **string**| Comma-separated list of types by which to filter events. Must be exact match(es). | [optional] 
 **createdBefore** | **DateTime**| Only return events created before this date | [optional] 
 **createdAfter** | **DateTime**| Only return events created after this date | [optional] 
 **session** | **string**| Session integration ID filter for events. Must be exact match. | [optional] 
 **profile** | **string**| Profile integration ID filter for events. Must be exact match. | [optional] 
 **customerName** | **string**| Customer name filter for events. Will match substrings case-insensitively. | [optional] 
 **customerEmail** | **string**| Customer e-mail address filter for events. Will match substrings case-insensitively. | [optional] 
 **couponCode** | **string**| Coupon code | [optional] 
 **referralCode** | **string**| Referral code | [optional] 
 **ruleQuery** | **string**| Rule name filter for events | [optional] 
 **campaignQuery** | **string**| Campaign name filter for events | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationEventsWithoutTotalCount

> InlineResponse20018 GetApplicationEventsWithoutTotalCount (int applicationId, int pageSize = null, int skip = null, string sort = null, string type = null, DateTime createdBefore = null, DateTime createdAfter = null, string session = null, string profile = null, string customerName = null, string customerEmail = null, string couponCode = null, string referralCode = null, string ruleQuery = null, string campaignQuery = null)

List Applications Events

Lists all events recorded for an application. Instead of having the total number of results in the response, this endpoint only if there are more results. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationEventsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var type = type_example;  // string | Comma-separated list of types by which to filter events. Must be exact match(es). (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Only return events created before this date (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Only return events created after this date (optional) 
            var session = session_example;  // string | Session integration ID filter for events. Must be exact match. (optional) 
            var profile = profile_example;  // string | Profile integration ID filter for events. Must be exact match. (optional) 
            var customerName = customerName_example;  // string | Customer name filter for events. Will match substrings case-insensitively. (optional) 
            var customerEmail = customerEmail_example;  // string | Customer e-mail address filter for events. Will match substrings case-insensitively. (optional) 
            var couponCode = couponCode_example;  // string | Coupon code (optional) 
            var referralCode = referralCode_example;  // string | Referral code (optional) 
            var ruleQuery = ruleQuery_example;  // string | Rule name filter for events (optional) 
            var campaignQuery = campaignQuery_example;  // string | Campaign name filter for events (optional) 

            try
            {
                // List Applications Events
                InlineResponse20018 result = apiInstance.GetApplicationEventsWithoutTotalCount(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationEventsWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **type** | **string**| Comma-separated list of types by which to filter events. Must be exact match(es). | [optional] 
 **createdBefore** | **DateTime**| Only return events created before this date | [optional] 
 **createdAfter** | **DateTime**| Only return events created after this date | [optional] 
 **session** | **string**| Session integration ID filter for events. Must be exact match. | [optional] 
 **profile** | **string**| Profile integration ID filter for events. Must be exact match. | [optional] 
 **customerName** | **string**| Customer name filter for events. Will match substrings case-insensitively. | [optional] 
 **customerEmail** | **string**| Customer e-mail address filter for events. Will match substrings case-insensitively. | [optional] 
 **couponCode** | **string**| Coupon code | [optional] 
 **referralCode** | **string**| Referral code | [optional] 
 **ruleQuery** | **string**| Rule name filter for events | [optional] 
 **campaignQuery** | **string**| Campaign name filter for events | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationSession

> ApplicationSession GetApplicationSession (int applicationId, int sessionId)

Get Application Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var sessionId = 56;  // int | 

            try
            {
                // Get Application Session
                ApplicationSession result = apiInstance.GetApplicationSession(applicationId, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationSession: " + e.Message );
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
 **applicationId** | **int**|  | 
 **sessionId** | **int**|  | 

### Return type

[**ApplicationSession**](ApplicationSession.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplicationSessions

> InlineResponse20016 GetApplicationSessions (int applicationId, int pageSize = null, int skip = null, string sort = null, string profile = null, string state = null, string coupon = null, string referral = null, string integrationId = null, string customerId = null)

List Application Sessions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationSessionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var profile = profile_example;  // string | Profile integration ID filter for sessions. Must be exact match. (optional) 
            var state = state_example;  // string | Filter by sessions with this state. Must be exact match. (optional) 
            var coupon = coupon_example;  // string | Filter by sessions with this coupon. Must be exact match. (optional) 
            var referral = referral_example;  // string | Filter by sessions with this referral. Must be exact match. (optional) 
            var integrationId = integrationId_example;  // string | Filter by sessions with this integrationId. Must be exact match. (optional) 
            var customerId = customerId_example;  // string | Filter by integration ID of the customer for the session (optional) 

            try
            {
                // List Application Sessions
                InlineResponse20016 result = apiInstance.GetApplicationSessions(applicationId, pageSize, skip, sort, profile, state, coupon, referral, integrationId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationSessions: " + e.Message );
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
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **profile** | **string**| Profile integration ID filter for sessions. Must be exact match. | [optional] 
 **state** | **string**| Filter by sessions with this state. Must be exact match. | [optional] 
 **coupon** | **string**| Filter by sessions with this coupon. Must be exact match. | [optional] 
 **referral** | **string**| Filter by sessions with this referral. Must be exact match. | [optional] 
 **integrationId** | **string**| Filter by sessions with this integrationId. Must be exact match. | [optional] 
 **customerId** | **string**| Filter by integration ID of the customer for the session | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetApplications

> InlineResponse2001 GetApplications (int pageSize = null, int skip = null, string sort = null)

List Applications

List all application in the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Applications
                InlineResponse2001 result = apiInstance.GetApplications(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplications: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAttribute

> Attribute GetAttribute (int attributeId)

Get a custom attribute

Returns custom attribute for the account by its id. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAttributeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var attributeId = 56;  // int | 

            try
            {
                // Get a custom attribute
                Attribute result = apiInstance.GetAttribute(attributeId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAttribute: " + e.Message );
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
 **attributeId** | **int**|  | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetAttributes

> InlineResponse20020 GetAttributes (int pageSize = null, int skip = null, string sort = null)

List custom attributes

Returns all the defined custom attributes for the account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAttributesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List custom attributes
                InlineResponse20020 result = apiInstance.GetAttributes(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAttributes: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCampaign

> Campaign GetCampaign (int applicationId, int campaignId)

Get a Campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 

            try
            {
                // Get a Campaign
                Campaign result = apiInstance.GetCampaign(applicationId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaign: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCampaignAnalytics

> InlineResponse20011 GetCampaignAnalytics (int applicationId, int campaignId, DateTime rangeStart, DateTime rangeEnd, string granularity = null)

Get analytics of campaigns

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignAnalyticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var granularity = granularity_example;  // string | The time interval between the results in the returned time-series. (optional) 

            try
            {
                // Get analytics of campaigns
                InlineResponse20011 result = apiInstance.GetCampaignAnalytics(applicationId, campaignId, rangeStart, rangeEnd, granularity);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignAnalytics: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **granularity** | **string**| The time interval between the results in the returned time-series. | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCampaignByAttributes

> InlineResponse2002 GetCampaignByAttributes (int applicationId, CampaignSearch body, int pageSize = null, int skip = null, string sort = null, string campaignState = null)

Get a list of all campaigns that match the given attributes

Gets a list of all the campaigns that exactly match a set of attributes. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignByAttributesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = new CampaignSearch(); // CampaignSearch | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // Get a list of all campaigns that match the given attributes
                InlineResponse2002 result = apiInstance.GetCampaignByAttributes(applicationId, body, pageSize, skip, sort, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignByAttributes: " + e.Message );
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
 **applicationId** | **int**|  | 
 **body** | [**CampaignSearch**](CampaignSearch.md)|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCampaigns

> InlineResponse2002 GetCampaigns (int applicationId, int pageSize = null, int skip = null, string sort = null, string campaignState = null, string name = null, string tags = null, DateTime createdBefore = null, DateTime createdAfter = null)

List your Campaigns

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 
            var name = name_example;  // string | Filter results performing case-insensitive matching against the name of the campaign. (optional) 
            var tags = tags_example;  // string | Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values  (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. (optional) 

            try
            {
                // List your Campaigns
                InlineResponse2002 result = apiInstance.GetCampaigns(applicationId, pageSize, skip, sort, campaignState, name, tags, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaigns: " + e.Message );
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
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 
 **name** | **string**| Filter results performing case-insensitive matching against the name of the campaign. | [optional] 
 **tags** | **string**| Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values  | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetChanges

> InlineResponse20027 GetChanges (int pageSize = null, int skip = null, string sort = null, int applicationId = null, DateTime createdBefore = null, DateTime createdAfter = null, bool withTotalResultSize = null, bool includeOld = null)

Get audit log for an account

Get list of changes caused by API calls for an account. Only accessible for admins.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetChangesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var applicationId = 56;  // int |  (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, hasMore will be be true whenever there is a next page. totalResultSize will always be zero. With this flag set to false, hasMore will always be set to false. totalResultSize will contain the total number of results for this query.  (optional) 
            var includeOld = true;  // bool | When this flag is set to false, the state without the change will not be returned. The default value is true. (optional) 

            try
            {
                // Get audit log for an account
                InlineResponse20027 result = apiInstance.GetChanges(pageSize, skip, sort, applicationId, createdBefore, createdAfter, withTotalResultSize, includeOld);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetChanges: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **applicationId** | **int**|  | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. | [optional] 
 **withTotalResultSize** | **bool**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, hasMore will be be true whenever there is a next page. totalResultSize will always be zero. With this flag set to false, hasMore will always be set to false. totalResultSize will contain the total number of results for this query.  | [optional] 
 **includeOld** | **bool**| When this flag is set to false, the state without the change will not be returned. The default value is true. | [optional] 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCoupons

> InlineResponse2004 GetCoupons (int applicationId, int campaignId, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, DateTime startsAfter = null, DateTime startsBefore = null, DateTime expiresAfter = null, DateTime expiresBefore = null, string valid = null, string batchId = null, string usable = null, int referralId = null, string recipientIntegrationId = null, bool exactMatch = null)

List Coupons (with total count)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCouponsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var startsAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var startsBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var expiresAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var expiresBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // List Coupons (with total count)
                InlineResponse2004 result = apiInstance.GetCoupons(applicationId, campaignId, pageSize, skip, sort, value, createdBefore, createdAfter, startsAfter, startsBefore, expiresAfter, expiresBefore, valid, batchId, usable, referralId, recipientIntegrationId, exactMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCoupons: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **startsAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **startsBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **expiresAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **expiresBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCouponsByAttributes

> InlineResponse2004 GetCouponsByAttributes (int applicationId, int campaignId, CouponSearch body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, bool exactMatch = null, string batchId = null)

Get a list of the coupons that match the given attributes

Gets a list of all the coupons that exactly match a set of attributes.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCouponsByAttributesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new CouponSearch(); // CouponSearch | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes
                InlineResponse2004 result = apiInstance.GetCouponsByAttributes(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCouponsByAttributes: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**CouponSearch**](CouponSearch.md)|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **batchId** | **string**| Filter results by batches of coupons | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCouponsByAttributesApplicationWide

> InlineResponse2004 GetCouponsByAttributesApplicationWide (int applicationId, CouponSearch body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, string campaignState = null)

Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)

Gets a list of all the coupons with attributes matching the query criteria Application wide 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCouponsByAttributesApplicationWideExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = new CouponSearch(); // CouponSearch | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)
                InlineResponse2004 result = apiInstance.GetCouponsByAttributesApplicationWide(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCouponsByAttributesApplicationWide: " + e.Message );
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
 **applicationId** | **int**|  | 
 **body** | [**CouponSearch**](CouponSearch.md)|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCouponsWithoutTotalCount

> InlineResponse2005 GetCouponsWithoutTotalCount (int applicationId, int campaignId, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null)

List Coupons

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCouponsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // List Coupons
                InlineResponse2005 result = apiInstance.GetCouponsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCouponsWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerActivityReport

> CustomerActivityReport GetCustomerActivityReport (DateTime rangeStart, DateTime rangeEnd, int applicationId, int customerId, int pageSize = null, int skip = null)

Get Activity Report for Single Customer

Fetch summary report for single application customer based on a time range

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerActivityReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var applicationId = 56;  // int | 
            var customerId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get Activity Report for Single Customer
                CustomerActivityReport result = apiInstance.GetCustomerActivityReport(rangeStart, rangeEnd, applicationId, customerId, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReport: " + e.Message );
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **applicationId** | **int**|  | 
 **customerId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**CustomerActivityReport**](CustomerActivityReport.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerActivityReports

> InlineResponse20014 GetCustomerActivityReports (DateTime rangeStart, DateTime rangeEnd, int applicationId, int pageSize = null, int skip = null, string sort = null, string name = null, string integrationId = null, string campaignName = null, string advocateName = null)

Get Activity Reports for Application Customers (with total count)

Fetch summary reports for all application customers based on a time range

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerActivityReportsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var name = name_example;  // string | Only return reports matching the customer name (optional) 
            var integrationId = integrationId_example;  // string | Only return reports matching the integrationId (optional) 
            var campaignName = campaignName_example;  // string | Only return reports matching the campaignName (optional) 
            var advocateName = advocateName_example;  // string | Only return reports matching the current customer referrer name (optional) 

            try
            {
                // Get Activity Reports for Application Customers (with total count)
                InlineResponse20014 result = apiInstance.GetCustomerActivityReports(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReports: " + e.Message );
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **name** | **string**| Only return reports matching the customer name | [optional] 
 **integrationId** | **string**| Only return reports matching the integrationId | [optional] 
 **campaignName** | **string**| Only return reports matching the campaignName | [optional] 
 **advocateName** | **string**| Only return reports matching the current customer referrer name | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerActivityReportsWithoutTotalCount

> InlineResponse20015 GetCustomerActivityReportsWithoutTotalCount (DateTime rangeStart, DateTime rangeEnd, int applicationId, int pageSize = null, int skip = null, string sort = null, string name = null, string integrationId = null, string campaignName = null, string advocateName = null)

Get Activity Reports for Application Customers

Fetch summary reports for all application customers based on a time range. Instead of having the total number of results in the response, this endpoint only if there are more results.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerActivityReportsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp, must be an RFC3339 timestamp string
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp, must be an RFC3339 timestamp string
            var applicationId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var name = name_example;  // string | Only return reports matching the customer name (optional) 
            var integrationId = integrationId_example;  // string | Only return reports matching the integrationId (optional) 
            var campaignName = campaignName_example;  // string | Only return reports matching the campaignName (optional) 
            var advocateName = advocateName_example;  // string | Only return reports matching the current customer referrer name (optional) 

            try
            {
                // Get Activity Reports for Application Customers
                InlineResponse20015 result = apiInstance.GetCustomerActivityReportsWithoutTotalCount(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReportsWithoutTotalCount: " + e.Message );
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp, must be an RFC3339 timestamp string | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp, must be an RFC3339 timestamp string | 
 **applicationId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **name** | **string**| Only return reports matching the customer name | [optional] 
 **integrationId** | **string**| Only return reports matching the integrationId | [optional] 
 **campaignName** | **string**| Only return reports matching the campaignName | [optional] 
 **advocateName** | **string**| Only return reports matching the current customer referrer name | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerAnalytics

> CustomerAnalytics GetCustomerAnalytics (int applicationId, int customerId, int pageSize = null, int skip = null, string sort = null)

Get Analytics Report for a Customer

Fetch analytics for single application customer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerAnalyticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var customerId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get Analytics Report for a Customer
                CustomerAnalytics result = apiInstance.GetCustomerAnalytics(applicationId, customerId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerAnalytics: " + e.Message );
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
 **applicationId** | **int**|  | 
 **customerId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**CustomerAnalytics**](CustomerAnalytics.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerProfile

> ApplicationCustomer GetCustomerProfile (int applicationId, int customerId)

Get Customer Profile

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var customerId = 56;  // int | 

            try
            {
                // Get Customer Profile
                ApplicationCustomer result = apiInstance.GetCustomerProfile(applicationId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerProfile: " + e.Message );
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
 **applicationId** | **int**|  | 
 **customerId** | **int**|  | 

### Return type

[**ApplicationCustomer**](ApplicationCustomer.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomerProfiles

> InlineResponse20013 GetCustomerProfiles (int pageSize = null, int skip = null)

List Customer Profiles

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerProfilesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List Customer Profiles
                InlineResponse20013 result = apiInstance.GetCustomerProfiles(pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerProfiles: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetCustomersByAttributes

> InlineResponse20013 GetCustomersByAttributes (ApplicationCustomerSearch body, int pageSize = null, int skip = null)

Get a list of the customer profiles that match the given attributes

Gets a list of all the customer profiles for the account that exactly match a set of attributes.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request.  [Customer Profile]: https://help.talon.one/hc/en-us/articles/360005130739-Data-Model#CustomerProfile 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomersByAttributesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new ApplicationCustomerSearch(); // ApplicationCustomerSearch | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get a list of the customer profiles that match the given attributes
                InlineResponse20013 result = apiInstance.GetCustomersByAttributes(body, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomersByAttributes: " + e.Message );
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
 **body** | [**ApplicationCustomerSearch**](ApplicationCustomerSearch.md)|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetEventTypes

> InlineResponse20025 GetEventTypes (string applicationIds = null, string name = null, bool includeOldVersions = null, int pageSize = null, int skip = null, string sort = null)

List Event Types

Fetch all event type definitions for your account. Each event type can be 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetEventTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationIds = applicationIds_example;  // string | Filter by one or more application ids separated by comma (optional) 
            var name = name_example;  // string | Filter results to event types with the given name. This parameter implies `includeOldVersions`. (optional) 
            var includeOldVersions = true;  // bool | Include all versions of every event type. (optional)  (default to false)
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Event Types
                InlineResponse20025 result = apiInstance.GetEventTypes(applicationIds, name, includeOldVersions, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetEventTypes: " + e.Message );
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
 **applicationIds** | **string**| Filter by one or more application ids separated by comma | [optional] 
 **name** | **string**| Filter results to event types with the given name. This parameter implies &#x60;includeOldVersions&#x60;. | [optional] 
 **includeOldVersions** | **bool**| Include all versions of every event type. | [optional] [default to false]
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetExports

> InlineResponse20028 GetExports (int pageSize = null, int skip = null, int applicationId = null, int campaignId = null, string entity = null)

Get Exports

Get a list of all past exports 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetExportsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var applicationId = 56;  // int |  (optional) 
            var campaignId = 56;  // int |  (optional) 
            var entity = entity_example;  // string | The name of the entity type that was exported. (optional) 

            try
            {
                // Get Exports
                InlineResponse20028 result = apiInstance.GetExports(pageSize, skip, applicationId, campaignId, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetExports: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **applicationId** | **int**|  | [optional] 
 **campaignId** | **int**|  | [optional] 
 **entity** | **string**| The name of the entity type that was exported. | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetImports

> InlineResponse20029 GetImports (int pageSize = null, int skip = null)

Get Imports

Get a list of all past imports 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetImportsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get Imports
                InlineResponse20029 result = apiInstance.GetImports(pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetImports: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetLoyaltyPoints

> LoyaltyLedger GetLoyaltyPoints (string programID, string integrationID)

get the Loyalty Ledger for this integrationID

Get the Loyalty Ledger for this profile integration ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var programID = programID_example;  // string | The identifier for the application, must be unique within the account.
            var integrationID = integrationID_example;  // string | The identifier for the application, must be unique within the account.

            try
            {
                // get the Loyalty Ledger for this integrationID
                LoyaltyLedger result = apiInstance.GetLoyaltyPoints(programID, integrationID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyPoints: " + e.Message );
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
 **programID** | **string**| The identifier for the application, must be unique within the account. | 
 **integrationID** | **string**| The identifier for the application, must be unique within the account. | 

### Return type

[**LoyaltyLedger**](LoyaltyLedger.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetLoyaltyProgram

> LoyaltyProgram GetLoyaltyProgram (string programID)

Get a loyalty program

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var programID = programID_example;  // string | 

            try
            {
                // Get a loyalty program
                LoyaltyProgram result = apiInstance.GetLoyaltyProgram(programID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgram: " + e.Message );
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
 **programID** | **string**|  | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetLoyaltyPrograms

> InlineResponse2008 GetLoyaltyPrograms ()

List all loyalty Programs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);

            try
            {
                // List all loyalty Programs
                InlineResponse2008 result = apiInstance.GetLoyaltyPrograms();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyPrograms: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetReferrals

> InlineResponse2006 GetReferrals (int applicationId, int campaignId, int pageSize = null, int skip = null, string sort = null, string code = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, string advocate = null)

List Referrals (with total count)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReferralsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var code = code_example;  // string | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches referrals in which the expiry date is set and in the past. The second matches referrals in which start date is null or in the past and expiry date is null or in the future, the third matches referrals in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only referrals where `usageCounter < usageLimit` will be returned, \"false\" will return only referrals where `usageCounter >= usageLimit`.  (optional) 
            var advocate = advocate_example;  // string | Filter results by match with a profile id specified in the referral's AdvocateProfileIntegrationId field (optional) 

            try
            {
                // List Referrals (with total count)
                InlineResponse2006 result = apiInstance.GetReferrals(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetReferrals: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **code** | **string**| Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches referrals in which the expiry date is set and in the past. The second matches referrals in which start date is null or in the past and expiry date is null or in the future, the third matches referrals in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **advocate** | **string**| Filter results by match with a profile id specified in the referral&#39;s AdvocateProfileIntegrationId field | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetReferralsWithoutTotalCount

> InlineResponse2007 GetReferralsWithoutTotalCount (int applicationId, int campaignId, int pageSize = null, int skip = null, string sort = null, string code = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, string advocate = null)

List Referrals

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReferralsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var code = code_example;  // string | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches referrals in which the expiry date is set and in the past. The second matches referrals in which start date is null or in the past and expiry date is null or in the future, the third matches referrals in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only referrals where `usageCounter < usageLimit` will be returned, \"false\" will return only referrals where `usageCounter >= usageLimit`.  (optional) 
            var advocate = advocate_example;  // string | Filter results by match with a profile id specified in the referral's AdvocateProfileIntegrationId field (optional) 

            try
            {
                // List Referrals
                InlineResponse2007 result = apiInstance.GetReferralsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetReferralsWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **code** | **string**| Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches referrals in which the expiry date is set and in the past. The second matches referrals in which start date is null or in the past and expiry date is null or in the future, the third matches referrals in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **advocate** | **string**| Filter results by match with a profile id specified in the referral&#39;s AdvocateProfileIntegrationId field | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetRole

> Role GetRole (int roleId)

Get information for the specified role.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var roleId = 56;  // int | 

            try
            {
                // Get information for the specified role.
                Role result = apiInstance.GetRole(roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRole: " + e.Message );
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
 **roleId** | **int**|  | 

### Return type

[**Role**](Role.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetRuleset

> Ruleset GetRuleset (int applicationId, int campaignId, int rulesetId)

Get a Ruleset

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRulesetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var rulesetId = 56;  // int | 

            try
            {
                // Get a Ruleset
                Ruleset result = apiInstance.GetRuleset(applicationId, campaignId, rulesetId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRuleset: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **rulesetId** | **int**|  | 

### Return type

[**Ruleset**](Ruleset.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetRulesets

> InlineResponse2003 GetRulesets (int applicationId, int campaignId, int pageSize = null, int skip = null, string sort = null)

List Campaign Rulesets

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRulesetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Campaign Rulesets
                InlineResponse2003 result = apiInstance.GetRulesets(applicationId, campaignId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRulesets: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetUser

> User GetUser (int userId)

Get a single User

Retrieves the data (including an invitation code) for a user. Non-admin users can only get themselves. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var userId = 56;  // int | 

            try
            {
                // Get a single User
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetUser: " + e.Message );
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
 **userId** | **int**|  | 

### Return type

[**User**](User.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetUsers

> InlineResponse20026 GetUsers (int pageSize = null, int skip = null, string sort = null)

List Users in your account

Retrieve all users in your account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Users in your account
                InlineResponse20026 result = apiInstance.GetUsers(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetUsers: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetWebhook

> Webhook GetWebhook (int webhookId)

Get Webhook

Returns an webhook by its id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var webhookId = 56;  // int | 

            try
            {
                // Get Webhook
                Webhook result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhook: " + e.Message );
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
 **webhookId** | **int**|  | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetWebhookActivationLogs

> InlineResponse20023 GetWebhookActivationLogs (int pageSize = null, int skip = null, string sort = null, string integrationRequestUuid = null, decimal webhookId = null, decimal applicationId = null, decimal campaignId = null, DateTime createdBefore = null, DateTime createdAfter = null)

List Webhook activation Log Entries

Webhook activation log entries would be created as soon as an integration request triggered an effect with a webhook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhookActivationLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var integrationRequestUuid = integrationRequestUuid_example;  // string | Filter results by integration request UUID. (optional) 
            var webhookId = 8.14;  // decimal | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal |  (optional) 
            var campaignId = 8.14;  // decimal | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Only return events created before this date. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. (optional) 

            try
            {
                // List Webhook activation Log Entries
                InlineResponse20023 result = apiInstance.GetWebhookActivationLogs(pageSize, skip, sort, integrationRequestUuid, webhookId, applicationId, campaignId, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhookActivationLogs: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **integrationRequestUuid** | **string**| Filter results by integration request UUID. | [optional] 
 **webhookId** | **decimal**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal**|  | [optional] 
 **campaignId** | **decimal**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime**| Only return events created before this date. | [optional] 
 **createdAfter** | **DateTime**| Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. | [optional] 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetWebhookLogs

> InlineResponse20024 GetWebhookLogs (int pageSize = null, int skip = null, string sort = null, string status = null, decimal webhookId = null, decimal applicationId = null, decimal campaignId = null, string requestUuid = null, DateTime createdBefore = null, DateTime createdAfter = null)

List Webhook Log Entries

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhookLogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var webhookId = 8.14;  // decimal | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal |  (optional) 
            var campaignId = 8.14;  // decimal | Filter results by campaign. (optional) 
            var requestUuid = requestUuid_example;  // string | Filter results by request UUID. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. (optional) 

            try
            {
                // List Webhook Log Entries
                InlineResponse20024 result = apiInstance.GetWebhookLogs(pageSize, skip, sort, status, webhookId, applicationId, campaignId, requestUuid, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhookLogs: " + e.Message );
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
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **webhookId** | **decimal**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal**|  | [optional] 
 **campaignId** | **decimal**| Filter results by campaign. | [optional] 
 **requestUuid** | **string**| Filter results by request UUID. | [optional] 
 **createdBefore** | **DateTime**| Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. | [optional] 
 **createdAfter** | **DateTime**| Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. | [optional] 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## GetWebhooks

> InlineResponse20022 GetWebhooks (string applicationIds = null, string sort = null, int pageSize = null, int skip = null)

List Webhooks

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationIds = applicationIds_example;  // string | Filter by one or more application ids separated by comma (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List Webhooks
                InlineResponse20022 result = apiInstance.GetWebhooks(applicationIds, sort, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhooks: " + e.Message );
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
 **applicationIds** | **string**| Filter by one or more application ids separated by comma | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## RemoveLoyaltyPoints

> void RemoveLoyaltyPoints (string programID, string integrationID, LoyaltyPoints body)

Deduct points in a certain loyalty program for the specified customer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class RemoveLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var programID = programID_example;  // string | 
            var integrationID = integrationID_example;  // string | 
            var body = new LoyaltyPoints(); // LoyaltyPoints | 

            try
            {
                // Deduct points in a certain loyalty program for the specified customer
                apiInstance.RemoveLoyaltyPoints(programID, integrationID, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.RemoveLoyaltyPoints: " + e.Message );
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
 **programID** | **string**|  | 
 **integrationID** | **string**|  | 
 **body** | [**LoyaltyPoints**](LoyaltyPoints.md)|  | 

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


## ResetPassword

> NewPassword ResetPassword (NewPassword body)

Reset password

Consumes the supplied password reset token and updates the password for the associated account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var body = new NewPassword(); // NewPassword | 

            try
            {
                // Reset password
                NewPassword result = apiInstance.ResetPassword(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ResetPassword: " + e.Message );
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
 **body** | [**NewPassword**](NewPassword.md)|  | 

### Return type

[**NewPassword**](NewPassword.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchCouponsAdvanced

> InlineResponse2004 SearchCouponsAdvanced (int applicationId, int campaignId, Object body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, bool exactMatch = null, string batchId = null)

Get a list of the coupons that match the given attributes (with total count)

Gets a list of all the coupons with attributes matching the query criteria 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = ;  // Object | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes (with total count)
                InlineResponse2004 result = apiInstance.SearchCouponsAdvanced(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvanced: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | **Object**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **batchId** | **string**| Filter results by batches of coupons | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## SearchCouponsAdvancedApplicationWide

> InlineResponse2004 SearchCouponsAdvancedApplicationWide (int applicationId, Object body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, string campaignState = null)

Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)

Gets a list of all the coupons with attributes matching the query criteria in all active campaigns of an application 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedApplicationWideExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = ;  // Object | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes in all active campaigns of an application (with total count)
                InlineResponse2004 result = apiInstance.SearchCouponsAdvancedApplicationWide(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedApplicationWide: " + e.Message );
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
 **applicationId** | **int**|  | 
 **body** | **Object**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## SearchCouponsAdvancedApplicationWideWithoutTotalCount

> InlineResponse2005 SearchCouponsAdvancedApplicationWideWithoutTotalCount (int applicationId, Object body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, string campaignState = null)

Get a list of the coupons that match the given attributes in all active campaigns of an application

Gets a list of all the coupons with attributes matching the query criteria in all active campaigns of an application 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedApplicationWideWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = ;  // Object | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes in all active campaigns of an application
                InlineResponse2005 result = apiInstance.SearchCouponsAdvancedApplicationWideWithoutTotalCount(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedApplicationWideWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **body** | **Object**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## SearchCouponsAdvancedWithoutTotalCount

> InlineResponse2005 SearchCouponsAdvancedWithoutTotalCount (int applicationId, int campaignId, Object body, int pageSize = null, int skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, int referralId = null, string recipientIntegrationId = null, bool exactMatch = null, string batchId = null)

Get a list of the coupons that match the given attributes

Gets a list of all the coupons with attributes matching the query criteria 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = ;  // Object | 
            var pageSize = 56;  // int | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // Get a list of the coupons that match the given attributes
                InlineResponse2005 result = apiInstance.SearchCouponsAdvancedWithoutTotalCount(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedWithoutTotalCount: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | **Object**|  | 
 **pageSize** | **int**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **createdAfter** | **DateTime**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **batchId** | **string**| Filter results by batches of coupons | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## UpdateAdditionalCost

> AccountAdditionalCost UpdateAdditionalCost (int additionalCostId, NewAdditionalCost body)

Update an additional cost

Updates an existing additional cost. Once created, the only property of an additional cost that can be changed is the title (human readable description). This restriction is in place to prevent accidentally breaking live integrations. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAdditionalCostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var additionalCostId = 56;  // int | 
            var body = new NewAdditionalCost(); // NewAdditionalCost | 

            try
            {
                // Update an additional cost
                AccountAdditionalCost result = apiInstance.UpdateAdditionalCost(additionalCostId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAdditionalCost: " + e.Message );
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
 **additionalCostId** | **int**|  | 
 **body** | [**NewAdditionalCost**](NewAdditionalCost.md)|  | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## UpdateAttribute

> Attribute UpdateAttribute (int attributeId, NewAttribute body)

Update a custom attribute

Updates an existing custom attribute. Once created, the only property of a custom attribute that can be changed is the title (human readable description). This restriction is in place to prevent accidentally breaking live integrations. E.g. if you have a customer profile attribute with the name `region`, and your integration is sending `attributes.region` with customer profile updates, changing the name to `locale` would cause the integration requests to begin failing.  If you **really** need to change the `type` or `name` property of a custom attribute, create a new attribute and update any relevant integrations and rules to use the new attribute. Then delete the old attribute when you are confident you have migrated any needed data from the old attribute to the new one. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAttributeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var attributeId = 56;  // int | 
            var body = new NewAttribute(); // NewAttribute | 

            try
            {
                // Update a custom attribute
                Attribute result = apiInstance.UpdateAttribute(attributeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAttribute: " + e.Message );
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
 **attributeId** | **int**|  | 
 **body** | [**NewAttribute**](NewAttribute.md)|  | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## UpdateCampaign

> Campaign UpdateCampaign (int applicationId, int campaignId, UpdateCampaign body)

Update a Campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new UpdateCampaign(); // UpdateCampaign | 

            try
            {
                // Update a Campaign
                Campaign result = apiInstance.UpdateCampaign(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCampaign: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**UpdateCampaign**](UpdateCampaign.md)|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## UpdateCoupon

> Coupon UpdateCoupon (int applicationId, int campaignId, string couponId, UpdateCoupon body)

Update a Coupon

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCouponExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var couponId = couponId_example;  // string | The ID of the coupon code to update
            var body = new UpdateCoupon(); // UpdateCoupon | 

            try
            {
                // Update a Coupon
                Coupon result = apiInstance.UpdateCoupon(applicationId, campaignId, couponId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCoupon: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **couponId** | **string**| The ID of the coupon code to update | 
 **body** | [**UpdateCoupon**](UpdateCoupon.md)|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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


## UpdateCouponBatch

> void UpdateCouponBatch (int applicationId, int campaignId, UpdateCouponBatch body)

Update a Batch of Coupons

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCouponBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var body = new UpdateCouponBatch(); // UpdateCouponBatch | 

            try
            {
                // Update a Batch of Coupons
                apiInstance.UpdateCouponBatch(applicationId, campaignId, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCouponBatch: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **body** | [**UpdateCouponBatch**](UpdateCouponBatch.md)|  | 

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


## UpdateRuleset

> Ruleset UpdateRuleset (int applicationId, int campaignId, int rulesetId, NewRuleset body)

Update a Ruleset

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateRulesetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var campaignId = 56;  // int | 
            var rulesetId = 56;  // int | 
            var body = new NewRuleset(); // NewRuleset | 

            try
            {
                // Update a Ruleset
                Ruleset result = apiInstance.UpdateRuleset(applicationId, campaignId, rulesetId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateRuleset: " + e.Message );
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
 **applicationId** | **int**|  | 
 **campaignId** | **int**|  | 
 **rulesetId** | **int**|  | 
 **body** | [**NewRuleset**](NewRuleset.md)|  | 

### Return type

[**Ruleset**](Ruleset.md)

### Authorization

[manager_auth](../README.md#manager_auth)

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

