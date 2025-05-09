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
    ///  Class for testing LoyaltyCard
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LoyaltyCardTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LoyaltyCard
        //private LoyaltyCard instance;

        public LoyaltyCardTests()
        {
            // TODO uncomment below to create an instance of LoyaltyCard
            //instance = new LoyaltyCard();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoyaltyCard
        /// </summary>
        [Fact]
        public void LoyaltyCardInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoyaltyCard
            //Assert.IsInstanceOfType<LoyaltyCard> (instance, "variable 'instance' is a LoyaltyCard");
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
        /// Test the property 'ProgramID'
        /// </summary>
        [Fact]
        public void ProgramIDTest()
        {
            // TODO unit test for the property 'ProgramID'
        }
        /// <summary>
        /// Test the property 'ProgramName'
        /// </summary>
        [Fact]
        public void ProgramNameTest()
        {
            // TODO unit test for the property 'ProgramName'
        }
        /// <summary>
        /// Test the property 'ProgramTitle'
        /// </summary>
        [Fact]
        public void ProgramTitleTest()
        {
            // TODO unit test for the property 'ProgramTitle'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'BlockReason'
        /// </summary>
        [Fact]
        public void BlockReasonTest()
        {
            // TODO unit test for the property 'BlockReason'
        }
        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Fact]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }
        /// <summary>
        /// Test the property 'UsersPerCardLimit'
        /// </summary>
        [Fact]
        public void UsersPerCardLimitTest()
        {
            // TODO unit test for the property 'UsersPerCardLimit'
        }
        /// <summary>
        /// Test the property 'Profiles'
        /// </summary>
        [Fact]
        public void ProfilesTest()
        {
            // TODO unit test for the property 'Profiles'
        }
        /// <summary>
        /// Test the property 'Ledger'
        /// </summary>
        [Fact]
        public void LedgerTest()
        {
            // TODO unit test for the property 'Ledger'
        }
        /// <summary>
        /// Test the property 'Subledgers'
        /// </summary>
        [Fact]
        public void SubledgersTest()
        {
            // TODO unit test for the property 'Subledgers'
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
        /// Test the property 'OldCardIdentifier'
        /// </summary>
        [Fact]
        public void OldCardIdentifierTest()
        {
            // TODO unit test for the property 'OldCardIdentifier'
        }
        /// <summary>
        /// Test the property 'NewCardIdentifier'
        /// </summary>
        [Fact]
        public void NewCardIdentifierTest()
        {
            // TODO unit test for the property 'NewCardIdentifier'
        }
        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Fact]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
        }

    }

}
