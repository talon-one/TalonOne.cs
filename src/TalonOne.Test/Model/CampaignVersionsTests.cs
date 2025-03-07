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
    ///  Class for testing CampaignVersions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CampaignVersionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CampaignVersions
        //private CampaignVersions instance;

        public CampaignVersionsTests()
        {
            // TODO uncomment below to create an instance of CampaignVersions
            //instance = new CampaignVersions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignVersions
        /// </summary>
        [Fact]
        public void CampaignVersionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CampaignVersions
            //Assert.IsInstanceOfType<CampaignVersions> (instance, "variable 'instance' is a CampaignVersions");
        }


        /// <summary>
        /// Test the property 'RevisionFrontendState'
        /// </summary>
        [Fact]
        public void RevisionFrontendStateTest()
        {
            // TODO unit test for the property 'RevisionFrontendState'
        }
        /// <summary>
        /// Test the property 'ActiveRevisionId'
        /// </summary>
        [Fact]
        public void ActiveRevisionIdTest()
        {
            // TODO unit test for the property 'ActiveRevisionId'
        }
        /// <summary>
        /// Test the property 'ActiveRevisionVersionId'
        /// </summary>
        [Fact]
        public void ActiveRevisionVersionIdTest()
        {
            // TODO unit test for the property 'ActiveRevisionVersionId'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Fact]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'CurrentRevisionId'
        /// </summary>
        [Fact]
        public void CurrentRevisionIdTest()
        {
            // TODO unit test for the property 'CurrentRevisionId'
        }
        /// <summary>
        /// Test the property 'CurrentRevisionVersionId'
        /// </summary>
        [Fact]
        public void CurrentRevisionVersionIdTest()
        {
            // TODO unit test for the property 'CurrentRevisionVersionId'
        }
        /// <summary>
        /// Test the property 'StageRevision'
        /// </summary>
        [Fact]
        public void StageRevisionTest()
        {
            // TODO unit test for the property 'StageRevision'
        }

    }

}
