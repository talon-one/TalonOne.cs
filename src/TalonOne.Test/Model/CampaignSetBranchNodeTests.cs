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
    ///  Class for testing CampaignSetBranchNode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignSetBranchNodeTests
    {
        // TODO uncomment below to declare an instance variable for CampaignSetBranchNode
        //private CampaignSetBranchNode instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CampaignSetBranchNode
            //instance = new CampaignSetBranchNode();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignSetBranchNode
        /// </summary>
        [Test]
        public void CampaignSetBranchNodeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CampaignSetBranchNode
            //Assert.IsInstanceOfType<CampaignSetBranchNode> (instance, "variable 'instance' is a CampaignSetBranchNode");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
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
        /// Test the property 'Operator'
        /// </summary>
        [Test]
        public void OperatorTest()
        {
            // TODO unit test for the property 'Operator'
        }
        /// <summary>
        /// Test the property 'Elements'
        /// </summary>
        [Test]
        public void ElementsTest()
        {
            // TODO unit test for the property 'Elements'
        }

    }

}
