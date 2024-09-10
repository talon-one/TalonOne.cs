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
    ///  Class for testing CouponDeletionJob
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CouponDeletionJobTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CouponDeletionJob
        //private CouponDeletionJob instance;

        public CouponDeletionJobTests()
        {
            // TODO uncomment below to create an instance of CouponDeletionJob
            //instance = new CouponDeletionJob();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CouponDeletionJob
        /// </summary>
        [Fact]
        public void CouponDeletionJobInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CouponDeletionJob
            //Assert.IsInstanceOfType<CouponDeletionJob> (instance, "variable 'instance' is a CouponDeletionJob");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'Filters'
        /// </summary>
        [Fact]
        public void FiltersTest()
        {
            // TODO unit test for the property 'Filters'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'DeletedAmount'
        /// </summary>
        [Fact]
        public void DeletedAmountTest()
        {
            // TODO unit test for the property 'DeletedAmount'
        }
        /// <summary>
        /// Test the property 'FailCount'
        /// </summary>
        [Fact]
        public void FailCountTest()
        {
            // TODO unit test for the property 'FailCount'
        }
        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }
        /// <summary>
        /// Test the property 'Communicated'
        /// </summary>
        [Fact]
        public void CommunicatedTest()
        {
            // TODO unit test for the property 'Communicated'
        }
        /// <summary>
        /// Test the property 'CampaignIDs'
        /// </summary>
        [Fact]
        public void CampaignIDsTest()
        {
            // TODO unit test for the property 'CampaignIDs'
        }

    }

}