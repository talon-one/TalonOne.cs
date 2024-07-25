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
    ///  Class for testing ApplicationCampaignAnalytics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationCampaignAnalyticsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationCampaignAnalytics
        //private ApplicationCampaignAnalytics instance;

        public ApplicationCampaignAnalyticsTests()
        {
            // TODO uncomment below to create an instance of ApplicationCampaignAnalytics
            //instance = new ApplicationCampaignAnalytics();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationCampaignAnalytics
        /// </summary>
        [Fact]
        public void ApplicationCampaignAnalyticsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationCampaignAnalytics
            //Assert.IsInstanceOfType<ApplicationCampaignAnalytics> (instance, "variable 'instance' is a ApplicationCampaignAnalytics");
        }


        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
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
        /// Test the property 'CampaignName'
        /// </summary>
        [Fact]
        public void CampaignNameTest()
        {
            // TODO unit test for the property 'CampaignName'
        }
        /// <summary>
        /// Test the property 'CampaignTags'
        /// </summary>
        [Fact]
        public void CampaignTagsTest()
        {
            // TODO unit test for the property 'CampaignTags'
        }
        /// <summary>
        /// Test the property 'CampaignState'
        /// </summary>
        [Fact]
        public void CampaignStateTest()
        {
            // TODO unit test for the property 'CampaignState'
        }
        /// <summary>
        /// Test the property 'TotalRevenue'
        /// </summary>
        [Fact]
        public void TotalRevenueTest()
        {
            // TODO unit test for the property 'TotalRevenue'
        }
        /// <summary>
        /// Test the property 'SessionsCount'
        /// </summary>
        [Fact]
        public void SessionsCountTest()
        {
            // TODO unit test for the property 'SessionsCount'
        }
        /// <summary>
        /// Test the property 'AvgItemsPerSession'
        /// </summary>
        [Fact]
        public void AvgItemsPerSessionTest()
        {
            // TODO unit test for the property 'AvgItemsPerSession'
        }
        /// <summary>
        /// Test the property 'AvgSessionValue'
        /// </summary>
        [Fact]
        public void AvgSessionValueTest()
        {
            // TODO unit test for the property 'AvgSessionValue'
        }
        /// <summary>
        /// Test the property 'TotalDiscounts'
        /// </summary>
        [Fact]
        public void TotalDiscountsTest()
        {
            // TODO unit test for the property 'TotalDiscounts'
        }
        /// <summary>
        /// Test the property 'CouponsCount'
        /// </summary>
        [Fact]
        public void CouponsCountTest()
        {
            // TODO unit test for the property 'CouponsCount'
        }

    }

}
