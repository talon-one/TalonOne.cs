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
    ///  Class for testing InlineResponse20034
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InlineResponse20034Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InlineResponse20034
        //private InlineResponse20034 instance;

        public InlineResponse20034Tests()
        {
            // TODO uncomment below to create an instance of InlineResponse20034
            //instance = new InlineResponse20034();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InlineResponse20034
        /// </summary>
        [Fact]
        public void InlineResponse20034InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InlineResponse20034
            //Assert.IsInstanceOfType<InlineResponse20034> (instance, "variable 'instance' is a InlineResponse20034");
        }


        /// <summary>
        /// Test the property 'TotalResultSize'
        /// </summary>
        [Fact]
        public void TotalResultSizeTest()
        {
            // TODO unit test for the property 'TotalResultSize'
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