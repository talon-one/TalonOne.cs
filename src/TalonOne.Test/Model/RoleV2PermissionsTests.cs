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
    ///  Class for testing RoleV2Permissions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RoleV2PermissionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoleV2Permissions
        //private RoleV2Permissions instance;

        public RoleV2PermissionsTests()
        {
            // TODO uncomment below to create an instance of RoleV2Permissions
            //instance = new RoleV2Permissions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoleV2Permissions
        /// </summary>
        [Fact]
        public void RoleV2PermissionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RoleV2Permissions
            //Assert.IsInstanceOfType<RoleV2Permissions> (instance, "variable 'instance' is a RoleV2Permissions");
        }


        /// <summary>
        /// Test the property 'PermissionSets'
        /// </summary>
        [Fact]
        public void PermissionSetsTest()
        {
            // TODO unit test for the property 'PermissionSets'
        }
        /// <summary>
        /// Test the property 'Roles'
        /// </summary>
        [Fact]
        public void RolesTest()
        {
            // TODO unit test for the property 'Roles'
        }

    }

}
