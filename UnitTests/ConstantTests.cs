﻿using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class ConstantTests
{

    //Create a tests for the Constants
    [TestMethod]
    public void GravitationalConstant_Test()
    {
        // Arrange
        EngineeringUnits.BaseUnit unit = Constants.GravitationalConstant;

        // Act
        var value = unit.As(ForceUnit.Newton);

        // Assert
        Assert.AreEqual(0.0000000000667408, value);
    }
}
