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
    /// NewLoyaltyProgram
    /// </summary>
    [DataContract]
    public partial class NewLoyaltyProgram :  IEquatable<NewLoyaltyProgram>, IValidatableObject
    {
        /// <summary>
        /// The policy that defines which date is used to calculate the expiration date of a customer&#39;s current tier.  - &#x60;tier_start_date&#x60;: The tier expiration date is calculated based on when the customer joined the current tier.  - &#x60;program_join_date&#x60;: The tier expiration date is calculated based on when the customer joined the loyalty program. 
        /// </summary>
        /// <value>The policy that defines which date is used to calculate the expiration date of a customer&#39;s current tier.  - &#x60;tier_start_date&#x60;: The tier expiration date is calculated based on when the customer joined the current tier.  - &#x60;program_join_date&#x60;: The tier expiration date is calculated based on when the customer joined the loyalty program. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TiersExpirationPolicyEnum
        {
            /// <summary>
            /// Enum Tierstartdate for value: tier_start_date
            /// </summary>
            [EnumMember(Value = "tier_start_date")]
            Tierstartdate = 1,

            /// <summary>
            /// Enum Programjoindate for value: program_join_date
            /// </summary>
            [EnumMember(Value = "program_join_date")]
            Programjoindate = 2

        }

        /// <summary>
        /// The policy that defines which date is used to calculate the expiration date of a customer&#39;s current tier.  - &#x60;tier_start_date&#x60;: The tier expiration date is calculated based on when the customer joined the current tier.  - &#x60;program_join_date&#x60;: The tier expiration date is calculated based on when the customer joined the loyalty program. 
        /// </summary>
        /// <value>The policy that defines which date is used to calculate the expiration date of a customer&#39;s current tier.  - &#x60;tier_start_date&#x60;: The tier expiration date is calculated based on when the customer joined the current tier.  - &#x60;program_join_date&#x60;: The tier expiration date is calculated based on when the customer joined the loyalty program. </value>
        [DataMember(Name="tiersExpirationPolicy", EmitDefaultValue=false)]
        public TiersExpirationPolicyEnum? TiersExpirationPolicy { get; set; }
        /// <summary>
        /// Customers&#39;s tier downgrade policy.  - &#x60;one_down&#x60;: Once the tier expires and if the user doesn&#39;t have enough points to stay in the tier, the user is downgraded one tier down.  - &#x60;balance_based&#x60;: Once the tier expires, the user&#39;s tier is evaluated based on the amount of active points the user has at this instant. 
        /// </summary>
        /// <value>Customers&#39;s tier downgrade policy.  - &#x60;one_down&#x60;: Once the tier expires and if the user doesn&#39;t have enough points to stay in the tier, the user is downgraded one tier down.  - &#x60;balance_based&#x60;: Once the tier expires, the user&#39;s tier is evaluated based on the amount of active points the user has at this instant. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TiersDowngradePolicyEnum
        {
            /// <summary>
            /// Enum Onedown for value: one_down
            /// </summary>
            [EnumMember(Value = "one_down")]
            Onedown = 1,

            /// <summary>
            /// Enum Balancebased for value: balance_based
            /// </summary>
            [EnumMember(Value = "balance_based")]
            Balancebased = 2

        }

        /// <summary>
        /// Customers&#39;s tier downgrade policy.  - &#x60;one_down&#x60;: Once the tier expires and if the user doesn&#39;t have enough points to stay in the tier, the user is downgraded one tier down.  - &#x60;balance_based&#x60;: Once the tier expires, the user&#39;s tier is evaluated based on the amount of active points the user has at this instant. 
        /// </summary>
        /// <value>Customers&#39;s tier downgrade policy.  - &#x60;one_down&#x60;: Once the tier expires and if the user doesn&#39;t have enough points to stay in the tier, the user is downgraded one tier down.  - &#x60;balance_based&#x60;: Once the tier expires, the user&#39;s tier is evaluated based on the amount of active points the user has at this instant. </value>
        [DataMember(Name="tiersDowngradePolicy", EmitDefaultValue=false)]
        public TiersDowngradePolicyEnum? TiersDowngradePolicy { get; set; }
        /// <summary>
        /// The policy that defines when the customer joins the loyalty program.   - &#x60;not_join&#x60;: The customer does not join the loyalty program but can still earn and spend loyalty points.       **Note**: The customer does not have a program join date.   - &#x60;points_activated&#x60;: The customer joins the loyalty program only when their earned loyalty points become active for the first time.   - &#x60;points_earned&#x60;: The customer joins the loyalty program when they earn loyalty points for the first time. 
        /// </summary>
        /// <value>The policy that defines when the customer joins the loyalty program.   - &#x60;not_join&#x60;: The customer does not join the loyalty program but can still earn and spend loyalty points.       **Note**: The customer does not have a program join date.   - &#x60;points_activated&#x60;: The customer joins the loyalty program only when their earned loyalty points become active for the first time.   - &#x60;points_earned&#x60;: The customer joins the loyalty program when they earn loyalty points for the first time. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProgramJoinPolicyEnum
        {
            /// <summary>
            /// Enum Notjoin for value: not_join
            /// </summary>
            [EnumMember(Value = "not_join")]
            Notjoin = 1,

            /// <summary>
            /// Enum Pointsactivated for value: points_activated
            /// </summary>
            [EnumMember(Value = "points_activated")]
            Pointsactivated = 2,

            /// <summary>
            /// Enum Pointsearned for value: points_earned
            /// </summary>
            [EnumMember(Value = "points_earned")]
            Pointsearned = 3

        }

        /// <summary>
        /// The policy that defines when the customer joins the loyalty program.   - &#x60;not_join&#x60;: The customer does not join the loyalty program but can still earn and spend loyalty points.       **Note**: The customer does not have a program join date.   - &#x60;points_activated&#x60;: The customer joins the loyalty program only when their earned loyalty points become active for the first time.   - &#x60;points_earned&#x60;: The customer joins the loyalty program when they earn loyalty points for the first time. 
        /// </summary>
        /// <value>The policy that defines when the customer joins the loyalty program.   - &#x60;not_join&#x60;: The customer does not join the loyalty program but can still earn and spend loyalty points.       **Note**: The customer does not have a program join date.   - &#x60;points_activated&#x60;: The customer joins the loyalty program only when their earned loyalty points become active for the first time.   - &#x60;points_earned&#x60;: The customer joins the loyalty program when they earn loyalty points for the first time. </value>
        [DataMember(Name="programJoinPolicy", EmitDefaultValue=false)]
        public ProgramJoinPolicyEnum? ProgramJoinPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLoyaltyProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewLoyaltyProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLoyaltyProgram" /> class.
        /// </summary>
        /// <param name="title">The display title for the Loyalty Program. (required).</param>
        /// <param name="description">Description of our Loyalty Program..</param>
        /// <param name="subscribedApplications">A list containing the IDs of all applications that are subscribed to this Loyalty Program..</param>
        /// <param name="defaultValidity">The default duration after which new loyalty points should expire. Can be &#39;unlimited&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month.  (required).</param>
        /// <param name="defaultPending">The default duration of the pending time after which points should be valid. Can be &#39;immediate&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month.  (required).</param>
        /// <param name="allowSubledger">Indicates if this program supports subledgers inside the program. (required).</param>
        /// <param name="usersPerCardLimit">The max amount of user profiles with whom a card can be shared. This can be set to 0 for no limit. This property is only used when &#x60;cardBased&#x60; is &#x60;true&#x60;. .</param>
        /// <param name="sandbox">Indicates if this program is a live or sandbox program. Programs of a given type can only be connected to Applications of the same type. (required).</param>
        /// <param name="tiersExpirationPolicy">The policy that defines which date is used to calculate the expiration date of a customer&#39;s current tier.  - &#x60;tier_start_date&#x60;: The tier expiration date is calculated based on when the customer joined the current tier.  - &#x60;program_join_date&#x60;: The tier expiration date is calculated based on when the customer joined the loyalty program. .</param>
        /// <param name="tiersExpireIn">The amount of time after which the tier expires.  The time format is an **integer** followed by one letter indicating the time unit. Examples: &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. .</param>
        /// <param name="tiersDowngradePolicy">Customers&#39;s tier downgrade policy.  - &#x60;one_down&#x60;: Once the tier expires and if the user doesn&#39;t have enough points to stay in the tier, the user is downgraded one tier down.  - &#x60;balance_based&#x60;: Once the tier expires, the user&#39;s tier is evaluated based on the amount of active points the user has at this instant. .</param>
        /// <param name="programJoinPolicy">The policy that defines when the customer joins the loyalty program.   - &#x60;not_join&#x60;: The customer does not join the loyalty program but can still earn and spend loyalty points.       **Note**: The customer does not have a program join date.   - &#x60;points_activated&#x60;: The customer joins the loyalty program only when their earned loyalty points become active for the first time.   - &#x60;points_earned&#x60;: The customer joins the loyalty program when they earn loyalty points for the first time. .</param>
        /// <param name="name">The internal name for the Loyalty Program. This is an immutable value. (required).</param>
        /// <param name="tiers">The tiers in this loyalty program..</param>
        /// <param name="timezone">A string containing an IANA timezone descriptor. (required).</param>
        /// <param name="cardBased">Defines the type of loyalty program: - &#x60;true&#x60;: the program is a card-based. - &#x60;false&#x60;: the program is profile-based.  (required) (default to false).</param>
        public NewLoyaltyProgram(string title = default(string), string description = default(string), List<int> subscribedApplications = default(List<int>), string defaultValidity = default(string), string defaultPending = default(string), bool allowSubledger = default(bool), int usersPerCardLimit = default(int), bool sandbox = default(bool), TiersExpirationPolicyEnum? tiersExpirationPolicy = default(TiersExpirationPolicyEnum?), string tiersExpireIn = default(string), TiersDowngradePolicyEnum? tiersDowngradePolicy = default(TiersDowngradePolicyEnum?), ProgramJoinPolicyEnum? programJoinPolicy = default(ProgramJoinPolicyEnum?), string name = default(string), List<NewLoyaltyTier> tiers = default(List<NewLoyaltyTier>), string timezone = default(string), bool cardBased = false)
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for NewLoyaltyProgram and cannot be null");
            // to ensure "defaultValidity" is required (not null)
            this.DefaultValidity = defaultValidity ?? throw new ArgumentNullException("defaultValidity is a required property for NewLoyaltyProgram and cannot be null");
            // to ensure "defaultPending" is required (not null)
            this.DefaultPending = defaultPending ?? throw new ArgumentNullException("defaultPending is a required property for NewLoyaltyProgram and cannot be null");
            this.AllowSubledger = allowSubledger;
            this.Sandbox = sandbox;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for NewLoyaltyProgram and cannot be null");
            // to ensure "timezone" is required (not null)
            this.Timezone = timezone ?? throw new ArgumentNullException("timezone is a required property for NewLoyaltyProgram and cannot be null");
            this.CardBased = cardBased;
            this.Description = description;
            this.SubscribedApplications = subscribedApplications;
            this.UsersPerCardLimit = usersPerCardLimit;
            this.TiersExpirationPolicy = tiersExpirationPolicy;
            this.TiersExpireIn = tiersExpireIn;
            this.TiersDowngradePolicy = tiersDowngradePolicy;
            this.ProgramJoinPolicy = programJoinPolicy;
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// The display title for the Loyalty Program.
        /// </summary>
        /// <value>The display title for the Loyalty Program.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Description of our Loyalty Program.
        /// </summary>
        /// <value>Description of our Loyalty Program.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list containing the IDs of all applications that are subscribed to this Loyalty Program.
        /// </summary>
        /// <value>A list containing the IDs of all applications that are subscribed to this Loyalty Program.</value>
        [DataMember(Name="subscribedApplications", EmitDefaultValue=false)]
        public List<int> SubscribedApplications { get; set; }

        /// <summary>
        /// The default duration after which new loyalty points should expire. Can be &#39;unlimited&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month. 
        /// </summary>
        /// <value>The default duration after which new loyalty points should expire. Can be &#39;unlimited&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month. </value>
        [DataMember(Name="defaultValidity", EmitDefaultValue=false)]
        public string DefaultValidity { get; set; }

        /// <summary>
        /// The default duration of the pending time after which points should be valid. Can be &#39;immediate&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month. 
        /// </summary>
        /// <value>The default duration of the pending time after which points should be valid. Can be &#39;immediate&#39; or a specific time. The time format is a number followed by one letter indicating the time unit, like &#39;30s&#39;, &#39;40m&#39;, &#39;1h&#39;, &#39;5D&#39;, &#39;7W&#39;, or 10M&#39;. These rounding suffixes are also supported: - &#39;_D&#39; for rounding down. Can be used as a suffix after &#39;D&#39;, and signifies the start of the day. - &#39;_U&#39; for rounding up. Can be used as a suffix after &#39;D&#39;, &#39;W&#39;, and &#39;M&#39;, and signifies the end of the day, week, and month. </value>
        [DataMember(Name="defaultPending", EmitDefaultValue=false)]
        public string DefaultPending { get; set; }

        /// <summary>
        /// Indicates if this program supports subledgers inside the program.
        /// </summary>
        /// <value>Indicates if this program supports subledgers inside the program.</value>
        [DataMember(Name="allowSubledger", EmitDefaultValue=false)]
        public bool AllowSubledger { get; set; }

        /// <summary>
        /// The max amount of user profiles with whom a card can be shared. This can be set to 0 for no limit. This property is only used when &#x60;cardBased&#x60; is &#x60;true&#x60;. 
        /// </summary>
        /// <value>The max amount of user profiles with whom a card can be shared. This can be set to 0 for no limit. This property is only used when &#x60;cardBased&#x60; is &#x60;true&#x60;. </value>
        [DataMember(Name="usersPerCardLimit", EmitDefaultValue=false)]
        public int UsersPerCardLimit { get; set; }

        /// <summary>
        /// Indicates if this program is a live or sandbox program. Programs of a given type can only be connected to Applications of the same type.
        /// </summary>
        /// <value>Indicates if this program is a live or sandbox program. Programs of a given type can only be connected to Applications of the same type.</value>
        [DataMember(Name="sandbox", EmitDefaultValue=false)]
        public bool Sandbox { get; set; }

        /// <summary>
        /// The amount of time after which the tier expires.  The time format is an **integer** followed by one letter indicating the time unit. Examples: &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. 
        /// </summary>
        /// <value>The amount of time after which the tier expires.  The time format is an **integer** followed by one letter indicating the time unit. Examples: &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. </value>
        [DataMember(Name="tiersExpireIn", EmitDefaultValue=false)]
        public string TiersExpireIn { get; set; }

        /// <summary>
        /// The internal name for the Loyalty Program. This is an immutable value.
        /// </summary>
        /// <value>The internal name for the Loyalty Program. This is an immutable value.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The tiers in this loyalty program.
        /// </summary>
        /// <value>The tiers in this loyalty program.</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<NewLoyaltyTier> Tiers { get; set; }

        /// <summary>
        /// A string containing an IANA timezone descriptor.
        /// </summary>
        /// <value>A string containing an IANA timezone descriptor.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Defines the type of loyalty program: - &#x60;true&#x60;: the program is a card-based. - &#x60;false&#x60;: the program is profile-based. 
        /// </summary>
        /// <value>Defines the type of loyalty program: - &#x60;true&#x60;: the program is a card-based. - &#x60;false&#x60;: the program is profile-based. </value>
        [DataMember(Name="cardBased", EmitDefaultValue=false)]
        public bool CardBased { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewLoyaltyProgram {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubscribedApplications: ").Append(SubscribedApplications).Append("\n");
            sb.Append("  DefaultValidity: ").Append(DefaultValidity).Append("\n");
            sb.Append("  DefaultPending: ").Append(DefaultPending).Append("\n");
            sb.Append("  AllowSubledger: ").Append(AllowSubledger).Append("\n");
            sb.Append("  UsersPerCardLimit: ").Append(UsersPerCardLimit).Append("\n");
            sb.Append("  Sandbox: ").Append(Sandbox).Append("\n");
            sb.Append("  TiersExpirationPolicy: ").Append(TiersExpirationPolicy).Append("\n");
            sb.Append("  TiersExpireIn: ").Append(TiersExpireIn).Append("\n");
            sb.Append("  TiersDowngradePolicy: ").Append(TiersDowngradePolicy).Append("\n");
            sb.Append("  ProgramJoinPolicy: ").Append(ProgramJoinPolicy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  CardBased: ").Append(CardBased).Append("\n");
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
            return this.Equals(input as NewLoyaltyProgram);
        }

        /// <summary>
        /// Returns true if NewLoyaltyProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of NewLoyaltyProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewLoyaltyProgram input)
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
                    this.SubscribedApplications == input.SubscribedApplications ||
                    this.SubscribedApplications != null &&
                    input.SubscribedApplications != null &&
                    this.SubscribedApplications.SequenceEqual(input.SubscribedApplications)
                ) && 
                (
                    this.DefaultValidity == input.DefaultValidity ||
                    (this.DefaultValidity != null &&
                    this.DefaultValidity.Equals(input.DefaultValidity))
                ) && 
                (
                    this.DefaultPending == input.DefaultPending ||
                    (this.DefaultPending != null &&
                    this.DefaultPending.Equals(input.DefaultPending))
                ) && 
                (
                    this.AllowSubledger == input.AllowSubledger ||
                    this.AllowSubledger.Equals(input.AllowSubledger)
                ) && 
                (
                    this.UsersPerCardLimit == input.UsersPerCardLimit ||
                    this.UsersPerCardLimit.Equals(input.UsersPerCardLimit)
                ) && 
                (
                    this.Sandbox == input.Sandbox ||
                    this.Sandbox.Equals(input.Sandbox)
                ) && 
                (
                    this.TiersExpirationPolicy == input.TiersExpirationPolicy ||
                    this.TiersExpirationPolicy.Equals(input.TiersExpirationPolicy)
                ) && 
                (
                    this.TiersExpireIn == input.TiersExpireIn ||
                    (this.TiersExpireIn != null &&
                    this.TiersExpireIn.Equals(input.TiersExpireIn))
                ) && 
                (
                    this.TiersDowngradePolicy == input.TiersDowngradePolicy ||
                    this.TiersDowngradePolicy.Equals(input.TiersDowngradePolicy)
                ) && 
                (
                    this.ProgramJoinPolicy == input.ProgramJoinPolicy ||
                    this.ProgramJoinPolicy.Equals(input.ProgramJoinPolicy)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.CardBased == input.CardBased ||
                    this.CardBased.Equals(input.CardBased)
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
                if (this.SubscribedApplications != null)
                    hashCode = hashCode * 59 + this.SubscribedApplications.GetHashCode();
                if (this.DefaultValidity != null)
                    hashCode = hashCode * 59 + this.DefaultValidity.GetHashCode();
                if (this.DefaultPending != null)
                    hashCode = hashCode * 59 + this.DefaultPending.GetHashCode();
                hashCode = hashCode * 59 + this.AllowSubledger.GetHashCode();
                hashCode = hashCode * 59 + this.UsersPerCardLimit.GetHashCode();
                hashCode = hashCode * 59 + this.Sandbox.GetHashCode();
                hashCode = hashCode * 59 + this.TiersExpirationPolicy.GetHashCode();
                if (this.TiersExpireIn != null)
                    hashCode = hashCode * 59 + this.TiersExpireIn.GetHashCode();
                hashCode = hashCode * 59 + this.TiersDowngradePolicy.GetHashCode();
                hashCode = hashCode * 59 + this.ProgramJoinPolicy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                hashCode = hashCode * 59 + this.CardBased.GetHashCode();
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
            // UsersPerCardLimit (int) minimum
            if(this.UsersPerCardLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsersPerCardLimit, must be a value greater than or equal to 0.", new [] { "UsersPerCardLimit" });
            }

            // Timezone (string) minLength
            if(this.Timezone != null && this.Timezone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timezone, length must be greater than 1.", new [] { "Timezone" });
            }

            yield break;
        }
    }

}
