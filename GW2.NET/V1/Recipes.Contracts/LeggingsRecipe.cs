﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeggingsRecipe.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a leg protection crafting recipe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Recipes.Contracts
{
    using GW2DotNET.Common;

    /// <summary>Represents a leg protection crafting recipe.</summary>
    [TypeDiscriminator(Value = "Leggings", BaseType = typeof(Recipe))]
    public class LeggingsRecipe : Recipe
    {
    }
}