# TalonOne.Api.ManagementApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoyaltyPoints**](ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{programID}/profile/{integrationID}/add_points | Add points in loyalty program for given customer
[**CopyCampaignToApplications**](ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into every specified application
[**CreateAdditionalCost**](ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Define a new additional cost
[**CreateAttribute**](ManagementApi.md#createattribute) | **POST** /v1/attributes | Create custom attribute
[**CreateCampaign**](ManagementApi.md#createcampaign) | **POST** /v1/applications/{applicationId}/campaigns | Create campaign
[**CreateCoupons**](ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create coupons
[**CreateCouponsForMultipleRecipients**](ManagementApi.md#createcouponsformultiplerecipients) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_with_recipients | Create coupons for multiple recipients
[**CreatePasswordRecoveryEmail**](ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset
[**CreateRuleset**](ManagementApi.md#createruleset) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | Create ruleset
[**CreateSession**](ManagementApi.md#createsession) | **POST** /v1/sessions | Create session
[**DeleteCampaign**](ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete campaign
[**DeleteCoupon**](ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete coupon
[**DeleteCoupons**](ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete coupons
[**DeleteReferral**](ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete referral
[**DestroySession**](ManagementApi.md#destroysession) | **DELETE** /v1/sessions | Destroy session
[**ExportCoupons**](ManagementApi.md#exportcoupons) | **GET** /v1/applications/{applicationId}/export_coupons | Export coupons to CSV file
[**ExportCustomerSessions**](ManagementApi.md#exportcustomersessions) | **GET** /v1/applications/{applicationId}/export_customer_sessions | Export customer sessions to CSV file
[**ExportEffects**](ManagementApi.md#exporteffects) | **GET** /v1/applications/{applicationId}/export_effects | Export triggered effects to CSV file
[**ExportLoyaltyBalance**](ManagementApi.md#exportloyaltybalance) | **GET** /v1/loyalty_programs/{programID}/export_customer_balance | Export customer loyalty balance to a CSV file
[**ExportLoyaltyLedger**](ManagementApi.md#exportloyaltyledger) | **GET** /v1/loyalty_programs/{programID}/profile/{integrationID}/export_log | Export a customer&#39;s loyalty ledger log to CSV file
[**GetAccessLogsWithoutTotalCount**](ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for Application
[**GetAccount**](ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get account details
[**GetAccountAnalytics**](ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get account analytics
[**GetAdditionalCost**](ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get an additional cost
[**GetAdditionalCosts**](ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs
[**GetAllAccessLogs**](ManagementApi.md#getallaccesslogs) | **GET** /v1/access_logs | List access logs
[**GetAllRoles**](ManagementApi.md#getallroles) | **GET** /v1/roles | List roles
[**GetApplication**](ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application
[**GetApplicationApiHealth**](ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get report of health of application API
[**GetApplicationCustomer**](ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get application&#39;s customer
[**GetApplicationCustomerFriends**](ManagementApi.md#getapplicationcustomerfriends) | **GET** /v1/applications/{applicationId}/profile/{integrationId}/friends | List friends referred by customer profile
[**GetApplicationCustomers**](ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List application&#39;s customers
[**GetApplicationCustomersByAttributes**](ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/applications/{applicationId}/customer_search | List application customers matching the given attributes
[**GetApplicationEventTypes**](ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications event types
[**GetApplicationEventsWithoutTotalCount**](ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications events
[**GetApplicationSession**](ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application session
[**GetApplicationSessions**](ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application sessions
[**GetApplications**](ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications
[**GetAttribute**](ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get a custom attribute
[**GetAttributes**](ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes
[**GetAudiences**](ManagementApi.md#getaudiences) | **GET** /v1/audiences | List audiences
[**GetCampaign**](ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get campaign
[**GetCampaignAnalytics**](ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns
[**GetCampaignByAttributes**](ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | List campaigns that match the given attributes
[**GetCampaigns**](ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List campaigns
[**GetChanges**](ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit log for an account
[**GetCouponsByAttributes**](ManagementApi.md#getcouponsbyattributes) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search | List coupons that match the given attributes
[**GetCouponsWithoutTotalCount**](ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List coupons
[**GetCustomerActivityReport**](ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get customer&#39;s activity report
[**GetCustomerActivityReportsWithoutTotalCount**](ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers
[**GetCustomerAnalytics**](ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get customer&#39;s analytics report
[**GetCustomerProfile**](ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get customer profile
[**GetCustomerProfiles**](ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List customer profiles
[**GetCustomersByAttributes**](ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | List customer profiles matching the given attributes
[**GetEventTypes**](ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List Event Types
[**GetExports**](ManagementApi.md#getexports) | **GET** /v1/exports | Get Exports
[**GetLoyaltyPoints**](ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{programID}/profile/{integrationID} | Get the Loyalty Ledger for this integrationID
[**GetLoyaltyProgram**](ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{programID} | Get loyalty program
[**GetLoyaltyPrograms**](ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List loyalty programs
[**GetLoyaltyStatistics**](ManagementApi.md#getloyaltystatistics) | **GET** /v1/loyalty_programs/{programID}/statistics | Get loyalty program statistics by loyalty program ID
[**GetReferralsWithoutTotalCount**](ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List referrals
[**GetRole**](ManagementApi.md#getrole) | **GET** /v1/roles/{roleId} | Get role
[**GetRuleset**](ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get ruleset
[**GetRulesets**](ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List campaign rulesets
[**GetUser**](ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get a single user
[**GetUsers**](ManagementApi.md#getusers) | **GET** /v1/users | List users in account
[**GetWebhook**](ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get Webhook
[**GetWebhookActivationLogs**](ManagementApi.md#getwebhookactivationlogs) | **GET** /v1/webhook_activation_logs | List webhook activation log entries
[**GetWebhookLogs**](ManagementApi.md#getwebhooklogs) | **GET** /v1/webhook_logs | List webhook log entries
[**GetWebhooks**](ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List webhooks
[**ImportCoupons**](ManagementApi.md#importcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_coupons | Import coupons via CSV file
[**ImportLoyaltyPoints**](ManagementApi.md#importloyaltypoints) | **POST** /v1/loyalty_programs/{programID}/import_points | Import loyalty points via CSV file
[**ImportPoolGiveaways**](ManagementApi.md#importpoolgiveaways) | **POST** /v1/giveaways/pools/{poolId}/import | Import giveaway codes into a giveaway pool
[**ImportReferrals**](ManagementApi.md#importreferrals) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_referrals | Import referrals via CSV file
[**RemoveLoyaltyPoints**](ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{programID}/profile/{integrationID}/deduct_points | Deduct points in loyalty program for given customer
[**ResetPassword**](ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password
[**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | List coupons that match the given attributes in all active campaigns of an application
[**SearchCouponsAdvancedWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | List coupons that match the given attributes
[**UpdateAdditionalCost**](ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update an additional cost
[**UpdateAttribute**](ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update a custom attribute
[**UpdateCampaign**](ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update campaign
[**UpdateCoupon**](ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update coupon
[**UpdateCouponBatch**](ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update a batch of coupons
[**UpdateReferral**](ManagementApi.md#updatereferral) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Update referral
[**UpdateRuleset**](ManagementApi.md#updateruleset) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Update ruleset



## AddLoyaltyPoints

> void AddLoyaltyPoints (string programID, string integrationID, LoyaltyPoints body)

Add points in loyalty program for given customer

Add points in the specified loyalty program for the given customer.  To get the `integrationId` of the customer profile, you can use the [Update customer session](/integration-api/#operation/updateCustomerSessionV2) or [Update customer profile](/integration-api/#operation/updateCustomerProfileV2) endpoints. 

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
                // Add points in loyalty program for given customer
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

Create custom attribute

Create a _custom attribute_ in this account. Custom attributes allow you to attach new fields to Talon.One domain objects like campaigns, coupons, customers and so on.  These attributes can then be given values when creating/updating these objects, and these values can be used in your campaign rules. For example, you could define a `zipCode` field for customer sessions, and add a rule to your campaign that only allows certain ZIP codes.  These attributes are shared across all applications in your account, and are never required. 

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
                // Create custom attribute
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

Create campaign

Create a campaign. A campaign is part of an Application and contains a set of promotion rules.

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
                // Create campaign
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

Create coupons

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
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

            try
            {
                // Create coupons
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
 **silent** | **string**| If set to &#x60;yes&#x60;, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). | [optional] 

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


## CreateCouponsForMultipleRecipients

> InlineResponse2004 CreateCouponsForMultipleRecipients (int applicationId, int campaignId, NewCouponsForMultipleRecipients body, string silent = null)

Create coupons for multiple recipients

Create coupons according to some pattern for up to 1000 recipients.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsForMultipleRecipientsExample
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
            var body = new NewCouponsForMultipleRecipients(); // NewCouponsForMultipleRecipients | 
            var silent = silent_example;  // string | If set to `yes`, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). (optional) 

            try
            {
                // Create coupons for multiple recipients
                InlineResponse2004 result = apiInstance.CreateCouponsForMultipleRecipients(applicationId, campaignId, body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCouponsForMultipleRecipients: " + e.Message );
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
 **body** | [**NewCouponsForMultipleRecipients**](NewCouponsForMultipleRecipients.md)|  | 
 **silent** | **string**| If set to &#x60;yes&#x60;, response will be an empty 204, otherwise a list of integration states will be generated (up to 1000). | [optional] 

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

Send an email with a password recovery link to the email address of an existing account. 

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

Create ruleset

Create a set of rules. A ruleset is a revision of all the rules of a campaign.

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
                // Create ruleset
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

Create session

Create a session to use the Management API endpoints. Use the value of the `token` property provided in the response as bearer token in other API calls.  This endpoint has a rate limit of 3 to 6 requests per second per account, depending on your setup. 

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
                // Create session
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

Delete campaign

Delete the given campaign.

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
                // Delete campaign
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

Delete coupon

Delete the specified coupon.

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
                // Delete coupon
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

> void DeleteCoupons (int applicationId, int campaignId, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, DateTime? startsAfter = null, DateTime? startsBefore = null, DateTime? expiresAfter = null, DateTime? expiresBefore = null, string valid = null, string batchId = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, bool? exactMatch = null)

Delete coupons

Deletes all the coupons matching the specified criteria.

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
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var startsAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var startsBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var expiresAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var expiresBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // Delete coupons
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
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **startsAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **startsBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **expiresAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **expiresBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

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

Delete referral

Delete the specified referral.

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
                // Delete referral
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


## DestroySession

> void DestroySession ()

Destroy session

Destroys the session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DestroySessionExample
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
                // Destroy session
                apiInstance.DestroySession();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.DestroySession: " + e.Message );
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


## ExportCoupons

> string ExportCoupons (int applicationId, decimal? campaignId = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null, string dateFormat = null, string campaignState = null)

Export coupons to CSV file

Download a file containing the coupons that match the given attributes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCouponsExample
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
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // Export coupons to CSV file
                string result = apiInstance.ExportCoupons(applicationId, campaignId, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, dateFormat, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCoupons: " + e.Message );
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
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 

### Return type

**string**

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportCustomerSessions

> string ExportCustomerSessions (int applicationId, DateTime? createdBefore = null, DateTime? createdAfter = null, string profileIntegrationId = null, string dateFormat = null, string customerSessionState = null)

Export customer sessions to CSV file

Download a file containing the customer sessions that match the request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCustomerSessionsExample
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
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var profileIntegrationId = profileIntegrationId_example;  // string | Only return sessions for the customer that matches this customer integration ID. (optional) 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 
            var customerSessionState = customerSessionState_example;  // string | Filter results by state. (optional) 

            try
            {
                // Export customer sessions to CSV file
                string result = apiInstance.ExportCustomerSessions(applicationId, createdBefore, createdAfter, profileIntegrationId, dateFormat, customerSessionState);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCustomerSessions: " + e.Message );
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
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional] 
 **profileIntegrationId** | **string**| Only return sessions for the customer that matches this customer integration ID. | [optional] 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 
 **customerSessionState** | **string**| Filter results by state. | [optional] 

### Return type

**string**

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportEffects

> string ExportEffects (int applicationId, decimal? campaignId = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string dateFormat = null)

Export triggered effects to CSV file

Download a file containing the triggered effects that match the given attributes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportEffectsExample
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
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export triggered effects to CSV file
                string result = apiInstance.ExportEffects(applicationId, campaignId, createdBefore, createdAfter, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportEffects: " + e.Message );
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
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportLoyaltyBalance

> string ExportLoyaltyBalance (string programID)

Export customer loyalty balance to a CSV file

Download a file with the balance of each customer in the loyalty program

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyBalanceExample
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
                // Export customer loyalty balance to a CSV file
                string result = apiInstance.ExportLoyaltyBalance(programID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalance: " + e.Message );
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

**string**

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportLoyaltyLedger

> string ExportLoyaltyLedger (DateTime rangeStart, DateTime rangeEnd, string programID, string integrationID, string dateFormat = null)

Export a customer's loyalty ledger log to CSV file

Download a file with a customer's ledger log in the loyalty program

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyLedgerExample
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
            var programID = programID_example;  // string | 
            var integrationID = integrationID_example;  // string | 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export a customer's loyalty ledger log to CSV file
                string result = apiInstance.ExportLoyaltyLedger(rangeStart, rangeEnd, programID, integrationID, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyLedger: " + e.Message );
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
 **programID** | **string**|  | 
 **integrationID** | **string**|  | 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAccessLogsWithoutTotalCount

> InlineResponse2008 GetAccessLogsWithoutTotalCount (int applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int? pageSize = null, int? skip = null, string sort = null)

Get access logs for Application

Retrieve the list of API calls to this Application matching the specified criteria. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get access logs for Application
                InlineResponse2008 result = apiInstance.GetAccessLogsWithoutTotalCount(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

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


## GetAccount

> Account GetAccount (int accountId)

Get account details

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
                // Get account details
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

Get account analytics

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
                // Get account analytics
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

> InlineResponse20021 GetAdditionalCosts (int? pageSize = null, int? skip = null, string sort = null)

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse2009 GetAllAccessLogs (DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int? pageSize = null, int? skip = null, string sort = null)

List access logs

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List access logs
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse20029 GetAllRoles ()

List roles

List all roles.

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
                // List roles
                InlineResponse20029 result = apiInstance.GetAllRoles();
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

Display the health of the application and show the last time the Application was used. 

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

Get application's customer

Retrieve the customers of the specified application.  The `customerId` parameter is the value of the `id` property of a customer profile. Get it with the [List application's customers](#operation/getApplicationCustomers) endpoint. 

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
                // Get application's customer
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


## GetApplicationCustomerFriends

> InlineResponse20019 GetApplicationCustomerFriends (int applicationId, string integrationId, int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null)

List friends referred by customer profile

List the friends referred by the specified customer profile in this Application. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomerFriendsExample
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
            var integrationId = integrationId_example;  // string | The Integration ID of the Advocate's Profile.
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, `hasMore` will be true whenever there is a next page. `totalResultSize` will always be zero. With this flag set to false, `hasMore` will always be set to false. `totalResultSize` will contain the total number of results for this query.  (optional) 

            try
            {
                // List friends referred by customer profile
                InlineResponse20019 result = apiInstance.GetApplicationCustomerFriends(applicationId, integrationId, pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomerFriends: " + e.Message );
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
 **integrationId** | **string**| The Integration ID of the Advocate&#39;s Profile. | 
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, &#x60;hasMore&#x60; will be true whenever there is a next page. &#x60;totalResultSize&#x60; will always be zero. With this flag set to false, &#x60;hasMore&#x60; will always be set to false. &#x60;totalResultSize&#x60; will contain the total number of results for this query.  | [optional] 

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


## GetApplicationCustomers

> InlineResponse20011 GetApplicationCustomers (int applicationId, string integrationId = null, int? pageSize = null, int? skip = null, bool? withTotalResultSize = null)

List application's customers

List all the customers of the specified application.

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
            var integrationId = integrationId_example;  // string | Filter results performing an exact matching against the profile integration identifier. (optional) 
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, `hasMore` will be true whenever there is a next page. `totalResultSize` will always be zero. With this flag set to false, `hasMore` will always be set to false. `totalResultSize` will contain the total number of results for this query.  (optional) 

            try
            {
                // List application's customers
                InlineResponse20011 result = apiInstance.GetApplicationCustomers(applicationId, integrationId, pageSize, skip, withTotalResultSize);
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
 **integrationId** | **string**| Filter results performing an exact matching against the profile integration identifier. | [optional] 
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, &#x60;hasMore&#x60; will be true whenever there is a next page. &#x60;totalResultSize&#x60; will always be zero. With this flag set to false, &#x60;hasMore&#x60; will always be set to false. &#x60;totalResultSize&#x60; will contain the total number of results for this query.  | [optional] 

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


## GetApplicationCustomersByAttributes

> InlineResponse20012 GetApplicationCustomersByAttributes (int applicationId, CustomerProfileSearchQuery body, int? pageSize = null, int? skip = null, bool? withTotalResultSize = null)

List application customers matching the given attributes

Get a list of the application customers matching the provided criteria.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request. 

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
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var applicationId = 56;  // int | 
            var body = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | 
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, `hasMore` will be true whenever there is a next page. `totalResultSize` will always be zero. With this flag set to false, `hasMore` will always be set to false. `totalResultSize` will contain the total number of results for this query.  (optional) 

            try
            {
                // List application customers matching the given attributes
                InlineResponse20012 result = apiInstance.GetApplicationCustomersByAttributes(applicationId, body, pageSize, skip, withTotalResultSize);
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
 **applicationId** | **int**|  | 
 **body** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md)|  | 
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, &#x60;hasMore&#x60; will be true whenever there is a next page. &#x60;totalResultSize&#x60; will always be zero. With this flag set to false, &#x60;hasMore&#x60; will always be set to false. &#x60;totalResultSize&#x60; will contain the total number of results for this query.  | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

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


## GetApplicationEventTypes

> InlineResponse20017 GetApplicationEventTypes (int applicationId, int? pageSize = null, int? skip = null, string sort = null)

List Applications event types

Get all of the distinct values of the Event `type` property for events recorded in the application.  See also: [Track an event](/integration-api/#operation/trackEvent) 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List Applications event types
                InlineResponse20017 result = apiInstance.GetApplicationEventTypes(applicationId, pageSize, skip, sort);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 

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

> InlineResponse20016 GetApplicationEventsWithoutTotalCount (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string type = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string session = null, string profile = null, string customerName = null, string customerEmail = null, string couponCode = null, string referralCode = null, string ruleQuery = null, string campaignQuery = null)

List Applications events

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var type = type_example;  // string | Comma-separated list of types by which to filter events. Must be exact match(es). (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
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
                // List Applications events
                InlineResponse20016 result = apiInstance.GetApplicationEventsWithoutTotalCount(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **type** | **string**| Comma-separated list of types by which to filter events. Must be exact match(es). | [optional] 
 **createdBefore** | **DateTime?**| Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **session** | **string**| Session integration ID filter for events. Must be exact match. | [optional] 
 **profile** | **string**| Profile integration ID filter for events. Must be exact match. | [optional] 
 **customerName** | **string**| Customer name filter for events. Will match substrings case-insensitively. | [optional] 
 **customerEmail** | **string**| Customer e-mail address filter for events. Will match substrings case-insensitively. | [optional] 
 **couponCode** | **string**| Coupon code | [optional] 
 **referralCode** | **string**| Referral code | [optional] 
 **ruleQuery** | **string**| Rule name filter for events | [optional] 
 **campaignQuery** | **string**| Campaign name filter for events | [optional] 

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


## GetApplicationSession

> ApplicationSession GetApplicationSession (int applicationId, int sessionId)

Get Application session

Get the details of the given session. You can list the sessions with the [List application sessions](#operation/getApplicationSessions) endpoint. 

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
                // Get Application session
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

> InlineResponse20015 GetApplicationSessions (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string profile = null, string state = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string coupon = null, string referral = null, string integrationId = null)

List Application sessions

List all the sessions of the specified Application. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var profile = profile_example;  // string | Profile integration ID filter for sessions. Must be exact match. (optional) 
            var state = state_example;  // string | Filter by sessions with this state. Must be exact match. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var coupon = coupon_example;  // string | Filter by sessions with this coupon. Must be exact match. (optional) 
            var referral = referral_example;  // string | Filter by sessions with this referral. Must be exact match. (optional) 
            var integrationId = integrationId_example;  // string | Filter by sessions with this integrationId. Must be exact match. (optional) 

            try
            {
                // List Application sessions
                InlineResponse20015 result = apiInstance.GetApplicationSessions(applicationId, pageSize, skip, sort, profile, state, createdBefore, createdAfter, coupon, referral, integrationId);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **profile** | **string**| Profile integration ID filter for sessions. Must be exact match. | [optional] 
 **state** | **string**| Filter by sessions with this state. Must be exact match. | [optional] 
 **createdBefore** | **DateTime?**| Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **coupon** | **string**| Filter by sessions with this coupon. Must be exact match. | [optional] 
 **referral** | **string**| Filter by sessions with this referral. Must be exact match. | [optional] 
 **integrationId** | **string**| Filter by sessions with this integrationId. Must be exact match. | [optional] 

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


## GetApplications

> InlineResponse2001 GetApplications (int? pageSize = null, int? skip = null, string sort = null)

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse20020 GetAttributes (int? pageSize = null, int? skip = null, string sort = null, string entity = null)

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var entity = entity_example;  // string | Returned attributes will be filtered by supplied entity (optional) 

            try
            {
                // List custom attributes
                InlineResponse20020 result = apiInstance.GetAttributes(pageSize, skip, sort, entity);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **entity** | **string**| Returned attributes will be filtered by supplied entity | [optional] 

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


## GetAudiences

> InlineResponse20018 GetAudiences (int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null)

List audiences

Get All audiences created in the account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAudiencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, `hasMore` will be true whenever there is a next page. `totalResultSize` will always be zero. With this flag set to false, `hasMore` will always be set to false. `totalResultSize` will contain the total number of results for this query.  (optional) 

            try
            {
                // List audiences
                InlineResponse20018 result = apiInstance.GetAudiences(pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAudiences: " + e.Message );
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, &#x60;hasMore&#x60; will be true whenever there is a next page. &#x60;totalResultSize&#x60; will always be zero. With this flag set to false, &#x60;hasMore&#x60; will always be set to false. &#x60;totalResultSize&#x60; will contain the total number of results for this query.  | [optional] 

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


## GetCampaign

> Campaign GetCampaign (int applicationId, int campaignId)

Get campaign

Retrieve the given campaign.

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
                // Get campaign
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

> InlineResponse20010 GetCampaignAnalytics (int applicationId, int campaignId, DateTime rangeStart, DateTime rangeEnd, string granularity = null)

Get analytics of campaigns

Retrieve statistical data about the performance of the given campaign.

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
                InlineResponse20010 result = apiInstance.GetCampaignAnalytics(applicationId, campaignId, rangeStart, rangeEnd, granularity);
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


## GetCampaignByAttributes

> InlineResponse2002 GetCampaignByAttributes (int applicationId, CampaignSearch body, int? pageSize = null, int? skip = null, string sort = null, string campaignState = null)

List campaigns that match the given attributes

Get a list of all the campaigns that match a set of attributes. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // List campaigns that match the given attributes
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse2002 GetCampaigns (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string campaignState = null, string name = null, string tags = null, DateTime? createdBefore = null, DateTime? createdAfter = null, int? campaignGroupId = null, int? templateId = null)

List campaigns

List all the campaigns of the specified application.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 
            var name = name_example;  // string | Filter results performing case-insensitive matching against the name of the campaign. (optional) 
            var tags = tags_example;  // string | Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values  (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var campaignGroupId = 56;  // int? | Filter results to campaigns owned by the specified campaign group ID. (optional) 
            var templateId = 56;  // int? | The ID of the Campaign Template this Campaign was created from. (optional) 

            try
            {
                // List campaigns
                InlineResponse2002 result = apiInstance.GetCampaigns(applicationId, pageSize, skip, sort, campaignState, name, tags, createdBefore, createdAfter, campaignGroupId, templateId);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign. | [optional] 
 **name** | **string**| Filter results performing case-insensitive matching against the name of the campaign. | [optional] 
 **tags** | **string**| Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values  | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **campaignGroupId** | **int?**| Filter results to campaigns owned by the specified campaign group ID. | [optional] 
 **templateId** | **int?**| The ID of the Campaign Template this Campaign was created from. | [optional] 

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

> InlineResponse20027 GetChanges (int? pageSize = null, int? skip = null, string sort = null, int? applicationId = null, string entityPath = null, int? userId = null, DateTime? createdBefore = null, DateTime? createdAfter = null, bool? withTotalResultSize = null, bool? includeOld = null)

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var applicationId = 56;  // int? |  (optional) 
            var entityPath = entityPath_example;  // string | Filter results on a case insensitive matching of the url path of the entity (optional) 
            var userId = 56;  // int? |  (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, `hasMore` will be true whenever there is a next page. `totalResultSize` will always be zero. With this flag set to false, `hasMore` will always be set to false. `totalResultSize` will contain the total number of results for this query.  (optional) 
            var includeOld = true;  // bool? | When this flag is set to false, the state without the change will not be returned. The default value is true. (optional) 

            try
            {
                // Get audit log for an account
                InlineResponse20027 result = apiInstance.GetChanges(pageSize, skip, sort, applicationId, entityPath, userId, createdBefore, createdAfter, withTotalResultSize, includeOld);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **applicationId** | **int?**|  | [optional] 
 **entityPath** | **string**| Filter results on a case insensitive matching of the url path of the entity | [optional] 
 **userId** | **int?**|  | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result will include the total size of the result, across all pages. This might decrease performance on large data sets. With this flag set to true, &#x60;hasMore&#x60; will be true whenever there is a next page. &#x60;totalResultSize&#x60; will always be zero. With this flag set to false, &#x60;hasMore&#x60; will always be set to false. &#x60;totalResultSize&#x60; will contain the total number of results for this query.  | [optional] 
 **includeOld** | **bool?**| When this flag is set to false, the state without the change will not be returned. The default value is true. | [optional] 

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


## GetCouponsByAttributes

> InlineResponse2004 GetCouponsByAttributes (int applicationId, int campaignId, CouponSearch body, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, bool? exactMatch = null, string batchId = null)

List coupons that match the given attributes

Get a list of all the coupons that exactly match a set of attributes.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // List coupons that match the given attributes
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
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


## GetCouponsWithoutTotalCount

> InlineResponse2005 GetCouponsWithoutTotalCount (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null)

List coupons

List all the coupons matching the specified criteria. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // List coupons
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

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

> CustomerActivityReport GetCustomerActivityReport (DateTime rangeStart, DateTime rangeEnd, int applicationId, int customerId, int? pageSize = null, int? skip = null)

Get customer's activity report

Fetch the summary report of a given customer in the given application, in a time range.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get customer's activity report
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

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


## GetCustomerActivityReportsWithoutTotalCount

> InlineResponse20014 GetCustomerActivityReportsWithoutTotalCount (DateTime rangeStart, DateTime rangeEnd, int applicationId, int? pageSize = null, int? skip = null, string sort = null, string name = null, string integrationId = null, string campaignName = null, string advocateName = null)

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var name = name_example;  // string | Only return reports matching the customer name (optional) 
            var integrationId = integrationId_example;  // string | Only return reports matching the integrationId (optional) 
            var campaignName = campaignName_example;  // string | Only return reports matching the campaignName (optional) 
            var advocateName = advocateName_example;  // string | Only return reports matching the current customer referrer name (optional) 

            try
            {
                // Get Activity Reports for Application Customers
                InlineResponse20014 result = apiInstance.GetCustomerActivityReportsWithoutTotalCount(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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


## GetCustomerAnalytics

> CustomerAnalytics GetCustomerAnalytics (int applicationId, int customerId, int? pageSize = null, int? skip = null, string sort = null)

Get customer's analytics report

Fetch analytics for a given customer in the given application.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // Get customer's analytics report
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> CustomerProfile GetCustomerProfile (int customerId)

Get customer profile

Return the details of the specified customer profile.  **Performance tip:** You can retrieve the same information via the Integration API, which can save you extra API requests. Consider these options: - Request the customer profile to be part of the response content using   [Update Customer Session](/integration-api/operation#updateCustomerSessionV2). - Send an empty update with the [Update Customer Profile](/integration-api/#operation/updateCustomerProfileV2) endpoint with `runRuleEngine=false`. 

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
            var customerId = 56;  // int | 

            try
            {
                // Get customer profile
                CustomerProfile result = apiInstance.GetCustomerProfile(customerId);
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
 **customerId** | **int**|  | 

### Return type

[**CustomerProfile**](CustomerProfile.md)

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

> InlineResponse20013 GetCustomerProfiles (int? pageSize = null, int? skip = null)

List customer profiles

List all customer profiles.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List customer profiles
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

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

> InlineResponse20013 GetCustomersByAttributes (CustomerProfileSearchQuery body, int? pageSize = null, int? skip = null)

List customer profiles matching the given attributes

Get a list of the customer profiles matching the provided criteria.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request. 

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
            var body = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | 
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List customer profiles matching the given attributes
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
 **body** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md)|  | 
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

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

> InlineResponse20025 GetEventTypes (string applicationIds = null, string name = null, bool? includeOldVersions = null, int? pageSize = null, int? skip = null, string sort = null)

List Event Types

Fetch all event type definitions for your account. 

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
            var includeOldVersions = true;  // bool? | Include all versions of every event type. (optional)  (default to false)
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
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
 **includeOldVersions** | **bool?**| Include all versions of every event type. | [optional] [default to false]
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse20028 GetExports (int? pageSize = null, int? skip = null, int? applicationId = null, int? campaignId = null, string entity = null)

Get Exports

List all past exports 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var applicationId = 56;  // int? |  (optional) 
            var campaignId = 56;  // int? |  (optional) 
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **applicationId** | **int?**|  | [optional] 
 **campaignId** | **int?**|  | [optional] 
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


## GetLoyaltyPoints

> LoyaltyLedger GetLoyaltyPoints (string programID, string integrationID)

Get the Loyalty Ledger for this integrationID

Get the loyalty ledger for this profile integration ID.  To get the `integrationId` of the profile, you can use the [Update customer session](/integration-api/#operation/updateCustomerSessionV2) or [Update customer profile](/integration-api/#operation/updateCustomerProfileV2) endpoints. 

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
                // Get the Loyalty Ledger for this integrationID
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

> LoyaltyProgram GetLoyaltyProgram (int programID)

Get loyalty program

Get the specified [loyalty program](https://www.talon.one/glossary/loyalty). To list all loyalty programs, use [List loyalty programs](#operation/getLoyaltyPrograms). 

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
            var programID = 56;  // int | 

            try
            {
                // Get loyalty program
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
 **programID** | **int**|  | 

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

> InlineResponse2007 GetLoyaltyPrograms ()

List loyalty programs

List the loyalty programs of the account.

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
                // List loyalty programs
                InlineResponse2007 result = apiInstance.GetLoyaltyPrograms();
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


## GetLoyaltyStatistics

> LoyaltyStatistics GetLoyaltyStatistics (string programID)

Get loyalty program statistics by loyalty program ID

Retrieve the statistics of the specified loyalty program such as the total active points, pending points, spent points and expired points. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyStatisticsExample
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
                // Get loyalty program statistics by loyalty program ID
                LoyaltyStatistics result = apiInstance.GetLoyaltyStatistics(programID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyStatistics: " + e.Message );
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

[**LoyaltyStatistics**](LoyaltyStatistics.md)

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

> InlineResponse2006 GetReferralsWithoutTotalCount (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null, string code = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, string advocate = null)

List referrals

List all referrals of the specified campaign.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var code = code_example;  // string | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches referrals in which the expiry date is set and in the past. The second matches referrals in which start date is null or in the past and expiry date is null or in the future, the third matches referrals in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only referrals where `usageCounter < usageLimit` will be returned, \"false\" will return only referrals where `usageCounter >= usageLimit`.  (optional) 
            var advocate = advocate_example;  // string | Filter results by match with a profile id specified in the referral's AdvocateProfileIntegrationId field (optional) 

            try
            {
                // List referrals
                InlineResponse2006 result = apiInstance.GetReferralsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **code** | **string**| Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
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


## GetRole

> Role GetRole (int roleId)

Get role

Get the details of the specified role. To see all the roles, use [List roles](#operation/getAllRoles). 

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
                // Get role
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

Get ruleset

Retrieve the specified ruleset.

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
                // Get ruleset
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

> InlineResponse2003 GetRulesets (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null)

List campaign rulesets

List all rulesets of this campaign. A ruleset is a revision of the rules of a campaign. **Important:** The response also includes deleted rules. You should only consider the latest revision of the returned rulesets. 

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List campaign rulesets
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

Get a single user

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
                // Get a single user
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

> InlineResponse20026 GetUsers (int? pageSize = null, int? skip = null, string sort = null)

List users in account

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 

            try
            {
                // List users in account
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
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

> InlineResponse20023 GetWebhookActivationLogs (int? pageSize = null, int? skip = null, string sort = null, string integrationRequestUuid = null, decimal? webhookId = null, decimal? applicationId = null, decimal? campaignId = null, DateTime? createdBefore = null, DateTime? createdAfter = null)

List webhook activation log entries

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var integrationRequestUuid = integrationRequestUuid_example;  // string | Filter results by integration request UUID. (optional) 
            var webhookId = 8.14;  // decimal? | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal? |  (optional) 
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. (optional) 

            try
            {
                // List webhook activation log entries
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **integrationRequestUuid** | **string**| Filter results by integration request UUID. | [optional] 
 **webhookId** | **decimal?**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal?**|  | [optional] 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime?**| Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 

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

> InlineResponse20024 GetWebhookLogs (int? pageSize = null, int? skip = null, string sort = null, string status = null, decimal? webhookId = null, decimal? applicationId = null, decimal? campaignId = null, string requestUuid = null, DateTime? createdBefore = null, DateTime? createdAfter = null)

List webhook log entries

Retrieve all webhook log entries.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var webhookId = 8.14;  // decimal? | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal? |  (optional) 
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var requestUuid = requestUuid_example;  // string | Filter results by request UUID. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. (optional) 

            try
            {
                // List webhook log entries
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **webhookId** | **decimal?**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal?**|  | [optional] 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **requestUuid** | **string**| Filter results by request UUID. | [optional] 
 **createdBefore** | **DateTime?**| Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 

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

> InlineResponse20022 GetWebhooks (string applicationIds = null, string sort = null, int? pageSize = null, int? skip = null)

List webhooks

List all webhooks.

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List webhooks
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

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


## ImportCoupons

> Import ImportCoupons (int applicationId, int campaignId, string upFile = null)

Import coupons via CSV file

Upload a CSV file containing the coupons that should be created. The file should be sent as multipart data.  The CSV file can contain the following columns:  - `value` (required): The coupon code. - `expirydate`: The end date in RFC3339 of the code redemption period. - `startdate`: The start date in RFC3339 of the code redemption period. - `limitval`: The maximum amount of redemptions of this code. Defaults to `1` when not provided. - `attributes`: A json object describing _custom_ referral attribute names and their values. Double the double-quotes in the object.   For example, if you created a custom attribute called `category`, set it with `\"{\"\"category\"\": \"\"10_off\"\"}\"`.  You can use thhe timezone of your choice. It is converted to UTC internally by Talon.One.  Example:  ``` \"value\",\"expirydate\",\"startdate\",\"recipientintegrationid\",\"limitval\",\"attributes\" COUP1,2018-07-01T04:00:00Z,2018-05-01T04:00:00Z,cust123,1,\"{\"\"Category\"\": \"\"10_off\"\"}\" ```  Once imported, you can find the `batchId` in the Campaign Manager or by using [List coupons](#operation/getReservedCustomers). 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCouponsExample
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
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import coupons via CSV file
                Import result = apiInstance.ImportCoupons(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCoupons: " + e.Message );
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
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportLoyaltyPoints

> Import ImportLoyaltyPoints (int programID, string upFile = null)

Import loyalty points via CSV file

Upload a CSV file containing the [loyalty](https://www.talon.one/glossary/loyalty) points that should be created. The file should be sent as multipart data.\" 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var programID = 56;  // int | 
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import loyalty points via CSV file
                Import result = apiInstance.ImportLoyaltyPoints(programID, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportLoyaltyPoints: " + e.Message );
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
 **programID** | **int**|  | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportPoolGiveaways

> Import ImportPoolGiveaways (int poolId, string upFile = null)

Import giveaway codes into a giveaway pool

Upload a CSV file containing the giveaway codes that should be created. Send the file as multipart data.  The CSV file can contain the following columns: - `code` (required): the code of your giveaway, for instance, a gift card redemption code. - `startdate`:  the start date in RFC3339 of the code redemption period. - `enddate`: the last date in RFC3339 of the code redemption period. - `attributes`: A json object describing _custom_ giveaway attribute names and their values. Double the double-quotes in the object.   For example, if you created a custom attribute called `provider`, set it with `\"{\"\"provider\"\": \"\"myPartnerCompany\"\"}\"`.  The `startdate` and `enddate` have nothing to do with the _validity_ of the codes. They are only used by the Rule Engine to award the codes or not. You can use the timezone of your choice. It is converted to UTC internally by Talon.One. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportPoolGiveawaysExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: manager_auth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(Configuration.Default);
            var poolId = 56;  // int | 
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import giveaway codes into a giveaway pool
                Import result = apiInstance.ImportPoolGiveaways(poolId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportPoolGiveaways: " + e.Message );
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
 **poolId** | **int**|  | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportReferrals

> Import ImportReferrals (int applicationId, int campaignId, string upFile = null)

Import referrals via CSV file

Upload a CSV file containing the referrals that should be created. The file should be sent as multipart data.  The CSV file can contain the following columns:  - `code` (required): The referral code. - `advocateprofileintegrationid` (required): The profile ID of the advocate. - `startdate`: The start date in RFC3339 of the code redemption period. - `expirydate`: The end date in RFC3339 of the code redemption period. - `limitval`: The maximum amount of redemptions of this code. Unlimited (0) when blank. - `attributes`: A json object describing _custom_ referral attribute names and their values. Double the double-quotes in the object.   For example, if you created a custom attribute called `category`, set it with `\"{\"\"category\"\": \"\"10_off\"\"}\"`.  You can use the timezone of your choice. It is converted to UTC internally by Talon.One. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportReferralsExample
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
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import referrals via CSV file
                Import result = apiInstance.ImportReferrals(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportReferrals: " + e.Message );
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
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[manager_auth](../README.md#manager_auth)

### HTTP request headers

- **Content-Type**: multipart/form-data
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

Deduct points in loyalty program for given customer

Remove points from the specified loyalty program and specified customer profile.  To get the `integrationId` of the customer profile, you can use the [Update customer session](/integration-api/#operation/updateCustomerSessionV2) or [Update customer profile](/integration-api/#operation/updateCustomerProfileV2) endpoints. 

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
                // Deduct points in loyalty program for given customer
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


## SearchCouponsAdvancedApplicationWideWithoutTotalCount

> InlineResponse2005 SearchCouponsAdvancedApplicationWideWithoutTotalCount (int applicationId, Object body, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null, string campaignState = null)

List coupons that match the given attributes in all active campaigns of an application

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign. (optional) 

            try
            {
                // List coupons that match the given attributes in all active campaigns of an application
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
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

> InlineResponse2005 SearchCouponsAdvancedWithoutTotalCount (int applicationId, int campaignId, Object body, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, bool? exactMatch = null, string batchId = null)

List coupons that match the given attributes

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
            var pageSize = 56;  // int? | The number of items to include in this response. When omitted, the maximum value of 1000 will be used. (optional) 
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with `-` to sort in descending order. (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // List coupons that match the given attributes
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
 **pageSize** | **int?**| The number of items to include in this response. When omitted, the maximum value of 1000 will be used. | [optional] 
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. Sorting defaults to ascending order, prefix the field name with &#x60;-&#x60; to sort in descending order. | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiry date is set and in the past. The second matches coupons in which start date is null or in the past and expiry date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the Id of a referral, that meaning the coupons that had been created as an effect of the usage of a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
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

Update campaign

Update the given campaign.

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
                // Update campaign
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

Update coupon

Update the specified coupon.

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
                // Update coupon
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

Update a batch of coupons

Update a batch of coupons. You can find the `batchId` in the **Coupons** view of your Application in the Campaign Manager or by using [List coupons](#operation/getCouponsWithoutTotalCount).  To update a specific coupon, use [Update coupon](#operation/updateCoupon). 

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
                // Update a batch of coupons
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


## UpdateReferral

> Referral UpdateReferral (int applicationId, int campaignId, string referralId, UpdateReferral body)

Update referral

Update the specified referral.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateReferralExample
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
            var body = new UpdateReferral(); // UpdateReferral | 

            try
            {
                // Update referral
                Referral result = apiInstance.UpdateReferral(applicationId, campaignId, referralId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateReferral: " + e.Message );
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
 **body** | [**UpdateReferral**](UpdateReferral.md)|  | 

### Return type

[**Referral**](Referral.md)

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


## UpdateRuleset

> Ruleset UpdateRuleset (int applicationId, int campaignId, int rulesetId, NewRuleset body)

Update ruleset

Update a ruleset.

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
                // Update ruleset
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

