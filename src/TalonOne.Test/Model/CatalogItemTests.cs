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
    ///  Class for testing CatalogItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CatalogItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CatalogItem
        //private CatalogItem instance;

        public CatalogItemTests()
        {
            // TODO uncomment below to create an instance of CatalogItem
            //instance = new CatalogItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CatalogItem
        /// </summary>
        [Fact]
        public void CatalogItemInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CatalogItem
            //Assert.IsInstanceOfType<CatalogItem> (instance, "variable 'instance' is a CatalogItem");
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
        /// Test the property 'Sku'
        /// </summary>
        [Fact]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Fact]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Catalogid'
        /// </summary>
        [Fact]
        public void CatalogidTest()
        {
            // TODO unit test for the property 'Catalogid'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Fact]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
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
        /// Test the property 'Product'
        /// </summary>
        [Fact]
        public void ProductTest()
        {
            // TODO unit test for the property 'Product'
        }

    }

}
