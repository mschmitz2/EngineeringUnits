using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricResistivity : BaseUnit
{
    public ElectricResistivity() { }
    public ElectricResistivity(decimal value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(double value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(int value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(UnknownUnit value) : base(value) { }

    public static ElectricResistivity From(double value, ElectricResistivityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricResistivity? From(double? value, ElectricResistivityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricResistivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricResistivity ToUnit(ElectricResistivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricResistivity Zero => new(0, ElectricResistivityUnit.SI);
    public static ElectricResistivity NaN => new(double.NaN, ElectricResistivityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricResistivity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricResistivityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricResistivity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricResistivityUnit>(_unit);
}
