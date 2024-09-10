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
    ///  Class for testing User
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for User
        //private User instance;

        public UserTests()
        {
            // TODO uncomment below to create an instance of User
            //instance = new User();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of User
        /// </summary>
        [Fact]
        public void UserInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" User
            //Assert.IsInstanceOfType<User> (instance, "variable 'instance' is a User");
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
        /// Test the property 'Modified'
        /// </summary>
        [Fact]
        public void ModifiedTest()
        {
            // TODO unit test for the property 'Modified'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
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
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'InviteToken'
        /// </summary>
        [Fact]
        public void InviteTokenTest()
        {
            // TODO unit test for the property 'InviteToken'
        }
        /// <summary>
        /// Test the property 'IsAdmin'
        /// </summary>
        [Fact]
        public void IsAdminTest()
        {
            // TODO unit test for the property 'IsAdmin'
        }
        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }
        /// <summary>
        /// Test the property 'Roles'
        /// </summary>
        [Fact]
        public void RolesTest()
        {
            // TODO unit test for the property 'Roles'
        }
        /// <summary>
        /// Test the property 'AuthMethod'
        /// </summary>
        [Fact]
        public void AuthMethodTest()
        {
            // TODO unit test for the property 'AuthMethod'
        }
        /// <summary>
        /// Test the property 'ApplicationNotificationSubscriptions'
        /// </summary>
        [Fact]
        public void ApplicationNotificationSubscriptionsTest()
        {
            // TODO unit test for the property 'ApplicationNotificationSubscriptions'
        }
        /// <summary>
        /// Test the property 'LastSignedIn'
        /// </summary>
        [Fact]
        public void LastSignedInTest()
        {
            // TODO unit test for the property 'LastSignedIn'
        }
        /// <summary>
        /// Test the property 'LastAccessed'
        /// </summary>
        [Fact]
        public void LastAccessedTest()
        {
            // TODO unit test for the property 'LastAccessed'
        }
        /// <summary>
        /// Test the property 'LatestFeedTimestamp'
        /// </summary>
        [Fact]
        public void LatestFeedTimestampTest()
        {
            // TODO unit test for the property 'LatestFeedTimestamp'
        }
        /// <summary>
        /// Test the property 'AdditionalAttributes'
        /// </summary>
        [Fact]
        public void AdditionalAttributesTest()
        {
            // TODO unit test for the property 'AdditionalAttributes'
        }

    }

}
