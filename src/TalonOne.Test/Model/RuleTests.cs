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
    ///  Class for testing Rule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RuleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Rule
        //private Rule instance;

        public RuleTests()
        {
            // TODO uncomment below to create an instance of Rule
            //instance = new Rule();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Rule
        /// </summary>
        [Fact]
        public void RuleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Rule
            //Assert.IsInstanceOfType<Rule> (instance, "variable 'instance' is a Rule");
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
        /// Test the property 'ParentId'
        /// </summary>
        [Fact]
        public void ParentIdTest()
        {
            // TODO unit test for the property 'ParentId'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'Condition'
        /// </summary>
        [Fact]
        public void ConditionTest()
        {
            // TODO unit test for the property 'Condition'
        }
        /// <summary>
        /// Test the property 'Effects'
        /// </summary>
        [Fact]
        public void EffectsTest()
        {
            // TODO unit test for the property 'Effects'
        }

    }

}
