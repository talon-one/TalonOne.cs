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
    ///  Class for testing ApplicationAnalyticsDataPointAvgItemsPerSession
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationAnalyticsDataPointAvgItemsPerSessionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationAnalyticsDataPointAvgItemsPerSession
        //private ApplicationAnalyticsDataPointAvgItemsPerSession instance;

        public ApplicationAnalyticsDataPointAvgItemsPerSessionTests()
        {
            // TODO uncomment below to create an instance of ApplicationAnalyticsDataPointAvgItemsPerSession
            //instance = new ApplicationAnalyticsDataPointAvgItemsPerSession();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationAnalyticsDataPointAvgItemsPerSession
        /// </summary>
        [Fact]
        public void ApplicationAnalyticsDataPointAvgItemsPerSessionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationAnalyticsDataPointAvgItemsPerSession
            //Assert.IsInstanceOfType<ApplicationAnalyticsDataPointAvgItemsPerSession> (instance, "variable 'instance' is a ApplicationAnalyticsDataPointAvgItemsPerSession");
        }


        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'Influenced'
        /// </summary>
        [Fact]
        public void InfluencedTest()
        {
            // TODO unit test for the property 'Influenced'
        }

    }

}
