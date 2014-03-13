﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Back.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a back piece.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Core.Items.Details.ItemTypes.Backs
{
    using GW2DotNET.V1.Core.Common.Converters;

    using Newtonsoft.Json;

    /// <summary>
    ///     Represents a back piece.
    /// </summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class Back : Item
    {
        /// <summary>Infrastructure. Stores the back details.</summary>
        private BackDetails backDetails;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Back" /> class.
        /// </summary>
        public Back()
            : base(ItemType.Back)
        {
        }

        /// <summary>
        ///     Gets or sets the back piece's details.
        /// </summary>
        [JsonProperty("back", Order = 100)]
        public BackDetails BackDetails
        {
            get
            {
                return this.backDetails;
            }

            set
            {
                this.backDetails = value;
                value.Back = this;
            }
        }
    }
}