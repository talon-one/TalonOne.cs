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
    ///  Class for testing Giveaway
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GiveawayTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Giveaway
        //private Giveaway instance;

        public GiveawayTests()
        {
            // TODO uncomment below to create an instance of Giveaway
            //instance = new Giveaway();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Giveaway
        /// </summary>
        [Fact]
        public void GiveawayInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Giveaway
            //Assert.IsInstanceOfType<Giveaway> (instance, "variable 'instance' is a Giveaway");
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
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'PoolId'
        /// </summary>
        [Fact]
        public void PoolIdTest()
        {
            // TODO unit test for the property 'PoolId'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Fact]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Fact]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'Used'
        /// </summary>
        [Fact]
        public void UsedTest()
        {
            // TODO unit test for the property 'Used'
        }
        /// <summary>
        /// Test the property 'ImportId'
        /// </summary>
        [Fact]
        public void ImportIdTest()
        {
            // TODO unit test for the property 'ImportId'
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
        /// Test the property 'ProfileId'
        /// </summary>
        [Fact]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
        }

    }

}
