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
    ///  Class for testing NewSamlConnection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewSamlConnectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewSamlConnection
        //private NewSamlConnection instance;

        public NewSamlConnectionTests()
        {
            // TODO uncomment below to create an instance of NewSamlConnection
            //instance = new NewSamlConnection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewSamlConnection
        /// </summary>
        [Fact]
        public void NewSamlConnectionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewSamlConnection
            //Assert.IsInstanceOfType<NewSamlConnection> (instance, "variable 'instance' is a NewSamlConnection");
        }


        /// <summary>
        /// Test the property 'X509certificate'
        /// </summary>
        [Fact]
        public void X509certificateTest()
        {
            // TODO unit test for the property 'X509certificate'
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

    }

}
