/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    ///  Class for testing TemplateDef
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TemplateDefTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TemplateDef
        //private TemplateDef instance;

        public TemplateDefTests()
        {
            // TODO uncomment below to create an instance of TemplateDef
            //instance = new TemplateDef();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TemplateDef
        /// </summary>
        [Fact]
        public void TemplateDefInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TemplateDef
            //Assert.IsInstanceOfType<TemplateDef> (instance, "variable 'instance' is a TemplateDef");
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
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Help'
        /// </summary>
        [Fact]
        public void HelpTest()
        {
            // TODO unit test for the property 'Help'
        }
        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
        }
        /// <summary>
        /// Test the property 'Expr'
        /// </summary>
        [Fact]
        public void ExprTest()
        {
            // TODO unit test for the property 'Expr'
        }
        /// <summary>
        /// Test the property 'Args'
        /// </summary>
        [Fact]
        public void ArgsTest()
        {
            // TODO unit test for the property 'Args'
        }
        /// <summary>
        /// Test the property 'Expose'
        /// </summary>
        [Fact]
        public void ExposeTest()
        {
            // TODO unit test for the property 'Expose'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
