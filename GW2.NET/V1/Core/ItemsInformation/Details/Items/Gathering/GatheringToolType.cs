﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GatheringToolType.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Enumerates the possible types of gathering equipment.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.Gathering
{
    using System.Runtime.Serialization;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Enumerates the possible types of gathering equipment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GatheringToolType
    {
        /// <summary>The 'Unknown' gathering tool.</summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 0, 

        /// <summary>The 'Foraging' gathering tool.</summary>
        [EnumMember(Value = "Foraging")]
        Foraging = 1 << 0, 

        /// <summary>The 'Logging' gathering tool.</summary>
        [EnumMember(Value = "Logging")]
        Logging = 1 << 1, 

        /// <summary>The 'Mining' gathering tool.</summary>
        [EnumMember(Value = "Mining")]
        Mining = 1 << 2
    }
}