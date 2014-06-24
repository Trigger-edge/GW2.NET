﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContainerKey.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a key that opens a container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.Gizmos
{
    using GW2DotNET.Common;

    /// <summary>Represents a key that opens a container.</summary>
    [TypeDiscriminator(Value = "ContainerKey", BaseType = typeof(Gizmo))]
    public class ContainerKey : Gizmo
    {
    }
}