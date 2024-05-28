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
    ///  Class for testing CustomerInventory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomerInventoryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomerInventory
        //private CustomerInventory instance;

        public CustomerInventoryTests()
        {
            // TODO uncomment below to create an instance of CustomerInventory
            //instance = new CustomerInventory();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerInventory
        /// </summary>
        [Fact]
        public void CustomerInventoryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CustomerInventory
            //Assert.IsInstanceOfType<CustomerInventory> (instance, "variable 'instance' is a CustomerInventory");
        }


        /// <summary>
        /// Test the property 'Profile'
        /// </summary>
        [Fact]
        public void ProfileTest()
        {
            // TODO unit test for the property 'Profile'
        }
        /// <summary>
        /// Test the property 'Loyalty'
        /// </summary>
        [Fact]
        public void LoyaltyTest()
        {
            // TODO unit test for the property 'Loyalty'
        }
        /// <summary>
        /// Test the property 'Referrals'
        /// </summary>
        [Fact]
        public void ReferralsTest()
        {
            // TODO unit test for the property 'Referrals'
        }
        /// <summary>
        /// Test the property 'Coupons'
        /// </summary>
        [Fact]
        public void CouponsTest()
        {
            // TODO unit test for the property 'Coupons'
        }
        /// <summary>
        /// Test the property 'Giveaways'
        /// </summary>
        [Fact]
        public void GiveawaysTest()
        {
            // TODO unit test for the property 'Giveaways'
        }
        /// <summary>
        /// Test the property 'Achievements'
        /// </summary>
        [Fact]
        public void AchievementsTest()
        {
            // TODO unit test for the property 'Achievements'
        }

    }

}
