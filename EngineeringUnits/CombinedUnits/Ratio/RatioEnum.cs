﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RatioUnit : Enumeration
    {

        public static readonly RatioUnit SI = new RatioUnit();
        public static readonly RatioUnit DecimalFraction = new RatioUnit();
        public static readonly RatioUnit PartPerBillion = new RatioUnit("ppb", 1/1e9m);
        public static readonly RatioUnit PartPerMillion = new RatioUnit("ppm", 1 / 1e6m);
        public static readonly RatioUnit PartPerThousand = new RatioUnit("‰", 1 / 1e3m);
        public static readonly RatioUnit PartPerTrillion = new RatioUnit("ppt", 1 / 1e12m);
        public static readonly RatioUnit Percent = new RatioUnit("%", 1 / 1e2m);

        public static readonly RatioUnit CentigramPerGram =     new RatioUnit(MassUnit.Centigram, MassUnit.Gram);
        public static readonly RatioUnit CentigramPerKilogram = new RatioUnit(MassUnit.Centigram, MassUnit.Kilogram);
        public static readonly RatioUnit DecagramPerGram =      new RatioUnit(MassUnit.Decagram, MassUnit.Gram);
        public static readonly RatioUnit DecagramPerKilogram =  new RatioUnit(MassUnit.Decagram, MassUnit.Kilogram);
        public static readonly RatioUnit DecigramPerGram =      new RatioUnit(MassUnit.Decigram, MassUnit.Gram);
        public static readonly RatioUnit DecigramPerKilogram =  new RatioUnit(MassUnit.Decigram, MassUnit.Kilogram);

        public static readonly RatioUnit GramPerGram =          new RatioUnit(MassUnit.Gram, MassUnit.Gram);
        public static readonly RatioUnit GramPerKilogram =      new RatioUnit(MassUnit.Gram, MassUnit.Kilogram);
        public static readonly RatioUnit HectogramPerGram =     new RatioUnit(MassUnit.Hectogram, MassUnit.Gram);
        public static readonly RatioUnit HectogramPerKilogram = new RatioUnit(MassUnit.Hectogram, MassUnit.Kilogram);
        public static readonly RatioUnit KilogramPerGram =      new RatioUnit(MassUnit.Kilogram, MassUnit.Gram);
        public static readonly RatioUnit KilogramPerKilogram =  new RatioUnit(MassUnit.Kilogram, MassUnit.Kilogram);
        public static readonly RatioUnit MicrogramPerGram =     new RatioUnit(MassUnit.Microgram, MassUnit.Gram);
        public static readonly RatioUnit MicrogramPerKilogram = new RatioUnit(MassUnit.Microgram, MassUnit.Kilogram);
        public static readonly RatioUnit MilligramPerGram =     new RatioUnit(MassUnit.Milligram, MassUnit.Gram);
        public static readonly RatioUnit MilligramPerKilogram = new RatioUnit(MassUnit.Milligram, MassUnit.Kilogram);
        public static readonly RatioUnit NanogramPerGram =      new RatioUnit(MassUnit.Nanogram, MassUnit.Gram);
        public static readonly RatioUnit NanogramPerKilogram =  new RatioUnit(MassUnit.Nanogram, MassUnit.Kilogram);


        //public static readonly RatioUnit HectocubicMeter = new RatioUnit(PreFix.hecto, CubicMeter);




        public RatioUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RatioUnit(MassUnit mass1, MassUnit mass2, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass1.Unit / mass2.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass1}/{mass2}");
        }

        public RatioUnit(PreFix SI, RatioUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RatioUnit(RatioUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}