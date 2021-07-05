using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ApparentEnergyTest
    {

        [TestMethod]
        public void ApparentEnergyAutoTest()
        {
            var A1 = new UnitsNet.ApparentEnergy(1, UnitsNet.Units.ApparentEnergyUnit.MegavoltampereHour);
            var A2 = new EngineeringUnits.ApparentEnergy(1, EngineeringUnits.ApparentEnergyUnit.MegavoltampereHour);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ApparentEnergyUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.ApparentEnergy.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.ApparentEnergyUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(3, WorkingCompares);

        }
    }
}