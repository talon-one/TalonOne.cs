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
    ///  Class for testing OutgoingIntegrationConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OutgoingIntegrationConfigurationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OutgoingIntegrationConfiguration
        //private OutgoingIntegrationConfiguration instance;

        public OutgoingIntegrationConfigurationTests()
        {
            // TODO uncomment below to create an instance of OutgoingIntegrationConfiguration
            //instance = new OutgoingIntegrationConfiguration();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OutgoingIntegrationConfiguration
        /// </summary>
        [Fact]
        public void OutgoingIntegrationConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OutgoingIntegrationConfiguration
            //Assert.IsInstanceOfType<OutgoingIntegrationConfiguration> (instance, "variable 'instance' is a OutgoingIntegrationConfiguration");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'TypeId'
        /// </summary>
        [Fact]
        public void TypeIdTest()
        {
            // TODO unit test for the property 'TypeId'
        }
        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }

    }

}
