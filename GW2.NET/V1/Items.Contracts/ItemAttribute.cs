﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemAttribute.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an item attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Contracts
{
    using System.Runtime.Serialization;

    using GW2DotNET.Common.Contracts;

    /// <summary>Represents an item attribute.</summary>
    /// TODO: rename to 'ItemAttributeContract'
    public sealed class ItemAttribute : ServiceContract
    {
        /// <summary>Gets or sets the attribute's type.</summary>
        [DataMember(Name = "attribute", Order = 0)]
        public string Attribute { get; set; }

        /// <summary>Gets or sets the attribute's modifier.</summary>
        [DataMember(Name = "modifier", Order = 1)]
        public string Modifier { get; set; }
    }
}