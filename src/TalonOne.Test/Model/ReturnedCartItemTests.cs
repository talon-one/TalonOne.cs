/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    ///  Class for testing ReturnedCartItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReturnedCartItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReturnedCartItem
        //private ReturnedCartItem instance;

        public ReturnedCartItemTests()
        {
            // TODO uncomment below to create an instance of ReturnedCartItem
            //instance = new ReturnedCartItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReturnedCartItem
        /// </summary>
        [Fact]
        public void ReturnedCartItemInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReturnedCartItem
            //Assert.IsInstanceOfType<ReturnedCartItem> (instance, "variable 'instance' is a ReturnedCartItem");
        }


        /// <summary>
        /// Test the property 'Position'
        /// </summary>
        [Fact]
        public void PositionTest()
        {
            // TODO unit test for the property 'Position'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }

    }

}