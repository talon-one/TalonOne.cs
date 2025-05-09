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
    /// Message Log.
    /// </summary>
    [DataContract]
    public partial class MessageLogEntry :  IEquatable<MessageLogEntry>, IValidatableObject
    {
        /// <summary>
        /// The entity type the log is related to. 
        /// </summary>
        /// <value>The entity type the log is related to. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Enum Application for value: application
            /// </summary>
            [EnumMember(Value = "application")]
            Application = 1,

            /// <summary>
            /// Enum Loyaltyprogram for value: loyalty_program
            /// </summary>
            [EnumMember(Value = "loyalty_program")]
            Loyaltyprogram = 2,

            /// <summary>
            /// Enum Webhook for value: webhook
            /// </summary>
            [EnumMember(Value = "webhook")]
            Webhook = 3

        }

        /// <summary>
        /// The entity type the log is related to. 
        /// </summary>
        /// <value>The entity type the log is related to. </value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageLogEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageLogEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageLogEntry" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the message. (required).</param>
        /// <param name="service">Name of the service that generated the log entry. (required).</param>
        /// <param name="changeType">Type of change that triggered the notification..</param>
        /// <param name="notificationId">ID of the notification..</param>
        /// <param name="notificationName">The name of the notification..</param>
        /// <param name="webhookId">ID of the webhook..</param>
        /// <param name="webhookName">The name of the webhook..</param>
        /// <param name="request">request.</param>
        /// <param name="response">response.</param>
        /// <param name="createdAt">Timestamp when the log entry was created. (required).</param>
        /// <param name="entityType">The entity type the log is related to.  (required).</param>
        /// <param name="url">The target URL of the request..</param>
        /// <param name="applicationId">Identifier of the Application..</param>
        /// <param name="loyaltyProgramId">Identifier of the loyalty program..</param>
        /// <param name="campaignId">Identifier of the campaign..</param>
        public MessageLogEntry(string id = default(string), string service = default(string), string changeType = default(string), int notificationId = default(int), string notificationName = default(string), int webhookId = default(int), string webhookName = default(string), MessageLogRequest request = default(MessageLogRequest), MessageLogResponse response = default(MessageLogResponse), DateTime createdAt = default(DateTime), EntityTypeEnum entityType = default(EntityTypeEnum), string url = default(string), int applicationId = default(int), int loyaltyProgramId = default(int), int campaignId = default(int))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for MessageLogEntry and cannot be null");
            // to ensure "service" is required (not null)
            this.Service = service ?? throw new ArgumentNullException("service is a required property for MessageLogEntry and cannot be null");
            this.CreatedAt = createdAt;
            this.EntityType = entityType;
            this.ChangeType = changeType;
            this.NotificationId = notificationId;
            this.NotificationName = notificationName;
            this.WebhookId = webhookId;
            this.WebhookName = webhookName;
            this.Request = request;
            this.Response = response;
            this.Url = url;
            this.ApplicationId = applicationId;
            this.LoyaltyProgramId = loyaltyProgramId;
            this.CampaignId = campaignId;
        }
        
        /// <summary>
        /// Unique identifier of the message.
        /// </summary>
        /// <value>Unique identifier of the message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the service that generated the log entry.
        /// </summary>
        /// <value>Name of the service that generated the log entry.</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Type of change that triggered the notification.
        /// </summary>
        /// <value>Type of change that triggered the notification.</value>
        [DataMember(Name="changeType", EmitDefaultValue=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// ID of the notification.
        /// </summary>
        /// <value>ID of the notification.</value>
        [DataMember(Name="notificationId", EmitDefaultValue=false)]
        public int NotificationId { get; set; }

        /// <summary>
        /// The name of the notification.
        /// </summary>
        /// <value>The name of the notification.</value>
        [DataMember(Name="notificationName", EmitDefaultValue=false)]
        public string NotificationName { get; set; }

        /// <summary>
        /// ID of the webhook.
        /// </summary>
        /// <value>ID of the webhook.</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public int WebhookId { get; set; }

        /// <summary>
        /// The name of the webhook.
        /// </summary>
        /// <value>The name of the webhook.</value>
        [DataMember(Name="webhookName", EmitDefaultValue=false)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public MessageLogRequest Request { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public MessageLogResponse Response { get; set; }

        /// <summary>
        /// Timestamp when the log entry was created.
        /// </summary>
        /// <value>Timestamp when the log entry was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The target URL of the request.
        /// </summary>
        /// <value>The target URL of the request.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Identifier of the Application.
        /// </summary>
        /// <value>Identifier of the Application.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Identifier of the loyalty program.
        /// </summary>
        /// <value>Identifier of the loyalty program.</value>
        [DataMember(Name="loyaltyProgramId", EmitDefaultValue=false)]
        public int LoyaltyProgramId { get; set; }

        /// <summary>
        /// Identifier of the campaign.
        /// </summary>
        /// <value>Identifier of the campaign.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageLogEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  NotificationName: ").Append(NotificationName).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  LoyaltyProgramId: ").Append(LoyaltyProgramId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as MessageLogEntry);
        }

        /// <summary>
        /// Returns true if MessageLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageLogEntry input)
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
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.ChangeType == input.ChangeType ||
                    (this.ChangeType != null &&
                    this.ChangeType.Equals(input.ChangeType))
                ) && 
                (
                    this.NotificationId == input.NotificationId ||
                    this.NotificationId.Equals(input.NotificationId)
                ) && 
                (
                    this.NotificationName == input.NotificationName ||
                    (this.NotificationName != null &&
                    this.NotificationName.Equals(input.NotificationName))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    this.WebhookId.Equals(input.WebhookId)
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    this.EntityType.Equals(input.EntityType)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.LoyaltyProgramId == input.LoyaltyProgramId ||
                    this.LoyaltyProgramId.Equals(input.LoyaltyProgramId)
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
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
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.ChangeType != null)
                    hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationId.GetHashCode();
                if (this.NotificationName != null)
                    hashCode = hashCode * 59 + this.NotificationName.GetHashCode();
                hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookName != null)
                    hashCode = hashCode * 59 + this.WebhookName.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.LoyaltyProgramId.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
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
            // ApplicationId (int) minimum
            if(this.ApplicationId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApplicationId, must be a value greater than or equal to 1.", new [] { "ApplicationId" });
            }

            // LoyaltyProgramId (int) minimum
            if(this.LoyaltyProgramId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoyaltyProgramId, must be a value greater than or equal to 1.", new [] { "LoyaltyProgramId" });
            }

            // CampaignId (int) minimum
            if(this.CampaignId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignId, must be a value greater than or equal to 1.", new [] { "CampaignId" });
            }

            yield break;
        }
    }

}
