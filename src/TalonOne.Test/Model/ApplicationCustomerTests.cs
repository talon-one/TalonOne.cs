/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    ///  Class for testing ApplicationCustomer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationCustomerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationCustomer
        //private ApplicationCustomer instance;

        public ApplicationCustomerTests()
        {
            // TODO uncomment below to create an instance of ApplicationCustomer
            //instance = new ApplicationCustomer();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationCustomer
        /// </summary>
        [Fact]
        public void ApplicationCustomerInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationCustomer
            //Assert.IsInstanceOfType<ApplicationCustomer> (instance, "variable 'instance' is a ApplicationCustomer");
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
        /// Test the property 'IntegrationId'
        /// </summary>
        [Fact]
        public void IntegrationIdTest()
        {
            // TODO unit test for the property 'IntegrationId'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Fact]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
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
        /// Test the property 'ClosedSessions'
        /// </summary>
        [Fact]
        public void ClosedSessionsTest()
        {
            // TODO unit test for the property 'ClosedSessions'
        }
        /// <summary>
        /// Test the property 'TotalSales'
        /// </summary>
        [Fact]
        public void TotalSalesTest()
        {
            // TODO unit test for the property 'TotalSales'
        }
        /// <summary>
        /// Test the property 'LoyaltyMemberships'
        /// </summary>
        [Fact]
        public void LoyaltyMembershipsTest()
        {
            // TODO unit test for the property 'LoyaltyMemberships'
        }
        /// <summary>
        /// Test the property 'AudienceMemberships'
        /// </summary>
        [Fact]
        public void AudienceMembershipsTest()
        {
            // TODO unit test for the property 'AudienceMemberships'
        }
        /// <summary>
        /// Test the property 'LastActivity'
        /// </summary>
        [Fact]
        public void LastActivityTest()
        {
            // TODO unit test for the property 'LastActivity'
        }
        /// <summary>
        /// Test the property 'AdvocateIntegrationId'
        /// </summary>
        [Fact]
        public void AdvocateIntegrationIdTest()
        {
            // TODO unit test for the property 'AdvocateIntegrationId'
        }

    }

}
