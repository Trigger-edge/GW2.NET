﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Match.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a World versus World match.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.WorldVersusWorld.Matches.Contracts
{
    using System;
    using System.Runtime.Serialization;

    using GW2DotNET.Common.Contracts;
    using GW2DotNET.V1.Worlds.Contracts;
    using GW2DotNET.V1.WorldVersusWorld.Matches.Contracts.Common;
    using GW2DotNET.V1.WorldVersusWorld.Matches.Contracts.Maps;

    /// <summary>Represents a World versus World match.</summary>
    public class Match : ServiceContract, IEquatable<Match>
    {
        /// <summary>Gets or sets the blue world.</summary>
        public World BlueWorld { get; set; }

        /// <summary>Gets or sets the timestamp (UTC) of when the match ends.</summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>Gets or sets the green world.</summary>
        public World GreenWorld { get; set; }

        /// <summary>Gets or sets the list of maps.</summary>
        [DataMember(Name = "maps")]
        public CompetitiveMapCollection Maps { get; set; }

        /// <summary>Gets or sets the match's ID.</summary>
        [DataMember(Name = "match_id")]
        public string MatchId { get; set; }

        /// <summary>Gets or sets the red world.</summary>
        public World RedWorld { get; set; }

        /// <summary>Gets or sets the total scores.</summary>
        [DataMember(Name = "scores")]
        public Scoreboard Scores { get; set; }

        /// <summary>Gets or sets the timestamp (UTC) of when the match started.</summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>Indicates whether an object is equal to another object of the same type.</summary>
        /// <param name="left">The object on the left side.</param>
        /// <param name="right">The object on the right side.</param>
        /// <returns>true if the <paramref name="left" /> parameter is equal to the <paramref name="right" /> parameter; otherwise, false.</returns>
        public static bool operator ==(Match left, Match right)
        {
            return object.Equals(left, right);
        }

        /// <summary>Indicates whether an object differs from another object of the same type.</summary>
        /// <param name="left">The object on the left side.</param>
        /// <param name="right">The object on the right side.</param>
        /// <returns>true if the <paramref name="left" /> parameter differs from the <paramref name="right" /> parameter; otherwise, false.</returns>
        public static bool operator !=(Match left, Match right)
        {
            return !object.Equals(left, right);
        }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <returns>true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Match other)
        {
            if (object.ReferenceEquals(null, other))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(this.MatchId, other.MatchId);
        }

        /// <summary>Determines whether the specified <see cref="T:System.Object"/> is equal to the current<see cref="T:System.Object"/>.</summary>
        /// <returns>true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.</returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param>
        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(null, obj))
            {
                return false;
            }

            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((Match)obj);
        }

        /// <summary>Serves as a hash function for a particular type.</summary>
        /// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
        public override int GetHashCode()
        {
            return this.MatchId != null ? this.MatchId.GetHashCode() : 0;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return this.MatchId;
        }
    }
}