# TalonOne.Api.ManagementApi

All URIs are relative to *https://yourbaseurl.talon.one*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoyaltyCardPoints**](ManagementApi.md#addloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/add_points | Add points to card
[**AddLoyaltyPoints**](ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/add_points | Add points to customer profile
[**CopyCampaignToApplications**](ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into the specified Application
[**CreateAccountCollection**](ManagementApi.md#createaccountcollection) | **POST** /v1/collections | Create account-level collection
[**CreateAdditionalCost**](ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Create additional cost
[**CreateAttribute**](ManagementApi.md#createattribute) | **POST** /v1/attributes | Create custom attribute
[**CreateCampaignFromTemplate**](ManagementApi.md#createcampaignfromtemplate) | **POST** /v1/applications/{applicationId}/create_campaign_from_template | Create campaign from campaign template
[**CreateCollection**](ManagementApi.md#createcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | Create collection
[**CreateCoupons**](ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create coupons
[**CreateCouponsAsync**](ManagementApi.md#createcouponsasync) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_async | Create coupons asynchronously
[**CreateCouponsForMultipleRecipients**](ManagementApi.md#createcouponsformultiplerecipients) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_with_recipients | Create coupons for multiple recipients
[**CreateNotificationWebhook**](ManagementApi.md#createnotificationwebhook) | **POST** /v1/applications/{applicationId}/notification_webhooks | Create notification about campaign-related changes
[**CreatePasswordRecoveryEmail**](ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset
[**CreateSession**](ManagementApi.md#createsession) | **POST** /v1/sessions | Create session
[**DeductLoyaltyCardPoints**](ManagementApi.md#deductloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/deduct_points | Deduct points from card
[**DeleteAccountCollection**](ManagementApi.md#deleteaccountcollection) | **DELETE** /v1/collections/{collectionId} | Delete account-level collection
[**DeleteCampaign**](ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete campaign
[**DeleteCollection**](ManagementApi.md#deletecollection) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Delete collection
[**DeleteCoupon**](ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete coupon
[**DeleteCoupons**](ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete coupons
[**DeleteLoyaltyCard**](ManagementApi.md#deleteloyaltycard) | **DELETE** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Delete loyalty card
[**DeleteNotificationWebhook**](ManagementApi.md#deletenotificationwebhook) | **DELETE** /v1/applications/{applicationId}/notification_webhooks/{notificationWebhookId} | Delete notification about campaign-related changes
[**DeleteReferral**](ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete referral
[**DestroySession**](ManagementApi.md#destroysession) | **DELETE** /v1/sessions | Destroy session
[**ExportAccountCollectionItems**](ManagementApi.md#exportaccountcollectionitems) | **GET** /v1/collections/{collectionId}/export | Export account-level collection&#39;s items
[**ExportCollectionItems**](ManagementApi.md#exportcollectionitems) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/export | Export a collection&#39;s items
[**ExportCoupons**](ManagementApi.md#exportcoupons) | **GET** /v1/applications/{applicationId}/export_coupons | Export coupons
[**ExportCustomerSessions**](ManagementApi.md#exportcustomersessions) | **GET** /v1/applications/{applicationId}/export_customer_sessions | Export customer sessions
[**ExportEffects**](ManagementApi.md#exporteffects) | **GET** /v1/applications/{applicationId}/export_effects | Export triggered effects
[**ExportLoyaltyBalance**](ManagementApi.md#exportloyaltybalance) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balance | Export customer loyalty balance to CSV
[**ExportLoyaltyBalances**](ManagementApi.md#exportloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balances | Export customer loyalty balances
[**ExportLoyaltyCardBalances**](ManagementApi.md#exportloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_card_balances | Export all card transaction logs
[**ExportLoyaltyCardLedger**](ManagementApi.md#exportloyaltycardledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/export_log | Export card&#39;s ledger log
[**ExportLoyaltyLedger**](ManagementApi.md#exportloyaltyledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/export_log | Export customer&#39;s transaction logs
[**ExportReferrals**](ManagementApi.md#exportreferrals) | **GET** /v1/applications/{applicationId}/export_referrals | Export referrals
[**GetAccessLogsWithoutTotalCount**](ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for Application
[**GetAccount**](ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get account details
[**GetAccountAnalytics**](ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get account analytics
[**GetAccountCollection**](ManagementApi.md#getaccountcollection) | **GET** /v1/collections/{collectionId} | Get account-level collection
[**GetAdditionalCost**](ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get additional cost
[**GetAdditionalCosts**](ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs
[**GetAllAccessLogs**](ManagementApi.md#getallaccesslogs) | **GET** /v1/access_logs | List access logs
[**GetAllRoles**](ManagementApi.md#getallroles) | **GET** /v1/roles | List roles
[**GetApplication**](ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application
[**GetApplicationApiHealth**](ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get Application health
[**GetApplicationCustomer**](ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get application&#39;s customer
[**GetApplicationCustomerFriends**](ManagementApi.md#getapplicationcustomerfriends) | **GET** /v1/applications/{applicationId}/profile/{integrationId}/friends | List friends referred by customer profile
[**GetApplicationCustomers**](ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List application&#39;s customers
[**GetApplicationCustomersByAttributes**](ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/applications/{applicationId}/customer_search | List application customers matching the given attributes
[**GetApplicationEventTypes**](ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications event types
[**GetApplicationEventsWithoutTotalCount**](ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications events
[**GetApplicationSession**](ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application session
[**GetApplicationSessions**](ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application sessions
[**GetApplications**](ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications
[**GetAttribute**](ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get custom attribute
[**GetAttributes**](ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes
[**GetAudiences**](ManagementApi.md#getaudiences) | **GET** /v1/audiences | List audiences
[**GetCampaign**](ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get campaign
[**GetCampaignAnalytics**](ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns
[**GetCampaignByAttributes**](ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | List campaigns that match the given attributes
[**GetCampaignTemplates**](ManagementApi.md#getcampaigntemplates) | **GET** /v1/campaign_templates | List campaign templates
[**GetCampaigns**](ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List campaigns
[**GetChanges**](ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit logs for an account
[**GetCollection**](ManagementApi.md#getcollection) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Get collection
[**GetCollectionItems**](ManagementApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items
[**GetCouponsWithoutTotalCount**](ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List coupons
[**GetCustomerActivityReport**](ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get customer&#39;s activity report
[**GetCustomerActivityReportsWithoutTotalCount**](ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers
[**GetCustomerAnalytics**](ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get customer&#39;s analytics report
[**GetCustomerProfile**](ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get customer profile
[**GetCustomerProfiles**](ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List customer profiles
[**GetCustomersByAttributes**](ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | List customer profiles matching the given attributes
[**GetEventTypes**](ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List event types
[**GetExports**](ManagementApi.md#getexports) | **GET** /v1/exports | Get exports
[**GetLoyaltyCard**](ManagementApi.md#getloyaltycard) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Get loyalty card
[**GetLoyaltyCardTransactionLogs**](ManagementApi.md#getloyaltycardtransactionlogs) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/logs | List card&#39;s transactions
[**GetLoyaltyCards**](ManagementApi.md#getloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards | List loyalty cards
[**GetLoyaltyPoints**](ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId} | Get customer&#39;s full loyalty ledger
[**GetLoyaltyProgram**](ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{loyaltyProgramId} | Get loyalty program
[**GetLoyaltyProgramTransactions**](ManagementApi.md#getloyaltyprogramtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/transactions | List loyalty program transactions
[**GetLoyaltyPrograms**](ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List loyalty programs
[**GetLoyaltyStatistics**](ManagementApi.md#getloyaltystatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/statistics | Get loyalty program statistics
[**GetNotificationWebhook**](ManagementApi.md#getnotificationwebhook) | **GET** /v1/applications/{applicationId}/notification_webhooks/{notificationWebhookId} | Get notification about campaign-related changes
[**GetNotificationWebhooks**](ManagementApi.md#getnotificationwebhooks) | **GET** /v1/applications/{applicationId}/notification_webhooks | List notifications about campaign-related changes
[**GetReferralsWithoutTotalCount**](ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List referrals
[**GetRole**](ManagementApi.md#getrole) | **GET** /v1/roles/{roleId} | Get role
[**GetRuleset**](ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get ruleset
[**GetRulesets**](ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List campaign rulesets
[**GetUser**](ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get user
[**GetUsers**](ManagementApi.md#getusers) | **GET** /v1/users | List users in account
[**GetWebhook**](ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get webhook
[**GetWebhookActivationLogs**](ManagementApi.md#getwebhookactivationlogs) | **GET** /v1/webhook_activation_logs | List webhook activation log entries
[**GetWebhookLogs**](ManagementApi.md#getwebhooklogs) | **GET** /v1/webhook_logs | List webhook log entries
[**GetWebhooks**](ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List webhooks
[**ImportAccountCollection**](ManagementApi.md#importaccountcollection) | **POST** /v1/collections/{collectionId}/import | Import data in existing account-level collection
[**ImportAllowedList**](ManagementApi.md#importallowedlist) | **POST** /v1/attributes/{attributeId}/allowed_list/import | Import allowed values for attribute
[**ImportCollection**](ManagementApi.md#importcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/import | Import data in existing collection
[**ImportCoupons**](ManagementApi.md#importcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_coupons | Import coupons
[**ImportLoyaltyCards**](ManagementApi.md#importloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_cards | Import loyalty cards
[**ImportLoyaltyPoints**](ManagementApi.md#importloyaltypoints) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_points | Import loyalty points
[**ImportPoolGiveaways**](ManagementApi.md#importpoolgiveaways) | **POST** /v1/giveaways/pools/{poolId}/import | Import giveaway codes into a giveaway pool
[**ImportReferrals**](ManagementApi.md#importreferrals) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_referrals | Import referrals
[**ListAccountCollections**](ManagementApi.md#listaccountcollections) | **GET** /v1/collections | List collections in account
[**ListCollections**](ManagementApi.md#listcollections) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | List collections
[**ListCollectionsInApplication**](ManagementApi.md#listcollectionsinapplication) | **GET** /v1/applications/{applicationId}/collections | List collections in application
[**PostAddedDeductedPointsNotification**](ManagementApi.md#postaddeddeductedpointsnotification) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/notifications/added_deducted_points | Create notification about added or deducted loyalty points
[**PostCatalogsStrikethroughNotification**](ManagementApi.md#postcatalogsstrikethroughnotification) | **POST** /v1/catalogs/{applicationId}/notifications/strikethrough | Create strikethrough notification
[**RemoveLoyaltyPoints**](ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/deduct_points | Deduct points from customer profile
[**ResetPassword**](ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password
[**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | List coupons that match the given attributes (without total count)
[**SearchCouponsAdvancedWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | List coupons that match the given attributes in campaign (without total count)
[**TransferLoyaltyCard**](ManagementApi.md#transferloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transfer | Transfer card data
[**UpdateAccountCollection**](ManagementApi.md#updateaccountcollection) | **PUT** /v1/collections/{collectionId} | Update account-level collection
[**UpdateAdditionalCost**](ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update additional cost
[**UpdateAttribute**](ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update custom attribute
[**UpdateCampaign**](ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update campaign
[**UpdateCollection**](ManagementApi.md#updatecollection) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Update collection description
[**UpdateCoupon**](ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update coupon
[**UpdateCouponBatch**](ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update coupons
[**UpdateLoyaltyCard**](ManagementApi.md#updateloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Update loyalty card status
[**UpdateNotificationWebhook**](ManagementApi.md#updatenotificationwebhook) | **PUT** /v1/applications/{applicationId}/notification_webhooks/{notificationWebhookId} | Update notification about campaign-related changes
[**UpdateReferral**](ManagementApi.md#updatereferral) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Update referral


<a name="addloyaltycardpoints"></a>
# **AddLoyaltyCardPoints**
> void AddLoyaltyCardPoints (int loyaltyProgramId, string loyaltyCardId, AddLoyaltyPoints body)

Add points to card

Add points to the given loyalty card in the specified card-based loyalty program. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class AddLoyaltyCardPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var body = new AddLoyaltyPoints(); // AddLoyaltyPoints | body

            try
            {
                // Add points to card
                apiInstance.AddLoyaltyCardPoints(loyaltyProgramId, loyaltyCardId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.AddLoyaltyCardPoints: " + e.Message );
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
 **body** | [**AddLoyaltyPoints**](AddLoyaltyPoints.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="addloyaltypoints"></a>
# **AddLoyaltyPoints**
> void AddLoyaltyPoints (string loyaltyProgramId, string integrationId, AddLoyaltyPoints body)

Add points to customer profile

Add points in the specified loyalty program for the given customer.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var integrationId = integrationId_example;  // string | The identifier of the profile.
            var body = new AddLoyaltyPoints(); // AddLoyaltyPoints | body

            try
            {
                // Add points to customer profile
                apiInstance.AddLoyaltyPoints(loyaltyProgramId, integrationId, body);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **integrationId** | **string**| The identifier of the profile. | 
 **body** | [**AddLoyaltyPoints**](AddLoyaltyPoints.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="copycampaigntoapplications"></a>
# **CopyCampaignToApplications**
> InlineResponse2004 CopyCampaignToApplications (int applicationId, int campaignId, CampaignCopy body)

Copy the campaign into the specified Application

Copy the campaign into all specified Applications.

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new CampaignCopy(); // CampaignCopy | body

            try
            {
                // Copy the campaign into the specified Application
                InlineResponse2004 result = apiInstance.CopyCampaignToApplications(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**CampaignCopy**](CampaignCopy.md)| body | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaccountcollection"></a>
# **CreateAccountCollection**
> Collection CreateAccountCollection (NewCollection body)

Create account-level collection

Create account-level collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new NewCollection(); // NewCollection | body

            try
            {
                // Create account-level collection
                Collection result = apiInstance.CreateAccountCollection(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAccountCollection: " + e.Message );
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
 **body** | [**NewCollection**](NewCollection.md)| body | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. A Collection with this name already exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createadditionalcost"></a>
# **CreateAdditionalCost**
> AccountAdditionalCost CreateAdditionalCost (NewAdditionalCost body)

Create additional cost

Create an [additional cost](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs).  These additional costs are shared across all applications in your account, and are never required. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new NewAdditionalCost(); // NewAdditionalCost | body

            try
            {
                // Create additional cost
                AccountAdditionalCost result = apiInstance.CreateAdditionalCost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**NewAdditionalCost**](NewAdditionalCost.md)| body | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createattribute"></a>
# **CreateAttribute**
> Attribute CreateAttribute (NewAttribute body)

Create custom attribute

Create a _custom attribute_ in this account. [Custom attributes](https://docs.talon.one/docs/dev/concepts/attributes) allow you to add data to Talon.One domain entities like campaigns, coupons, customers and so on.  These attributes can then be given values when creating/updating these entities, and these values can be used in your campaign rules.  For example, you could define a `zipCode` field for customer sessions, and add a rule to your campaign that only allows certain ZIP codes.  These attributes are shared across all Applications in your account and are never required. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new NewAttribute(); // NewAttribute | body

            try
            {
                // Create custom attribute
                Attribute result = apiInstance.CreateAttribute(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**NewAttribute**](NewAttribute.md)| body | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcampaignfromtemplate"></a>
# **CreateCampaignFromTemplate**
> CreateTemplateCampaignResponse CreateCampaignFromTemplate (int applicationId, CreateTemplateCampaign body)

Create campaign from campaign template

Use the campaign template referenced in the request body to create a new campaign in one of the connected Applications.  If the template was created from a campaign with rules referencing [campaign collections](https://docs.talon.one/docs/product/campaigns/managing-collections), the corresponding collections for the new campaign are created automatically. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCampaignFromTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = new CreateTemplateCampaign(); // CreateTemplateCampaign | body

            try
            {
                // Create campaign from campaign template
                CreateTemplateCampaignResponse result = apiInstance.CreateCampaignFromTemplate(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCampaignFromTemplate: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | [**CreateTemplateCampaign**](CreateTemplateCampaign.md)| body | 

### Return type

[**CreateTemplateCampaignResponse**](CreateTemplateCampaignResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcollection"></a>
# **CreateCollection**
> Collection CreateCollection (int applicationId, int campaignId, NewCampaignCollection body)

Create collection

Create a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new NewCampaignCollection(); // NewCampaignCollection | body

            try
            {
                // Create collection
                Collection result = apiInstance.CreateCollection(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCollection: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewCampaignCollection**](NewCampaignCollection.md)| body | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcoupons"></a>
# **CreateCoupons**
> InlineResponse2007 CreateCoupons (int applicationId, int campaignId, NewCoupons body, string silent = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new NewCoupons(); // NewCoupons | body
            var silent = silent_example;  // string | Possible values: `yes` or `no`. - `yes`: Increases the perfomance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Create coupons
                InlineResponse2007 result = apiInstance.CreateCoupons(applicationId, campaignId, body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewCoupons**](NewCoupons.md)| body | 
 **silent** | **string**| Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the perfomance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcouponsasync"></a>
# **CreateCouponsAsync**
> AsyncCouponCreationResponse CreateCouponsAsync (int applicationId, int campaignId, NewCouponCreationJob body)

Create coupons asynchronously

Create up to 5,000,000 coupons asynchronously. You should typically use this enpdoint when you create at least 20,001 coupons. You receive an email when the creation is complete.  If you want to create less than 20,001 coupons, you can use the [Create coupons](https://docs.talon.one/management-api#tag/Coupons/operation/createCoupons) endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new NewCouponCreationJob(); // NewCouponCreationJob | body

            try
            {
                // Create coupons asynchronously
                AsyncCouponCreationResponse result = apiInstance.CreateCouponsAsync(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCouponsAsync: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewCouponCreationJob**](NewCouponCreationJob.md)| body | 

### Return type

[**AsyncCouponCreationResponse**](AsyncCouponCreationResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcouponsformultiplerecipients"></a>
# **CreateCouponsForMultipleRecipients**
> InlineResponse2007 CreateCouponsForMultipleRecipients (int applicationId, int campaignId, NewCouponsForMultipleRecipients body, string silent = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new NewCouponsForMultipleRecipients(); // NewCouponsForMultipleRecipients | body
            var silent = silent_example;  // string | Possible values: `yes` or `no`. - `yes`: Increases the perfomance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Create coupons for multiple recipients
                InlineResponse2007 result = apiInstance.CreateCouponsForMultipleRecipients(applicationId, campaignId, body, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewCouponsForMultipleRecipients**](NewCouponsForMultipleRecipients.md)| body | 
 **silent** | **string**| Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the perfomance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnotificationwebhook"></a>
# **CreateNotificationWebhook**
> NotificationWebhook CreateNotificationWebhook (int applicationId, NewNotificationWebhook body)

Create notification about campaign-related changes

Create a [notification about campaign-related changes](https://docs.talon.one/docs/product/applications/outbound-notifications).  A notification about campaign-related changes is different from regular webhooks in that it is Application-scoped and has a predefined payload. [Regular webhooks](https://docs.talon.one/docs/dev/getting-started/webhooks) have user-definable payloads.  **Tip:**  - You can create these notifications using the Campaign Manager. See [Managing notifications](https://docs.talon.one/docs/product/applications/outbound-notifications). - You can review the payload you will receive in the [specs](https://docs.talon.one/outbound-notifications#/paths/campaign_created/post). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateNotificationWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = new NewNotificationWebhook(); // NewNotificationWebhook | body

            try
            {
                // Create notification about campaign-related changes
                NotificationWebhook result = apiInstance.CreateNotificationWebhook(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateNotificationWebhook: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewNotificationWebhook**](NewNotificationWebhook.md)| body | 

### Return type

[**NotificationWebhook**](NotificationWebhook.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpasswordrecoveryemail"></a>
# **CreatePasswordRecoveryEmail**
> NewPasswordEmail CreatePasswordRecoveryEmail (NewPasswordEmail body)

Request a password reset

Send an email with a password recovery link to the email address of an existing account.  **Note:** The password recovery link expires 30 minutes after this endpoint is triggered. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new NewPasswordEmail(); // NewPasswordEmail | body

            try
            {
                // Request a password reset
                NewPasswordEmail result = apiInstance.CreatePasswordRecoveryEmail(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**NewPasswordEmail**](NewPasswordEmail.md)| body | 

### Return type

[**NewPasswordEmail**](NewPasswordEmail.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsession"></a>
# **CreateSession**
> Session CreateSession (LoginParams body)

Create session

Create a session to use the Management API endpoints. Use the value of the `token` property provided in the response as bearer token in other API calls.  A token is valid for 3 months. In accordance with best pratices, use your generated token for all your API requests. Do **not** regenerate a token for each request.  This endpoint has a rate limit of 3 to 6 requests per second per account, depending on your setup.  <div class=\"redoc-section\">   <p class=\"title\">Granular API key</p>   Instead of using a session, you can also use the <a href=\"https://docs.talon.one/docs/product/account/dev-tools/managing-mapi-keys\">Management API key feature</a>   in the Campaign Manager to decide which endpoints can be used with a given key. </div> 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new LoginParams(); // LoginParams | body

            try
            {
                // Create session
                Session result = apiInstance.CreateSession(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**LoginParams**](LoginParams.md)| body | 

### Return type

[**Session**](Session.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deductloyaltycardpoints"></a>
# **DeductLoyaltyCardPoints**
> void DeductLoyaltyCardPoints (int loyaltyProgramId, string loyaltyCardId, DeductLoyaltyPoints body)

Deduct points from card

Deduct points from the given loyalty card in the specified card-based loyalty program. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeductLoyaltyCardPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var body = new DeductLoyaltyPoints(); // DeductLoyaltyPoints | body

            try
            {
                // Deduct points from card
                apiInstance.DeductLoyaltyCardPoints(loyaltyProgramId, loyaltyCardId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeductLoyaltyCardPoints: " + e.Message );
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
 **body** | [**DeductLoyaltyPoints**](DeductLoyaltyPoints.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="deleteaccountcollection"></a>
# **DeleteAccountCollection**
> void DeleteAccountCollection (int collectionId)

Delete account-level collection

Delete the given account-level collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Delete account-level collection
                apiInstance.DeleteAccountCollection(collectionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteAccountCollection: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaign"></a>
# **DeleteCampaign**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Delete campaign
                apiInstance.DeleteCampaign(applicationId, campaignId);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> void DeleteCollection (int applicationId, int campaignId, int collectionId)

Delete collection

Delete the given collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Delete collection
                apiInstance.DeleteCollection(applicationId, campaignId, collectionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCollection: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoupon"></a>
# **DeleteCoupon**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var couponId = couponId_example;  // string | The internal ID of the coupon code. You can find this value in the `id` property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response. 

            try
            {
                // Delete coupon
                apiInstance.DeleteCoupon(applicationId, campaignId, couponId);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **couponId** | **string**| The internal ID of the coupon code. You can find this value in the &#x60;id&#x60; property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response.  | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoupons"></a>
# **DeleteCoupons**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var startsAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var startsBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var expiresAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var expiresBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | - `expired`: Matches coupons in which the expiration date is set and in the past. - `validNow`: Matches coupons in which start date is null or in the past and expiration date is null or in the future. - `validFuture`: Matches coupons in which start date is set and in the future.  (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var usable = usable_example;  // string | - `true`: only coupons where `usageCounter < usageLimit` will be returned. - `false`: only coupons where `usageCounter >= usageLimit` will be returned.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's `RecipientIntegrationId` field.  (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // Delete coupons
                apiInstance.DeleteCoupons(applicationId, campaignId, value, createdBefore, createdAfter, startsAfter, startsBefore, expiresAfter, expiresBefore, valid, batchId, usable, referralId, recipientIntegrationId, exactMatch);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **startsAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **startsBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **expiresAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **expiresBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| - &#x60;expired&#x60;: Matches coupons in which the expiration date is set and in the past. - &#x60;validNow&#x60;: Matches coupons in which start date is null or in the past and expiration date is null or in the future. - &#x60;validFuture&#x60;: Matches coupons in which start date is set and in the future.  | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **usable** | **string**| - &#x60;true&#x60;: only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned. - &#x60;false&#x60;: only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60; will be returned.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s &#x60;RecipientIntegrationId&#x60; field.  | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloyaltycard"></a>
# **DeleteLoyaltyCard**
> void DeleteLoyaltyCard (int loyaltyProgramId, string loyaltyCardId)

Delete loyalty card

Delete the given loyalty card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 

            try
            {
                // Delete loyalty card
                apiInstance.DeleteLoyaltyCard(loyaltyProgramId, loyaltyCardId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteLoyaltyCard: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="deletenotificationwebhook"></a>
# **DeleteNotificationWebhook**
> void DeleteNotificationWebhook (int applicationId, int notificationWebhookId)

Delete notification about campaign-related changes

Remove the given existing [notification about campaign-related changes](https://docs.talon.one/docs/product/applications/outbound-notifications). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteNotificationWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var notificationWebhookId = 56;  // int | The ID of the webhook. Get it with the appropriate _List notifications_ endpoint.

            try
            {
                // Delete notification about campaign-related changes
                apiInstance.DeleteNotificationWebhook(applicationId, notificationWebhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteNotificationWebhook: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **notificationWebhookId** | **int**| The ID of the webhook. Get it with the appropriate _List notifications_ endpoint. | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereferral"></a>
# **DeleteReferral**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var referralId = referralId_example;  // string | The ID of the referral code.

            try
            {
                // Delete referral
                apiInstance.DeleteReferral(applicationId, campaignId, referralId);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **referralId** | **string**| The ID of the referral code. | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroysession"></a>
# **DestroySession**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Destroy session
                apiInstance.DestroySession();
            }
            catch (ApiException  e)
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

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportaccountcollectionitems"></a>
# **ExportAccountCollectionItems**
> string ExportAccountCollectionItems (int collectionId)

Export account-level collection's items

Download a CSV file containing items from an account-level collection.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportAccountCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Export account-level collection's items
                string result = apiInstance.ExportAccountCollectionItems(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportAccountCollectionItems: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcollectionitems"></a>
# **ExportCollectionItems**
> string ExportCollectionItems (int applicationId, int campaignId, int collectionId)

Export a collection's items

Download a CSV file containing a collection's items.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Export a collection's items
                string result = apiInstance.ExportCollectionItems(applicationId, campaignId, collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCollectionItems: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcoupons"></a>
# **ExportCoupons**
> string ExportCoupons (int applicationId, decimal? campaignId = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null, string dateFormat = null, string campaignState = null)

Export coupons

Download a CSV file containing the coupons that match the given properties.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns:  - `accountid`: The ID of your deployment. - `applicationid`: The ID of the Application this coupon is related to. - `attributes`: A json object describing _custom_ referral attribute names and their values. - `batchid`: The ID of the batch this coupon is part of. - `campaignid`: The ID of the campaign this coupon is related to. - `counter`: The number of times this coupon has been redeemed. - `created`: The creation date of the coupon code. - `deleted`: Whether the coupon code is deleted. - `deleted_changelogid`: The ID of the delete event in the logs. - `discount_counter`: The amount of discount given by this coupon. - `discount_limitval`: The maximum discount amount that can be given be this coupon. - `expirydate`: The end date in RFC3339 of the code redemption period. - `id`: The internal ID of the coupon code. - `importid`: The ID of the import job that created this coupon. - `is_reservation_mandatory`: Whether this coupon requires a reservation to be redeemed. - `limits`: The limits set on this coupon. - `limitval`: The maximum number of redemptions of this code. - `recipientintegrationid`: The integration ID of the customer considered as recipient of the coupon.   Only the customer with this integration ID can redeem the corresponding coupon code.   Learn about [coupon reservation](https://docs.talon.one/docs/product/rules/effects/using-effects#reserving-a-coupon-code). - `referralid`: The ID of the referral code that triggered the creation of this coupon (create coupon effect). - `reservation`: Whether the coupon is reserved. - `reservation_counter`: How many times this coupon has been reserved. - `reservation_limitval`: The maximum of number of reservations this coupon can have. - `startdate`: The start date in RFC3339 of the code redemption period. - `value`: The coupon code. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived. - `draft`: Campaigns that are drafts.  (optional) 

            try
            {
                // Export coupons
                string result = apiInstance.ExportCoupons(applicationId, campaignId, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, dateFormat, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived. - &#x60;draft&#x60;: Campaigns that are drafts.  | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcustomersessions"></a>
# **ExportCustomerSessions**
> string ExportCustomerSessions (int applicationId, DateTime? createdBefore = null, DateTime? createdAfter = null, string profileIntegrationId = null, string dateFormat = null, string customerSessionState = null)

Export customer sessions

Download a CSV file containing the customer sessions that match the request.  **Important:** Archived sessions cannot be exported. See the [retention policy](https://docs.talon.one/docs/product/server-infrastructure-and-data-retention#data-retention-policy).  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  - `id`: The internal ID of the session. - `firstsession`: Whether this is a first session. - `integrationid`: The integration ID of the session. - `applicationid`: The ID of the Application. - `profileid`: The internal ID of the customer profile. - `profileintegrationid`: The integration ID of the customer profile. - `created`: The timestamp when the session was created. - `state`: The [state](https://docs.talon.one/docs/dev/concepts/entities#customer-session-states) of the session. - `cartitems`: The cart items in the session. - `discounts`: The discounts in the session. - `total`: The total value of the session. - `attributes`: The attributes set in the session. - `closedat`: Timestamp when the session was closed. - `cancelledat`: Timestamp when the session was cancelled. - `referral`: The referral code in the session. - `identifiers`: The identifiers in the session. - `additional_costs`: The [additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs) in the session. - `updated`: Timestamp of the last session update. - `coupons`: Coupon codes in the session. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var profileIntegrationId = profileIntegrationId_example;  // string | Only return sessions for the customer that matches this customer integration ID. (optional) 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 
            var customerSessionState = customerSessionState_example;  // string | Filter results by state. (optional) 

            try
            {
                // Export customer sessions
                string result = apiInstance.ExportCustomerSessions(applicationId, createdBefore, createdAfter, profileIntegrationId, dateFormat, customerSessionState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional] 
 **profileIntegrationId** | **string**| Only return sessions for the customer that matches this customer integration ID. | [optional] 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 
 **customerSessionState** | **string**| Filter results by state. | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exporteffects"></a>
# **ExportEffects**
> string ExportEffects (int applicationId, decimal? campaignId = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string dateFormat = null)

Export triggered effects

Download a CSV file containing the triggered effects that match the given attributes.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `applicationid`: The ID of the Application. - `campaignid`: The ID of the campaign. - `couponid`: The ID of the coupon, when applicable to the effect. - `created`: The timestamp of the effect. - `event_type`: The name of the event. See the [docs](https://docs.talon.one/docs/dev/concepts/events). - `eventid`: The internal ID of the effect. - `name`: The effect name. See the [docs](https://docs.talon.one/docs/dev/integration-api/api-effects). - `profileintegrationid`: The ID of the customer profile, when applicable. - `props`: The [properties](https://docs.talon.one/docs/dev/integration-api/api-effects) of the effect. - `ruleindex`: The index of the rule. - `rulesetid`: The ID of the rule set. - `sessionid`: The internal ID of the session that triggered the effect. - `profileid`: The internal ID of the customer profile. - `sessionintegrationid`: The integration ID of the session. - `total_revenue`: The total revenue. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export triggered effects
                string result = apiInstance.ExportEffects(applicationId, campaignId, createdBefore, createdAfter, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportloyaltybalance"></a>
# **ExportLoyaltyBalance**
> string ExportLoyaltyBalance (string loyaltyProgramId, DateTime? endDate = null)

Export customer loyalty balance to CSV

⚠️ Deprecation notice: Support for requests to this endpoint will end soon. To export customer loyalty balances to CSV, use the [Export customer loyalty balances to CSV](/management-api#tag/Loyalty/operation/exportLoyaltyBalances) endpoint.  Download a CSV file containing the balance of each customer in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  (optional) 

            try
            {
                // Export customer loyalty balance to CSV
                string result = apiInstance.ExportLoyaltyBalance(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **endDate** | **DateTime?**| Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportloyaltybalances"></a>
# **ExportLoyaltyBalances**
> string ExportLoyaltyBalances (string loyaltyProgramId, DateTime? endDate = null)

Export customer loyalty balances

Download a CSV file containing the balance of each customer in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `loyaltyProgramID`: The ID of the loyalty program. - `loyaltySubledger`: The name of the subdleger, when applicatble. - `profileIntegrationID`: The integration ID of the customer profile. - `currentBalance`: The current point balance. - `pendingBalance`: The number of pending points. - `expiredBalance`: The number of expired points. - `spentBalance`: The number of spent points. - `currentTier`: The tier that the customer is in at the time of the export. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  (optional) 

            try
            {
                // Export customer loyalty balances
                string result = apiInstance.ExportLoyaltyBalances(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalances: " + e.Message );
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
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **endDate** | **DateTime?**| Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportloyaltycardbalances"></a>
# **ExportLoyaltyCardBalances**
> string ExportLoyaltyCardBalances (int loyaltyProgramId, DateTime? endDate = null)

Export all card transaction logs

Download a CSV file containing the balances of all cards in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns: - `loyaltyProgramID`: The ID of the loyalty program. - `loyaltySubledger`: The name of the subdleger, when applicatble. - `cardIdentifier`: The alphanumeric identifier of the loyalty card. - `cardState`:The state of the loyalty card. It can be `active` or `inactive`. - `currentBalance`: The current point balance. - `pendingBalance`: The number of pending points. - `expiredBalance`: The number of expired points. - `spentBalance`: The number of spent points. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyCardBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  (optional) 

            try
            {
                // Export all card transaction logs
                string result = apiInstance.ExportLoyaltyCardBalances(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardBalances: " + e.Message );
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
 **endDate** | **DateTime?**| Used to return balances only for entries older than this timestamp. The expired, active, and pending points are relative to this timestamp.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportloyaltycardledger"></a>
# **ExportLoyaltyCardLedger**
> string ExportLoyaltyCardLedger (int loyaltyProgramId, string loyaltyCardId, DateTime rangeStart, DateTime rangeEnd, string dateFormat = null)

Export card's ledger log

Download a CSV file containing a loyalty card ledger log of the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyCardLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export card's ledger log
                string result = apiInstance.ExportLoyaltyCardLedger(loyaltyProgramId, loyaltyCardId, rangeStart, rangeEnd, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardLedger: " + e.Message );
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportloyaltyledger"></a>
# **ExportLoyaltyLedger**
> string ExportLoyaltyLedger (DateTime rangeStart, DateTime rangeEnd, string loyaltyProgramId, string integrationId, string dateFormat = null)

Export customer's transaction logs

Download a CSV file containing a customer's transaction logs in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `customerprofileid`: The ID of the profile. - `customersessionid`: The ID of the customer session. - `rulesetid`: The ID of the rule set. - `rulename`: The name of the rule. - `programid`: The ID of the loyalty program. - `type`: The type of the loyalty program. - `name`: The name of the loyalty program. - `subledgerid`: The ID of the subledger, when applicable. - `startdate`: The start date of the program. - `expirydate`: The expiration date of the program. - `id`: The ID of the transaction. - `created`: The timestamp of the creation of the loyalty program. - `amount`: The number of points in that transaction. - `archived`: Whether the session related to the transaction is archived. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var integrationId = integrationId_example;  // string | The identifier of the profile.
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export customer's transaction logs
                string result = apiInstance.ExportLoyaltyLedger(rangeStart, rangeEnd, loyaltyProgramId, integrationId, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **integrationId** | **string**| The identifier of the profile. | 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportreferrals"></a>
# **ExportReferrals**
> string ExportReferrals (int applicationId, decimal? campaignId = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, string batchId = null, string dateFormat = null)

Export referrals

Download a CSV file containing the referrals that match the given parameters.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns:  - `code`: The referral code. - `advocateprofileintegrationid`: The profile ID of the advocate. - `startdate`: The start date in RFC3339 of the code redemption period. - `expirydate`: The end date in RFC3339 of the code redemption period. - `limitval`: The maximum number of redemptions of this code. Defaults to `1` when left blank. - `attributes`: A json object describing _custom_ referral attribute names and their values. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportReferralsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | - `expired`: Matches referrals in which the expiration date is set and in the past. - `validNow`: Matches referrals in which start date is null or in the past and expiration date is null or in the future. - `validFuture`: Matches referrals in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | - `true`, only referrals where `usageCounter < usageLimit` will be returned. - `false`, only referrals where `usageCounter >= usageLimit` will be returned.  (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of referrals (optional) 
            var dateFormat = dateFormat_example;  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export referrals
                string result = apiInstance.ExportReferrals(applicationId, campaignId, createdBefore, createdAfter, valid, usable, batchId, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportReferrals: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| - &#x60;expired&#x60;: Matches referrals in which the expiration date is set and in the past. - &#x60;validNow&#x60;: Matches referrals in which start date is null or in the past and expiration date is null or in the future. - &#x60;validFuture&#x60;: Matches referrals in which start date is set and in the future.  | [optional] 
 **usable** | **string**| - &#x60;true&#x60;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned. - &#x60;false&#x60;, only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60; will be returned.  | [optional] 
 **batchId** | **string**| Filter results by batches of referrals | [optional] 
 **dateFormat** | **string**| Determines the format of dates in the export document. | [optional] 

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccesslogswithouttotalcount"></a>
# **GetAccessLogsWithoutTotalCount**
> InlineResponse20018 GetAccessLogsWithoutTotalCount (int applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int? pageSize = null, int? skip = null, string sort = null)

Get access logs for Application

Retrieve the list of API calls sent to the specified Application. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var path = path_example;  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = method_example;  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // Get access logs for Application
                InlineResponse20018 result = apiInstance.GetAccessLogsWithoutTotalCount(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **path** | **string**| Only return results where the request path matches the given regular expression. | [optional] 
 **method** | **string**| Only return results where the request method matches the given regular expression. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var accountId = 56;  // int | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the `accountId` property. 

            try
            {
                // Get account details
                Account result = apiInstance.GetAccount(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **accountId** | **int**| The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the &#x60;accountId&#x60; property.  | 

### Return type

[**Account**](Account.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountanalytics"></a>
# **GetAccountAnalytics**
> AccountAnalytics GetAccountAnalytics (int accountId)

Get account analytics

Return the analytics of your Talon.One account. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var accountId = 56;  // int | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the `accountId` property. 

            try
            {
                // Get account analytics
                AccountAnalytics result = apiInstance.GetAccountAnalytics(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **accountId** | **int**| The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the &#x60;accountId&#x60; property.  | 

### Return type

[**AccountAnalytics**](AccountAnalytics.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountcollection"></a>
# **GetAccountCollection**
> Collection GetAccountCollection (int collectionId)

Get account-level collection

Retrieve a given account-level collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Get account-level collection
                Collection result = apiInstance.GetAccountCollection(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccountCollection: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadditionalcost"></a>
# **GetAdditionalCost**
> AccountAdditionalCost GetAdditionalCost (int additionalCostId)

Get additional cost

Returns the additional cost. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var additionalCostId = 56;  // int | The ID of the additional cost. You can find the ID the the Campaign Manager's URL when you display the details of the cost in **Account** > **Tools** > **Additional costs**. 

            try
            {
                // Get additional cost
                AccountAdditionalCost result = apiInstance.GetAdditionalCost(additionalCostId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **additionalCostId** | **int**| The ID of the additional cost. You can find the ID the the Campaign Manager&#39;s URL when you display the details of the cost in **Account** &gt; **Tools** &gt; **Additional costs**.  | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadditionalcosts"></a>
# **GetAdditionalCosts**
> InlineResponse20032 GetAdditionalCosts (int? pageSize = null, int? skip = null, string sort = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List additional costs
                InlineResponse20032 result = apiInstance.GetAdditionalCosts(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallaccesslogs"></a>
# **GetAllAccessLogs**
> InlineResponse20019 GetAllAccessLogs (DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, int? pageSize = null, int? skip = null, string sort = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var path = path_example;  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = method_example;  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List access logs
                InlineResponse20019 result = apiInstance.GetAllAccessLogs(rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **path** | **string**| Only return results where the request path matches the given regular expression. | [optional] 
 **method** | **string**| Only return results where the request method matches the given regular expression. | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallroles"></a>
# **GetAllRoles**
> InlineResponse20040 GetAllRoles ()

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List roles
                InlineResponse20040 result = apiInstance.GetAllRoles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplication"></a>
# **GetApplication**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get Application
                Application result = apiInstance.GetApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 

### Return type

[**Application**](Application.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationapihealth"></a>
# **GetApplicationApiHealth**
> ApplicationApiHealth GetApplicationApiHealth (int applicationId)

Get Application health

Display the health of the Application and show the last time the Application was used.  You can also display this information from the **Settings** of an Application, in the **Developer Settings** menu. See the [docs](https://docs.talon.one/docs/dev/tutorials/monitoring-integration-status). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get Application health
                ApplicationApiHealth result = apiInstance.GetApplicationApiHealth(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 

### Return type

[**ApplicationApiHealth**](ApplicationApiHealth.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationcustomer"></a>
# **GetApplicationCustomer**
> ApplicationCustomer GetApplicationCustomer (int applicationId, int customerId)

Get application's customer

Retrieve the customers of the specified application. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 56;  // int | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 

            try
            {
                // Get application's customer
                ApplicationCustomer result = apiInstance.GetApplicationCustomer(applicationId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **customerId** | **int**| The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 

### Return type

[**ApplicationCustomer**](ApplicationCustomer.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationcustomerfriends"></a>
# **GetApplicationCustomerFriends**
> InlineResponse20030 GetApplicationCustomerFriends (int applicationId, string integrationId, int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var integrationId = integrationId_example;  // string | The Integration ID of the Advocate's Profile.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List friends referred by customer profile
                InlineResponse20030 result = apiInstance.GetApplicationCustomerFriends(applicationId, integrationId, pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **integrationId** | **string**| The Integration ID of the Advocate&#39;s Profile. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationcustomers"></a>
# **GetApplicationCustomers**
> InlineResponse20021 GetApplicationCustomers (int applicationId, string integrationId = null, int? pageSize = null, int? skip = null, bool? withTotalResultSize = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var integrationId = integrationId_example;  // string | Filter results performing an exact matching against the profile integration identifier. (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List application's customers
                InlineResponse20021 result = apiInstance.GetApplicationCustomers(applicationId, integrationId, pageSize, skip, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **integrationId** | **string**| Filter results performing an exact matching against the profile integration identifier. | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationcustomersbyattributes"></a>
# **GetApplicationCustomersByAttributes**
> InlineResponse20022 GetApplicationCustomersByAttributes (int applicationId, CustomerProfileSearchQuery body, int? pageSize = null, int? skip = null, bool? withTotalResultSize = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | body
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List application customers matching the given attributes
                InlineResponse20022 result = apiInstance.GetApplicationCustomersByAttributes(applicationId, body, pageSize, skip, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md)| body | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationeventtypes"></a>
# **GetApplicationEventTypes**
> InlineResponse20028 GetApplicationEventTypes (int applicationId, int? pageSize = null, int? skip = null, string sort = null)

List Applications event types

Get all of the distinct values of the Event `type` property for events recorded in the application.  See also: [Track an event](https://docs.talon.one/integration-api#operation/trackEvent) 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List Applications event types
                InlineResponse20028 result = apiInstance.GetApplicationEventTypes(applicationId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationeventswithouttotalcount"></a>
# **GetApplicationEventsWithoutTotalCount**
> InlineResponse20027 GetApplicationEventsWithoutTotalCount (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string type = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string session = null, string profile = null, string customerName = null, string customerEmail = null, string couponCode = null, string referralCode = null, string ruleQuery = null, string campaignQuery = null)

List Applications events

Lists all events recorded for an application. Instead of having the total number of results in the response, this endpoint only mentions whether there are more results. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
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
                InlineResponse20027 result = apiInstance.GetApplicationEventsWithoutTotalCount(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
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

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsession"></a>
# **GetApplicationSession**
> ApplicationSession GetApplicationSession (int applicationId, int sessionId)

Get Application session

Get the details of the given session. You can list the sessions with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var sessionId = 56;  // int | The **internal** ID of the session. You can get the ID with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint. 

            try
            {
                // Get Application session
                ApplicationSession result = apiInstance.GetApplicationSession(applicationId, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **sessionId** | **int**| The **internal** ID of the session. You can get the ID with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint.  | 

### Return type

[**ApplicationSession**](ApplicationSession.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsessions"></a>
# **GetApplicationSessions**
> InlineResponse20026 GetApplicationSessions (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string profile = null, string state = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string coupon = null, string referral = null, string integrationId = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
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
                InlineResponse20026 result = apiInstance.GetApplicationSessions(applicationId, pageSize, skip, sort, profile, state, createdBefore, createdAfter, coupon, referral, integrationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **profile** | **string**| Profile integration ID filter for sessions. Must be exact match. | [optional] 
 **state** | **string**| Filter by sessions with this state. Must be exact match. | [optional] 
 **createdBefore** | **DateTime?**| Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **coupon** | **string**| Filter by sessions with this coupon. Must be exact match. | [optional] 
 **referral** | **string**| Filter by sessions with this referral. Must be exact match. | [optional] 
 **integrationId** | **string**| Filter by sessions with this integrationId. Must be exact match. | [optional] 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplications"></a>
# **GetApplications**
> InlineResponse2003 GetApplications (int? pageSize = null, int? skip = null, string sort = null)

List Applications

List all applications in the current account.

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List Applications
                InlineResponse2003 result = apiInstance.GetApplications(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattribute"></a>
# **GetAttribute**
> Attribute GetAttribute (int attributeId)

Get custom attribute

Retrieve the specified custom attribute. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 56;  // int | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.

            try
            {
                // Get custom attribute
                Attribute result = apiInstance.GetAttribute(attributeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **attributeId** | **int**| The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattributes"></a>
# **GetAttributes**
> InlineResponse20031 GetAttributes (int? pageSize = null, int? skip = null, string sort = null, string entity = null)

List custom attributes

Return all the custom attributes for the account. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var entity = entity_example;  // string | Returned attributes will be filtered by supplied entity. (optional) 

            try
            {
                // List custom attributes
                InlineResponse20031 result = apiInstance.GetAttributes(pageSize, skip, sort, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **entity** | **string**| Returned attributes will be filtered by supplied entity. | [optional] 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaudiences"></a>
# **GetAudiences**
> InlineResponse20029 GetAudiences (int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null)

List audiences

Get all audiences created in the account. To create an audience, use [Create audience](https://docs.talon.one/integration-api#tag/Audiences/operation/createAudienceV2). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List audiences
                InlineResponse20029 result = apiInstance.GetAudiences(pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaign"></a>
# **GetCampaign**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get campaign
                Campaign result = apiInstance.GetCampaign(applicationId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignanalytics"></a>
# **GetCampaignAnalytics**
> InlineResponse20020 GetCampaignAnalytics (int applicationId, int campaignId, DateTime rangeStart, DateTime rangeEnd, string granularity = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var granularity = granularity_example;  // string | The time interval between the results in the returned time-series. (optional) 

            try
            {
                // Get analytics of campaigns
                InlineResponse20020 result = apiInstance.GetCampaignAnalytics(applicationId, campaignId, rangeStart, rangeEnd, granularity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **granularity** | **string**| The time interval between the results in the returned time-series. | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignbyattributes"></a>
# **GetCampaignByAttributes**
> InlineResponse2004 GetCampaignByAttributes (int applicationId, CampaignSearch body, int? pageSize = null, int? skip = null, string sort = null, string campaignState = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = new CampaignSearch(); // CampaignSearch | body
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived. - `draft`: Campaigns that are drafts.  (optional) 

            try
            {
                // List campaigns that match the given attributes
                InlineResponse2004 result = apiInstance.GetCampaignByAttributes(applicationId, body, pageSize, skip, sort, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | [**CampaignSearch**](CampaignSearch.md)| body | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived. - &#x60;draft&#x60;: Campaigns that are drafts.  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigntemplates"></a>
# **GetCampaignTemplates**
> InlineResponse20010 GetCampaignTemplates (int? pageSize = null, int? skip = null, string sort = null, string state = null, string name = null, string tags = null, int? userId = null)

List campaign templates

Retrieve a list of campaign templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var state = state_example;  // string | Filter results by the state of the campaign template. (optional) 
            var name = name_example;  // string | Filter results performing case-insensitive matching against the name of the campaign template. (optional) 
            var tags = tags_example;  // string | Filter results performing case-insensitive matching against the tags of the campaign template. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values.  (optional) 
            var userId = 56;  // int? | Filter results by user ID. (optional) 

            try
            {
                // List campaign templates
                InlineResponse20010 result = apiInstance.GetCampaignTemplates(pageSize, skip, sort, state, name, tags, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignTemplates: " + e.Message );
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **state** | **string**| Filter results by the state of the campaign template. | [optional] 
 **name** | **string**| Filter results performing case-insensitive matching against the name of the campaign template. | [optional] 
 **tags** | **string**| Filter results performing case-insensitive matching against the tags of the campaign template. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values.  | [optional] 
 **userId** | **int?**| Filter results by user ID. | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigns"></a>
# **GetCampaigns**
> InlineResponse2004 GetCampaigns (int applicationId, int? pageSize = null, int? skip = null, string sort = null, string campaignState = null, string name = null, string tags = null, DateTime? createdBefore = null, DateTime? createdAfter = null, int? campaignGroupId = null, int? templateId = null)

List campaigns

List the campaigns of the specified application that match your filter criteria. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived. - `draft`: Campaigns that are drafts.  (optional) 
            var name = name_example;  // string | Filter results performing case-insensitive matching against the name of the campaign. (optional) 
            var tags = tags_example;  // string | Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values  (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var campaignGroupId = 56;  // int? | Filter results to campaigns owned by the specified campaign group ID. (optional) 
            var templateId = 56;  // int? | The ID of the Campaign Template this Campaign was created from. (optional) 

            try
            {
                // List campaigns
                InlineResponse2004 result = apiInstance.GetCampaigns(applicationId, pageSize, skip, sort, campaignState, name, tags, createdBefore, createdAfter, campaignGroupId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **campaignState** | **string**| Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived. - &#x60;draft&#x60;: Campaigns that are drafts.  | [optional] 
 **name** | **string**| Filter results performing case-insensitive matching against the name of the campaign. | [optional] 
 **tags** | **string**| Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values  | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **campaignGroupId** | **int?**| Filter results to campaigns owned by the specified campaign group ID. | [optional] 
 **templateId** | **int?**| The ID of the Campaign Template this Campaign was created from. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchanges"></a>
# **GetChanges**
> InlineResponse20038 GetChanges (int? pageSize = null, int? skip = null, string sort = null, decimal? applicationId = null, string entityPath = null, int? userId = null, DateTime? createdBefore = null, DateTime? createdAfter = null, bool? withTotalResultSize = null, int? managementKeyId = null, bool? includeOld = null)

Get audit logs for an account

Retrieve the audit logs displayed in **Accounts > Audit logs**. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var applicationId = 8.14;  // decimal? | Filter results by Application ID. (optional) 
            var entityPath = entityPath_example;  // string | Filter results on a case insensitive matching of the url path of the entity (optional) 
            var userId = 56;  // int? | Filter results by user ID. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var managementKeyId = 56;  // int? | Filter results that match the given management key ID. (optional) 
            var includeOld = true;  // bool? | When this flag is set to false, the state without the change will not be returned. The default value is true. (optional) 

            try
            {
                // Get audit logs for an account
                InlineResponse20038 result = apiInstance.GetChanges(pageSize, skip, sort, applicationId, entityPath, userId, createdBefore, createdAfter, withTotalResultSize, managementKeyId, includeOld);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **applicationId** | **decimal?**| Filter results by Application ID. | [optional] 
 **entityPath** | **string**| Filter results on a case insensitive matching of the url path of the entity | [optional] 
 **userId** | **int?**| Filter results by user ID. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 
 **managementKeyId** | **int?**| Filter results that match the given management key ID. | [optional] 
 **includeOld** | **bool?**| When this flag is set to false, the state without the change will not be returned. The default value is true. | [optional] 

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollection"></a>
# **GetCollection**
> Collection GetCollection (int applicationId, int campaignId, int collectionId)

Get collection

Retrieve a given collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Get collection
                Collection result = apiInstance.GetCollection(applicationId, campaignId, collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCollection: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionitems"></a>
# **GetCollectionItems**
> InlineResponse20016 GetCollectionItems (int collectionId, int? pageSize = null, int? skip = null)

Get collection items

Retrieve the items from the given collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get collection items
                InlineResponse20016 result = apiInstance.GetCollectionItems(collectionId, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCollectionItems: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponswithouttotalcount"></a>
# **GetCouponsWithoutTotalCount**
> InlineResponse2008 GetCouponsWithoutTotalCount (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // List coupons
                InlineResponse2008 result = apiInstance.GetCouponsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeractivityreport"></a>
# **GetCustomerActivityReport**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 56;  // int | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // Get customer's activity report
                CustomerActivityReport result = apiInstance.GetCustomerActivityReport(rangeStart, rangeEnd, applicationId, customerId, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **customerId** | **int**| The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**CustomerActivityReport**](CustomerActivityReport.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeractivityreportswithouttotalcount"></a>
# **GetCustomerActivityReportsWithoutTotalCount**
> InlineResponse20025 GetCustomerActivityReportsWithoutTotalCount (DateTime rangeStart, DateTime rangeEnd, int applicationId, int? pageSize = null, int? skip = null, string sort = null, string name = null, string integrationId = null, string campaignName = null, string advocateName = null)

Get Activity Reports for Application Customers

Fetch summary reports for all application customers based on a time range. Instead of having the total number of results in the response, this endpoint only mentions whether there are more results. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from after this timestamp. This must be an RFC3339 timestamp string.
            var rangeEnd = 2013-10-20T19:20:30+01:00;  // DateTime | Only return results from before this timestamp. This must be an RFC3339 timestamp string.
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var name = name_example;  // string | Only return reports matching the customer name (optional) 
            var integrationId = integrationId_example;  // string | Filter results performing an exact matching against the profile integration identifier. (optional) 
            var campaignName = campaignName_example;  // string | Only return reports matching the campaignName (optional) 
            var advocateName = advocateName_example;  // string | Only return reports matching the current customer referrer name (optional) 

            try
            {
                // Get Activity Reports for Application Customers
                InlineResponse20025 result = apiInstance.GetCustomerActivityReportsWithoutTotalCount(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **rangeStart** | **DateTime**| Only return results from after this timestamp. This must be an RFC3339 timestamp string. | 
 **rangeEnd** | **DateTime**| Only return results from before this timestamp. This must be an RFC3339 timestamp string. | 
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **name** | **string**| Only return reports matching the customer name | [optional] 
 **integrationId** | **string**| Filter results performing an exact matching against the profile integration identifier. | [optional] 
 **campaignName** | **string**| Only return reports matching the campaignName | [optional] 
 **advocateName** | **string**| Only return reports matching the current customer referrer name | [optional] 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeranalytics"></a>
# **GetCustomerAnalytics**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 56;  // int | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // Get customer's analytics report
                CustomerAnalytics result = apiInstance.GetCustomerAnalytics(applicationId, customerId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **customerId** | **int**| The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**CustomerAnalytics**](CustomerAnalytics.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerprofile"></a>
# **GetCustomerProfile**
> CustomerProfile GetCustomerProfile (int customerId)

Get customer profile

Return the details of the specified customer profile.  <div class=\"redoc-section\">   <p class=\"title\">Performance tips</p>    You can retrieve the same information via the Integration API, which can save you extra API requests. consider these options:    - Request the customer profile to be part of the response content using     [Update Customer Session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2).   - Send an empty update with the [Update Customer Profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint with `runRuleEngine=false`. </div> 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var customerId = 56;  // int | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 

            try
            {
                // Get customer profile
                CustomerProfile result = apiInstance.GetCustomerProfile(customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **customerId** | **int**| The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  | 

### Return type

[**CustomerProfile**](CustomerProfile.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerprofiles"></a>
# **GetCustomerProfiles**
> InlineResponse20024 GetCustomerProfiles (int? pageSize = null, int? skip = null, bool? sandbox = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sandbox = true;  // bool? | Indicates whether you are pointing to a sandbox or Live customer. (optional)  (default to false)

            try
            {
                // List customer profiles
                InlineResponse20024 result = apiInstance.GetCustomerProfiles(pageSize, skip, sandbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sandbox** | **bool?**| Indicates whether you are pointing to a sandbox or Live customer. | [optional] [default to false]

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomersbyattributes"></a>
# **GetCustomersByAttributes**
> InlineResponse20023 GetCustomersByAttributes (CustomerProfileSearchQuery body, int? pageSize = null, int? skip = null, bool? sandbox = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | body
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sandbox = true;  // bool? | Indicates whether you are pointing to a sandbox or Live customer. (optional)  (default to false)

            try
            {
                // List customer profiles matching the given attributes
                InlineResponse20023 result = apiInstance.GetCustomersByAttributes(body, pageSize, skip, sandbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md)| body | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sandbox** | **bool?**| Indicates whether you are pointing to a sandbox or Live customer. | [optional] [default to false]

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventtypes"></a>
# **GetEventTypes**
> InlineResponse20036 GetEventTypes (string name = null, bool? includeOldVersions = null, int? pageSize = null, int? skip = null, string sort = null)

List event types

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var name = name_example;  // string | Filter results to event types with the given name. This parameter implies `includeOldVersions`. (optional) 
            var includeOldVersions = true;  // bool? | Include all versions of every event type. (optional)  (default to false)
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List event types
                InlineResponse20036 result = apiInstance.GetEventTypes(name, includeOldVersions, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **name** | **string**| Filter results to event types with the given name. This parameter implies &#x60;includeOldVersions&#x60;. | [optional] 
 **includeOldVersions** | **bool?**| Include all versions of every event type. | [optional] [default to false]
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexports"></a>
# **GetExports**
> InlineResponse20039 GetExports (int? pageSize = null, int? skip = null, decimal? applicationId = null, int? campaignId = null, string entity = null)

Get exports

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var applicationId = 8.14;  // decimal? | Filter results by Application ID. (optional) 
            var campaignId = 56;  // int? | Filter by the campaign ID on which the limit counters are used. (optional) 
            var entity = entity_example;  // string | The name of the entity type that was exported. (optional) 

            try
            {
                // Get exports
                InlineResponse20039 result = apiInstance.GetExports(pageSize, skip, applicationId, campaignId, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **applicationId** | **decimal?**| Filter results by Application ID. | [optional] 
 **campaignId** | **int?**| Filter by the campaign ID on which the limit counters are used. | [optional] 
 **entity** | **string**| The name of the entity type that was exported. | [optional] 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycard"></a>
# **GetLoyaltyCard**
> LoyaltyCard GetLoyaltyCard (int loyaltyProgramId, string loyaltyCardId)

Get loyalty card

Get the given loyalty card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 

            try
            {
                // Get loyalty card
                LoyaltyCard result = apiInstance.GetLoyaltyCard(loyaltyProgramId, loyaltyCardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCard: " + e.Message );
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

### Return type

[**LoyaltyCard**](LoyaltyCard.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="getloyaltycardtransactionlogs"></a>
# **GetLoyaltyCardTransactionLogs**
> InlineResponse20014 GetLoyaltyCardTransactionLogs (int loyaltyProgramId, string loyaltyCardId, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, int? skip = null, string subledgerId = null)

List card's transactions

Retrieve the transaction logs for the given [loyalty card](https://docs.talon.one/docs/product/loyalty-programs/loyalty-cards/loyalty-card-overview) within the specified [card-based loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview#loyalty-program-types) with filtering options applied. If no filtering options are applied, the last 50 loyalty transactions for the given loyalty card are returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardTransactionLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var subledgerId = subledgerId_example;  // string | The ID of the subledger by which we filter the data. (optional) 

            try
            {
                // List card's transactions
                InlineResponse20014 result = apiInstance.GetLoyaltyCardTransactionLogs(loyaltyProgramId, loyaltyCardId, startDate, endDate, pageSize, skip, subledgerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCardTransactionLogs: " + e.Message );
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
 **startDate** | **DateTime?**| Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **endDate** | **DateTime?**| Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **subledgerId** | **string**| The ID of the subledger by which we filter the data. | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycards"></a>
# **GetLoyaltyCards**
> InlineResponse20013 GetLoyaltyCards (int loyaltyProgramId, int? pageSize = null, int? skip = null, string sort = null, string identifier = null, int? profileId = null)

List loyalty cards

For the given card-based loyalty program, list the loyalty cards that match your filter criteria. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var identifier = identifier_example;  // string | Optional query parameter to search cards by identifier. (optional) 
            var profileId = 56;  // int? | Filter by the profile ID. (optional) 

            try
            {
                // List loyalty cards
                InlineResponse20013 result = apiInstance.GetLoyaltyCards(loyaltyProgramId, pageSize, skip, sort, identifier, profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCards: " + e.Message );
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **identifier** | **string**| Optional query parameter to search cards by identifier. | [optional] 
 **profileId** | **int?**| Filter by the profile ID. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltypoints"></a>
# **GetLoyaltyPoints**
> LoyaltyLedger GetLoyaltyPoints (string loyaltyProgramId, string integrationId)

Get customer's full loyalty ledger

Get the loyalty ledger for this profile integration ID.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var integrationId = integrationId_example;  // string | The identifier of the profile.

            try
            {
                // Get customer's full loyalty ledger
                LoyaltyLedger result = apiInstance.GetLoyaltyPoints(loyaltyProgramId, integrationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **integrationId** | **string**| The identifier of the profile. | 

### Return type

[**LoyaltyLedger**](LoyaltyLedger.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltyprogram"></a>
# **GetLoyaltyProgram**
> LoyaltyProgram GetLoyaltyProgram (int loyaltyProgramId)

Get loyalty program

Get the specified [loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview). To list all loyalty programs in your Application, use [List loyalty programs](#operation/getLoyaltyPrograms).  To list the loyalty programs that a customer profile is part of, use the [List customer data](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/getCustomerInventory) 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 

            try
            {
                // Get loyalty program
                LoyaltyProgram result = apiInstance.GetLoyaltyProgram(loyaltyProgramId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltyprogramtransactions"></a>
# **GetLoyaltyProgramTransactions**
> InlineResponse20012 GetLoyaltyProgramTransactions (int loyaltyProgramId, string loyaltyTransactionType = null, string subledgerId = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, int? skip = null)

List loyalty program transactions

Retrieve all loyalty program transaction logs in a given loyalty program with filtering options applied. Manual and imported transactions are also included. If no filters are applied, the last 50 loyalty transactions for the given loyalty program are returned.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyTransactionType = loyaltyTransactionType_example;  // string | Filter results by loyalty transaction type: - `manual`: Loyalty transaction that was done manually. - `session`: Loyalty transaction that resulted from a customer session. - `import`: Loyalty transaction that was imported from a CSV file.  (optional) 
            var subledgerId = subledgerId_example;  // string | The ID of the subledger by which we filter the data. (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 50)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List loyalty program transactions
                InlineResponse20012 result = apiInstance.GetLoyaltyProgramTransactions(loyaltyProgramId, loyaltyTransactionType, subledgerId, startDate, endDate, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgramTransactions: " + e.Message );
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
 **loyaltyTransactionType** | **string**| Filter results by loyalty transaction type: - &#x60;manual&#x60;: Loyalty transaction that was done manually. - &#x60;session&#x60;: Loyalty transaction that resulted from a customer session. - &#x60;import&#x60;: Loyalty transaction that was imported from a CSV file.  | [optional] 
 **subledgerId** | **string**| The ID of the subledger by which we filter the data. | [optional] 
 **startDate** | **DateTime?**| Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **endDate** | **DateTime?**| Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:** It must be an RFC3339 timestamp string.  | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 50]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="getloyaltyprograms"></a>
# **GetLoyaltyPrograms**
> InlineResponse20011 GetLoyaltyPrograms ()

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List loyalty programs
                InlineResponse20011 result = apiInstance.GetLoyaltyPrograms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltystatistics"></a>
# **GetLoyaltyStatistics**
> LoyaltyStatistics GetLoyaltyStatistics (int loyaltyProgramId)

Get loyalty program statistics

Retrieve the statistics of the specified loyalty program such as the total active points, pending points, spent points, and expired points.  **Important:** The returned data does not include the current day. All statistics are updated daily at 11:59 PM in the loyalty program time zone. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 

            try
            {
                // Get loyalty program statistics
                LoyaltyStatistics result = apiInstance.GetLoyaltyStatistics(loyaltyProgramId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 

### Return type

[**LoyaltyStatistics**](LoyaltyStatistics.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationwebhook"></a>
# **GetNotificationWebhook**
> NotificationWebhook GetNotificationWebhook (int applicationId, int notificationWebhookId)

Get notification about campaign-related changes

Return the given [notification about campaign-related changes](https://docs.talon.one/docs/product/applications/outbound-notifications). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetNotificationWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var notificationWebhookId = 56;  // int | The ID of the webhook. Get it with the appropriate _List notifications_ endpoint.

            try
            {
                // Get notification about campaign-related changes
                NotificationWebhook result = apiInstance.GetNotificationWebhook(applicationId, notificationWebhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetNotificationWebhook: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **notificationWebhookId** | **int**| The ID of the webhook. Get it with the appropriate _List notifications_ endpoint. | 

### Return type

[**NotificationWebhook**](NotificationWebhook.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationwebhooks"></a>
# **GetNotificationWebhooks**
> InlineResponse2005 GetNotificationWebhooks (int applicationId)

List notifications about campaign-related changes

List all [notifications about campaign-related changes](https://docs.talon.one/docs/product/applications/outbound-notifications) for the given Application. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetNotificationWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.

            try
            {
                // List notifications about campaign-related changes
                InlineResponse2005 result = apiInstance.GetNotificationWebhooks(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetNotificationWebhooks: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreferralswithouttotalcount"></a>
# **GetReferralsWithoutTotalCount**
> InlineResponse2009 GetReferralsWithoutTotalCount (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null, string code = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, string advocate = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var code = code_example;  // string | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches referrals in which the expiration date is set and in the past. The second matches referrals in which start date is null or in the past and expiration date is null or in the future, the third matches referrals in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only referrals where `usageCounter < usageLimit` will be returned, \"false\" will return only referrals where `usageCounter >= usageLimit`.  (optional) 
            var advocate = advocate_example;  // string | Filter results by match with a profile id specified in the referral's AdvocateProfileIntegrationId field (optional) 

            try
            {
                // List referrals
                InlineResponse2009 result = apiInstance.GetReferralsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **code** | **string**| Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches referrals in which the expiration date is set and in the past. The second matches referrals in which start date is null or in the past and expiration date is null or in the future, the third matches referrals in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **advocate** | **string**| Filter results by match with a profile id specified in the referral&#39;s AdvocateProfileIntegrationId field | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var roleId = 56;  // int | The Id of role. 

            try
            {
                // Get role
                Role result = apiInstance.GetRole(roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **roleId** | **int**| The Id of role.  | 

### Return type

[**Role**](Role.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getruleset"></a>
# **GetRuleset**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var rulesetId = 56;  // int | The ID of the ruleset.

            try
            {
                // Get ruleset
                Ruleset result = apiInstance.GetRuleset(applicationId, campaignId, rulesetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **rulesetId** | **int**| The ID of the ruleset. | 

### Return type

[**Ruleset**](Ruleset.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulesets"></a>
# **GetRulesets**
> InlineResponse2006 GetRulesets (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List campaign rulesets
                InlineResponse2006 result = apiInstance.GetRulesets(applicationId, campaignId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (int userId)

Get user

Retrieve the data (including an invitation code) for a user. Non-admin users can only get their own profile. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 56;  // int | The ID of the user.

            try
            {
                // Get user
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **userId** | **int**| The ID of the user. | 

### Return type

[**User**](User.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> InlineResponse20037 GetUsers (int? pageSize = null, int? skip = null, string sort = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 

            try
            {
                // List users in account
                InlineResponse20037 result = apiInstance.GetUsers(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 

### Return type

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (int webhookId)

Get webhook

Returns a webhook by its id.

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var webhookId = 56;  // int | The ID of the webhook. You can find the ID in the Campaign Manager's URL when you display the details of the webhook in **Account** > **Webhooks**. 

            try
            {
                // Get webhook
                Webhook result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **webhookId** | **int**| The ID of the webhook. You can find the ID in the Campaign Manager&#39;s URL when you display the details of the webhook in **Account** &gt; **Webhooks**.  | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookactivationlogs"></a>
# **GetWebhookActivationLogs**
> InlineResponse20034 GetWebhookActivationLogs (int? pageSize = null, int? skip = null, string sort = null, string integrationRequestUuid = null, decimal? webhookId = null, decimal? applicationId = null, decimal? campaignId = null, DateTime? createdBefore = null, DateTime? createdAfter = null)

List webhook activation log entries

Webhook activation log entries are created as soon as an integration request triggers a webhook effect. See the [docs](https://docs.talon.one/docs/dev/getting-started/webhooks). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var integrationRequestUuid = integrationRequestUuid_example;  // string | Filter results by integration request UUID. (optional) 
            var webhookId = 8.14;  // decimal? | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal? | Filter results by Application ID. (optional) 
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. (optional) 

            try
            {
                // List webhook activation log entries
                InlineResponse20034 result = apiInstance.GetWebhookActivationLogs(pageSize, skip, sort, integrationRequestUuid, webhookId, applicationId, campaignId, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **integrationRequestUuid** | **string**| Filter results by integration request UUID. | [optional] 
 **webhookId** | **decimal?**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal?**| Filter results by Application ID. | [optional] 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **createdBefore** | **DateTime?**| Only return events created before this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Only return events created after this date. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 

### Return type

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklogs"></a>
# **GetWebhookLogs**
> InlineResponse20035 GetWebhookLogs (int? pageSize = null, int? skip = null, string sort = null, string status = null, decimal? webhookId = null, decimal? applicationId = null, decimal? campaignId = null, string requestUuid = null, DateTime? createdBefore = null, DateTime? createdAfter = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var status = status_example;  // string | Filter results by HTTP status codes. (optional) 
            var webhookId = 8.14;  // decimal? | Filter results by Webhook. (optional) 
            var applicationId = 8.14;  // decimal? | Filter results by Application ID. (optional) 
            var campaignId = 8.14;  // decimal? | Filter results by campaign. (optional) 
            var requestUuid = requestUuid_example;  // string | Filter results by request UUID. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. (optional) 

            try
            {
                // List webhook log entries
                InlineResponse20035 result = apiInstance.GetWebhookLogs(pageSize, skip, sort, status, webhookId, applicationId, campaignId, requestUuid, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **status** | **string**| Filter results by HTTP status codes. | [optional] 
 **webhookId** | **decimal?**| Filter results by Webhook. | [optional] 
 **applicationId** | **decimal?**| Filter results by Application ID. | [optional] 
 **campaignId** | **decimal?**| Filter results by campaign. | [optional] 
 **requestUuid** | **string**| Filter results by request UUID. | [optional] 
 **createdBefore** | **DateTime?**| Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> InlineResponse20033 GetWebhooks (string applicationIds = null, string sort = null, int? pageSize = null, int? skip = null)

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationIds = applicationIds_example;  // string | Filter by one or more application IDs separated by a comma. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 

            try
            {
                // List webhooks
                InlineResponse20033 result = apiInstance.GetWebhooks(applicationIds, sort, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationIds** | **string**| Filter by one or more application IDs separated by a comma. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importaccountcollection"></a>
# **ImportAccountCollection**
> Import ImportAccountCollection (int collectionId, string upFile = null)

Import data in existing account-level collection

Upload a CSV file containing the collection of string values that should be attached as payload for collection. The file should be sent as multipart data.  The import **replaces** the initial content of the collection.  The CSV file **must** only contain the following column:  - `item`: the values in your collection.  A collection is limited to 500,000 items.  Example:  ``` item Addidas Nike Asics ```  **Note:** Before sending a request to this endpoint, ensure the data in the CSV to import is different from the data currently stored in the collection. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import data in existing account-level collection
                Import result = apiInstance.ImportAccountCollection(collectionId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportAccountCollection: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importallowedlist"></a>
# **ImportAllowedList**
> Import ImportAllowedList (int attributeId, string upFile = null)

Import allowed values for attribute

Upload a CSV file containing a list of [picklist values](https://docs.talon.one/docs/product/account/dev-tools/managing-attributes#picklist-values) for the specified attribute.  The file should be sent as multipart data.  The import **replaces** the previous list of allowed values for this attribute, if any.  The CSV file **must** only contain the following column: - `item` (required): the values in your allowed list, for example a list of SKU's.  An allowed list is limited to 500,000 items.  Example:  ```text item CS-VG-04032021-UP-50D-10 CS-DV-04042021-UP-49D-12 CS-DG-02082021-UP-50G-07 ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportAllowedListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 56;  // int | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import allowed values for attribute
                Import result = apiInstance.ImportAllowedList(attributeId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportAllowedList: " + e.Message );
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
 **attributeId** | **int**| The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcollection"></a>
# **ImportCollection**
> Import ImportCollection (int applicationId, int campaignId, int collectionId, string upFile = null)

Import data in existing collection

Upload a CSV file containing the collection of string values that should be attached as payload for collection. The file should be sent as multipart data.  The import **replaces** the initial content of the collection.  The CSV file **must** only contain the following column:  - `item`: the values in your collection.  A collection is limited to 500,000 items.  Example:  ``` item Addidas Nike Asics ```  **Note:** Before sending a request to this endpoint, ensure the data in the CSV to import is different from the data currently stored in the collection. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import data in existing collection
                Import result = apiInstance.ImportCollection(applicationId, campaignId, collectionId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCollection: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcoupons"></a>
# **ImportCoupons**
> Import ImportCoupons (int applicationId, int campaignId, string upFile = null)

Import coupons

Upload a CSV file containing the coupons that should be created. The file should be sent as multipart data.  The CSV file contains the following columns:  - `value` (required): The coupon code. - `expirydate`: The end date in RFC3339 of the code redemption period. - `startdate`: The start date in RFC3339 of the code redemption period. - `recipientintegrationid`: The integration ID of the customer who receives the coupon.   Only the customer with this integration ID can redeem the corresponding coupon code.   Learn about [coupon reservation](https://docs.talon.one/docs/product/rules/effects/using-effects#reserving-a-coupon-code). - `limitval`: The maximum number of redemptions of this code. For unlimited redemptions, use `0`. Defaults to `1` when not provided. - `discountlimit`: The total discount value that the code can give. This is typically used to represent a gift card value. - `attributes`: A json object describing _custom_ referral attribute names and their values. Double the double-quotes in the object.   For example, if you created a [custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `category` associated to the coupon entity, set it with `\"{\"\"category\"\": \"\"10_off\"\"}\"`.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```text \"value\",\"expirydate\",\"startdate\",\"recipientintegrationid\",\"limitval\",\"attributes\",\"discountlimit\" COUP1,2018-07-01T04:00:00Z,2018-05-01T04:00:00Z,cust123,1,\"{\"\"Category\"\": \"\"10_off\"\"}\",2.4 ```  Once imported, you can find the `batchId` in the Campaign Manager or by using [List coupons](#tag/Coupons/operation/getCouponsWithoutTotalCount). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import coupons
                Import result = apiInstance.ImportCoupons(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importloyaltycards"></a>
# **ImportLoyaltyCards**
> Import ImportLoyaltyCards (int loyaltyProgramId, string upFile = null)

Import loyalty cards

Upload a CSV file containing the loyalty cards that you want to use in your card-based loyalty program. Send the file as multipart data.  It contains the following columns for each card:  - `identifier` (required): The alphanumeric identifier of the loyalty card. - `state` (required): The state of the loyalty card. It can be `active` or `inactive`. - `customerprofileids` (optional): An array of strings representing the identifiers of the customer profiles linked to the loyalty card.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```csv identifier,state,customerprofileids 123-456-789AT,active,Alexa001;UserA ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import loyalty cards
                Import result = apiInstance.ImportLoyaltyCards(loyaltyProgramId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportLoyaltyCards: " + e.Message );
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
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importloyaltypoints"></a>
# **ImportLoyaltyPoints**
> Import ImportLoyaltyPoints (int loyaltyProgramId, string upFile = null)

Import loyalty points

Upload a CSV file containing the loyalty points you want to import into a given loyalty program. Send the file as multipart data.  Depending on the loyalty program type, you can import the points into a given customer profile or into a given _active_ loyalty card.  The CSV file contains the following columns:  - `customerprofileid` (optional): For profile-based loyalty programs, the integration ID of the customer profile where the loyalty points are imported. - `identifier` (optional): For card-based loyalty programs, the identifier of the loyalty card where the loyalty points are imported. - `amount`: The amount of points to award to the customer profile. - `startdate`: The earliest date when the points can be redeemed. On this date and until the expiration date, the points are `active`. - `expirydate`: The latest date when the points can be redeemed. After this date, the points are `expired`. - `subledgerid` (optional): The ID of the subledger that should received the points. - `reason` (optional): The reason why these points are awarded.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** For existing customer profiles and loyalty cards, the imported points are added to any previous active or pending points, depending on the value provided for `startdate`. If `startdate` matches the current date, the imported points are _active_. If it is later, the points are _pending_ until the date provided for `startdate` is reached.  **Note:** We recommend limiting your file size to 500MB.  **Example for profile-based programs:**  ```text customerprofileid,amount,startdate,expirydate,subledgerid,reason URNGV8294NV,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ```  **Example for card-based programs:**  ```text identifier,amount,startdate,expirydate,subledgerid,reason summer-loyalty-card-0543,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ``` 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import loyalty points
                Import result = apiInstance.ImportLoyaltyPoints(loyaltyProgramId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **int**| Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importpoolgiveaways"></a>
# **ImportPoolGiveaways**
> Import ImportPoolGiveaways (int poolId, string upFile = null)

Import giveaway codes into a giveaway pool

Upload a CSV file containing the giveaway codes that should be created. Send the file as multipart data.  The CSV file contains the following columns: - `code` (required): the code of your giveaway, for instance, a gift card redemption code. - `startdate`:  the start date in RFC3339 of the code redemption period. - `enddate`: the last date in RFC3339 of the code redemption period. - `attributes`: A json object describing _custom_ giveaway attribute names and their values. Double the double-quotes in the object.   For example, if you [created a custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `provider` associated to the giveaway entity, set it with `\"{\"\"provider\"\": \"\"myPartnerCompany\"\"}\"`.  The `startdate` and `enddate` have nothing to do with the _validity_ of the codes. They are only used by the Rule Engine to award the codes or not. You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```text code,startdate,enddate,attributes GIVEAWAY1,2020-11-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Amazon\"\"}\" GIVEAWAY2,2020-11-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Amazon\"\"}\" GIVEAWAY3,2021-01-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Aliexpress\"\"}\" ``` 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var poolId = 56;  // int | The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import giveaway codes into a giveaway pool
                Import result = apiInstance.ImportPoolGiveaways(poolId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **poolId** | **int**| The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importreferrals"></a>
# **ImportReferrals**
> Import ImportReferrals (int applicationId, int campaignId, string upFile = null)

Import referrals

Upload a CSV file containing the referrals that should be created. The file should be sent as multipart data.  The CSV file contains the following columns:  - `code` (required): The referral code. - `advocateprofileintegrationid` (required): The profile ID of the advocate. - `startdate`: The start date in RFC3339 of the code redemption period. - `expirydate`: The end date in RFC3339 of the code redemption period. - `limitval`: The maximum number of redemptions of this code. Defaults to `1` when left blank. - `attributes`: A json object describing _custom_ referral attribute names and their values. Double the double-quotes in the object.    For example, if you [created a custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `category` associated to the referral entity, set it with `\"{\"\"category\"\": \"\"10_off\"\"}\"`.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```text code,startdate,expirydate,advocateprofileintegrationid,limitval,attributes REFERRAL_CODE1,2020-11-10T23:00:00Z,2021-11-11T23:00:00Z,integid_4,1,\"{\"\"my_attribute\"\": \"\"10_off\"\"}\" REFERRAL_CODE2,2020-11-10T23:00:00Z,2021-11-11T23:00:00Z,integid1,1,\"{\"\"my_attribute\"\": \"\"20_off\"\"}\" ``` 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var upFile = upFile_example;  // string | The file with the information about the data that should be imported. (optional) 

            try
            {
                // Import referrals
                Import result = apiInstance.ImportReferrals(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **upFile** | **string**| The file with the information about the data that should be imported. | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountcollections"></a>
# **ListAccountCollections**
> InlineResponse20015 ListAccountCollections (int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null, string name = null)

List collections in account

List collections in account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListAccountCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = name_example;  // string | Filter by the name of the Collection. (optional) 

            try
            {
                // List collections in account
                InlineResponse20015 result = apiInstance.ListAccountCollections(pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListAccountCollections: " + e.Message );
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
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 
 **name** | **string**| Filter by the name of the Collection. | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="listcollections"></a>
# **ListCollections**
> InlineResponse20017 ListCollections (int applicationId, int campaignId, int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null, string name = null)

List collections

List collections in the campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = name_example;  // string | Filter by the name of the Collection. (optional) 

            try
            {
                // List collections
                InlineResponse20017 result = apiInstance.ListCollections(applicationId, campaignId, pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCollections: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 
 **name** | **string**| Filter by the name of the Collection. | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcollectionsinapplication"></a>
# **ListCollectionsInApplication**
> InlineResponse20017 ListCollectionsInApplication (int applicationId, int? pageSize = null, int? skip = null, string sort = null, bool? withTotalResultSize = null, string name = null)

List collections in application

List collections from all campaigns in the Application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCollectionsInApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var withTotalResultSize = true;  // bool? | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = name_example;  // string | Filter by the name of the Collection. (optional) 

            try
            {
                // List collections in application
                InlineResponse20017 result = apiInstance.ListCollectionsInApplication(applicationId, pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCollectionsInApplication: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **withTotalResultSize** | **bool?**| When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional] 
 **name** | **string**| Filter by the name of the Collection. | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaddeddeductedpointsnotification"></a>
# **PostAddedDeductedPointsNotification**
> BaseNotification PostAddedDeductedPointsNotification (int loyaltyProgramId, NewBaseNotification body)

Create notification about added or deducted loyalty points

Create a notification about added or deducted loyalty points in a given profile-based loyalty program. A notification for added or deducted loyalty points is different from regular webhooks in that it is loyalty program-scoped and has a predefined payload.  For more information, see [Managing notifications](https://docs.talon.one/docs/product/loyalty-programs/managing-notifications). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class PostAddedDeductedPointsNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var body = new NewBaseNotification(); // NewBaseNotification | body

            try
            {
                // Create notification about added or deducted loyalty points
                BaseNotification result = apiInstance.PostAddedDeductedPointsNotification(loyaltyProgramId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.PostAddedDeductedPointsNotification: " + e.Message );
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
 **body** | [**NewBaseNotification**](NewBaseNotification.md)| body | 

### Return type

[**BaseNotification**](BaseNotification.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="postcatalogsstrikethroughnotification"></a>
# **PostCatalogsStrikethroughNotification**
> BaseNotification PostCatalogsStrikethroughNotification (int applicationId, NewBaseNotification body)

Create strikethrough notification

Create a notification for the in the given Application. For more information, see [Managing notifications](https://docs.talon.one/docs/product/applications/outbound-notifications).  See the [payload](https://docs.talon.one/outbound-notifications) you will receive. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class PostCatalogsStrikethroughNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = new NewBaseNotification(); // NewBaseNotification | body

            try
            {
                // Create strikethrough notification
                BaseNotification result = apiInstance.PostCatalogsStrikethroughNotification(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.PostCatalogsStrikethroughNotification: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | [**NewBaseNotification**](NewBaseNotification.md)| body | 

### Return type

[**BaseNotification**](BaseNotification.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="removeloyaltypoints"></a>
# **RemoveLoyaltyPoints**
> void RemoveLoyaltyPoints (string loyaltyProgramId, string integrationId, DeductLoyaltyPoints body)

Deduct points from customer profile

Deduct points from the specified loyalty program and specified customer profile.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = loyaltyProgramId_example;  // string | The identifier for the loyalty program.
            var integrationId = integrationId_example;  // string | The identifier of the profile.
            var body = new DeductLoyaltyPoints(); // DeductLoyaltyPoints | body

            try
            {
                // Deduct points from customer profile
                apiInstance.RemoveLoyaltyPoints(loyaltyProgramId, integrationId, body);
            }
            catch (ApiException  e)
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
 **loyaltyProgramId** | **string**| The identifier for the loyalty program. | 
 **integrationId** | **string**| The identifier of the profile. | 
 **body** | [**DeductLoyaltyPoints**](DeductLoyaltyPoints.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="resetpassword"></a>
# **ResetPassword**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var body = new NewPassword(); // NewPassword | body

            try
            {
                // Reset password
                NewPassword result = apiInstance.ResetPassword(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **body** | [**NewPassword**](NewPassword.md)| body | 

### Return type

[**NewPassword**](NewPassword.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcouponsadvancedapplicationwidewithouttotalcount"></a>
# **SearchCouponsAdvancedApplicationWideWithoutTotalCount**
> InlineResponse2008 SearchCouponsAdvancedApplicationWideWithoutTotalCount (int applicationId, Object body, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, string batchId = null, bool? exactMatch = null, string campaignState = null)

List coupons that match the given attributes (without total count)

List the coupons whose attributes match the query criteria in all **active** campaigns of the given Application.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request.  **Note:** The total count is not included in the response. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = ;  // Object | body
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var campaignState = campaignState_example;  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived. - `draft`: Campaigns that are drafts.  (optional) 

            try
            {
                // List coupons that match the given attributes (without total count)
                InlineResponse2008 result = apiInstance.SearchCouponsAdvancedApplicationWideWithoutTotalCount(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **body** | **Object**| body | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **batchId** | **string**| Filter results by batches of coupons | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **campaignState** | **string**| Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived. - &#x60;draft&#x60;: Campaigns that are drafts.  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcouponsadvancedwithouttotalcount"></a>
# **SearchCouponsAdvancedWithoutTotalCount**
> InlineResponse2008 SearchCouponsAdvancedWithoutTotalCount (int applicationId, int campaignId, Object body, int? pageSize = null, int? skip = null, string sort = null, string value = null, DateTime? createdBefore = null, DateTime? createdAfter = null, string valid = null, string usable = null, int? referralId = null, string recipientIntegrationId = null, bool? exactMatch = null, string batchId = null)

List coupons that match the given attributes in campaign (without total count)

List the coupons whose attributes match the query criteria in the given campaign.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request.  **Note:** The total count is not included in the response. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = ;  // Object | body
            var pageSize = 56;  // int? | The number of items in this response. (optional)  (default to 1000)
            var skip = 56;  // int? | Skips the given number of items when paging through large result sets. (optional) 
            var sort = sort_example;  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** This parameter works only with numeric fields.  (optional) 
            var value = value_example;  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. (optional) 
            var valid = valid_example;  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = usable_example;  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 56;  // int? | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = recipientIntegrationId_example;  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field (optional) 
            var exactMatch = true;  // bool? | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)
            var batchId = batchId_example;  // string | Filter results by batches of coupons (optional) 

            try
            {
                // List coupons that match the given attributes in campaign (without total count)
                InlineResponse2008 result = apiInstance.SearchCouponsAdvancedWithoutTotalCount(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | **Object**| body | 
 **pageSize** | **int?**| The number of items in this response. | [optional] [default to 1000]
 **skip** | **int?**| Skips the given number of items when paging through large result sets. | [optional] 
 **sort** | **string**| The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** This parameter works only with numeric fields.  | [optional] 
 **value** | **string**| Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional] 
 **createdBefore** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **createdAfter** | **DateTime?**| Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any timezone. Talon.One will convert to UTC internally. | [optional] 
 **valid** | **string**| Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional] 
 **usable** | **string**| Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional] 
 **referralId** | **int?**| Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional] 
 **recipientIntegrationId** | **string**| Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field | [optional] 
 **exactMatch** | **bool?**| Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false]
 **batchId** | **string**| Filter results by batches of coupons | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferloyaltycard"></a>
# **TransferLoyaltyCard**
> void TransferLoyaltyCard (int loyaltyProgramId, string loyaltyCardId, TransferLoyaltyCard body)

Transfer card data

Transfer loyalty card data, such as linked customers, loyalty balances and transactions, from a given loyalty card to a new, automatically created loyalty card.  **Important:**  - The original card is automatically blocked once the new card is created, and it cannot be activated again. - The default status of the new card is _active_. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class TransferLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var body = new TransferLoyaltyCard(); // TransferLoyaltyCard | body

            try
            {
                // Transfer card data
                apiInstance.TransferLoyaltyCard(loyaltyProgramId, loyaltyCardId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.TransferLoyaltyCard: " + e.Message );
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
 **body** | [**TransferLoyaltyCard**](TransferLoyaltyCard.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="updateaccountcollection"></a>
# **UpdateAccountCollection**
> Collection UpdateAccountCollection (int collectionId, UpdateCollection body)

Update account-level collection

Edit the description of the account-level collection and enable or disable the collection in the specified Applications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.
            var body = new UpdateCollection(); // UpdateCollection | body

            try
            {
                // Update account-level collection
                Collection result = apiInstance.UpdateAccountCollection(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAccountCollection: " + e.Message );
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
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 
 **body** | [**UpdateCollection**](UpdateCollection.md)| body | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. A Collection with this name already exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateadditionalcost"></a>
# **UpdateAdditionalCost**
> AccountAdditionalCost UpdateAdditionalCost (int additionalCostId, NewAdditionalCost body)

Update additional cost

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var additionalCostId = 56;  // int | The ID of the additional cost. You can find the ID the the Campaign Manager's URL when you display the details of the cost in **Account** > **Tools** > **Additional costs**. 
            var body = new NewAdditionalCost(); // NewAdditionalCost | body

            try
            {
                // Update additional cost
                AccountAdditionalCost result = apiInstance.UpdateAdditionalCost(additionalCostId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **additionalCostId** | **int**| The ID of the additional cost. You can find the ID the the Campaign Manager&#39;s URL when you display the details of the cost in **Account** &gt; **Tools** &gt; **Additional costs**.  | 
 **body** | [**NewAdditionalCost**](NewAdditionalCost.md)| body | 

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattribute"></a>
# **UpdateAttribute**
> Attribute UpdateAttribute (int attributeId, NewAttribute body)

Update custom attribute

Update an existing custom attribute. Once created, the only property of a custom attribute that can be changed is the description.  To change the `type` or `name` property of a custom attribute, create a new attribute and update any relevant integrations and rules to use the new attribute. 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 56;  // int | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.
            var body = new NewAttribute(); // NewAttribute | body

            try
            {
                // Update custom attribute
                Attribute result = apiInstance.UpdateAttribute(attributeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **attributeId** | **int**| The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. | 
 **body** | [**NewAttribute**](NewAttribute.md)| body | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaign"></a>
# **UpdateCampaign**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new UpdateCampaign(); // UpdateCampaign | body

            try
            {
                // Update campaign
                Campaign result = apiInstance.UpdateCampaign(applicationId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**UpdateCampaign**](UpdateCampaign.md)| body | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (int applicationId, int campaignId, int collectionId, UpdateCampaignCollection body)

Update collection description

Edit the description of the collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 56;  // int | The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint.
            var body = new UpdateCampaignCollection(); // UpdateCampaignCollection | body

            try
            {
                // Update collection description
                Collection result = apiInstance.UpdateCollection(applicationId, campaignId, collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCollection: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **collectionId** | **int**| The ID of the collection. You can get it with the [List collection in account](#operation/listCollectionsInApplication) endpoint. | 
 **body** | [**UpdateCampaignCollection**](UpdateCampaignCollection.md)| body | 

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupon"></a>
# **UpdateCoupon**
> Coupon UpdateCoupon (int applicationId, int campaignId, string couponId, UpdateCoupon body)

Update coupon

Update the specified coupon.  <div class=\"redoc-section\">   <p class=\"title\">Important</p>    <p>With this PUT endpoint only, any property you do not explicitly set in your request   will be set to <code>null</code>.</p>  </div> 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var couponId = couponId_example;  // string | The internal ID of the coupon code. You can find this value in the `id` property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response. 
            var body = new UpdateCoupon(); // UpdateCoupon | body

            try
            {
                // Update coupon
                Coupon result = apiInstance.UpdateCoupon(applicationId, campaignId, couponId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **couponId** | **string**| The internal ID of the coupon code. You can find this value in the &#x60;id&#x60; property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response.  | 
 **body** | [**UpdateCoupon**](UpdateCoupon.md)| body | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecouponbatch"></a>
# **UpdateCouponBatch**
> void UpdateCouponBatch (int applicationId, int campaignId, UpdateCouponBatch body)

Update coupons

Update all coupons, or a specific batch of coupons, in a campaign. You can find the `batchId` in the **Coupons** view of your Application in the Campaign Manager, or you can use [List coupons](#operation/getCouponsWithoutTotalCount).  <div class=\"redoc-section\">   <p class=\"title\">Important</p>    <ul>     <li>Only send sequential requests to this endpoint.</li>     <li>Requests to this endpoint timeout after 30 minutes. If you hit a timeout, reach out to our support team.</li>   </ul>  </div>  To update a specific coupon, use [Update coupon](#operation/updateCoupon). 

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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = new UpdateCouponBatch(); // UpdateCouponBatch | body

            try
            {
                // Update coupons
                apiInstance.UpdateCouponBatch(applicationId, campaignId, body);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **body** | [**UpdateCouponBatch**](UpdateCouponBatch.md)| body | 

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloyaltycard"></a>
# **UpdateLoyaltyCard**
> LoyaltyCard UpdateLoyaltyCard (int loyaltyProgramId, string loyaltyCardId, UpdateLoyaltyCard body)

Update loyalty card status

Update the status of the given loyalty card. A card can be _active_ or _inactive_.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 56;  // int | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = loyaltyCardId_example;  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var body = new UpdateLoyaltyCard(); // UpdateLoyaltyCard | body

            try
            {
                // Update loyalty card status
                LoyaltyCard result = apiInstance.UpdateLoyaltyCard(loyaltyProgramId, loyaltyCardId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateLoyaltyCard: " + e.Message );
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
 **body** | [**UpdateLoyaltyCard**](UpdateLoyaltyCard.md)| body | 

### Return type

[**LoyaltyCard**](LoyaltyCard.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

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

<a name="updatenotificationwebhook"></a>
# **UpdateNotificationWebhook**
> NotificationWebhook UpdateNotificationWebhook (int applicationId, int notificationWebhookId, NewNotificationWebhook body)

Update notification about campaign-related changes

Update the given [notification about campaign-related changes](https://docs.talon.one/docs/product/applications/outbound-notifications).  **Tip:** You can review the payload you will receive in the [specs](https://docs.talon.one/outbound-notifications#/paths/campaign_edited/post). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateNotificationWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var notificationWebhookId = 56;  // int | The ID of the webhook. Get it with the appropriate _List notifications_ endpoint.
            var body = new NewNotificationWebhook(); // NewNotificationWebhook | body

            try
            {
                // Update notification about campaign-related changes
                NotificationWebhook result = apiInstance.UpdateNotificationWebhook(applicationId, notificationWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateNotificationWebhook: " + e.Message );
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **notificationWebhookId** | **int**| The ID of the webhook. Get it with the appropriate _List notifications_ endpoint. | 
 **body** | [**NewNotificationWebhook**](NewNotificationWebhook.md)| body | 

### Return type

[**NotificationWebhook**](NotificationWebhook.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereferral"></a>
# **UpdateReferral**
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
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 56;  // int | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 56;  // int | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var referralId = referralId_example;  // string | The ID of the referral code.
            var body = new UpdateReferral(); // UpdateReferral | body

            try
            {
                // Update referral
                Referral result = apiInstance.UpdateReferral(applicationId, campaignId, referralId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **applicationId** | **int**| The ID of the Application. It is displayed in your Talon.One deployment URL. | 
 **campaignId** | **int**| The ID of the campaign. It is displayed in your Talon.One deployment URL. | 
 **referralId** | **string**| The ID of the referral code. | 
 **body** | [**UpdateReferral**](UpdateReferral.md)| body | 

### Return type

[**Referral**](Referral.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

