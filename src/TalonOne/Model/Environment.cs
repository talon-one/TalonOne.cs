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
    /// Environment
    /// </summary>
    [DataContract]
    public partial class Environment :  IEquatable<Environment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Environment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="slots">The slots defined for this application. (required).</param>
        /// <param name="functions">The functions defined for this application. (required).</param>
        /// <param name="templates">The templates defined for this application. (required).</param>
        /// <param name="giveawaysPools">The giveaways pools that the application is subscribed to..</param>
        /// <param name="loyaltyPrograms">The loyalty programs that the application is subscribed to..</param>
        /// <param name="attributes">The attributes that the application is subscribed to..</param>
        /// <param name="additionalCosts">The additional costs that the application is subscribed to..</param>
        /// <param name="audiences">The audiences contained in the account which the application belongs to..</param>
        /// <param name="variables">variables (required).</param>
        public Environment(int id = default(int), DateTime created = default(DateTime), int applicationId = default(int), List<SlotDef> slots = default(List<SlotDef>), List<FunctionDef> functions = default(List<FunctionDef>), List<TemplateDef> templates = default(List<TemplateDef>), List<GiveawaysPool> giveawaysPools = default(List<GiveawaysPool>), List<LoyaltyProgram> loyaltyPrograms = default(List<LoyaltyProgram>), List<Attribute> attributes = default(List<Attribute>), List<AccountAdditionalCost> additionalCosts = default(List<AccountAdditionalCost>), List<Audience> audiences = default(List<Audience>), string variables = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Environment and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Environment and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for Environment and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            
            // to ensure "slots" is required (not null)
            if (slots == null)
            {
                throw new InvalidDataException("slots is a required property for Environment and cannot be null");
            }
            else
            {
                this.Slots = slots;
            }
            
            // to ensure "functions" is required (not null)
            if (functions == null)
            {
                throw new InvalidDataException("functions is a required property for Environment and cannot be null");
            }
            else
            {
                this.Functions = functions;
            }
            
            // to ensure "templates" is required (not null)
            if (templates == null)
            {
                throw new InvalidDataException("templates is a required property for Environment and cannot be null");
            }
            else
            {
                this.Templates = templates;
            }
            
            // to ensure "variables" is required (not null)
            if (variables == null)
            {
                throw new InvalidDataException("variables is a required property for Environment and cannot be null");
            }
            else
            {
                this.Variables = variables;
            }
            
            this.GiveawaysPools = giveawaysPools;
            this.LoyaltyPrograms = loyaltyPrograms;
            this.Attributes = attributes;
            this.AdditionalCosts = additionalCosts;
            this.Audiences = audiences;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=true)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The slots defined for this application.
        /// </summary>
        /// <value>The slots defined for this application.</value>
        [DataMember(Name="slots", EmitDefaultValue=true)]
        public List<SlotDef> Slots { get; set; }

        /// <summary>
        /// The functions defined for this application.
        /// </summary>
        /// <value>The functions defined for this application.</value>
        [DataMember(Name="functions", EmitDefaultValue=true)]
        public List<FunctionDef> Functions { get; set; }

        /// <summary>
        /// The templates defined for this application.
        /// </summary>
        /// <value>The templates defined for this application.</value>
        [DataMember(Name="templates", EmitDefaultValue=true)]
        public List<TemplateDef> Templates { get; set; }

        /// <summary>
        /// The giveaways pools that the application is subscribed to.
        /// </summary>
        /// <value>The giveaways pools that the application is subscribed to.</value>
        [DataMember(Name="giveawaysPools", EmitDefaultValue=false)]
        public List<GiveawaysPool> GiveawaysPools { get; set; }

        /// <summary>
        /// The loyalty programs that the application is subscribed to.
        /// </summary>
        /// <value>The loyalty programs that the application is subscribed to.</value>
        [DataMember(Name="loyaltyPrograms", EmitDefaultValue=false)]
        public List<LoyaltyProgram> LoyaltyPrograms { get; set; }

        /// <summary>
        /// The attributes that the application is subscribed to.
        /// </summary>
        /// <value>The attributes that the application is subscribed to.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// The additional costs that the application is subscribed to.
        /// </summary>
        /// <value>The additional costs that the application is subscribed to.</value>
        [DataMember(Name="additionalCosts", EmitDefaultValue=false)]
        public List<AccountAdditionalCost> AdditionalCosts { get; set; }

        /// <summary>
        /// The audiences contained in the account which the application belongs to.
        /// </summary>
        /// <value>The audiences contained in the account which the application belongs to.</value>
        [DataMember(Name="audiences", EmitDefaultValue=false)]
        public List<Audience> Audiences { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=true)]
        public string Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Environment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  GiveawaysPools: ").Append(GiveawaysPools).Append("\n");
            sb.Append("  LoyaltyPrograms: ").Append(LoyaltyPrograms).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AdditionalCosts: ").Append(AdditionalCosts).Append("\n");
            sb.Append("  Audiences: ").Append(Audiences).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as Environment);
        }

        /// <summary>
        /// Returns true if Environment instances are equal
        /// </summary>
        /// <param name="input">Instance of Environment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Environment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Slots == input.Slots ||
                    this.Slots != null &&
                    input.Slots != null &&
                    this.Slots.SequenceEqual(input.Slots)
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
                ) && 
                (
                    this.GiveawaysPools == input.GiveawaysPools ||
                    this.GiveawaysPools != null &&
                    input.GiveawaysPools != null &&
                    this.GiveawaysPools.SequenceEqual(input.GiveawaysPools)
                ) && 
                (
                    this.LoyaltyPrograms == input.LoyaltyPrograms ||
                    this.LoyaltyPrograms != null &&
                    input.LoyaltyPrograms != null &&
                    this.LoyaltyPrograms.SequenceEqual(input.LoyaltyPrograms)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.AdditionalCosts == input.AdditionalCosts ||
                    this.AdditionalCosts != null &&
                    input.AdditionalCosts != null &&
                    this.AdditionalCosts.SequenceEqual(input.AdditionalCosts)
                ) && 
                (
                    this.Audiences == input.Audiences ||
                    this.Audiences != null &&
                    input.Audiences != null &&
                    this.Audiences.SequenceEqual(input.Audiences)
                ) && 
                (
                    this.Variables == input.Variables ||
                    (this.Variables != null &&
                    this.Variables.Equals(input.Variables))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Slots != null)
                    hashCode = hashCode * 59 + this.Slots.GetHashCode();
                if (this.Functions != null)
                    hashCode = hashCode * 59 + this.Functions.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
                if (this.GiveawaysPools != null)
                    hashCode = hashCode * 59 + this.GiveawaysPools.GetHashCode();
                if (this.LoyaltyPrograms != null)
                    hashCode = hashCode * 59 + this.LoyaltyPrograms.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AdditionalCosts != null)
                    hashCode = hashCode * 59 + this.AdditionalCosts.GetHashCode();
                if (this.Audiences != null)
                    hashCode = hashCode * 59 + this.Audiences.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
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
