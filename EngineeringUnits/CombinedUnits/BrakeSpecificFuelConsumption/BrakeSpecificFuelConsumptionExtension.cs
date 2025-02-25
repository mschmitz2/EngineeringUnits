using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class BrakeSpecificFuelConsumptionUnitExtension
{

    public static BrakeSpecificFuelConsumption IfNullSetToZero(this BrakeSpecificFuelConsumption? local)
    {
        if (local is not null)
        {
            return local;
        }

        return BrakeSpecificFuelConsumption.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static BrakeSpecificFuelConsumption? Abs(this BrakeSpecificFuelConsumption? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               