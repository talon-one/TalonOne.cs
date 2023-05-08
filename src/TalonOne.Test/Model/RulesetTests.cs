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
    ///  Class for testing Ruleset
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RulesetTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Ruleset
        //private Ruleset instance;

        public RulesetTests()
        {
            // TODO uncomment below to create an instance of Ruleset
            //instance = new Ruleset();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Ruleset
        /// </summary>
        [Fact]
        public void RulesetInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Ruleset
            //Assert.IsInstanceOfType<Ruleset> (instance, "variable 'instance' is a Ruleset");
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
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'Rules'
        /// </summary>
        [Fact]
        public void RulesTest()
        {
            // TODO unit test for the property 'Rules'
        }
        /// <summary>
        /// Test the property 'StrikethroughRules'
        /// </summary>
        [Fact]
        public void StrikethroughRulesTest()
        {
            // TODO unit test for the property 'StrikethroughRules'
        }
        /// <summary>
        /// Test the property 'Bindings'
        /// </summary>
        [Fact]
        public void BindingsTest()
        {
            // TODO unit test for the property 'Bindings'
        }
        /// <summary>
        /// Test the property 'RbVersion'
        /// </summary>
        [Fact]
        public void RbVersionTest()
        {
            // TODO unit test for the property 'RbVersion'
        }
        /// <summary>
        /// Test the property 'Activate'
        /// </summary>
        [Fact]
        public void ActivateTest()
        {
            // TODO unit test for the property 'Activate'
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
        /// Test the property 'TemplateId'
        /// </summary>
        [Fact]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }
        /// <summary>
        /// Test the property 'ActivatedAt'
        /// </summary>
        [Fact]
        public void ActivatedAtTest()
        {
            // TODO unit test for the property 'ActivatedAt'
        }

    }

}
