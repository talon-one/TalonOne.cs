/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    ///  Class for testing NewApplication
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewApplicationTests
    {
        // TODO uncomment below to declare an instance variable for NewApplication
        //private NewApplication instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NewApplication
            //instance = new NewApplication();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NewApplication
        /// </summary>
        [Test]
        public void NewApplicationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" NewApplication
            //Assert.IsInstanceOf(typeof(NewApplication), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'CaseSensitivity'
        /// </summary>
        [Test]
        public void CaseSensitivityTest()
        {
            // TODO unit test for the property 'CaseSensitivity'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'Limits'
        /// </summary>
        [Test]
        public void LimitsTest()
        {
            // TODO unit test for the property 'Limits'
        }
        /// <summary>
        /// Test the property 'AttributesSettings'
        /// </summary>
        [Test]
        public void AttributesSettingsTest()
        {
            // TODO unit test for the property 'AttributesSettings'
        }
        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }

    }

}
