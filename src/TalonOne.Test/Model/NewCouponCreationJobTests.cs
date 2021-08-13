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
    ///  Class for testing NewCouponCreationJob
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCouponCreationJobTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewCouponCreationJob
        //private NewCouponCreationJob instance;

        public NewCouponCreationJobTests()
        {
            // TODO uncomment below to create an instance of NewCouponCreationJob
            //instance = new NewCouponCreationJob();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewCouponCreationJob
        /// </summary>
        [Fact]
        public void NewCouponCreationJobInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewCouponCreationJob
            //Assert.IsInstanceOfType<NewCouponCreationJob> (instance, "variable 'instance' is a NewCouponCreationJob");
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
        /// Test the property 'NumberOfCoupons'
        /// </summary>
        [Fact]
        public void NumberOfCouponsTest()
        {
            // TODO unit test for the property 'NumberOfCoupons'
        }
        /// <summary>
        /// Test the property 'CouponSettings'
        /// </summary>
        [Fact]
        public void CouponSettingsTest()
        {
            // TODO unit test for the property 'CouponSettings'
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
