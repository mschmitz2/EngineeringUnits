using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class SpecificThermalResistance : BaseUnit
{
    public SpecificThermalResistance() { }
    public SpecificThermalResistance(decimal value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(double value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(int value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(UnknownUnit value) : base(value) { }

    public static SpecificThermalResistance From(double value, SpecificThermalResistanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static SpecificThermalResistance? From(double? value, SpecificThermalResistanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SpecificThermalResistanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificThermalResistance ToUnit(SpecificThermalResistanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificThermalResistance Zero => new(0, SpecificThermalResistanceUnit.SI);
    public static SpecificThermalResistance NaN => new(double.NaN, SpecificThermalResistanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificThermalResistance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SpecificThermalResistanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificThermalResistance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificThermalResistanceUnit>(_unit);
}
