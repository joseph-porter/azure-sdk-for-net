// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Login by a local user that isn't allowed. Allow list consists of login
    /// names to allow.
    /// </summary>
    public partial class LocalUserNotAllowed : AllowlistCustomAlertRule
    {
        /// <summary>
        /// Initializes a new instance of the LocalUserNotAllowed class.
        /// </summary>
        public LocalUserNotAllowed()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalUserNotAllowed class.
        /// </summary>
        /// <param name="isEnabled">Status of the custom alert.</param>
        /// <param name="allowlistValues">The values to allow. The format of
        /// the values depends on the rule type.</param>
        /// <param name="displayName">The display name of the custom
        /// alert.</param>
        /// <param name="description">The description of the custom
        /// alert.</param>
        /// <param name="valueType">The value type of the items in the list.
        /// Possible values include: 'IpCidr', 'String'</param>
        public LocalUserNotAllowed(bool isEnabled, IList<string> allowlistValues, string displayName = default(string), string description = default(string), string valueType = default(string))
            : base(isEnabled, allowlistValues, displayName, description, valueType)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}