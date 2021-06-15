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
    ///  Class for testing NewRuleset
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewRulesetTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewRuleset
        //private NewRuleset instance;

        public NewRulesetTests()
        {
            // TODO uncomment below to create an instance of NewRuleset
            //instance = new NewRuleset();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewRuleset
        /// </summary>
        [Fact]
        public void NewRulesetInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewRuleset
            //Assert.IsInstanceOfType<NewRuleset> (instance, "variable 'instance' is a NewRuleset");
        }


        /// <summary>
        /// Test the property 'Rules'
        /// </summary>
        [Fact]
        public void RulesTest()
        {
            // TODO unit test for the property 'Rules'
        }
        /// <summary>
        /// Test the property 'Bindings'
        /// </summary>
        [Fact]
        public void BindingsTest()
        {
            // TODO unit test for the property 'Bindings'
        }
        /// <summary>
        /// Test the property 'RbVersion'
        /// </summary>
        [Fact]
        public void RbVersionTest()
        {
            // TODO unit test for the property 'RbVersion'
        }
        /// <summary>
        /// Test the property 'Activate'
        /// </summary>
        [Fact]
        public void ActivateTest()
        {
            // TODO unit test for the property 'Activate'
        }

    }

}
