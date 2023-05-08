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
    ///  Class for testing CardLedgerTransactionLogEntryIntegrationAPI
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CardLedgerTransactionLogEntryIntegrationAPITests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CardLedgerTransactionLogEntryIntegrationAPI
        //private CardLedgerTransactionLogEntryIntegrationAPI instance;

        public CardLedgerTransactionLogEntryIntegrationAPITests()
        {
            // TODO uncomment below to create an instance of CardLedgerTransactionLogEntryIntegrationAPI
            //instance = new CardLedgerTransactionLogEntryIntegrationAPI();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CardLedgerTransactionLogEntryIntegrationAPI
        /// </summary>
        [Fact]
        public void CardLedgerTransactionLogEntryIntegrationAPIInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CardLedgerTransactionLogEntryIntegrationAPI
            //Assert.IsInstanceOfType<CardLedgerTransactionLogEntryIntegrationAPI> (instance, "variable 'instance' is a CardLedgerTransactionLogEntryIntegrationAPI");
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
        /// Test the property 'ProgramId'
        /// </summary>
        [Fact]
        public void ProgramIdTest()
        {
            // TODO unit test for the property 'ProgramId'
        }
        /// <summary>
        /// Test the property 'CardIdentifier'
        /// </summary>
        [Fact]
        public void CardIdentifierTest()
        {
            // TODO unit test for the property 'CardIdentifier'
        }
        /// <summary>
        /// Test the property 'CustomerSessionId'
        /// </summary>
        [Fact]
        public void CustomerSessionIdTest()
        {
            // TODO unit test for the property 'CustomerSessionId'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
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
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Fact]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }
        /// <summary>
        /// Test the property 'SubledgerId'
        /// </summary>
        [Fact]
        public void SubledgerIdTest()
        {
            // TODO unit test for the property 'SubledgerId'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
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
        /// Test the property 'RulesetId'
        /// </summary>
        [Fact]
        public void RulesetIdTest()
        {
            // TODO unit test for the property 'RulesetId'
        }
        /// <summary>
        /// Test the property 'RuleName'
        /// </summary>
        [Fact]
        public void RuleNameTest()
        {
            // TODO unit test for the property 'RuleName'
        }

    }

}