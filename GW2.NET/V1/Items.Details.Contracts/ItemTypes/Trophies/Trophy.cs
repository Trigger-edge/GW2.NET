﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trophy.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a trophy.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Trophies
{
    /// <summary>Represents a trophy.</summary>
    public class Trophy : Item
    {
        /// <summary>Initializes a new instance of the <see cref="Trophy" /> class.</summary>
        public Trophy()
            : base(ItemType.Trophy)
        {
        }
    }
}