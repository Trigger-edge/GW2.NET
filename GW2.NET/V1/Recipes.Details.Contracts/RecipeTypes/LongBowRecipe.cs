﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LongBowRecipe.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about a long bow crafting recipe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Recipes.Details.Contracts.RecipeTypes
{
    /// <summary>Represents detailed information about a long bow crafting recipe.</summary>
    public class LongBowRecipe : Recipe
    {
        /// <summary>Initializes a new instance of the <see cref="LongBowRecipe" /> class.</summary>
        public LongBowRecipe()
            : base(RecipeType.LongBow)
        {
        }
    }
}