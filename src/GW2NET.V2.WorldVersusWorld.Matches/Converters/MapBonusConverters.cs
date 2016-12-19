﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V2.WorldVersusWorld.Matches.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.WorldVersusWorld;
	using MapBonusDTO = GW2NET.V2.WorldVersusWorld.Matches.Json.MapBonusDTO;

    public sealed partial class MapBonusConverter : IConverter<MapBonusDTO, MapBonus>
	{
	    private readonly ITypeConverterFactory<MapBonusDTO, MapBonus> converterFactory;

		private MapBonusConverter(ITypeConverterFactory<MapBonusDTO, MapBonus> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        MapBonus IConverter<MapBonusDTO, MapBonus>.Convert(MapBonusDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'MapBonus' (if any)
    	partial void Merge(MapBonus entity, MapBonusDTO dto, object state);

		/*
		// Use this template
		public partial class MapBonusConverter
		{
		    partial void Merge(MapBonus entity, MapBonusDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region Bloodlust
    /// <summary>Converts objects of type <see cref="MapBonusDTO"/> to objects of type <see cref="Bloodlust"/>.</summary>
    public sealed partial class BloodlustConverter : IConverter<MapBonusDTO, MapBonus>
    {
	    /// <inheritdoc />
        public MapBonus Convert(MapBonusDTO value, object state)
        {
    		var entity = new Bloodlust();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Bloodlust' (if any)
    	partial void Merge(Bloodlust entity, MapBonusDTO dto, object state);

		/*
		// Use this template
		public partial class BloodlustConverter
		{
		    partial void Merge(Bloodlust entity, MapBonusDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownMapBonus
    /// <summary>Converts objects of type <see cref="MapBonusDTO"/> to objects of type <see cref="UnknownMapBonus"/>.</summary>
    public sealed partial class UnknownMapBonusConverter : IConverter<MapBonusDTO, MapBonus>
    {
	    /// <inheritdoc />
        public MapBonus Convert(MapBonusDTO value, object state)
        {
    		var entity = new UnknownMapBonus();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownMapBonus' (if any)
    	partial void Merge(UnknownMapBonus entity, MapBonusDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownMapBonusConverter
		{
		    partial void Merge(UnknownMapBonus entity, MapBonusDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
