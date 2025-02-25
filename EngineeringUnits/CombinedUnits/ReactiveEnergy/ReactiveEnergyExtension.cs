using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ReactiveEnergyUnitExtension
{

    public static ReactiveEnergy IfNullSetToZero(this ReactiveEnergy? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ReactiveEnergy.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ReactiveEnergy? Abs(this ReactiveEnergy? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               