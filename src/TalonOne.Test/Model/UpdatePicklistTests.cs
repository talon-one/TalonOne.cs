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
    ///  Class for testing UpdatePicklist
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdatePicklistTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdatePicklist
        //private UpdatePicklist instance;

        public UpdatePicklistTests()
        {
            // TODO uncomment below to create an instance of UpdatePicklist
            //instance = new UpdatePicklist();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdatePicklist
        /// </summary>
        [Fact]
        public void UpdatePicklistInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdatePicklist
            //Assert.IsInstanceOfType<UpdatePicklist> (instance, "variable 'instance' is a UpdatePicklist");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Values'
        /// </summary>
        [Fact]
        public void ValuesTest()
        {
            // TODO unit test for the property 'Values'
        }

    }

}
