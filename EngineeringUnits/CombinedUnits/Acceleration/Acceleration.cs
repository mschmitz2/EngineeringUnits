using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class Acceleration : BaseUnit
{
    public Acceleration() { }
    public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(UnknownUnit value) : base(value) { }

    public static Acceleration From(double value, AccelerationUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Acceleration? From(double? value, AccelerationUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AccelerationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Acceleration ToUnit(AccelerationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Acceleration Zero => new(0, AccelerationUnit.SI);
    public static Acceleration NaN => new(double.NaN, AccelerationUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Acceleration?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AccelerationUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Acceleration? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AccelerationUnit>(_unit);
}
