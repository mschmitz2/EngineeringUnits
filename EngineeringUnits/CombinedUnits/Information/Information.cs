using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class Information : BaseUnit
{
    public Information() { }
    public Information(decimal value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Information(double value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Information(int value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Information(UnknownUnit value) : base(value) { }

    public static Information From(double value, InformationUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Information? From(double? value, InformationUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(InformationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Information ToUnit(InformationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Information Zero => new(0, InformationUnit.SI);
    public static Information NaN => new(double.NaN, InformationUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Information?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, InformationUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Information? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<InformationUnit>(_unit);
}
