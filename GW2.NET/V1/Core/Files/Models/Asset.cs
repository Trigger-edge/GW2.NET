﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Asset.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.Files.Models
{
    /// <summary>
    /// Represents information about a file that can be retrieved from the render service.
    /// </summary>
    public class Asset : JsonObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset"/> class.
        /// </summary>
        public Asset()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset"/> class.
        /// </summary>
        /// <param name="fileId">The file ID.</param>
        /// <param name="signature">The file signature.</param>
        public Asset(string fileId, string signature)
        {
            this.FileId = fileId;
            this.Signature = signature;
        }

        /// <summary>
        /// Gets or sets the file ID to be used with the render service.
        /// </summary>
        [JsonProperty("file_id", Order = 0)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or sets file signature to be used with the render service.
        /// </summary>
        [JsonProperty("signature", Order = 1)]
        public string Signature { get; set; }
    }
}