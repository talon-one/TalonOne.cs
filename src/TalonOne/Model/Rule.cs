/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// Rule
    /// </summary>
    [DataContract]
    public partial class Rule :  IEquatable<Rule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="title">A short description of the rule. (required).</param>
        /// <param name="description">A longer, more detailed description of the rule..</param>
        /// <param name="bindings">An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array..</param>
        /// <param name="condition">A Talang expression that will be evaluated in the context of the given event. (required).</param>
        /// <param name="effects">An array of effectful Talang expressions in arrays that will be evaluated when a rule matches. (required).</param>
        public Rule(string title = default(string), string description = default(string), List<Binding> bindings = default(List<Binding>), List<Object> condition = default(List<Object>), List<Object> effects = default(List<Object>))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for Rule and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "condition" is required (not null)
            if (condition == null)
            {
                throw new InvalidDataException("condition is a required property for Rule and cannot be null");
            }
            else
            {
                this.Condition = condition;
            }
            // to ensure "effects" is required (not null)
            if (effects == null)
            {
                throw new InvalidDataException("effects is a required property for Rule and cannot be null");
            }
            else
            {
                this.Effects = effects;
            }
            this.Description = description;
            this.Bindings = bindings;
        }
        
        /// <summary>
        /// A short description of the rule.
        /// </summary>
        /// <value>A short description of the rule.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// A longer, more detailed description of the rule.
        /// </summary>
        /// <value>A longer, more detailed description of the rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array.
        /// </summary>
        /// <value>An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array.</value>
        [DataMember(Name="bindings", EmitDefaultValue=false)]
        public List<Binding> Bindings { get; set; }

        /// <summary>
        /// A Talang expression that will be evaluated in the context of the given event.
        /// </summary>
        /// <value>A Talang expression that will be evaluated in the context of the given event.</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public List<Object> Condition { get; set; }

        /// <summary>
        /// An array of effectful Talang expressions in arrays that will be evaluated when a rule matches.
        /// </summary>
        /// <value>An array of effectful Talang expressions in arrays that will be evaluated when a rule matches.</value>
        [DataMember(Name="effects", EmitDefaultValue=false)]
        public List<Object> Effects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Bindings: ").Append(Bindings).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
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
            return this.Equals(input as Rule);
        }

        /// <summary>
        /// Returns true if Rule instances are equal
        /// </summary>
        /// <param name="input">Instance of Rule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Bindings == input.Bindings ||
                    this.Bindings != null &&
                    this.Bindings.SequenceEqual(input.Bindings)
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition != null &&
                    this.Condition.SequenceEqual(input.Condition)
                ) && 
                (
                    this.Effects == input.Effects ||
                    this.Effects != null &&
                    this.Effects.SequenceEqual(input.Effects)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Bindings != null)
                    hashCode = hashCode * 59 + this.Bindings.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Effects != null)
                    hashCode = hashCode * 59 + this.Effects.GetHashCode();
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
