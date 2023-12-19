﻿using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace EngineeringUnits
{
    //This is the object that is used in the list of the unitsystem

    //When converting between units we use y=ax+b
    //The a and the b are found below
    //The count tell how many of the same type we have: 
    //ex. 1meter has a count of 1 lenght
    //ex. 1meter^2 (area) has a count of 2 lenght

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public record RawUnit
    {

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue("")]
        public string Symbol { get; init; } 

        public Fraction A { get; init; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(0d)]
        public decimal B { get; init; }

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(1)]
        public int Count { get; init; } 
        public BaseunitType UnitType { get; init; }

        [JsonIgnore]
        public Fraction TotalConstant => Fraction.Pow(A, Count);

        [JsonIgnore]
        public bool IsSI => A == Fraction.One && B == 0m;

        public RawUnit() {}

        public RawUnit CloneAndReverseCount()
        {
            return this with
            {
                Count = Count * -1,
            };

        }
        public RawUnit CloneWithNewCount(int newCount)
        {
            if (Count == newCount)
                return this;


            return this with
            {
                Count = newCount,
            };

        }

        public RawUnit CloneAsSI()
        {
            return this with
            {
                A = Fraction.One,
                B = 0,
                Symbol = null,
            };

        }

        public override int GetHashCode()
        {
            int TempHashCode;
            unchecked // Overflow is fine, just wrap
            {
                TempHashCode = (int)2166136261;
                TempHashCode = (TempHashCode * 16777619) ^ A.GetHashCode();
                TempHashCode = (TempHashCode * 45476689) ^ B.GetHashCode();
                TempHashCode = (TempHashCode * 16777619) ^ Count.GetHashCode();
                TempHashCode = (TempHashCode * 16777619) ^ UnitType.GetHashCode();
            }

            return TempHashCode;
        }
    }
}
