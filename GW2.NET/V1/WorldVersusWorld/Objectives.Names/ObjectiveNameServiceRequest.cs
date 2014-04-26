// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectiveNameServiceRequest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a request for a list of objectives and their localized name.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.WorldVersusWorld.Objectives.Names
{
    using GW2DotNET.V1.Common;

    /// <summary>Represents a request for a list of objectives and their localized name.</summary>
    public class ObjectiveNameServiceRequest : ServiceRequest
    {
        /// <summary>Initializes a new instance of the <see cref="ObjectiveNameServiceRequest" /> class.</summary>
        public ObjectiveNameServiceRequest()
            : base(Services.ObjectiveNames)
        {
        }
    }
}