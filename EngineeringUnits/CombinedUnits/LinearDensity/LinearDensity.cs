using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class LinearDensity : BaseUnit
{
    public LinearDensity() { }
    public LinearDensity(decimal value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearDensity(double value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearDensity(int value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearDensity(UnknownUnit value) : base(value) { }

    public static LinearDensity From(double value, LinearDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LinearDensity? From(double? value, LinearDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LinearDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LinearDensity ToUnit(LinearDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LinearDensity Zero => new(0, LinearDensityUnit.SI);
    public static LinearDensity NaN => new(double.NaN, LinearDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LinearDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LinearDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LinearDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LinearDensityUnit>(_unit);
}
