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
    ///  Class for testing Campaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignTests
    {
        // TODO uncomment below to declare an instance variable for Campaign
        //private Campaign instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Campaign
            //instance = new Campaign();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Campaign
        /// </summary>
        [Test]
        public void CampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Campaign
            //Assert.IsInstanceOfType<Campaign> (instance, "variable 'instance' is a Campaign");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Test]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
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
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
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
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ActiveRulesetId'
        /// </summary>
        [Test]
        public void ActiveRulesetIdTest()
        {
            // TODO unit test for the property 'ActiveRulesetId'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'Features'
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO unit test for the property 'Features'
        }
        /// <summary>
        /// Test the property 'CouponSettings'
        /// </summary>
        [Test]
        public void CouponSettingsTest()
        {
            // TODO unit test for the property 'CouponSettings'
        }
        /// <summary>
        /// Test the property 'ReferralSettings'
        /// </summary>
        [Test]
        public void ReferralSettingsTest()
        {
            // TODO unit test for the property 'ReferralSettings'
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
        /// Test the property 'CouponRedemptionCount'
        /// </summary>
        [Test]
        public void CouponRedemptionCountTest()
        {
            // TODO unit test for the property 'CouponRedemptionCount'
        }
        /// <summary>
        /// Test the property 'ReferralRedemptionCount'
        /// </summary>
        [Test]
        public void ReferralRedemptionCountTest()
        {
            // TODO unit test for the property 'ReferralRedemptionCount'
        }
        /// <summary>
        /// Test the property 'DiscountCount'
        /// </summary>
        [Test]
        public void DiscountCountTest()
        {
            // TODO unit test for the property 'DiscountCount'
        }
        /// <summary>
        /// Test the property 'DiscountEffectCount'
        /// </summary>
        [Test]
        public void DiscountEffectCountTest()
        {
            // TODO unit test for the property 'DiscountEffectCount'
        }
        /// <summary>
        /// Test the property 'CouponCreationCount'
        /// </summary>
        [Test]
        public void CouponCreationCountTest()
        {
            // TODO unit test for the property 'CouponCreationCount'
        }
        /// <summary>
        /// Test the property 'LastActivity'
        /// </summary>
        [Test]
        public void LastActivityTest()
        {
            // TODO unit test for the property 'LastActivity'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Test]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }
        /// <summary>
        /// Test the property 'UpdatedBy'
        /// </summary>
        [Test]
        public void UpdatedByTest()
        {
            // TODO unit test for the property 'UpdatedBy'
        }

    }

}
