/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Model;
using TalonOne.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing NewCampaignStoreBudgetStoreLimit
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCampaignStoreBudgetStoreLimitTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewCampaignStoreBudgetStoreLimit
        //private NewCampaignStoreBudgetStoreLimit instance;

        public NewCampaignStoreBudgetStoreLimitTests()
        {
            // TODO uncomment below to create an instance of NewCampaignStoreBudgetStoreLimit
            //instance = new NewCampaignStoreBudgetStoreLimit();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewCampaignStoreBudgetStoreLimit
        /// </summary>
        [Fact]
        public void NewCampaignStoreBudgetStoreLimitInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewCampaignStoreBudgetStoreLimit
            //Assert.IsInstanceOfType<NewCampaignStoreBudgetStoreLimit> (instance, "variable 'instance' is a NewCampaignStoreBudgetStoreLimit");
        }


        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Fact]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

    }

}
