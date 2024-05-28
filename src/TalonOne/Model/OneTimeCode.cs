/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// OneTimeCode
    /// </summary>
    [DataContract]
    public partial class OneTimeCode :  IEquatable<OneTimeCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OneTimeCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeCode" /> class.
        /// </summary>
        /// <param name="userId">The ID of the user. (required).</param>
        /// <param name="accountId">The ID of the account. (required).</param>
        /// <param name="token">The two-factor authentication token created during sign-in. This token is used to ensure that the correct user is trying to sign in with a given one-time security code. (required).</param>
        /// <param name="code">The one-time security code used for signing in..</param>
        public OneTimeCode(int userId = default(int), int accountId = default(int), string token = default(string), string code = default(string))
        {
            this.UserId = userId;
            this.AccountId = accountId;
            // to ensure "token" is required (not null)
            this.Token = token ?? throw new ArgumentNullException("token is a required property for OneTimeCode and cannot be null");
            this.Code = code;
        }
        
        /// <summary>
        /// The ID of the user.
        /// </summary>
        /// <value>The ID of the user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// The ID of the account.
        /// </summary>
        /// <value>The ID of the account.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// The two-factor authentication token created during sign-in. This token is used to ensure that the correct user is trying to sign in with a given one-time security code.
        /// </summary>
        /// <value>The two-factor authentication token created during sign-in. This token is used to ensure that the correct user is trying to sign in with a given one-time security code.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The one-time security code used for signing in.
        /// </summary>
        /// <value>The one-time security code used for signing in.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OneTimeCode {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OneTimeCode);
        }

        /// <summary>
        /// Returns true if OneTimeCode instances are equal
        /// </summary>
        /// <param name="input">Instance of OneTimeCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneTimeCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
