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
    ///  Class for testing NewCampaignGroup
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCampaignGroupTests
    {
        // TODO uncomment below to declare an instance variable for NewCampaignGroup
        //private NewCampaignGroup instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NewCampaignGroup
            //instance = new NewCampaignGroup();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NewCampaignGroup
        /// </summary>
        [Test]
        public void NewCampaignGroupInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" NewCampaignGroup
            //Assert.IsInstanceOf(typeof(NewCampaignGroup), instance);
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
        /// Test the property 'SubscribedApplicationsIds'
        /// </summary>
        [Test]
        public void SubscribedApplicationsIdsTest()
        {
            // TODO unit test for the property 'SubscribedApplicationsIds'
        }
        /// <summary>
        /// Test the property 'CampaignIds'
        /// </summary>
        [Test]
        public void CampaignIdsTest()
        {
            // TODO unit test for the property 'CampaignIds'
        }

    }

}