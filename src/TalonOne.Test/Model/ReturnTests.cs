/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    ///  Class for testing Return
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReturnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Return
        //private Return instance;

        public ReturnTests()
        {
            // TODO uncomment below to create an instance of Return
            //instance = new Return();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Return
        /// </summary>
        [Fact]
        public void ReturnInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Return
            //Assert.IsInstanceOfType<Return> (instance, "variable 'instance' is a Return");
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
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
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
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'ReturnedCartItems'
        /// </summary>
        [Fact]
        public void ReturnedCartItemsTest()
        {
            // TODO unit test for the property 'ReturnedCartItems'
        }
        /// <summary>
        /// Test the property 'EventId'
        /// </summary>
        [Fact]
        public void EventIdTest()
        {
            // TODO unit test for the property 'EventId'
        }
        /// <summary>
        /// Test the property 'SessionId'
        /// </summary>
        [Fact]
        public void SessionIdTest()
        {
            // TODO unit test for the property 'SessionId'
        }
        /// <summary>
        /// Test the property 'SessionIntegrationId'
        /// </summary>
        [Fact]
        public void SessionIntegrationIdTest()
        {
            // TODO unit test for the property 'SessionIntegrationId'
        }
        /// <summary>
        /// Test the property 'ProfileId'
        /// </summary>
        [Fact]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
        }
        /// <summary>
        /// Test the property 'ProfileIntegrationId'
        /// </summary>
        [Fact]
        public void ProfileIntegrationIdTest()
        {
            // TODO unit test for the property 'ProfileIntegrationId'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }

    }

}