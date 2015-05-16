﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForDefaultContainer.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="DetailsDataContract" /> to objects of type <see cref="DefaultContainer" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V2.Items
{
    using System.Diagnostics.Contracts;

    using GW2NET.Common;
    using GW2NET.Items;

    /// <summary>Converts objects of type <see cref="DetailsDataContract"/> to objects of type <see cref="DefaultContainer"/>.</summary>
    internal sealed class ConverterForDefaultContainer : IConverter<DetailsDataContract, DefaultContainer>
    {
        /// <summary>Converts the given object of type <see cref="DetailsDataContract"/> to an object of type <see cref="DefaultContainer"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public DefaultContainer Convert(DetailsDataContract value)
        {
            Contract.Assume(value != null);
            return new DefaultContainer();
        }
    }
}