﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlovesRecipe.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using GW2DotNET.V1.Core.Converters;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Recipes.Gloves
{
    /// <summary>
    /// Represents detailed information about a gloves crafting recipe.
    /// </summary>
    [JsonConverter(typeof(DefaultConverter))]
    public class GlovesRecipe : Recipe
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlovesRecipe"/> class.
        /// </summary>
        public GlovesRecipe()
            : base(RecipeType.Gloves)
        {
        }
    }
}