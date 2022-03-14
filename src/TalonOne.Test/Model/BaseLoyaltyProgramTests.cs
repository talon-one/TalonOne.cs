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
    ///  Class for testing BaseLoyaltyProgram
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BaseLoyaltyProgramTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BaseLoyaltyProgram
        //private BaseLoyaltyProgram instance;

        public BaseLoyaltyProgramTests()
        {
            // TODO uncomment below to create an instance of BaseLoyaltyProgram
            //instance = new BaseLoyaltyProgram();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BaseLoyaltyProgram
        /// </summary>
        [Fact]
        public void BaseLoyaltyProgramInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BaseLoyaltyProgram
            //Assert.IsInstanceOfType<BaseLoyaltyProgram> (instance, "variable 'instance' is a BaseLoyaltyProgram");
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'SubscribedApplications'
        /// </summary>
        [Fact]
        public void SubscribedApplicationsTest()
        {
            // TODO unit test for the property 'SubscribedApplications'
        }
        /// <summary>
        /// Test the property 'DefaultValidity'
        /// </summary>
        [Fact]
        public void DefaultValidityTest()
        {
            // TODO unit test for the property 'DefaultValidity'
        }
        /// <summary>
        /// Test the property 'DefaultPending'
        /// </summary>
        [Fact]
        public void DefaultPendingTest()
        {
            // TODO unit test for the property 'DefaultPending'
        }
        /// <summary>
        /// Test the property 'AllowSubledger'
        /// </summary>
        [Fact]
        public void AllowSubledgerTest()
        {
            // TODO unit test for the property 'AllowSubledger'
        }
        /// <summary>
        /// Test the property 'UsersPerCardLimit'
        /// </summary>
        [Fact]
        public void UsersPerCardLimitTest()
        {
            // TODO unit test for the property 'UsersPerCardLimit'
        }

    }

}
