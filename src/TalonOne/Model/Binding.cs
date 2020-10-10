/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    /// Binding
    /// </summary>
    [DataContract]
    public partial class Binding :  IEquatable<Binding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Binding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Binding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Binding" /> class.
        /// </summary>
        /// <param name="name">A descriptive name for the value to be bound. (required).</param>
        /// <param name="expression">A Talang expression that will be evaluated and its result attached to the name of the binding. (required).</param>
        public Binding(string name = default(string), List<Object> expression = default(List<Object>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Binding and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new InvalidDataException("expression is a required property for Binding and cannot be null");
            }
            else
            {
                this.Expression = expression;
            }
            
        }
        
        /// <summary>
        /// A descriptive name for the value to be bound.
        /// </summary>
        /// <value>A descriptive name for the value to be bound.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// A Talang expression that will be evaluated and its result attached to the name of the binding.
        /// </summary>
        /// <value>A Talang expression that will be evaluated and its result attached to the name of the binding.</value>
        [DataMember(Name="expression", EmitDefaultValue=true)]
        public List<Object> Expression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Binding {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
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
            return this.Equals(input as Binding);
        }

        /// <summary>
        /// Returns true if Binding instances are equal
        /// </summary>
        /// <param name="input">Instance of Binding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Binding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Expression == input.Expression ||
                    this.Expression != null &&
                    input.Expression != null &&
                    this.Expression.SequenceEqual(input.Expression)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
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
