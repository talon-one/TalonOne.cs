/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

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
    ///  Class for testing NewWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NewWebhookTests
    {
        // TODO uncomment below to declare an instance variable for NewWebhook
        //private NewWebhook instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NewWebhook
            //instance = new NewWebhook();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NewWebhook
        /// </summary>
        [Test]
        public void NewWebhookInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewWebhook
            //Assert.IsInstanceOfType<NewWebhook> (instance, "variable 'instance' is a NewWebhook");
        }


        /// <summary>
        /// Test the property 'ApplicationIds'
        /// </summary>
        [Test]
        public void ApplicationIdsTest()
        {
            // TODO unit test for the property 'ApplicationIds'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Verb'
        /// </summary>
        [Test]
        public void VerbTest()
        {
            // TODO unit test for the property 'Verb'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'Headers'
        /// </summary>
        [Test]
        public void HeadersTest()
        {
            // TODO unit test for the property 'Headers'
        }
        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Test]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }
        /// <summary>
        /// Test the property 'Params'
        /// </summary>
        [Test]
        public void ParamsTest()
        {
            // TODO unit test for the property 'Params'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }

    }

}
