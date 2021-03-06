/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    ///  Class for testing CustomerActivityReport
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomerActivityReportTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomerActivityReport
        //private CustomerActivityReport instance;

        public CustomerActivityReportTests()
        {
            // TODO uncomment below to create an instance of CustomerActivityReport
            //instance = new CustomerActivityReport();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerActivityReport
        /// </summary>
        [Fact]
        public void CustomerActivityReportInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CustomerActivityReport
            //Assert.IsInstanceOfType<CustomerActivityReport> (instance, "variable 'instance' is a CustomerActivityReport");
        }


        /// <summary>
        /// Test the property 'IntegrationId'
        /// </summary>
        [Fact]
        public void IntegrationIdTest()
        {
            // TODO unit test for the property 'IntegrationId'
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'CustomerId'
        /// </summary>
        [Fact]
        public void CustomerIdTest()
        {
            // TODO unit test for the property 'CustomerId'
        }
        /// <summary>
        /// Test the property 'LastActivity'
        /// </summary>
        [Fact]
        public void LastActivityTest()
        {
            // TODO unit test for the property 'LastActivity'
        }
        /// <summary>
        /// Test the property 'CouponRedemptions'
        /// </summary>
        [Fact]
        public void CouponRedemptionsTest()
        {
            // TODO unit test for the property 'CouponRedemptions'
        }
        /// <summary>
        /// Test the property 'CouponUseAttempts'
        /// </summary>
        [Fact]
        public void CouponUseAttemptsTest()
        {
            // TODO unit test for the property 'CouponUseAttempts'
        }
        /// <summary>
        /// Test the property 'CouponFailedAttempts'
        /// </summary>
        [Fact]
        public void CouponFailedAttemptsTest()
        {
            // TODO unit test for the property 'CouponFailedAttempts'
        }
        /// <summary>
        /// Test the property 'AccruedDiscounts'
        /// </summary>
        [Fact]
        public void AccruedDiscountsTest()
        {
            // TODO unit test for the property 'AccruedDiscounts'
        }
        /// <summary>
        /// Test the property 'AccruedRevenue'
        /// </summary>
        [Fact]
        public void AccruedRevenueTest()
        {
            // TODO unit test for the property 'AccruedRevenue'
        }
        /// <summary>
        /// Test the property 'TotalOrders'
        /// </summary>
        [Fact]
        public void TotalOrdersTest()
        {
            // TODO unit test for the property 'TotalOrders'
        }
        /// <summary>
        /// Test the property 'TotalOrdersNoCoupon'
        /// </summary>
        [Fact]
        public void TotalOrdersNoCouponTest()
        {
            // TODO unit test for the property 'TotalOrdersNoCoupon'
        }
        /// <summary>
        /// Test the property 'CampaignName'
        /// </summary>
        [Fact]
        public void CampaignNameTest()
        {
            // TODO unit test for the property 'CampaignName'
        }

    }

}
