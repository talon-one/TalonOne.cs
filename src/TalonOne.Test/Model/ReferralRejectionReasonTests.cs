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
    ///  Class for testing ReferralRejectionReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReferralRejectionReasonTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReferralRejectionReason
        //private ReferralRejectionReason instance;

        public ReferralRejectionReasonTests()
        {
            // TODO uncomment below to create an instance of ReferralRejectionReason
            //instance = new ReferralRejectionReason();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReferralRejectionReason
        /// </summary>
        [Fact]
        public void ReferralRejectionReasonInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReferralRejectionReason
            //Assert.IsInstanceOfType<ReferralRejectionReason> (instance, "variable 'instance' is a ReferralRejectionReason");
        }


        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'ReferralId'
        /// </summary>
        [Fact]
        public void ReferralIdTest()
        {
            // TODO unit test for the property 'ReferralId'
        }
        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Fact]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }

    }

}
