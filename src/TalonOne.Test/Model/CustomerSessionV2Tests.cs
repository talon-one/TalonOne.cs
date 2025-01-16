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
    ///  Class for testing CustomerSessionV2
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomerSessionV2Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomerSessionV2
        //private CustomerSessionV2 instance;

        public CustomerSessionV2Tests()
        {
            // TODO uncomment below to create an instance of CustomerSessionV2
            //instance = new CustomerSessionV2();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerSessionV2
        /// </summary>
        [Fact]
        public void CustomerSessionV2InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CustomerSessionV2
            //Assert.IsInstanceOfType<CustomerSessionV2> (instance, "variable 'instance' is a CustomerSessionV2");
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
        /// Test the property 'IntegrationId'
        /// </summary>
        [Fact]
        public void IntegrationIdTest()
        {
            // TODO unit test for the property 'IntegrationId'
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
        /// Test the property 'StoreIntegrationId'
        /// </summary>
        [Fact]
        public void StoreIntegrationIdTest()
        {
            // TODO unit test for the property 'StoreIntegrationId'
        }
        /// <summary>
        /// Test the property 'EvaluableCampaignIds'
        /// </summary>
        [Fact]
        public void EvaluableCampaignIdsTest()
        {
            // TODO unit test for the property 'EvaluableCampaignIds'
        }
        /// <summary>
        /// Test the property 'CouponCodes'
        /// </summary>
        [Fact]
        public void CouponCodesTest()
        {
            // TODO unit test for the property 'CouponCodes'
        }
        /// <summary>
        /// Test the property 'ReferralCode'
        /// </summary>
        [Fact]
        public void ReferralCodeTest()
        {
            // TODO unit test for the property 'ReferralCode'
        }
        /// <summary>
        /// Test the property 'LoyaltyCards'
        /// </summary>
        [Fact]
        public void LoyaltyCardsTest()
        {
            // TODO unit test for the property 'LoyaltyCards'
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
        /// Test the property 'AdditionalCosts'
        /// </summary>
        [Fact]
        public void AdditionalCostsTest()
        {
            // TODO unit test for the property 'AdditionalCosts'
        }
        /// <summary>
        /// Test the property 'Identifiers'
        /// </summary>
        [Fact]
        public void IdentifiersTest()
        {
            // TODO unit test for the property 'Identifiers'
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
        /// Test the property 'FirstSession'
        /// </summary>
        [Fact]
        public void FirstSessionTest()
        {
            // TODO unit test for the property 'FirstSession'
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
        /// Test the property 'CartItemTotal'
        /// </summary>
        [Fact]
        public void CartItemTotalTest()
        {
            // TODO unit test for the property 'CartItemTotal'
        }
        /// <summary>
        /// Test the property 'AdditionalCostTotal'
        /// </summary>
        [Fact]
        public void AdditionalCostTotalTest()
        {
            // TODO unit test for the property 'AdditionalCostTotal'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Fact]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }
        /// <summary>
        /// Test the property 'ClosurePrediction'
        /// </summary>
        [Fact]
        public void ClosurePredictionTest()
        {
            // TODO unit test for the property 'ClosurePrediction'
        }

    }

}
