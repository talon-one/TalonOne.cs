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
    /// RoleV2ApplicationDetails
    /// </summary>
    [DataContract]
    public partial class RoleV2ApplicationDetails :  IEquatable<RoleV2ApplicationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleV2ApplicationDetails" /> class.
        /// </summary>
        /// <param name="application">Name of the Application-level permission set..</param>
        /// <param name="campaign">Name of the campaign-level permission set..</param>
        /// <param name="draftCampaign">Name of the draft campaign-level permission set..</param>
        public RoleV2ApplicationDetails(string application = default(string), string campaign = default(string), string draftCampaign = default(string))
        {
            this.Application = application;
            this.Campaign = campaign;
            this.DraftCampaign = draftCampaign;
        }
        
        /// <summary>
        /// Name of the Application-level permission set.
        /// </summary>
        /// <value>Name of the Application-level permission set.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }

        /// <summary>
        /// Name of the campaign-level permission set.
        /// </summary>
        /// <value>Name of the campaign-level permission set.</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public string Campaign { get; set; }

        /// <summary>
        /// Name of the draft campaign-level permission set.
        /// </summary>
        /// <value>Name of the draft campaign-level permission set.</value>
        [DataMember(Name="draftCampaign", EmitDefaultValue=false)]
        public string DraftCampaign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleV2ApplicationDetails {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  DraftCampaign: ").Append(DraftCampaign).Append("\n");
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
            return this.Equals(input as RoleV2ApplicationDetails);
        }

        /// <summary>
        /// Returns true if RoleV2ApplicationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleV2ApplicationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleV2ApplicationDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
                ) && 
                (
                    this.DraftCampaign == input.DraftCampaign ||
                    (this.DraftCampaign != null &&
                    this.DraftCampaign.Equals(input.DraftCampaign))
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
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
                if (this.DraftCampaign != null)
                    hashCode = hashCode * 59 + this.DraftCampaign.GetHashCode();
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
