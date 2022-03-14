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
    ///  Class for testing SamlConnection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SamlConnectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SamlConnection
        //private SamlConnection instance;

        public SamlConnectionTests()
        {
            // TODO uncomment below to create an instance of SamlConnection
            //instance = new SamlConnection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SamlConnection
        /// </summary>
        [Fact]
        public void SamlConnectionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SamlConnection
            //Assert.IsInstanceOfType<SamlConnection> (instance, "variable 'instance' is a SamlConnection");
        }


        /// <summary>
        /// Test the property 'AssertionConsumerServiceURL'
        /// </summary>
        [Fact]
        public void AssertionConsumerServiceURLTest()
        {
            // TODO unit test for the property 'AssertionConsumerServiceURL'
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'Issuer'
        /// </summary>
        [Fact]
        public void IssuerTest()
        {
            // TODO unit test for the property 'Issuer'
        }
        /// <summary>
        /// Test the property 'SignOnURL'
        /// </summary>
        [Fact]
        public void SignOnURLTest()
        {
            // TODO unit test for the property 'SignOnURL'
        }
        /// <summary>
        /// Test the property 'SignOutURL'
        /// </summary>
        [Fact]
        public void SignOutURLTest()
        {
            // TODO unit test for the property 'SignOutURL'
        }
        /// <summary>
        /// Test the property 'MetadataURL'
        /// </summary>
        [Fact]
        public void MetadataURLTest()
        {
            // TODO unit test for the property 'MetadataURL'
        }
        /// <summary>
        /// Test the property 'AudienceURI'
        /// </summary>
        [Fact]
        public void AudienceURITest()
        {
            // TODO unit test for the property 'AudienceURI'
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

    }

}
