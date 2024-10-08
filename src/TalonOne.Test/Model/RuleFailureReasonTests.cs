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
    ///  Class for testing RuleFailureReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RuleFailureReasonTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RuleFailureReason
        //private RuleFailureReason instance;

        public RuleFailureReasonTests()
        {
            // TODO uncomment below to create an instance of RuleFailureReason
            //instance = new RuleFailureReason();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RuleFailureReason
        /// </summary>
        [Fact]
        public void RuleFailureReasonInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RuleFailureReason
            //Assert.IsInstanceOfType<RuleFailureReason> (instance, "variable 'instance' is a RuleFailureReason");
        }


        /// <summary>
        /// Test the property 'CampaignID'
        /// </summary>
        [Fact]
        public void CampaignIDTest()
        {
            // TODO unit test for the property 'CampaignID'
        }
        /// <summary>
        /// Test the property 'CampaignName'
        /// </summary>
        [Fact]
        public void CampaignNameTest()
        {
            // TODO unit test for the property 'CampaignName'
        }
        /// <summary>
        /// Test the property 'RulesetID'
        /// </summary>
        [Fact]
        public void RulesetIDTest()
        {
            // TODO unit test for the property 'RulesetID'
        }
        /// <summary>
        /// Test the property 'CouponID'
        /// </summary>
        [Fact]
        public void CouponIDTest()
        {
            // TODO unit test for the property 'CouponID'
        }
        /// <summary>
        /// Test the property 'CouponValue'
        /// </summary>
        [Fact]
        public void CouponValueTest()
        {
            // TODO unit test for the property 'CouponValue'
        }
        /// <summary>
        /// Test the property 'ReferralID'
        /// </summary>
        [Fact]
        public void ReferralIDTest()
        {
            // TODO unit test for the property 'ReferralID'
        }
        /// <summary>
        /// Test the property 'ReferralValue'
        /// </summary>
        [Fact]
        public void ReferralValueTest()
        {
            // TODO unit test for the property 'ReferralValue'
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
        /// Test the property 'ConditionIndex'
        /// </summary>
        [Fact]
        public void ConditionIndexTest()
        {
            // TODO unit test for the property 'ConditionIndex'
        }
        /// <summary>
        /// Test the property 'EffectIndex'
        /// </summary>
        [Fact]
        public void EffectIndexTest()
        {
            // TODO unit test for the property 'EffectIndex'
        }
        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Fact]
        public void DetailsTest()
        {
            // TODO unit test for the property 'Details'
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

    }

}
