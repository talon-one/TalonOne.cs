using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace _example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure BasePath & API key authorization: api_key_v1
            var integrationConfig = new Configuration {
                BasePath = "http://localhost:9000",
                ApiKey = new Dictionary<string, string> {
                    { "Authorization", System.Environment.GetEnvironmentVariable("TALON_API_KEY") }
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
    }
}
