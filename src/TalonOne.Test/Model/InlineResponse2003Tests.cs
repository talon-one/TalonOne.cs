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
    ///  Class for testing InlineResponse2003
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InlineResponse2003Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InlineResponse2003
        //private InlineResponse2003 instance;

        public InlineResponse2003Tests()
        {
            // TODO uncomment below to create an instance of InlineResponse2003
            //instance = new InlineResponse2003();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InlineResponse2003
        /// </summary>
        [Fact]
        public void InlineResponse2003InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InlineResponse2003
            //Assert.IsInstanceOfType<InlineResponse2003> (instance, "variable 'instance' is a InlineResponse2003");
        }


        /// <summary>
        /// Test the property 'HasMore'
        /// </summary>
        [Fact]
        public void HasMoreTest()
        {
            // TODO unit test for the property 'HasMore'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
