﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectiveNameDataContractConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="ObjectiveNameDataContract" /> to objects of type <see cref="ObjectiveName" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.WorldVersusWorld.Objectives.Json
{
    using System.Diagnostics;

    using GW2NET.Common;
    using GW2NET.Entities.WorldVersusWorld;

    /// <summary>Converts objects of type <see cref="ObjectiveNameDataContract"/> to objects of type <see cref="ObjectiveName"/>.</summary>
    internal sealed class ObjectiveNameDataContractConverter : IConverter<ObjectiveNameDataContract, ObjectiveName>
    {
        /// <summary>Converts the given object of type <see cref="ObjectiveNameDataContract"/> to an object of type <see cref="ObjectiveName"/>.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The converted value.</returns>
        public ObjectiveName Convert(ObjectiveNameDataContract value)
        {
            int objectiveId;
            if (!int.TryParse(value.Id, out objectiveId))
            {
                Debug.WriteLine("Invalid value for objective ID: '{0}'", value.Id);
            }

            return new ObjectiveName { ObjectiveId = objectiveId, Name = value.Name };
        }
    }
}