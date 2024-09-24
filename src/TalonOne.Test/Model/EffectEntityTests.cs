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
    ///  Class for testing EffectEntity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EffectEntityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EffectEntity
        //private EffectEntity instance;

        public EffectEntityTests()
        {
            // TODO uncomment below to create an instance of EffectEntity
            //instance = new EffectEntity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EffectEntity
        /// </summary>
        [Fact]
        public void EffectEntityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EffectEntity
            //Assert.IsInstanceOfType<EffectEntity> (instance, "variable 'instance' is a EffectEntity");
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
        /// Test the property 'CampaignRevisionId'
        /// </summary>
        [Fact]
        public void CampaignRevisionIdTest()
        {
            // TODO unit test for the property 'CampaignRevisionId'
        }
        /// <summary>
        /// Test the property 'CampaignRevisionVersionId'
        /// </summary>
        [Fact]
        public void CampaignRevisionVersionIdTest()
        {
            // TODO unit test for the property 'CampaignRevisionVersionId'
        }

    }

}
