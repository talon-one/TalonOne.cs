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
    ///  Class for testing NewCoupons
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCouponsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewCoupons
        //private NewCoupons instance;

        public NewCouponsTests()
        {
            // TODO uncomment below to create an instance of NewCoupons
            //instance = new NewCoupons();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewCoupons
        /// </summary>
        [Fact]
        public void NewCouponsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewCoupons
            //Assert.IsInstanceOfType<NewCoupons> (instance, "variable 'instance' is a NewCoupons");
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
        /// Test the property 'DiscountLimit'
        /// </summary>
        [Fact]
        public void DiscountLimitTest()
        {
            // TODO unit test for the property 'DiscountLimit'
        }
        /// <summary>
        /// Test the property 'ReservationLimit'
        /// </summary>
        [Fact]
        public void ReservationLimitTest()
        {
            // TODO unit test for the property 'ReservationLimit'
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
        /// Test the property 'Limits'
        /// </summary>
        [Fact]
        public void LimitsTest()
        {
            // TODO unit test for the property 'Limits'
        }
        /// <summary>
        /// Test the property 'NumberOfCoupons'
        /// </summary>
        [Fact]
        public void NumberOfCouponsTest()
        {
            // TODO unit test for the property 'NumberOfCoupons'
        }
        /// <summary>
        /// Test the property 'UniquePrefix'
        /// </summary>
        [Fact]
        public void UniquePrefixTest()
        {
            // TODO unit test for the property 'UniquePrefix'
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
        /// Test the property 'RecipientIntegrationId'
        /// </summary>
        [Fact]
        public void RecipientIntegrationIdTest()
        {
            // TODO unit test for the property 'RecipientIntegrationId'
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
        /// Test the property 'CouponPattern'
        /// </summary>
        [Fact]
        public void CouponPatternTest()
        {
            // TODO unit test for the property 'CouponPattern'
        }
        /// <summary>
        /// Test the property 'IsReservationMandatory'
        /// </summary>
        [Fact]
        public void IsReservationMandatoryTest()
        {
            // TODO unit test for the property 'IsReservationMandatory'
        }
        /// <summary>
        /// Test the property 'ImplicitlyReserved'
        /// </summary>
        [Fact]
        public void ImplicitlyReservedTest()
        {
            // TODO unit test for the property 'ImplicitlyReserved'
        }

    }

}
