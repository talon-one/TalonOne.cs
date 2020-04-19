/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

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
    ///  Class for testing ShowNotificationEffectProps
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowNotificationEffectPropsTests
    {
        // TODO uncomment below to declare an instance variable for ShowNotificationEffectProps
        //private ShowNotificationEffectProps instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShowNotificationEffectProps
            //instance = new ShowNotificationEffectProps();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShowNotificationEffectProps
        /// </summary>
        [Test]
        public void ShowNotificationEffectPropsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ShowNotificationEffectProps
            //Assert.IsInstanceOf(typeof(ShowNotificationEffectProps), instance);
        }


        /// <summary>
        /// Test the property 'NotificationType'
        /// </summary>
        [Test]
        public void NotificationTypeTest()
        {
            // TODO unit test for the property 'NotificationType'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }

    }

}