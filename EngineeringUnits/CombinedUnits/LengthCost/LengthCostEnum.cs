namespace EngineeringUnits.Units;
public partial record LengthCostUnit : UnitTypebase
{
    public static readonly LengthCostUnit SI = new(CostUnit.SI, LengthUnit.SI);
    public static readonly LengthCostUnit USDollarPerMeter = new(CostUnit.USDollar, LengthUnit.Meter);
    public static readonly LengthCostUnit EuroPerMeter = new(CostUnit.Euro, LengthUnit.Meter);

    public LengthCostUnit(CostUnit cost, LengthUnit length)
    {
        UnitSystem localUnit = cost / length;
        var localSymbol = $"{cost}/{length}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
