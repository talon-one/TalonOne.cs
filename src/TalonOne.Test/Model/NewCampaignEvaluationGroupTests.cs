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
    ///  Class for testing NewCampaignEvaluationGroup
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCampaignEvaluationGroupTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewCampaignEvaluationGroup
        //private NewCampaignEvaluationGroup instance;

        public NewCampaignEvaluationGroupTests()
        {
            // TODO uncomment below to create an instance of NewCampaignEvaluationGroup
            //instance = new NewCampaignEvaluationGroup();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewCampaignEvaluationGroup
        /// </summary>
        [Fact]
        public void NewCampaignEvaluationGroupInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewCampaignEvaluationGroup
            //Assert.IsInstanceOfType<NewCampaignEvaluationGroup> (instance, "variable 'instance' is a NewCampaignEvaluationGroup");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'EvaluationMode'
        /// </summary>
        [Fact]
        public void EvaluationModeTest()
        {
            // TODO unit test for the property 'EvaluationMode'
        }
        /// <summary>
        /// Test the property 'EvaluationScope'
        /// </summary>
        [Fact]
        public void EvaluationScopeTest()
        {
            // TODO unit test for the property 'EvaluationScope'
        }
        /// <summary>
        /// Test the property 'Locked'
        /// </summary>
        [Fact]
        public void LockedTest()
        {
            // TODO unit test for the property 'Locked'
        }

    }

}