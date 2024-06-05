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
    ///  Class for testing CreateTemplateCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateTemplateCampaignTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateTemplateCampaign
        //private CreateTemplateCampaign instance;

        public CreateTemplateCampaignTests()
        {
            // TODO uncomment below to create an instance of CreateTemplateCampaign
            //instance = new CreateTemplateCampaign();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateTemplateCampaign
        /// </summary>
        [Fact]
        public void CreateTemplateCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateTemplateCampaign
            //Assert.IsInstanceOfType<CreateTemplateCampaign> (instance, "variable 'instance' is a CreateTemplateCampaign");
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'CampaignAttributesOverrides'
        /// </summary>
        [Fact]
        public void CampaignAttributesOverridesTest()
        {
            // TODO unit test for the property 'CampaignAttributesOverrides'
        }
        /// <summary>
        /// Test the property 'TemplateParamValues'
        /// </summary>
        [Fact]
        public void TemplateParamValuesTest()
        {
            // TODO unit test for the property 'TemplateParamValues'
        }
        /// <summary>
        /// Test the property 'LimitOverrides'
        /// </summary>
        [Fact]
        public void LimitOverridesTest()
        {
            // TODO unit test for the property 'LimitOverrides'
        }
        /// <summary>
        /// Test the property 'CampaignGroups'
        /// </summary>
        [Fact]
        public void CampaignGroupsTest()
        {
            // TODO unit test for the property 'CampaignGroups'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'EvaluationGroupId'
        /// </summary>
        [Fact]
        public void EvaluationGroupIdTest()
        {
            // TODO unit test for the property 'EvaluationGroupId'
        }
        /// <summary>
        /// Test the property 'LinkedStoreIds'
        /// </summary>
        [Fact]
        public void LinkedStoreIdsTest()
        {
            // TODO unit test for the property 'LinkedStoreIds'
        }

    }

}
