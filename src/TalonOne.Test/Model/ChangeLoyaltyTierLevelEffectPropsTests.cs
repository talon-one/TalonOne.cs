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
    ///  Class for testing ChangeLoyaltyTierLevelEffectProps
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ChangeLoyaltyTierLevelEffectPropsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ChangeLoyaltyTierLevelEffectProps
        //private ChangeLoyaltyTierLevelEffectProps instance;

        public ChangeLoyaltyTierLevelEffectPropsTests()
        {
            // TODO uncomment below to create an instance of ChangeLoyaltyTierLevelEffectProps
            //instance = new ChangeLoyaltyTierLevelEffectProps();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChangeLoyaltyTierLevelEffectProps
        /// </summary>
        [Fact]
        public void ChangeLoyaltyTierLevelEffectPropsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ChangeLoyaltyTierLevelEffectProps
            //Assert.IsInstanceOfType<ChangeLoyaltyTierLevelEffectProps> (instance, "variable 'instance' is a ChangeLoyaltyTierLevelEffectProps");
        }


        /// <summary>
        /// Test the property 'RuleTitle'
        /// </summary>
        [Fact]
        public void RuleTitleTest()
        {
            // TODO unit test for the property 'RuleTitle'
        }
        /// <summary>
        /// Test the property 'ProgramId'
        /// </summary>
        [Fact]
        public void ProgramIdTest()
        {
            // TODO unit test for the property 'ProgramId'
        }
        /// <summary>
        /// Test the property 'SubLedgerId'
        /// </summary>
        [Fact]
        public void SubLedgerIdTest()
        {
            // TODO unit test for the property 'SubLedgerId'
        }
        /// <summary>
        /// Test the property 'PreviousTierName'
        /// </summary>
        [Fact]
        public void PreviousTierNameTest()
        {
            // TODO unit test for the property 'PreviousTierName'
        }
        /// <summary>
        /// Test the property 'NewTierName'
        /// </summary>
        [Fact]
        public void NewTierNameTest()
        {
            // TODO unit test for the property 'NewTierName'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Fact]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }

    }

}
