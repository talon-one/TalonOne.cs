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
    ///  Class for testing LoyaltyStatistics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LoyaltyStatisticsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LoyaltyStatistics
        //private LoyaltyStatistics instance;

        public LoyaltyStatisticsTests()
        {
            // TODO uncomment below to create an instance of LoyaltyStatistics
            //instance = new LoyaltyStatistics();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoyaltyStatistics
        /// </summary>
        [Fact]
        public void LoyaltyStatisticsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoyaltyStatistics
            //Assert.IsInstanceOfType<LoyaltyStatistics> (instance, "variable 'instance' is a LoyaltyStatistics");
        }


        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'TotalActivePoints'
        /// </summary>
        [Fact]
        public void TotalActivePointsTest()
        {
            // TODO unit test for the property 'TotalActivePoints'
        }
        /// <summary>
        /// Test the property 'TotalPendingPoints'
        /// </summary>
        [Fact]
        public void TotalPendingPointsTest()
        {
            // TODO unit test for the property 'TotalPendingPoints'
        }
        /// <summary>
        /// Test the property 'TotalSpentPoints'
        /// </summary>
        [Fact]
        public void TotalSpentPointsTest()
        {
            // TODO unit test for the property 'TotalSpentPoints'
        }
        /// <summary>
        /// Test the property 'TotalExpiredPoints'
        /// </summary>
        [Fact]
        public void TotalExpiredPointsTest()
        {
            // TODO unit test for the property 'TotalExpiredPoints'
        }
        /// <summary>
        /// Test the property 'TotalMembers'
        /// </summary>
        [Fact]
        public void TotalMembersTest()
        {
            // TODO unit test for the property 'TotalMembers'
        }
        /// <summary>
        /// Test the property 'NewMembers'
        /// </summary>
        [Fact]
        public void NewMembersTest()
        {
            // TODO unit test for the property 'NewMembers'
        }
        /// <summary>
        /// Test the property 'SpentPoints'
        /// </summary>
        [Fact]
        public void SpentPointsTest()
        {
            // TODO unit test for the property 'SpentPoints'
        }
        /// <summary>
        /// Test the property 'EarnedPoints'
        /// </summary>
        [Fact]
        public void EarnedPointsTest()
        {
            // TODO unit test for the property 'EarnedPoints'
        }

    }

}
