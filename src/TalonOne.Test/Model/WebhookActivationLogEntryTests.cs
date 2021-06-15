/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    ///  Class for testing WebhookActivationLogEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WebhookActivationLogEntryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WebhookActivationLogEntry
        //private WebhookActivationLogEntry instance;

        public WebhookActivationLogEntryTests()
        {
            // TODO uncomment below to create an instance of WebhookActivationLogEntry
            //instance = new WebhookActivationLogEntry();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookActivationLogEntry
        /// </summary>
        [Fact]
        public void WebhookActivationLogEntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WebhookActivationLogEntry
            //Assert.IsInstanceOfType<WebhookActivationLogEntry> (instance, "variable 'instance' is a WebhookActivationLogEntry");
        }


        /// <summary>
        /// Test the property 'IntegrationRequestUuid'
        /// </summary>
        [Fact]
        public void IntegrationRequestUuidTest()
        {
            // TODO unit test for the property 'IntegrationRequestUuid'
        }
        /// <summary>
        /// Test the property 'WebhookId'
        /// </summary>
        [Fact]
        public void WebhookIdTest()
        {
            // TODO unit test for the property 'WebhookId'
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }

    }

}
