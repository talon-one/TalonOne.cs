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
    ///  Class for testing CreateTemplateCampaignResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateTemplateCampaignResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateTemplateCampaignResponse
        //private CreateTemplateCampaignResponse instance;

        public CreateTemplateCampaignResponseTests()
        {
            // TODO uncomment below to create an instance of CreateTemplateCampaignResponse
            //instance = new CreateTemplateCampaignResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateTemplateCampaignResponse
        /// </summary>
        [Fact]
        public void CreateTemplateCampaignResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateTemplateCampaignResponse
            //Assert.IsInstanceOfType<CreateTemplateCampaignResponse> (instance, "variable 'instance' is a CreateTemplateCampaignResponse");
        }


        /// <summary>
        /// Test the property 'Campaign'
        /// </summary>
        [Fact]
        public void CampaignTest()
        {
            // TODO unit test for the property 'Campaign'
        }
        /// <summary>
        /// Test the property 'Ruleset'
        /// </summary>
        [Fact]
        public void RulesetTest()
        {
            // TODO unit test for the property 'Ruleset'
        }
        /// <summary>
        /// Test the property 'Collections'
        /// </summary>
        [Fact]
        public void CollectionsTest()
        {
            // TODO unit test for the property 'Collections'
        }

    }

}
