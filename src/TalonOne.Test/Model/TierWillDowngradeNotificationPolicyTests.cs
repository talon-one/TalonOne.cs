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
    ///  Class for testing TierWillDowngradeNotificationPolicy
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TierWillDowngradeNotificationPolicyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TierWillDowngradeNotificationPolicy
        //private TierWillDowngradeNotificationPolicy instance;

        public TierWillDowngradeNotificationPolicyTests()
        {
            // TODO uncomment below to create an instance of TierWillDowngradeNotificationPolicy
            //instance = new TierWillDowngradeNotificationPolicy();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TierWillDowngradeNotificationPolicy
        /// </summary>
        [Fact]
        public void TierWillDowngradeNotificationPolicyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TierWillDowngradeNotificationPolicy
            //Assert.IsInstanceOfType<TierWillDowngradeNotificationPolicy> (instance, "variable 'instance' is a TierWillDowngradeNotificationPolicy");
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
        /// Test the property 'BatchingEnabled'
        /// </summary>
        [Fact]
        public void BatchingEnabledTest()
        {
            // TODO unit test for the property 'BatchingEnabled'
        }
        /// <summary>
        /// Test the property 'BatchSize'
        /// </summary>
        [Fact]
        public void BatchSizeTest()
        {
            // TODO unit test for the property 'BatchSize'
        }
        /// <summary>
        /// Test the property 'Triggers'
        /// </summary>
        [Fact]
        public void TriggersTest()
        {
            // TODO unit test for the property 'Triggers'
        }

    }

}
