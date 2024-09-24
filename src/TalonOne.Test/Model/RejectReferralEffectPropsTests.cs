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
    ///  Class for testing RejectReferralEffectProps
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RejectReferralEffectPropsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RejectReferralEffectProps
        //private RejectReferralEffectProps instance;

        public RejectReferralEffectPropsTests()
        {
            // TODO uncomment below to create an instance of RejectReferralEffectProps
            //instance = new RejectReferralEffectProps();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RejectReferralEffectProps
        /// </summary>
        [Fact]
        public void RejectReferralEffectPropsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RejectReferralEffectProps
            //Assert.IsInstanceOfType<RejectReferralEffectProps> (instance, "variable 'instance' is a RejectReferralEffectProps");
        }


        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'RejectionReason'
        /// </summary>
        [Fact]
        public void RejectionReasonTest()
        {
            // TODO unit test for the property 'RejectionReason'
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
        /// Test the property 'CampaignExclusionReason'
        /// </summary>
        [Fact]
        public void CampaignExclusionReasonTest()
        {
            // TODO unit test for the property 'CampaignExclusionReason'
        }

    }

}
