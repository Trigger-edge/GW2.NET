﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicEventDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.EventDetails.Models
{
    /// <summary>
    /// Represents details about a specific dynamic event.
    /// </summary>
    public partial class DynamicEventDetails : JsonObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicEventDetails"/> class.
        /// </summary>
        public DynamicEventDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicEventDetails"/> class.
        /// </summary>
        /// <param name="name">The name of the event.</param>
        /// <param name="level">The event level.</param>
        /// <param name="mapId">The map where the event takes place.</param>
        /// <param name="flags">Additional flags.</param>
        /// <param name="location">The location of the event.</param>
        public DynamicEventDetails(string name, int level, int mapId, DynamicEventStyles flags, Location location)
        {
            this.Name = name;
            this.Level = level;
            this.MapId = mapId;
            this.Flags = flags;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets additional flags.
        /// </summary>
        [JsonProperty("flags", Order = 3)]
        public DynamicEventStyles Flags { get; set; }

        /// <summary>
        /// Gets or sets the event level.
        /// </summary>
        [JsonProperty("level", Order = 1)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the location of the event.
        /// </summary>
        [JsonProperty("location", Order = 4)]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the map where the event takes place.
        /// </summary>
        [JsonProperty("map_id", Order = 2)]
        public int MapId { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        [JsonProperty("name", Order = 0)]
        public string Name { get; set; }
    }
}