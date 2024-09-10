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
    ///  Class for testing Effect
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EffectTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Effect
        //private Effect instance;

        public EffectTests()
        {
            // TODO uncomment below to create an instance of Effect
            //instance = new Effect();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Effect
        /// </summary>
        [Fact]
        public void EffectInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Effect
            //Assert.IsInstanceOfType<Effect> (instance, "variable 'instance' is a Effect");
        }


        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'RulesetId'
        /// </summary>
        [Fact]
        public void RulesetIdTest()
        {
            // TODO unit test for the property 'RulesetId'
        }
        /// <summary>
        /// Test the property 'RuleIndex'
        /// </summary>
        [Fact]
        public void RuleIndexTest()
        {
            // TODO unit test for the property 'RuleIndex'
        }
        /// <summary>
        /// Test the property 'RuleName'
        /// </summary>
        [Fact]
        public void RuleNameTest()
        {
            // TODO unit test for the property 'RuleName'
        }
        /// <summary>
        /// Test the property 'EffectType'
        /// </summary>
        [Fact]
        public void EffectTypeTest()
        {
            // TODO unit test for the property 'EffectType'
        }
        /// <summary>
        /// Test the property 'TriggeredByCoupon'
        /// </summary>
        [Fact]
        public void TriggeredByCouponTest()
        {
            // TODO unit test for the property 'TriggeredByCoupon'
        }
        /// <summary>
        /// Test the property 'TriggeredForCatalogItem'
        /// </summary>
        [Fact]
        public void TriggeredForCatalogItemTest()
        {
            // TODO unit test for the property 'TriggeredForCatalogItem'
        }
        /// <summary>
        /// Test the property 'ConditionIndex'
        /// </summary>
        [Fact]
        public void ConditionIndexTest()
        {
            // TODO unit test for the property 'ConditionIndex'
        }
        /// <summary>
        /// Test the property 'EvaluationGroupID'
        /// </summary>
        [Fact]
        public void EvaluationGroupIDTest()
        {
            // TODO unit test for the property 'EvaluationGroupID'
        }
        /// <summary>
        /// Test the property 'EvaluationGroupMode'
        /// </summary>
        [Fact]
        public void EvaluationGroupModeTest()
        {
            // TODO unit test for the property 'EvaluationGroupMode'
        }
        /// <summary>
        /// Test the property 'Props'
        /// </summary>
        [Fact]
        public void PropsTest()
        {
            // TODO unit test for the property 'Props'
        }

    }

}
