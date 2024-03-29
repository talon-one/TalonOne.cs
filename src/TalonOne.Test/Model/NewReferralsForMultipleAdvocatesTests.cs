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
    ///  Class for testing NewReferralsForMultipleAdvocates
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewReferralsForMultipleAdvocatesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewReferralsForMultipleAdvocates
        //private NewReferralsForMultipleAdvocates instance;

        public NewReferralsForMultipleAdvocatesTests()
        {
            // TODO uncomment below to create an instance of NewReferralsForMultipleAdvocates
            //instance = new NewReferralsForMultipleAdvocates();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewReferralsForMultipleAdvocates
        /// </summary>
        [Fact]
        public void NewReferralsForMultipleAdvocatesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewReferralsForMultipleAdvocates
            //Assert.IsInstanceOfType<NewReferralsForMultipleAdvocates> (instance, "variable 'instance' is a NewReferralsForMultipleAdvocates");
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
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Fact]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }
        /// <summary>
        /// Test the property 'UsageLimit'
        /// </summary>
        [Fact]
        public void UsageLimitTest()
        {
            // TODO unit test for the property 'UsageLimit'
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'AdvocateProfileIntegrationIds'
        /// </summary>
        [Fact]
        public void AdvocateProfileIntegrationIdsTest()
        {
            // TODO unit test for the property 'AdvocateProfileIntegrationIds'
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
        /// Test the property 'ValidCharacters'
        /// </summary>
        [Fact]
        public void ValidCharactersTest()
        {
            // TODO unit test for the property 'ValidCharacters'
        }
        /// <summary>
        /// Test the property 'ReferralPattern'
        /// </summary>
        [Fact]
        public void ReferralPatternTest()
        {
            // TODO unit test for the property 'ReferralPattern'
        }

    }

}
