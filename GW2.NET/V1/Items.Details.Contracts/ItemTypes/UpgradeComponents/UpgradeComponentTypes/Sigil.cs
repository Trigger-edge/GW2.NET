﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sigil.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about a sigil upgrade component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.UpgradeComponents.UpgradeComponentTypes
{
    /// <summary>Represents detailed information about a sigil upgrade component.</summary>
    public class Sigil : UpgradeComponent
    {
        /// <summary>Initializes a new instance of the <see cref="Sigil" /> class.</summary>
        public Sigil()
            : base(UpgradeComponentType.Sigil)
        {
        }
    }
}