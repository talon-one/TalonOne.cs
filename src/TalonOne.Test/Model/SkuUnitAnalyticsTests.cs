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
    ///  Class for testing SkuUnitAnalytics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SkuUnitAnalyticsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SkuUnitAnalytics
        //private SkuUnitAnalytics instance;

        public SkuUnitAnalyticsTests()
        {
            // TODO uncomment below to create an instance of SkuUnitAnalytics
            //instance = new SkuUnitAnalytics();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SkuUnitAnalytics
        /// </summary>
        [Fact]
        public void SkuUnitAnalyticsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SkuUnitAnalytics
            //Assert.IsInstanceOfType<SkuUnitAnalytics> (instance, "variable 'instance' is a SkuUnitAnalytics");
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'Totals'
        /// </summary>
        [Fact]
        public void TotalsTest()
        {
            // TODO unit test for the property 'Totals'
        }

    }

}
