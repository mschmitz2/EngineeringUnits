using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricChargeUnitExtension
{

    public static ElectricCharge IfNullSetToZero(this ElectricCharge? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricCharge.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricCharge? Abs(this ElectricCharge? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               