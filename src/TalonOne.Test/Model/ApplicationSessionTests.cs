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
    ///  Class for testing ApplicationSession
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationSessionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationSession
        //private ApplicationSession instance;

        public ApplicationSessionTests()
        {
            // TODO uncomment below to create an instance of ApplicationSession
            //instance = new ApplicationSession();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationSession
        /// </summary>
        [Fact]
        public void ApplicationSessionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationSession
            //Assert.IsInstanceOfType<ApplicationSession> (instance, "variable 'instance' is a ApplicationSession");
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
        /// Test the property 'ProfileId'
        /// </summary>
        [Fact]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
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
        /// Test the property 'Profileintegrationid'
        /// </summary>
        [Fact]
        public void ProfileintegrationidTest()
        {
            // TODO unit test for the property 'Profileintegrationid'
        }
        /// <summary>
        /// Test the property 'Coupon'
        /// </summary>
        [Fact]
        public void CouponTest()
        {
            // TODO unit test for the property 'Coupon'
        }
        /// <summary>
        /// Test the property 'Referral'
        /// </summary>
        [Fact]
        public void ReferralTest()
        {
            // TODO unit test for the property 'Referral'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'CartItems'
        /// </summary>
        [Fact]
        public void CartItemsTest()
        {
            // TODO unit test for the property 'CartItems'
        }
        /// <summary>
        /// Test the property 'Discounts'
        /// </summary>
        [Fact]
        public void DiscountsTest()
        {
            // TODO unit test for the property 'Discounts'
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
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Fact]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }

    }

}
