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
    ///  Class for testing BaseNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BaseNotificationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BaseNotification
        //private BaseNotification instance;

        public BaseNotificationTests()
        {
            // TODO uncomment below to create an instance of BaseNotification
            //instance = new BaseNotification();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BaseNotification
        /// </summary>
        [Fact]
        public void BaseNotificationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BaseNotification
            //Assert.IsInstanceOfType<BaseNotification> (instance, "variable 'instance' is a BaseNotification");
        }


        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }
        /// <summary>
        /// Test the property 'Webhook'
        /// </summary>
        [Fact]
        public void WebhookTest()
        {
            // TODO unit test for the property 'Webhook'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
