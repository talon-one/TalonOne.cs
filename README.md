# Talon.One C# SDK

This SDK supports all of the operations of Talon.One's Integration API and Management API.

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.15.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```powershell
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

## Installation

Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;
```

## Determining the base URL of the endpoints

The API is available at the same hostname as your Campaign Manager deployment.
For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one`,
the URL for the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint
is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}`.

## Getting started

### Integration API

The following code shows an example of using the Integration API:

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class Example
    {
        public static void main()
        {
            // Configure BasePath & API key authorization: api_key_v1
            var integrationConfig = new Configuration {
                BasePath = "https://yourbaseurl.talon.one", // No trailing slash!
                ApiKey = new Dictionary<string, string> {
                    { "Authorization", "e18149e88f42205432281c9d3d0e711111302722577ad60dcebc86c43aabfe70" }
                },
                ApiKeyPrefix = new Dictionary<string, string> {
                    { "Authorization", "ApiKey-v1" }
                }
            };

            // ************************************************
            // Integration API example to send a session update
            // ************************************************

            // When using the default approach, the next initiation of `IntegrationApi`
            // could be using the empty constructor
            var integrationApi = new IntegrationApi(integrationConfig);
            var customerSessionId = "my_unique_session_integration_id_2";  // string | The custom identifier for this session, must be unique within the account.

            // Preparing a NewCustomerSessionV2 object
            NewCustomerSessionV2 customerSession = new NewCustomerSessionV2 {
                ProfileId = "PROFILE_ID",
                CouponCodes = new List<string> {
                    "Cool-Stuff-2020"
                },
                CartItems = new List<CartItem> {
                    new CartItem(
                        name: "Hummus Tahini",
                        sku: "hum-t",
                        quantity: 1,
                        price: (decimal)5.5,
                        category: "Food"
                    ),
                    new CartItem(
                        name: "Iced Mint Lemonade",
                        sku: "ice-mn-lemon",
                        quantity: 1,
                        price: (decimal)3.5,
                        category: "Beverages"
                    )
                }
            };

            // Instantiating an IntegrationRequest object
            IntegrationRequest body = new IntegrationRequest(
                customerSession
                // Optional list of requested information to be present on the response.
                // See src/TalonOne/Model/IntegrationRequest#ResponseContentEnum for full list of supported values
                // new List<IntegrationRequest.ResponseContentEnum> {
                //     IntegrationRequest.ResponseContentEnum.CustomerSession,
                //     IntegrationRequest.ResponseContentEnum.CustomerProfile
                // }
            );

            try
            {
                // Create/update a customer session using `UpdateCustomerSessionV2` function
                IntegrationStateV2 response = integrationApi.UpdateCustomerSessionV2(customerSessionId, body);
                Debug.WriteLine(response);

                // Parsing the returned effects list, please consult https://developers.talon.one/Integration-API/handling-effects-v2 for the full list of effects and their corresponding properties
                foreach (Effect effect in response.Effects) {
                    switch(effect.EffectType) {
                        case "setDiscount":
                            // Initiating right props instance according to the effect type
                            SetDiscountEffectProps setDiscountEffectProps = (SetDiscountEffectProps) Newtonsoft.Json.JsonConvert.DeserializeObject(effect.Props.ToString(), typeof(SetDiscountEffectProps));

                            // Access the specific effect's properties
                            Debug.WriteLine("Set a discount '{0}' of {1:00.000}", setDiscountEffectProps.Name, setDiscountEffectProps.Value);
                            break;
                        // case "acceptCoupon":
                            // AcceptCouponEffectProps acceptCouponEffectProps = (AcceptCouponEffectProps) Newtonsoft.Json.JsonConvert.DeserializeObject(effect.Props.ToString(), typeof(AcceptCouponEffectProps));

                            // Work with AcceptCouponEffectProps' properties
                            // ...
                            // break;
                        default:
                            Debug.WriteLine("Encounter unknown effect type: {0}", effect.EffectType);
                            break;
                    }
                }
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerSessionV2: " + e.Message );
            }
        }
    }
}
```

### Management API

The following code shows an example of using the Management API:

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            // Configure BasePath & API key authorization: management_key
            var managementConfig = new Configuration {
                BasePath = "https://yourbaseurl.talon.one", // No trailing slash!
                ApiKey = new Dictionary<string, string> {
                    { "Authorization", "2f0dce055da01ae595005d7d79154bae7448d319d5fc7c5b2951fadd6ba1ea07" }
                },
                ApiKeyPrefix = new Dictionary<string, string> {
                    { "Authorization", "ManagementKey-v1" }
                }
            };

            // ****************************************************
            // Management API example to load application with id 7
            // ****************************************************

            // When using the default approach, the next initiation of `ManagementApi`
            // could be using the empty constructor
            var managementApi = new ManagementApi(managementConfig);

            try
            {
                // Calling `GetApplication` function with the desired id (7)
                Application app = managementApi.GetApplication(7);
                Debug.WriteLine(app);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplication: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

## Documentation for API endpoints

All URLs are relative to `https://yourbaseurl.talon.one`.

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IntegrationApi* | [**CreateAudienceV2**](docs/IntegrationApi.md#createaudiencev2) | **POST** /v2/audiences | Create audience
*IntegrationApi* | [**CreateCouponReservation**](docs/IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create coupon reservation
*IntegrationApi* | [**CreateReferral**](docs/IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create referral code for an advocate
*IntegrationApi* | [**CreateReferralsForMultipleAdvocates**](docs/IntegrationApi.md#createreferralsformultipleadvocates) | **POST** /v1/referrals_for_multiple_advocates | Create referral codes for multiple advocates
*IntegrationApi* | [**DeleteAudienceMembershipsV2**](docs/IntegrationApi.md#deleteaudiencemembershipsv2) | **DELETE** /v2/audiences/{audienceId}/memberships | Delete audience memberships
*IntegrationApi* | [**DeleteAudienceV2**](docs/IntegrationApi.md#deleteaudiencev2) | **DELETE** /v2/audiences/{audienceId} | Delete audience
*IntegrationApi* | [**DeleteCouponReservation**](docs/IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
*IntegrationApi* | [**DeleteCustomerData**](docs/IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete customer's personal data
*IntegrationApi* | [**GenerateLoyaltyCard**](docs/IntegrationApi.md#generateloyaltycard) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/cards | Generate loyalty card
*IntegrationApi* | [**GetCustomerAchievementHistory**](docs/IntegrationApi.md#getcustomerachievementhistory) | **GET** /v1/customer_profiles/{integrationId}/achievements/{achievementId} | List customer's achievement history
*IntegrationApi* | [**GetCustomerAchievements**](docs/IntegrationApi.md#getcustomerachievements) | **GET** /v1/customer_profiles/{integrationId}/achievements | List customer's available achievements
*IntegrationApi* | [**GetCustomerInventory**](docs/IntegrationApi.md#getcustomerinventory) | **GET** /v1/customer_profiles/{integrationId}/inventory | List customer data
*IntegrationApi* | [**GetCustomerSession**](docs/IntegrationApi.md#getcustomersession) | **GET** /v2/customer_sessions/{customerSessionId} | Get customer session
*IntegrationApi* | [**GetLoyaltyBalances**](docs/IntegrationApi.md#getloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/balances | Get customer's loyalty balances
*IntegrationApi* | [**GetLoyaltyCardBalances**](docs/IntegrationApi.md#getloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/balances | Get card's point balances
*IntegrationApi* | [**GetLoyaltyCardPoints**](docs/IntegrationApi.md#getloyaltycardpoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/points | List card's unused loyalty points
*IntegrationApi* | [**GetLoyaltyCardTransactions**](docs/IntegrationApi.md#getloyaltycardtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transactions | List card's transactions
*IntegrationApi* | [**GetLoyaltyProgramProfilePoints**](docs/IntegrationApi.md#getloyaltyprogramprofilepoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/points | List customer's unused loyalty points
*IntegrationApi* | [**GetLoyaltyProgramProfileTransactions**](docs/IntegrationApi.md#getloyaltyprogramprofiletransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/transactions | List customer's loyalty transactions
*IntegrationApi* | [**GetReservedCustomers**](docs/IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | List customers that have this coupon reserved
*IntegrationApi* | [**LinkLoyaltyCardToProfile**](docs/IntegrationApi.md#linkloyaltycardtoprofile) | **POST** /v2/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/link_profile | Link customer profile to card
*IntegrationApi* | [**ReopenCustomerSession**](docs/IntegrationApi.md#reopencustomersession) | **PUT** /v2/customer_sessions/{customerSessionId}/reopen | Reopen customer session
*IntegrationApi* | [**ReturnCartItems**](docs/IntegrationApi.md#returncartitems) | **POST** /v2/customer_sessions/{customerSessionId}/returns | Return cart items
*IntegrationApi* | [**SyncCatalog**](docs/IntegrationApi.md#synccatalog) | **PUT** /v1/catalogs/{catalogId}/sync | Sync cart item catalog
*IntegrationApi* | [**TrackEventV2**](docs/IntegrationApi.md#trackeventv2) | **POST** /v2/events | Track event
*IntegrationApi* | [**UpdateAudienceCustomersAttributes**](docs/IntegrationApi.md#updateaudiencecustomersattributes) | **PUT** /v2/audience_customers/{audienceId}/attributes | Update profile attributes for all customers in audience
*IntegrationApi* | [**UpdateAudienceV2**](docs/IntegrationApi.md#updateaudiencev2) | **PUT** /v2/audiences/{audienceId} | Update audience name
*IntegrationApi* | [**UpdateCustomerProfileAudiences**](docs/IntegrationApi.md#updatecustomerprofileaudiences) | **POST** /v2/customer_audiences | Update multiple customer profiles' audiences
*IntegrationApi* | [**UpdateCustomerProfileV2**](docs/IntegrationApi.md#updatecustomerprofilev2) | **PUT** /v2/customer_profiles/{integrationId} | Update customer profile
*IntegrationApi* | [**UpdateCustomerProfilesV2**](docs/IntegrationApi.md#updatecustomerprofilesv2) | **PUT** /v2/customer_profiles | Update multiple customer profiles
*IntegrationApi* | [**UpdateCustomerSessionV2**](docs/IntegrationApi.md#updatecustomersessionv2) | **PUT** /v2/customer_sessions/{customerSessionId} | Update customer session
*ManagementApi* | [**ActivateUserByEmail**](docs/ManagementApi.md#activateuserbyemail) | **POST** /v1/users/activate | Enable user by email address
*ManagementApi* | [**AddLoyaltyCardPoints**](docs/ManagementApi.md#addloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/add_points | Add points to card
*ManagementApi* | [**AddLoyaltyPoints**](docs/ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/add_points | Add points to customer profile
*ManagementApi* | [**CopyCampaignToApplications**](docs/ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into the specified Application
*ManagementApi* | [**CreateAccountCollection**](docs/ManagementApi.md#createaccountcollection) | **POST** /v1/collections | Create account-level collection
*ManagementApi* | [**CreateAchievement**](docs/ManagementApi.md#createachievement) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | Create achievement
*ManagementApi* | [**CreateAdditionalCost**](docs/ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Create additional cost
*ManagementApi* | [**CreateAttribute**](docs/ManagementApi.md#createattribute) | **POST** /v1/attributes | Create custom attribute
*ManagementApi* | [**CreateBatchLoyaltyCards**](docs/ManagementApi.md#createbatchloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/cards/batch | Create loyalty cards
*ManagementApi* | [**CreateCampaignFromTemplate**](docs/ManagementApi.md#createcampaignfromtemplate) | **POST** /v1/applications/{applicationId}/create_campaign_from_template | Create campaign from campaign template
*ManagementApi* | [**CreateCollection**](docs/ManagementApi.md#createcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | Create campaign-level collection
*ManagementApi* | [**CreateCoupons**](docs/ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create coupons
*ManagementApi* | [**CreateCouponsAsync**](docs/ManagementApi.md#createcouponsasync) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_async | Create coupons asynchronously
*ManagementApi* | [**CreateCouponsDeletionJob**](docs/ManagementApi.md#createcouponsdeletionjob) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_deletion_jobs | Creates a coupon deletion job
*ManagementApi* | [**CreateCouponsForMultipleRecipients**](docs/ManagementApi.md#createcouponsformultiplerecipients) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_with_recipients | Create coupons for multiple recipients
*ManagementApi* | [**CreateInviteEmail**](docs/ManagementApi.md#createinviteemail) | **POST** /v1/invite_emails | Resend invitation email
*ManagementApi* | [**CreateInviteV2**](docs/ManagementApi.md#createinvitev2) | **POST** /v2/invites | Invite user
*ManagementApi* | [**CreatePasswordRecoveryEmail**](docs/ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset
*ManagementApi* | [**CreateSession**](docs/ManagementApi.md#createsession) | **POST** /v1/sessions | Create session
*ManagementApi* | [**CreateStore**](docs/ManagementApi.md#createstore) | **POST** /v1/applications/{applicationId}/stores | Create store
*ManagementApi* | [**DeactivateUserByEmail**](docs/ManagementApi.md#deactivateuserbyemail) | **POST** /v1/users/deactivate | Disable user by email address
*ManagementApi* | [**DeductLoyaltyCardPoints**](docs/ManagementApi.md#deductloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/deduct_points | Deduct points from card
*ManagementApi* | [**DeleteAccountCollection**](docs/ManagementApi.md#deleteaccountcollection) | **DELETE** /v1/collections/{collectionId} | Delete account-level collection
*ManagementApi* | [**DeleteAchievement**](docs/ManagementApi.md#deleteachievement) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Delete achievement
*ManagementApi* | [**DeleteCampaign**](docs/ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete campaign
*ManagementApi* | [**DeleteCollection**](docs/ManagementApi.md#deletecollection) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Delete campaign-level collection
*ManagementApi* | [**DeleteCoupon**](docs/ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete coupon
*ManagementApi* | [**DeleteCoupons**](docs/ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete coupons
*ManagementApi* | [**DeleteLoyaltyCard**](docs/ManagementApi.md#deleteloyaltycard) | **DELETE** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Delete loyalty card
*ManagementApi* | [**DeleteReferral**](docs/ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete referral
*ManagementApi* | [**DeleteStore**](docs/ManagementApi.md#deletestore) | **DELETE** /v1/applications/{applicationId}/stores/{storeId} | Delete store
*ManagementApi* | [**DeleteUser**](docs/ManagementApi.md#deleteuser) | **DELETE** /v1/users/{userId} | Delete user
*ManagementApi* | [**DeleteUserByEmail**](docs/ManagementApi.md#deleteuserbyemail) | **POST** /v1/users/delete | Delete user by email address
*ManagementApi* | [**DestroySession**](docs/ManagementApi.md#destroysession) | **DELETE** /v1/sessions | Destroy session
*ManagementApi* | [**DisconnectCampaignStores**](docs/ManagementApi.md#disconnectcampaignstores) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/stores | Disconnect stores
*ManagementApi* | [**ExportAccountCollectionItems**](docs/ManagementApi.md#exportaccountcollectionitems) | **GET** /v1/collections/{collectionId}/export | Export account-level collection's items
*ManagementApi* | [**ExportAchievements**](docs/ManagementApi.md#exportachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId}/export | Export achievement customer data
*ManagementApi* | [**ExportAudiencesMemberships**](docs/ManagementApi.md#exportaudiencesmemberships) | **GET** /v1/audiences/{audienceId}/memberships/export | Export audience members
*ManagementApi* | [**ExportCampaignStores**](docs/ManagementApi.md#exportcampaignstores) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/export | Export stores
*ManagementApi* | [**ExportCollectionItems**](docs/ManagementApi.md#exportcollectionitems) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/export | Export campaign-level collection's items
*ManagementApi* | [**ExportCoupons**](docs/ManagementApi.md#exportcoupons) | **GET** /v1/applications/{applicationId}/export_coupons | Export coupons
*ManagementApi* | [**ExportCustomerSessions**](docs/ManagementApi.md#exportcustomersessions) | **GET** /v1/applications/{applicationId}/export_customer_sessions | Export customer sessions
*ManagementApi* | [**ExportCustomersTiers**](docs/ManagementApi.md#exportcustomerstiers) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customers_tiers | Export customers' tier data
*ManagementApi* | [**ExportEffects**](docs/ManagementApi.md#exporteffects) | **GET** /v1/applications/{applicationId}/export_effects | Export triggered effects
*ManagementApi* | [**ExportLoyaltyBalance**](docs/ManagementApi.md#exportloyaltybalance) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balance | Export customer loyalty balance to CSV
*ManagementApi* | [**ExportLoyaltyBalances**](docs/ManagementApi.md#exportloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balances | Export customer loyalty balances
*ManagementApi* | [**ExportLoyaltyCardBalances**](docs/ManagementApi.md#exportloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_card_balances | Export all card transaction logs
*ManagementApi* | [**ExportLoyaltyCardLedger**](docs/ManagementApi.md#exportloyaltycardledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/export_log | Export card's ledger log
*ManagementApi* | [**ExportLoyaltyCards**](docs/ManagementApi.md#exportloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/export | Export loyalty cards
*ManagementApi* | [**ExportLoyaltyLedger**](docs/ManagementApi.md#exportloyaltyledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/export_log | Export customer's transaction logs
*ManagementApi* | [**ExportPoolGiveaways**](docs/ManagementApi.md#exportpoolgiveaways) | **GET** /v1/giveaways/pools/{poolId}/export | Export giveaway codes of a giveaway pool
*ManagementApi* | [**ExportReferrals**](docs/ManagementApi.md#exportreferrals) | **GET** /v1/applications/{applicationId}/export_referrals | Export referrals
*ManagementApi* | [**GetAccessLogsWithoutTotalCount**](docs/ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for Application
*ManagementApi* | [**GetAccount**](docs/ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get account details
*ManagementApi* | [**GetAccountAnalytics**](docs/ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get account analytics
*ManagementApi* | [**GetAccountCollection**](docs/ManagementApi.md#getaccountcollection) | **GET** /v1/collections/{collectionId} | Get account-level collection
*ManagementApi* | [**GetAchievement**](docs/ManagementApi.md#getachievement) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Get achievement
*ManagementApi* | [**GetAdditionalCost**](docs/ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get additional cost
*ManagementApi* | [**GetAdditionalCosts**](docs/ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs
*ManagementApi* | [**GetApplication**](docs/ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application
*ManagementApi* | [**GetApplicationApiHealth**](docs/ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get Application health
*ManagementApi* | [**GetApplicationCustomer**](docs/ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get application's customer
*ManagementApi* | [**GetApplicationCustomerFriends**](docs/ManagementApi.md#getapplicationcustomerfriends) | **GET** /v1/applications/{applicationId}/profile/{integrationId}/friends | List friends referred by customer profile
*ManagementApi* | [**GetApplicationCustomers**](docs/ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List application's customers
*ManagementApi* | [**GetApplicationCustomersByAttributes**](docs/ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/applications/{applicationId}/customer_search | List application customers matching the given attributes
*ManagementApi* | [**GetApplicationEventTypes**](docs/ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications event types
*ManagementApi* | [**GetApplicationEventsWithoutTotalCount**](docs/ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications events
*ManagementApi* | [**GetApplicationSession**](docs/ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application session
*ManagementApi* | [**GetApplicationSessions**](docs/ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application sessions
*ManagementApi* | [**GetApplications**](docs/ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications
*ManagementApi* | [**GetAttribute**](docs/ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get custom attribute
*ManagementApi* | [**GetAttributes**](docs/ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes
*ManagementApi* | [**GetAudienceMemberships**](docs/ManagementApi.md#getaudiencememberships) | **GET** /v1/audiences/{audienceId}/memberships | List audience members
*ManagementApi* | [**GetAudiences**](docs/ManagementApi.md#getaudiences) | **GET** /v1/audiences | List audiences
*ManagementApi* | [**GetAudiencesAnalytics**](docs/ManagementApi.md#getaudiencesanalytics) | **GET** /v1/audiences/analytics | List audience analytics
*ManagementApi* | [**GetCampaign**](docs/ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get campaign
*ManagementApi* | [**GetCampaignAnalytics**](docs/ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns
*ManagementApi* | [**GetCampaignByAttributes**](docs/ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | List campaigns that match the given attributes
*ManagementApi* | [**GetCampaignGroup**](docs/ManagementApi.md#getcampaigngroup) | **GET** /v1/campaign_groups/{campaignGroupId} | Get campaign access group
*ManagementApi* | [**GetCampaignGroups**](docs/ManagementApi.md#getcampaigngroups) | **GET** /v1/campaign_groups | List campaign access groups
*ManagementApi* | [**GetCampaignTemplates**](docs/ManagementApi.md#getcampaigntemplates) | **GET** /v1/campaign_templates | List campaign templates
*ManagementApi* | [**GetCampaigns**](docs/ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List campaigns
*ManagementApi* | [**GetChanges**](docs/ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit logs for an account
*ManagementApi* | [**GetCollection**](docs/ManagementApi.md#getcollection) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Get campaign-level collection
*ManagementApi* | [**GetCollectionItems**](docs/ManagementApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items
*ManagementApi* | [**GetCouponsWithoutTotalCount**](docs/ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List coupons
*ManagementApi* | [**GetCustomerActivityReport**](docs/ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get customer's activity report
*ManagementApi* | [**GetCustomerActivityReportsWithoutTotalCount**](docs/ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers
*ManagementApi* | [**GetCustomerAnalytics**](docs/ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get customer's analytics report
*ManagementApi* | [**GetCustomerProfile**](docs/ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get customer profile
*ManagementApi* | [**GetCustomerProfileAchievementProgress**](docs/ManagementApi.md#getcustomerprofileachievementprogress) | **GET** /v1/applications/{applicationId}/achievement_progress/{integrationId} | List customer achievements
*ManagementApi* | [**GetCustomerProfiles**](docs/ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List customer profiles
*ManagementApi* | [**GetCustomersByAttributes**](docs/ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | List customer profiles matching the given attributes
*ManagementApi* | [**GetDashboardStatistics**](docs/ManagementApi.md#getdashboardstatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/dashboard | Get statistics for loyalty dashboard
*ManagementApi* | [**GetEventTypes**](docs/ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List event types
*ManagementApi* | [**GetExports**](docs/ManagementApi.md#getexports) | **GET** /v1/exports | Get exports
*ManagementApi* | [**GetLoyaltyCard**](docs/ManagementApi.md#getloyaltycard) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Get loyalty card
*ManagementApi* | [**GetLoyaltyCardTransactionLogs**](docs/ManagementApi.md#getloyaltycardtransactionlogs) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/logs | List card's transactions
*ManagementApi* | [**GetLoyaltyCards**](docs/ManagementApi.md#getloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards | List loyalty cards
*ManagementApi* | [**GetLoyaltyPoints**](docs/ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId} | Get customer's full loyalty ledger
*ManagementApi* | [**GetLoyaltyProgram**](docs/ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{loyaltyProgramId} | Get loyalty program
*ManagementApi* | [**GetLoyaltyProgramTransactions**](docs/ManagementApi.md#getloyaltyprogramtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/transactions | List loyalty program transactions
*ManagementApi* | [**GetLoyaltyPrograms**](docs/ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List loyalty programs
*ManagementApi* | [**GetLoyaltyStatistics**](docs/ManagementApi.md#getloyaltystatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/statistics | Get loyalty program statistics
*ManagementApi* | [**GetMessageLogs**](docs/ManagementApi.md#getmessagelogs) | **GET** /v1/message_logs | List message log entries
*ManagementApi* | [**GetReferralsWithoutTotalCount**](docs/ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List referrals
*ManagementApi* | [**GetRoleV2**](docs/ManagementApi.md#getrolev2) | **GET** /v2/roles/{roleId} | Get role
*ManagementApi* | [**GetRuleset**](docs/ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get ruleset
*ManagementApi* | [**GetRulesets**](docs/ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List campaign rulesets
*ManagementApi* | [**GetStore**](docs/ManagementApi.md#getstore) | **GET** /v1/applications/{applicationId}/stores/{storeId} | Get store
*ManagementApi* | [**GetUser**](docs/ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get user
*ManagementApi* | [**GetUsers**](docs/ManagementApi.md#getusers) | **GET** /v1/users | List users in account
*ManagementApi* | [**GetWebhook**](docs/ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get webhook
*ManagementApi* | [**GetWebhookActivationLogs**](docs/ManagementApi.md#getwebhookactivationlogs) | **GET** /v1/webhook_activation_logs | List webhook activation log entries
*ManagementApi* | [**GetWebhookLogs**](docs/ManagementApi.md#getwebhooklogs) | **GET** /v1/webhook_logs | List webhook log entries
*ManagementApi* | [**GetWebhooks**](docs/ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List webhooks
*ManagementApi* | [**ImportAccountCollection**](docs/ManagementApi.md#importaccountcollection) | **POST** /v1/collections/{collectionId}/import | Import data into existing account-level collection
*ManagementApi* | [**ImportAllowedList**](docs/ManagementApi.md#importallowedlist) | **POST** /v1/attributes/{attributeId}/allowed_list/import | Import allowed values for attribute
*ManagementApi* | [**ImportAudiencesMemberships**](docs/ManagementApi.md#importaudiencesmemberships) | **POST** /v1/audiences/{audienceId}/memberships/import | Import audience members
*ManagementApi* | [**ImportCampaignStores**](docs/ManagementApi.md#importcampaignstores) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/import | Import stores
*ManagementApi* | [**ImportCollection**](docs/ManagementApi.md#importcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/import | Import data into existing campaign-level collection
*ManagementApi* | [**ImportCoupons**](docs/ManagementApi.md#importcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_coupons | Import coupons
*ManagementApi* | [**ImportLoyaltyCards**](docs/ManagementApi.md#importloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_cards | Import loyalty cards
*ManagementApi* | [**ImportLoyaltyCustomersTiers**](docs/ManagementApi.md#importloyaltycustomerstiers) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_customers_tiers | Import customers into loyalty tiers
*ManagementApi* | [**ImportLoyaltyPoints**](docs/ManagementApi.md#importloyaltypoints) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_points | Import loyalty points
*ManagementApi* | [**ImportPoolGiveaways**](docs/ManagementApi.md#importpoolgiveaways) | **POST** /v1/giveaways/pools/{poolId}/import | Import giveaway codes into a giveaway pool
*ManagementApi* | [**ImportReferrals**](docs/ManagementApi.md#importreferrals) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_referrals | Import referrals
*ManagementApi* | [**InviteUserExternal**](docs/ManagementApi.md#inviteuserexternal) | **POST** /v1/users/invite | Invite user from identity provider
*ManagementApi* | [**ListAccountCollections**](docs/ManagementApi.md#listaccountcollections) | **GET** /v1/collections | List collections in account
*ManagementApi* | [**ListAchievements**](docs/ManagementApi.md#listachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | List achievements
*ManagementApi* | [**ListAllRolesV2**](docs/ManagementApi.md#listallrolesv2) | **GET** /v2/roles | List roles
*ManagementApi* | [**ListCatalogItems**](docs/ManagementApi.md#listcatalogitems) | **GET** /v1/catalogs/{catalogId}/items | List items in a catalog
*ManagementApi* | [**ListCollections**](docs/ManagementApi.md#listcollections) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | List collections in campaign
*ManagementApi* | [**ListCollectionsInApplication**](docs/ManagementApi.md#listcollectionsinapplication) | **GET** /v1/applications/{applicationId}/collections | List collections in Application
*ManagementApi* | [**ListStores**](docs/ManagementApi.md#liststores) | **GET** /v1/applications/{applicationId}/stores | List stores
*ManagementApi* | [**OktaEventHandlerChallenge**](docs/ManagementApi.md#oktaeventhandlerchallenge) | **GET** /v1/provisioning/okta | Validate Okta API ownership
*ManagementApi* | [**RemoveLoyaltyPoints**](docs/ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/deduct_points | Deduct points from customer profile
*ManagementApi* | [**ResetPassword**](docs/ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password
*ManagementApi* | [**ScimCreateUser**](docs/ManagementApi.md#scimcreateuser) | **POST** /v1/provisioning/scim/Users | Create SCIM user
*ManagementApi* | [**ScimDeleteUser**](docs/ManagementApi.md#scimdeleteuser) | **DELETE** /v1/provisioning/scim/Users/{userId} | Delete SCIM user
*ManagementApi* | [**ScimGetResourceTypes**](docs/ManagementApi.md#scimgetresourcetypes) | **GET** /v1/provisioning/scim/ResourceTypes | List supported SCIM resource types
*ManagementApi* | [**ScimGetSchemas**](docs/ManagementApi.md#scimgetschemas) | **GET** /v1/provisioning/scim/Schemas | List supported SCIM schemas
*ManagementApi* | [**ScimGetServiceProviderConfig**](docs/ManagementApi.md#scimgetserviceproviderconfig) | **GET** /v1/provisioning/scim/ServiceProviderConfig | Get SCIM service provider configuration
*ManagementApi* | [**ScimGetUser**](docs/ManagementApi.md#scimgetuser) | **GET** /v1/provisioning/scim/Users/{userId} | Get SCIM user
*ManagementApi* | [**ScimGetUsers**](docs/ManagementApi.md#scimgetusers) | **GET** /v1/provisioning/scim/Users | List SCIM users
*ManagementApi* | [**ScimPatchUser**](docs/ManagementApi.md#scimpatchuser) | **PATCH** /v1/provisioning/scim/Users/{userId} | Update SCIM user attributes
*ManagementApi* | [**ScimReplaceUserAttributes**](docs/ManagementApi.md#scimreplaceuserattributes) | **PUT** /v1/provisioning/scim/Users/{userId} | Update SCIM user
*ManagementApi* | [**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](docs/ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | List coupons that match the given attributes (without total count)
*ManagementApi* | [**SearchCouponsAdvancedWithoutTotalCount**](docs/ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | List coupons that match the given attributes in campaign (without total count)
*ManagementApi* | [**TransferLoyaltyCard**](docs/ManagementApi.md#transferloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transfer | Transfer card data
*ManagementApi* | [**UpdateAccountCollection**](docs/ManagementApi.md#updateaccountcollection) | **PUT** /v1/collections/{collectionId} | Update account-level collection
*ManagementApi* | [**UpdateAchievement**](docs/ManagementApi.md#updateachievement) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Update achievement
*ManagementApi* | [**UpdateAdditionalCost**](docs/ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update additional cost
*ManagementApi* | [**UpdateAttribute**](docs/ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update custom attribute
*ManagementApi* | [**UpdateCampaign**](docs/ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update campaign
*ManagementApi* | [**UpdateCollection**](docs/ManagementApi.md#updatecollection) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Update campaign-level collection's description
*ManagementApi* | [**UpdateCoupon**](docs/ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update coupon
*ManagementApi* | [**UpdateCouponBatch**](docs/ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update coupons
*ManagementApi* | [**UpdateLoyaltyCard**](docs/ManagementApi.md#updateloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Update loyalty card status
*ManagementApi* | [**UpdateReferral**](docs/ManagementApi.md#updatereferral) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Update referral
*ManagementApi* | [**UpdateRoleV2**](docs/ManagementApi.md#updaterolev2) | **PUT** /v2/roles/{roleId} | Update role
*ManagementApi* | [**UpdateStore**](docs/ManagementApi.md#updatestore) | **PUT** /v1/applications/{applicationId}/stores/{storeId} | Update store
*ManagementApi* | [**UpdateUser**](docs/ManagementApi.md#updateuser) | **PUT** /v1/users/{userId} | Update user

## Documentation for models

- [Model.APIError](docs/APIError.md)
- [Model.AcceptCouponEffectProps](docs/AcceptCouponEffectProps.md)
- [Model.AcceptReferralEffectProps](docs/AcceptReferralEffectProps.md)
- [Model.AccessLogEntry](docs/AccessLogEntry.md)
- [Model.Account](docs/Account.md)
- [Model.AccountAdditionalCost](docs/AccountAdditionalCost.md)
- [Model.AccountAnalytics](docs/AccountAnalytics.md)
- [Model.AccountDashboardStatistic](docs/AccountDashboardStatistic.md)
- [Model.AccountDashboardStatisticCampaigns](docs/AccountDashboardStatisticCampaigns.md)
- [Model.AccountDashboardStatisticDiscount](docs/AccountDashboardStatisticDiscount.md)
- [Model.AccountDashboardStatisticLoyaltyPoints](docs/AccountDashboardStatisticLoyaltyPoints.md)
- [Model.AccountDashboardStatisticReferrals](docs/AccountDashboardStatisticReferrals.md)
- [Model.AccountDashboardStatisticRevenue](docs/AccountDashboardStatisticRevenue.md)
- [Model.AccountEntity](docs/AccountEntity.md)
- [Model.AccountLimits](docs/AccountLimits.md)
- [Model.Achievement](docs/Achievement.md)
- [Model.AchievementAdditionalProperties](docs/AchievementAdditionalProperties.md)
- [Model.AchievementBase](docs/AchievementBase.md)
- [Model.AchievementProgress](docs/AchievementProgress.md)
- [Model.AchievementProgressWithDefinition](docs/AchievementProgressWithDefinition.md)
- [Model.AchievementStatusEntry](docs/AchievementStatusEntry.md)
- [Model.AddFreeItemEffectProps](docs/AddFreeItemEffectProps.md)
- [Model.AddItemCatalogAction](docs/AddItemCatalogAction.md)
- [Model.AddLoyaltyPoints](docs/AddLoyaltyPoints.md)
- [Model.AddLoyaltyPointsEffectProps](docs/AddLoyaltyPointsEffectProps.md)
- [Model.AddToAudienceEffectProps](docs/AddToAudienceEffectProps.md)
- [Model.AddedDeductedPointsNotificationPolicy](docs/AddedDeductedPointsNotificationPolicy.md)
- [Model.AdditionalCampaignProperties](docs/AdditionalCampaignProperties.md)
- [Model.AdditionalCost](docs/AdditionalCost.md)
- [Model.AnalyticsDataPoint](docs/AnalyticsDataPoint.md)
- [Model.AnalyticsDataPointWithTrend](docs/AnalyticsDataPointWithTrend.md)
- [Model.AnalyticsDataPointWithTrendAndInfluencedRate](docs/AnalyticsDataPointWithTrendAndInfluencedRate.md)
- [Model.AnalyticsDataPointWithTrendAndUplift](docs/AnalyticsDataPointWithTrendAndUplift.md)
- [Model.AnalyticsProduct](docs/AnalyticsProduct.md)
- [Model.AnalyticsSKU](docs/AnalyticsSKU.md)
- [Model.Application](docs/Application.md)
- [Model.ApplicationAPIKey](docs/ApplicationAPIKey.md)
- [Model.ApplicationAnalyticsDataPoint](docs/ApplicationAnalyticsDataPoint.md)
- [Model.ApplicationApiHealth](docs/ApplicationApiHealth.md)
- [Model.ApplicationCIF](docs/ApplicationCIF.md)
- [Model.ApplicationCIFExpression](docs/ApplicationCIFExpression.md)
- [Model.ApplicationCIFReferences](docs/ApplicationCIFReferences.md)
- [Model.ApplicationCampaignAnalytics](docs/ApplicationCampaignAnalytics.md)
- [Model.ApplicationCampaignStats](docs/ApplicationCampaignStats.md)
- [Model.ApplicationCustomer](docs/ApplicationCustomer.md)
- [Model.ApplicationCustomerEntity](docs/ApplicationCustomerEntity.md)
- [Model.ApplicationEntity](docs/ApplicationEntity.md)
- [Model.ApplicationEvent](docs/ApplicationEvent.md)
- [Model.ApplicationNotification](docs/ApplicationNotification.md)
- [Model.ApplicationReferee](docs/ApplicationReferee.md)
- [Model.ApplicationSession](docs/ApplicationSession.md)
- [Model.ApplicationSessionEntity](docs/ApplicationSessionEntity.md)
- [Model.ApplicationStoreEntity](docs/ApplicationStoreEntity.md)
- [Model.AsyncCouponCreationResponse](docs/AsyncCouponCreationResponse.md)
- [Model.AsyncCouponDeletionJobResponse](docs/AsyncCouponDeletionJobResponse.md)
- [Model.Attribute](docs/Attribute.md)
- [Model.AttributesMandatory](docs/AttributesMandatory.md)
- [Model.AttributesSettings](docs/AttributesSettings.md)
- [Model.Audience](docs/Audience.md)
- [Model.AudienceAnalytics](docs/AudienceAnalytics.md)
- [Model.AudienceCustomer](docs/AudienceCustomer.md)
- [Model.AudienceIntegrationID](docs/AudienceIntegrationID.md)
- [Model.AudienceMembership](docs/AudienceMembership.md)
- [Model.AwardGiveawayEffectProps](docs/AwardGiveawayEffectProps.md)
- [Model.BaseCampaign](docs/BaseCampaign.md)
- [Model.BaseLoyaltyProgram](docs/BaseLoyaltyProgram.md)
- [Model.BaseNotification](docs/BaseNotification.md)
- [Model.BaseNotificationEntity](docs/BaseNotificationEntity.md)
- [Model.BaseNotificationWebhook](docs/BaseNotificationWebhook.md)
- [Model.BaseNotifications](docs/BaseNotifications.md)
- [Model.BaseSamlConnection](docs/BaseSamlConnection.md)
- [Model.Binding](docs/Binding.md)
- [Model.BulkApplicationNotification](docs/BulkApplicationNotification.md)
- [Model.BulkCampaignNotification](docs/BulkCampaignNotification.md)
- [Model.BulkOperationOnCampaigns](docs/BulkOperationOnCampaigns.md)
- [Model.Campaign](docs/Campaign.md)
- [Model.CampaignActivationRequest](docs/CampaignActivationRequest.md)
- [Model.CampaignAnalytics](docs/CampaignAnalytics.md)
- [Model.CampaignBudget](docs/CampaignBudget.md)
- [Model.CampaignCollection](docs/CampaignCollection.md)
- [Model.CampaignCollectionEditedNotification](docs/CampaignCollectionEditedNotification.md)
- [Model.CampaignCollectionWithoutPayload](docs/CampaignCollectionWithoutPayload.md)
- [Model.CampaignCopy](docs/CampaignCopy.md)
- [Model.CampaignCreatedNotification](docs/CampaignCreatedNotification.md)
- [Model.CampaignDeletedNotification](docs/CampaignDeletedNotification.md)
- [Model.CampaignDetail](docs/CampaignDetail.md)
- [Model.CampaignEditedNotification](docs/CampaignEditedNotification.md)
- [Model.CampaignEntity](docs/CampaignEntity.md)
- [Model.CampaignEvaluationGroup](docs/CampaignEvaluationGroup.md)
- [Model.CampaignEvaluationPosition](docs/CampaignEvaluationPosition.md)
- [Model.CampaignEvaluationTreeChangedNotification](docs/CampaignEvaluationTreeChangedNotification.md)
- [Model.CampaignGroup](docs/CampaignGroup.md)
- [Model.CampaignGroupEntity](docs/CampaignGroupEntity.md)
- [Model.CampaignNotification](docs/CampaignNotification.md)
- [Model.CampaignNotificationPolicy](docs/CampaignNotificationPolicy.md)
- [Model.CampaignRulesetChangedNotification](docs/CampaignRulesetChangedNotification.md)
- [Model.CampaignSearch](docs/CampaignSearch.md)
- [Model.CampaignSet](docs/CampaignSet.md)
- [Model.CampaignSetBranchNode](docs/CampaignSetBranchNode.md)
- [Model.CampaignSetLeafNode](docs/CampaignSetLeafNode.md)
- [Model.CampaignSetNode](docs/CampaignSetNode.md)
- [Model.CampaignStateChangedNotification](docs/CampaignStateChangedNotification.md)
- [Model.CampaignStoreBudget](docs/CampaignStoreBudget.md)
- [Model.CampaignStoreBudgetLimitConfig](docs/CampaignStoreBudgetLimitConfig.md)
- [Model.CampaignTemplate](docs/CampaignTemplate.md)
- [Model.CampaignTemplateCollection](docs/CampaignTemplateCollection.md)
- [Model.CampaignTemplateCouponReservationSettings](docs/CampaignTemplateCouponReservationSettings.md)
- [Model.CampaignTemplateParams](docs/CampaignTemplateParams.md)
- [Model.CampaignVersions](docs/CampaignVersions.md)
- [Model.CardAddedDeductedPointsNotificationPolicy](docs/CardAddedDeductedPointsNotificationPolicy.md)
- [Model.CardExpiringPointsNotificationPolicy](docs/CardExpiringPointsNotificationPolicy.md)
- [Model.CardExpiringPointsNotificationTrigger](docs/CardExpiringPointsNotificationTrigger.md)
- [Model.CardLedgerPointsEntryIntegrationAPI](docs/CardLedgerPointsEntryIntegrationAPI.md)
- [Model.CardLedgerTransactionLogEntry](docs/CardLedgerTransactionLogEntry.md)
- [Model.CardLedgerTransactionLogEntryIntegrationAPI](docs/CardLedgerTransactionLogEntryIntegrationAPI.md)
- [Model.CartItem](docs/CartItem.md)
- [Model.Catalog](docs/Catalog.md)
- [Model.CatalogAction](docs/CatalogAction.md)
- [Model.CatalogActionFilter](docs/CatalogActionFilter.md)
- [Model.CatalogItem](docs/CatalogItem.md)
- [Model.CatalogSyncRequest](docs/CatalogSyncRequest.md)
- [Model.CatalogsStrikethroughNotificationPolicy](docs/CatalogsStrikethroughNotificationPolicy.md)
- [Model.Change](docs/Change.md)
- [Model.ChangeLoyaltyTierLevelEffectProps](docs/ChangeLoyaltyTierLevelEffectProps.md)
- [Model.ChangeProfilePassword](docs/ChangeProfilePassword.md)
- [Model.CodeGeneratorSettings](docs/CodeGeneratorSettings.md)
- [Model.Collection](docs/Collection.md)
- [Model.CollectionItem](docs/CollectionItem.md)
- [Model.CollectionWithoutPayload](docs/CollectionWithoutPayload.md)
- [Model.Coupon](docs/Coupon.md)
- [Model.CouponConstraints](docs/CouponConstraints.md)
- [Model.CouponCreatedEffectProps](docs/CouponCreatedEffectProps.md)
- [Model.CouponCreationJob](docs/CouponCreationJob.md)
- [Model.CouponDeletionFilters](docs/CouponDeletionFilters.md)
- [Model.CouponDeletionJob](docs/CouponDeletionJob.md)
- [Model.CouponLimitConfigs](docs/CouponLimitConfigs.md)
- [Model.CouponRejectionReason](docs/CouponRejectionReason.md)
- [Model.CouponReservations](docs/CouponReservations.md)
- [Model.CouponSearch](docs/CouponSearch.md)
- [Model.CouponValue](docs/CouponValue.md)
- [Model.CouponsNotificationPolicy](docs/CouponsNotificationPolicy.md)
- [Model.CreateAchievement](docs/CreateAchievement.md)
- [Model.CreateApplicationAPIKey](docs/CreateApplicationAPIKey.md)
- [Model.CreateManagementKey](docs/CreateManagementKey.md)
- [Model.CreateTemplateCampaign](docs/CreateTemplateCampaign.md)
- [Model.CreateTemplateCampaignResponse](docs/CreateTemplateCampaignResponse.md)
- [Model.CustomEffect](docs/CustomEffect.md)
- [Model.CustomEffectProps](docs/CustomEffectProps.md)
- [Model.CustomerActivityReport](docs/CustomerActivityReport.md)
- [Model.CustomerAnalytics](docs/CustomerAnalytics.md)
- [Model.CustomerInventory](docs/CustomerInventory.md)
- [Model.CustomerProfile](docs/CustomerProfile.md)
- [Model.CustomerProfileAudienceRequest](docs/CustomerProfileAudienceRequest.md)
- [Model.CustomerProfileAudienceRequestItem](docs/CustomerProfileAudienceRequestItem.md)
- [Model.CustomerProfileIntegrationRequestV2](docs/CustomerProfileIntegrationRequestV2.md)
- [Model.CustomerProfileIntegrationResponseV2](docs/CustomerProfileIntegrationResponseV2.md)
- [Model.CustomerProfileSearchQuery](docs/CustomerProfileSearchQuery.md)
- [Model.CustomerProfileUpdateV2Response](docs/CustomerProfileUpdateV2Response.md)
- [Model.CustomerSession](docs/CustomerSession.md)
- [Model.CustomerSessionV2](docs/CustomerSessionV2.md)
- [Model.DeductLoyaltyPoints](docs/DeductLoyaltyPoints.md)
- [Model.DeductLoyaltyPointsEffectProps](docs/DeductLoyaltyPointsEffectProps.md)
- [Model.DeleteUserRequest](docs/DeleteUserRequest.md)
- [Model.Effect](docs/Effect.md)
- [Model.EffectEntity](docs/EffectEntity.md)
- [Model.EmailEntity](docs/EmailEntity.md)
- [Model.Endpoint](docs/Endpoint.md)
- [Model.Entity](docs/Entity.md)
- [Model.EntityWithTalangVisibleID](docs/EntityWithTalangVisibleID.md)
- [Model.Environment](docs/Environment.md)
- [Model.ErrorEffectProps](docs/ErrorEffectProps.md)
- [Model.ErrorResponse](docs/ErrorResponse.md)
- [Model.ErrorResponseWithStatus](docs/ErrorResponseWithStatus.md)
- [Model.ErrorSource](docs/ErrorSource.md)
- [Model.EvaluableCampaignIds](docs/EvaluableCampaignIds.md)
- [Model.Event](docs/Event.md)
- [Model.EventType](docs/EventType.md)
- [Model.EventV2](docs/EventV2.md)
- [Model.ExpiringCouponsNotificationPolicy](docs/ExpiringCouponsNotificationPolicy.md)
- [Model.ExpiringCouponsNotificationTrigger](docs/ExpiringCouponsNotificationTrigger.md)
- [Model.ExpiringPointsNotificationPolicy](docs/ExpiringPointsNotificationPolicy.md)
- [Model.ExpiringPointsNotificationTrigger](docs/ExpiringPointsNotificationTrigger.md)
- [Model.Export](docs/Export.md)
- [Model.FeatureFlag](docs/FeatureFlag.md)
- [Model.FeaturesFeed](docs/FeaturesFeed.md)
- [Model.FuncArgDef](docs/FuncArgDef.md)
- [Model.FunctionDef](docs/FunctionDef.md)
- [Model.GenerateCampaignDescription](docs/GenerateCampaignDescription.md)
- [Model.GenerateCampaignTags](docs/GenerateCampaignTags.md)
- [Model.GenerateItemFilterDescription](docs/GenerateItemFilterDescription.md)
- [Model.GenerateLoyaltyCard](docs/GenerateLoyaltyCard.md)
- [Model.GenerateRuleTitle](docs/GenerateRuleTitle.md)
- [Model.GenerateRuleTitleRule](docs/GenerateRuleTitleRule.md)
- [Model.GetIntegrationCouponRequest](docs/GetIntegrationCouponRequest.md)
- [Model.Giveaway](docs/Giveaway.md)
- [Model.GiveawaysPool](docs/GiveawaysPool.md)
- [Model.HiddenConditionsEffects](docs/HiddenConditionsEffects.md)
- [Model.IdentifiableEntity](docs/IdentifiableEntity.md)
- [Model.Import](docs/Import.md)
- [Model.ImportEntity](docs/ImportEntity.md)
- [Model.IncreaseAchievementProgressEffectProps](docs/IncreaseAchievementProgressEffectProps.md)
- [Model.InlineResponse200](docs/InlineResponse200.md)
- [Model.InlineResponse2001](docs/InlineResponse2001.md)
- [Model.InlineResponse20010](docs/InlineResponse20010.md)
- [Model.InlineResponse20011](docs/InlineResponse20011.md)
- [Model.InlineResponse20012](docs/InlineResponse20012.md)
- [Model.InlineResponse20013](docs/InlineResponse20013.md)
- [Model.InlineResponse20014](docs/InlineResponse20014.md)
- [Model.InlineResponse20015](docs/InlineResponse20015.md)
- [Model.InlineResponse20016](docs/InlineResponse20016.md)
- [Model.InlineResponse20017](docs/InlineResponse20017.md)
- [Model.InlineResponse20018](docs/InlineResponse20018.md)
- [Model.InlineResponse20019](docs/InlineResponse20019.md)
- [Model.InlineResponse2002](docs/InlineResponse2002.md)
- [Model.InlineResponse20020](docs/InlineResponse20020.md)
- [Model.InlineResponse20021](docs/InlineResponse20021.md)
- [Model.InlineResponse20022](docs/InlineResponse20022.md)
- [Model.InlineResponse20023](docs/InlineResponse20023.md)
- [Model.InlineResponse20024](docs/InlineResponse20024.md)
- [Model.InlineResponse20025](docs/InlineResponse20025.md)
- [Model.InlineResponse20026](docs/InlineResponse20026.md)
- [Model.InlineResponse20027](docs/InlineResponse20027.md)
- [Model.InlineResponse20028](docs/InlineResponse20028.md)
- [Model.InlineResponse20029](docs/InlineResponse20029.md)
- [Model.InlineResponse2003](docs/InlineResponse2003.md)
- [Model.InlineResponse20030](docs/InlineResponse20030.md)
- [Model.InlineResponse20031](docs/InlineResponse20031.md)
- [Model.InlineResponse20032](docs/InlineResponse20032.md)
- [Model.InlineResponse20033](docs/InlineResponse20033.md)
- [Model.InlineResponse20034](docs/InlineResponse20034.md)
- [Model.InlineResponse20035](docs/InlineResponse20035.md)
- [Model.InlineResponse20036](docs/InlineResponse20036.md)
- [Model.InlineResponse20037](docs/InlineResponse20037.md)
- [Model.InlineResponse20038](docs/InlineResponse20038.md)
- [Model.InlineResponse20039](docs/InlineResponse20039.md)
- [Model.InlineResponse2004](docs/InlineResponse2004.md)
- [Model.InlineResponse20040](docs/InlineResponse20040.md)
- [Model.InlineResponse20041](docs/InlineResponse20041.md)
- [Model.InlineResponse20042](docs/InlineResponse20042.md)
- [Model.InlineResponse20043](docs/InlineResponse20043.md)
- [Model.InlineResponse20044](docs/InlineResponse20044.md)
- [Model.InlineResponse20045](docs/InlineResponse20045.md)
- [Model.InlineResponse20046](docs/InlineResponse20046.md)
- [Model.InlineResponse20047](docs/InlineResponse20047.md)
- [Model.InlineResponse20048](docs/InlineResponse20048.md)
- [Model.InlineResponse20049](docs/InlineResponse20049.md)
- [Model.InlineResponse2005](docs/InlineResponse2005.md)
- [Model.InlineResponse2006](docs/InlineResponse2006.md)
- [Model.InlineResponse2007](docs/InlineResponse2007.md)
- [Model.InlineResponse2008](docs/InlineResponse2008.md)
- [Model.InlineResponse2009](docs/InlineResponse2009.md)
- [Model.InlineResponse201](docs/InlineResponse201.md)
- [Model.IntegrationCoupon](docs/IntegrationCoupon.md)
- [Model.IntegrationCustomerSessionResponse](docs/IntegrationCustomerSessionResponse.md)
- [Model.IntegrationEntity](docs/IntegrationEntity.md)
- [Model.IntegrationEvent](docs/IntegrationEvent.md)
- [Model.IntegrationEventV2Request](docs/IntegrationEventV2Request.md)
- [Model.IntegrationProfileEntity](docs/IntegrationProfileEntity.md)
- [Model.IntegrationRequest](docs/IntegrationRequest.md)
- [Model.IntegrationState](docs/IntegrationState.md)
- [Model.IntegrationStateV2](docs/IntegrationStateV2.md)
- [Model.IntegrationStoreEntity](docs/IntegrationStoreEntity.md)
- [Model.InventoryCoupon](docs/InventoryCoupon.md)
- [Model.InventoryReferral](docs/InventoryReferral.md)
- [Model.ItemAttribute](docs/ItemAttribute.md)
- [Model.LedgerEntry](docs/LedgerEntry.md)
- [Model.LedgerInfo](docs/LedgerInfo.md)
- [Model.LedgerPointsEntryIntegrationAPI](docs/LedgerPointsEntryIntegrationAPI.md)
- [Model.LedgerTransactionLogEntryIntegrationAPI](docs/LedgerTransactionLogEntryIntegrationAPI.md)
- [Model.LibraryAttribute](docs/LibraryAttribute.md)
- [Model.LimitConfig](docs/LimitConfig.md)
- [Model.LimitCounter](docs/LimitCounter.md)
- [Model.ListCampaignStoreBudgets](docs/ListCampaignStoreBudgets.md)
- [Model.ListCampaignStoreBudgetsStore](docs/ListCampaignStoreBudgetsStore.md)
- [Model.LoginParams](docs/LoginParams.md)
- [Model.Loyalty](docs/Loyalty.md)
- [Model.LoyaltyBalance](docs/LoyaltyBalance.md)
- [Model.LoyaltyBalanceWithTier](docs/LoyaltyBalanceWithTier.md)
- [Model.LoyaltyBalances](docs/LoyaltyBalances.md)
- [Model.LoyaltyBalancesWithTiers](docs/LoyaltyBalancesWithTiers.md)
- [Model.LoyaltyCard](docs/LoyaltyCard.md)
- [Model.LoyaltyCardBalances](docs/LoyaltyCardBalances.md)
- [Model.LoyaltyCardBatch](docs/LoyaltyCardBatch.md)
- [Model.LoyaltyCardBatchResponse](docs/LoyaltyCardBatchResponse.md)
- [Model.LoyaltyCardProfileRegistration](docs/LoyaltyCardProfileRegistration.md)
- [Model.LoyaltyCardRegistration](docs/LoyaltyCardRegistration.md)
- [Model.LoyaltyDashboardData](docs/LoyaltyDashboardData.md)
- [Model.LoyaltyDashboardPointsBreakdown](docs/LoyaltyDashboardPointsBreakdown.md)
- [Model.LoyaltyLedger](docs/LoyaltyLedger.md)
- [Model.LoyaltyLedgerEntry](docs/LoyaltyLedgerEntry.md)
- [Model.LoyaltyLedgerEntryFlags](docs/LoyaltyLedgerEntryFlags.md)
- [Model.LoyaltyLedgerTransactions](docs/LoyaltyLedgerTransactions.md)
- [Model.LoyaltyMembership](docs/LoyaltyMembership.md)
- [Model.LoyaltyProgram](docs/LoyaltyProgram.md)
- [Model.LoyaltyProgramBalance](docs/LoyaltyProgramBalance.md)
- [Model.LoyaltyProgramEntity](docs/LoyaltyProgramEntity.md)
- [Model.LoyaltyProgramLedgers](docs/LoyaltyProgramLedgers.md)
- [Model.LoyaltyProgramTransaction](docs/LoyaltyProgramTransaction.md)
- [Model.LoyaltySubLedger](docs/LoyaltySubLedger.md)
- [Model.LoyaltyTier](docs/LoyaltyTier.md)
- [Model.ManagementKey](docs/ManagementKey.md)
- [Model.ManagerConfig](docs/ManagerConfig.md)
- [Model.MessageLogEntries](docs/MessageLogEntries.md)
- [Model.MessageLogEntry](docs/MessageLogEntry.md)
- [Model.MessageLogRequest](docs/MessageLogRequest.md)
- [Model.MessageLogResponse](docs/MessageLogResponse.md)
- [Model.MessageTest](docs/MessageTest.md)
- [Model.Meta](docs/Meta.md)
- [Model.MultiApplicationEntity](docs/MultiApplicationEntity.md)
- [Model.MultipleAttribute](docs/MultipleAttribute.md)
- [Model.MultipleAudiences](docs/MultipleAudiences.md)
- [Model.MultipleAudiencesItem](docs/MultipleAudiencesItem.md)
- [Model.MultipleCustomerProfileIntegrationRequest](docs/MultipleCustomerProfileIntegrationRequest.md)
- [Model.MultipleCustomerProfileIntegrationRequestItem](docs/MultipleCustomerProfileIntegrationRequestItem.md)
- [Model.MultipleCustomerProfileIntegrationResponseV2](docs/MultipleCustomerProfileIntegrationResponseV2.md)
- [Model.MultipleNewAttribute](docs/MultipleNewAttribute.md)
- [Model.MultipleNewAudiences](docs/MultipleNewAudiences.md)
- [Model.MutableEntity](docs/MutableEntity.md)
- [Model.NewAccount](docs/NewAccount.md)
- [Model.NewAccountSignUp](docs/NewAccountSignUp.md)
- [Model.NewAdditionalCost](docs/NewAdditionalCost.md)
- [Model.NewAppWideCouponDeletionJob](docs/NewAppWideCouponDeletionJob.md)
- [Model.NewApplication](docs/NewApplication.md)
- [Model.NewApplicationAPIKey](docs/NewApplicationAPIKey.md)
- [Model.NewApplicationCIF](docs/NewApplicationCIF.md)
- [Model.NewApplicationCIFExpression](docs/NewApplicationCIFExpression.md)
- [Model.NewAttribute](docs/NewAttribute.md)
- [Model.NewAudience](docs/NewAudience.md)
- [Model.NewBaseNotification](docs/NewBaseNotification.md)
- [Model.NewCampaign](docs/NewCampaign.md)
- [Model.NewCampaignCollection](docs/NewCampaignCollection.md)
- [Model.NewCampaignEvaluationGroup](docs/NewCampaignEvaluationGroup.md)
- [Model.NewCampaignGroup](docs/NewCampaignGroup.md)
- [Model.NewCampaignSet](docs/NewCampaignSet.md)
- [Model.NewCampaignStoreBudget](docs/NewCampaignStoreBudget.md)
- [Model.NewCampaignStoreBudgetStoreLimit](docs/NewCampaignStoreBudgetStoreLimit.md)
- [Model.NewCampaignTemplate](docs/NewCampaignTemplate.md)
- [Model.NewCatalog](docs/NewCatalog.md)
- [Model.NewCollection](docs/NewCollection.md)
- [Model.NewCouponCreationJob](docs/NewCouponCreationJob.md)
- [Model.NewCouponDeletionJob](docs/NewCouponDeletionJob.md)
- [Model.NewCoupons](docs/NewCoupons.md)
- [Model.NewCouponsForMultipleRecipients](docs/NewCouponsForMultipleRecipients.md)
- [Model.NewCustomEffect](docs/NewCustomEffect.md)
- [Model.NewCustomerProfile](docs/NewCustomerProfile.md)
- [Model.NewCustomerSession](docs/NewCustomerSession.md)
- [Model.NewCustomerSessionV2](docs/NewCustomerSessionV2.md)
- [Model.NewEvent](docs/NewEvent.md)
- [Model.NewEventType](docs/NewEventType.md)
- [Model.NewExternalInvitation](docs/NewExternalInvitation.md)
- [Model.NewGiveawaysPool](docs/NewGiveawaysPool.md)
- [Model.NewInternalAudience](docs/NewInternalAudience.md)
- [Model.NewInvitation](docs/NewInvitation.md)
- [Model.NewInviteEmail](docs/NewInviteEmail.md)
- [Model.NewLoyaltyProgram](docs/NewLoyaltyProgram.md)
- [Model.NewLoyaltyTier](docs/NewLoyaltyTier.md)
- [Model.NewManagementKey](docs/NewManagementKey.md)
- [Model.NewMessageTest](docs/NewMessageTest.md)
- [Model.NewMultipleAudiencesItem](docs/NewMultipleAudiencesItem.md)
- [Model.NewNotificationWebhook](docs/NewNotificationWebhook.md)
- [Model.NewOutgoingIntegrationWebhook](docs/NewOutgoingIntegrationWebhook.md)
- [Model.NewPassword](docs/NewPassword.md)
- [Model.NewPasswordEmail](docs/NewPasswordEmail.md)
- [Model.NewPicklist](docs/NewPicklist.md)
- [Model.NewReferral](docs/NewReferral.md)
- [Model.NewReferralsForMultipleAdvocates](docs/NewReferralsForMultipleAdvocates.md)
- [Model.NewReturn](docs/NewReturn.md)
- [Model.NewRevisionVersion](docs/NewRevisionVersion.md)
- [Model.NewRole](docs/NewRole.md)
- [Model.NewRoleV2](docs/NewRoleV2.md)
- [Model.NewRuleset](docs/NewRuleset.md)
- [Model.NewSamlConnection](docs/NewSamlConnection.md)
- [Model.NewStore](docs/NewStore.md)
- [Model.NewTemplateDef](docs/NewTemplateDef.md)
- [Model.NewUser](docs/NewUser.md)
- [Model.NewWebhook](docs/NewWebhook.md)
- [Model.Notification](docs/Notification.md)
- [Model.NotificationActivation](docs/NotificationActivation.md)
- [Model.NotificationListItem](docs/NotificationListItem.md)
- [Model.OktaEvent](docs/OktaEvent.md)
- [Model.OktaEventPayload](docs/OktaEventPayload.md)
- [Model.OktaEventPayloadData](docs/OktaEventPayloadData.md)
- [Model.OktaEventTarget](docs/OktaEventTarget.md)
- [Model.OneTimeCode](docs/OneTimeCode.md)
- [Model.OutgoingIntegrationBrazePolicy](docs/OutgoingIntegrationBrazePolicy.md)
- [Model.OutgoingIntegrationCleverTapPolicy](docs/OutgoingIntegrationCleverTapPolicy.md)
- [Model.OutgoingIntegrationConfiguration](docs/OutgoingIntegrationConfiguration.md)
- [Model.OutgoingIntegrationIterablePolicy](docs/OutgoingIntegrationIterablePolicy.md)
- [Model.OutgoingIntegrationMoEngagePolicy](docs/OutgoingIntegrationMoEngagePolicy.md)
- [Model.OutgoingIntegrationTemplate](docs/OutgoingIntegrationTemplate.md)
- [Model.OutgoingIntegrationTemplateWithConfigurationDetails](docs/OutgoingIntegrationTemplateWithConfigurationDetails.md)
- [Model.OutgoingIntegrationTemplates](docs/OutgoingIntegrationTemplates.md)
- [Model.OutgoingIntegrationType](docs/OutgoingIntegrationType.md)
- [Model.OutgoingIntegrationTypes](docs/OutgoingIntegrationTypes.md)
- [Model.PatchItemCatalogAction](docs/PatchItemCatalogAction.md)
- [Model.PatchManyItemsCatalogAction](docs/PatchManyItemsCatalogAction.md)
- [Model.PendingPointsNotificationPolicy](docs/PendingPointsNotificationPolicy.md)
- [Model.Picklist](docs/Picklist.md)
- [Model.Product](docs/Product.md)
- [Model.ProductSearchMatch](docs/ProductSearchMatch.md)
- [Model.ProductUnitAnalytics](docs/ProductUnitAnalytics.md)
- [Model.ProductUnitAnalyticsDataPoint](docs/ProductUnitAnalyticsDataPoint.md)
- [Model.ProductUnitAnalyticsTotals](docs/ProductUnitAnalyticsTotals.md)
- [Model.ProfileAudiencesChanges](docs/ProfileAudiencesChanges.md)
- [Model.ProjectedTier](docs/ProjectedTier.md)
- [Model.RedeemReferralEffectProps](docs/RedeemReferralEffectProps.md)
- [Model.Referral](docs/Referral.md)
- [Model.ReferralConstraints](docs/ReferralConstraints.md)
- [Model.ReferralCreatedEffectProps](docs/ReferralCreatedEffectProps.md)
- [Model.ReferralRejectionReason](docs/ReferralRejectionReason.md)
- [Model.RejectCouponEffectProps](docs/RejectCouponEffectProps.md)
- [Model.RejectReferralEffectProps](docs/RejectReferralEffectProps.md)
- [Model.RemoveFromAudienceEffectProps](docs/RemoveFromAudienceEffectProps.md)
- [Model.RemoveItemCatalogAction](docs/RemoveItemCatalogAction.md)
- [Model.RemoveManyItemsCatalogAction](docs/RemoveManyItemsCatalogAction.md)
- [Model.ReopenSessionResponse](docs/ReopenSessionResponse.md)
- [Model.ReserveCouponEffectProps](docs/ReserveCouponEffectProps.md)
- [Model.Return](docs/Return.md)
- [Model.ReturnIntegrationRequest](docs/ReturnIntegrationRequest.md)
- [Model.ReturnedCartItem](docs/ReturnedCartItem.md)
- [Model.Revision](docs/Revision.md)
- [Model.RevisionActivation](docs/RevisionActivation.md)
- [Model.RevisionActivationRequest](docs/RevisionActivationRequest.md)
- [Model.RevisionVersion](docs/RevisionVersion.md)
- [Model.Role](docs/Role.md)
- [Model.RoleAssign](docs/RoleAssign.md)
- [Model.RoleMembership](docs/RoleMembership.md)
- [Model.RoleV2](docs/RoleV2.md)
- [Model.RoleV2ApplicationDetails](docs/RoleV2ApplicationDetails.md)
- [Model.RoleV2Base](docs/RoleV2Base.md)
- [Model.RoleV2PermissionSet](docs/RoleV2PermissionSet.md)
- [Model.RoleV2Permissions](docs/RoleV2Permissions.md)
- [Model.RoleV2RolesGroup](docs/RoleV2RolesGroup.md)
- [Model.RollbackAddedLoyaltyPointsEffectProps](docs/RollbackAddedLoyaltyPointsEffectProps.md)
- [Model.RollbackCouponEffectProps](docs/RollbackCouponEffectProps.md)
- [Model.RollbackDeductedLoyaltyPointsEffectProps](docs/RollbackDeductedLoyaltyPointsEffectProps.md)
- [Model.RollbackDiscountEffectProps](docs/RollbackDiscountEffectProps.md)
- [Model.RollbackIncreasedAchievementProgressEffectProps](docs/RollbackIncreasedAchievementProgressEffectProps.md)
- [Model.RollbackReferralEffectProps](docs/RollbackReferralEffectProps.md)
- [Model.Rule](docs/Rule.md)
- [Model.RuleFailureReason](docs/RuleFailureReason.md)
- [Model.Ruleset](docs/Ruleset.md)
- [Model.SSOConfig](docs/SSOConfig.md)
- [Model.SamlConnection](docs/SamlConnection.md)
- [Model.SamlConnectionInternal](docs/SamlConnectionInternal.md)
- [Model.SamlConnectionMetadata](docs/SamlConnectionMetadata.md)
- [Model.SamlLoginEndpoint](docs/SamlLoginEndpoint.md)
- [Model.ScimBaseUser](docs/ScimBaseUser.md)
- [Model.ScimBaseUserName](docs/ScimBaseUserName.md)
- [Model.ScimNewUser](docs/ScimNewUser.md)
- [Model.ScimPatchOperation](docs/ScimPatchOperation.md)
- [Model.ScimPatchRequest](docs/ScimPatchRequest.md)
- [Model.ScimResource](docs/ScimResource.md)
- [Model.ScimResourceTypesListResponse](docs/ScimResourceTypesListResponse.md)
- [Model.ScimSchemaResource](docs/ScimSchemaResource.md)
- [Model.ScimSchemasListResponse](docs/ScimSchemasListResponse.md)
- [Model.ScimServiceProviderConfigResponse](docs/ScimServiceProviderConfigResponse.md)
- [Model.ScimServiceProviderConfigResponseBulk](docs/ScimServiceProviderConfigResponseBulk.md)
- [Model.ScimServiceProviderConfigResponseChangePassword](docs/ScimServiceProviderConfigResponseChangePassword.md)
- [Model.ScimServiceProviderConfigResponseFilter](docs/ScimServiceProviderConfigResponseFilter.md)
- [Model.ScimServiceProviderConfigResponsePatch](docs/ScimServiceProviderConfigResponsePatch.md)
- [Model.ScimServiceProviderConfigResponseSort](docs/ScimServiceProviderConfigResponseSort.md)
- [Model.ScimUser](docs/ScimUser.md)
- [Model.ScimUsersListResponse](docs/ScimUsersListResponse.md)
- [Model.Session](docs/Session.md)
- [Model.SetDiscountEffectProps](docs/SetDiscountEffectProps.md)
- [Model.SetDiscountPerAdditionalCostEffectProps](docs/SetDiscountPerAdditionalCostEffectProps.md)
- [Model.SetDiscountPerAdditionalCostPerItemEffectProps](docs/SetDiscountPerAdditionalCostPerItemEffectProps.md)
- [Model.SetDiscountPerItemEffectProps](docs/SetDiscountPerItemEffectProps.md)
- [Model.ShowBundleMetadataEffectProps](docs/ShowBundleMetadataEffectProps.md)
- [Model.ShowNotificationEffectProps](docs/ShowNotificationEffectProps.md)
- [Model.SkuUnitAnalytics](docs/SkuUnitAnalytics.md)
- [Model.SkuUnitAnalyticsDataPoint](docs/SkuUnitAnalyticsDataPoint.md)
- [Model.SlotDef](docs/SlotDef.md)
- [Model.Store](docs/Store.md)
- [Model.StrikethroughChangedItem](docs/StrikethroughChangedItem.md)
- [Model.StrikethroughCustomEffectPerItemProps](docs/StrikethroughCustomEffectPerItemProps.md)
- [Model.StrikethroughDebugResponse](docs/StrikethroughDebugResponse.md)
- [Model.StrikethroughEffect](docs/StrikethroughEffect.md)
- [Model.StrikethroughLabelingNotification](docs/StrikethroughLabelingNotification.md)
- [Model.StrikethroughSetDiscountPerItemEffectProps](docs/StrikethroughSetDiscountPerItemEffectProps.md)
- [Model.StrikethroughTrigger](docs/StrikethroughTrigger.md)
- [Model.SummaryCampaignStoreBudget](docs/SummaryCampaignStoreBudget.md)
- [Model.TalangAttribute](docs/TalangAttribute.md)
- [Model.TalangAttributeVisibility](docs/TalangAttributeVisibility.md)
- [Model.TemplateArgDef](docs/TemplateArgDef.md)
- [Model.TemplateDef](docs/TemplateDef.md)
- [Model.TemplateLimitConfig](docs/TemplateLimitConfig.md)
- [Model.Tier](docs/Tier.md)
- [Model.TierDowngradeNotificationPolicy](docs/TierDowngradeNotificationPolicy.md)
- [Model.TierUpgradeNotificationPolicy](docs/TierUpgradeNotificationPolicy.md)
- [Model.TierWillDowngradeNotificationPolicy](docs/TierWillDowngradeNotificationPolicy.md)
- [Model.TierWillDowngradeNotificationTrigger](docs/TierWillDowngradeNotificationTrigger.md)
- [Model.TimePoint](docs/TimePoint.md)
- [Model.TrackEventV2Response](docs/TrackEventV2Response.md)
- [Model.TransferLoyaltyCard](docs/TransferLoyaltyCard.md)
- [Model.TriggerWebhookEffectProps](docs/TriggerWebhookEffectProps.md)
- [Model.TwoFAConfig](docs/TwoFAConfig.md)
- [Model.UpdateAccount](docs/UpdateAccount.md)
- [Model.UpdateAchievement](docs/UpdateAchievement.md)
- [Model.UpdateApplication](docs/UpdateApplication.md)
- [Model.UpdateApplicationAPIKey](docs/UpdateApplicationAPIKey.md)
- [Model.UpdateApplicationCIF](docs/UpdateApplicationCIF.md)
- [Model.UpdateAttributeEffectProps](docs/UpdateAttributeEffectProps.md)
- [Model.UpdateAudience](docs/UpdateAudience.md)
- [Model.UpdateCampaign](docs/UpdateCampaign.md)
- [Model.UpdateCampaignCollection](docs/UpdateCampaignCollection.md)
- [Model.UpdateCampaignEvaluationGroup](docs/UpdateCampaignEvaluationGroup.md)
- [Model.UpdateCampaignGroup](docs/UpdateCampaignGroup.md)
- [Model.UpdateCampaignTemplate](docs/UpdateCampaignTemplate.md)
- [Model.UpdateCatalog](docs/UpdateCatalog.md)
- [Model.UpdateCollection](docs/UpdateCollection.md)
- [Model.UpdateCoupon](docs/UpdateCoupon.md)
- [Model.UpdateCouponBatch](docs/UpdateCouponBatch.md)
- [Model.UpdateLoyaltyCard](docs/UpdateLoyaltyCard.md)
- [Model.UpdateLoyaltyProgram](docs/UpdateLoyaltyProgram.md)
- [Model.UpdateLoyaltyProgramTier](docs/UpdateLoyaltyProgramTier.md)
- [Model.UpdatePicklist](docs/UpdatePicklist.md)
- [Model.UpdateReferral](docs/UpdateReferral.md)
- [Model.UpdateReferralBatch](docs/UpdateReferralBatch.md)
- [Model.UpdateRole](docs/UpdateRole.md)
- [Model.UpdateStore](docs/UpdateStore.md)
- [Model.UpdateUser](docs/UpdateUser.md)
- [Model.User](docs/User.md)
- [Model.UserEntity](docs/UserEntity.md)
- [Model.ValueMap](docs/ValueMap.md)
- [Model.Webhook](docs/Webhook.md)
- [Model.WebhookActivationLogEntry](docs/WebhookActivationLogEntry.md)
- [Model.WebhookLogEntry](docs/WebhookLogEntry.md)
- [Model.WebhookWithOutgoingIntegrationDetails](docs/WebhookWithOutgoingIntegrationDetails.md)
- [Model.WillAwardGiveawayEffectProps](docs/WillAwardGiveawayEffectProps.md)

## Authorization

### api_key_v1

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

### management_key

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

### manager_auth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

