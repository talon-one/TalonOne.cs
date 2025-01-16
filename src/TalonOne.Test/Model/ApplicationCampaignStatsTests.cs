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
    ///  Class for testing ApplicationCampaignStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationCampaignStatsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationCampaignStats
        //private ApplicationCampaignStats instance;

        public ApplicationCampaignStatsTests()
        {
            // TODO uncomment below to create an instance of ApplicationCampaignStats
            //instance = new ApplicationCampaignStats();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationCampaignStats
        /// </summary>
        [Fact]
        public void ApplicationCampaignStatsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationCampaignStats
            //Assert.IsInstanceOfType<ApplicationCampaignStats> (instance, "variable 'instance' is a ApplicationCampaignStats");
        }


        /// <summary>
        /// Test the property 'Disabled'
        /// </summary>
        [Fact]
        public void DisabledTest()
        {
            // TODO unit test for the property 'Disabled'
        }
        /// <summary>
        /// Test the property 'Staged'
        /// </summary>
        [Fact]
        public void StagedTest()
        {
            // TODO unit test for the property 'Staged'
        }
        /// <summary>
        /// Test the property 'Scheduled'
        /// </summary>
        [Fact]
        public void ScheduledTest()
        {
            // TODO unit test for the property 'Scheduled'
        }
        /// <summary>
        /// Test the property 'Running'
        /// </summary>
        [Fact]
        public void RunningTest()
        {
            // TODO unit test for the property 'Running'
        }
        /// <summary>
        /// Test the property 'Expired'
        /// </summary>
        [Fact]
        public void ExpiredTest()
        {
            // TODO unit test for the property 'Expired'
        }
        /// <summary>
        /// Test the property 'Archived'
        /// </summary>
        [Fact]
        public void ArchivedTest()
        {
            // TODO unit test for the property 'Archived'
        }

    }

}
