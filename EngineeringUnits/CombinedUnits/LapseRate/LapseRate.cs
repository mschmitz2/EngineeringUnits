
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LapseRate : BaseUnit
    {

        public LapseRate() { }
        public LapseRate(decimal value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(double value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(int value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(UnknownUnit value) : base(value) { }

        public static LapseRate From(double value, LapseRateUnit unit) => new(value, unit);

        public static LapseRate From(double? value, LapseRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(LapseRateUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public LapseRate ToUnit(LapseRateUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static LapseRate Zero => new(0, LapseRateUnit.SI);

        public static implicit operator LapseRate(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(LapseRateUnit.SI);
            return new(Unit);        
        }

        public static implicit operator LapseRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LapseRateUnit>(_unit);
	}
}

