﻿using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class SpecificEnergy : BaseUnit
    {

        public SpecificEnergy() { }
        public SpecificEnergy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(UnknownUnit value) : base(value) { }

        public SpecificEnergy(UnknownUnit value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static SpecificEnergy From(double value, SpecificEnergyUnit unit) => new(value, unit);
        public double As(SpecificEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificEnergy ToUnit(SpecificEnergyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificEnergy Zero => new(0, SpecificEnergyUnit.SI);

        public static implicit operator SpecificEnergy(UnknownUnit Unit) => new(Unit, SpecificEnergyUnit.SI);

        public static implicit operator SpecificEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
