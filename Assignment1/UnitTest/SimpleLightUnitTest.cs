/******************************************************************************
 * Filename    = SimpleLightUnitTest.cs
 *
 * Author      = Nandhana Sunil
 *
 * Product     = Interface Segmentation Principle - Smart Home Devices
 * 
 * Project     = Assignment1
 *
 * Description = Unit tests for the Simple lights.
 *****************************************************************************/

using System.Dynamic;
using System.Linq;
using ControlOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace UnitTest;

/// <summary>
/// Unit tests for the SimpleLight class.
/// </summary>
[TestClass]
public class SimpleLightUnitTests
{
    /// <summary>
    /// Tests TurnOn function of light.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestSimpleLightOn()
    {
        Logger.LogMessage("Running TestSimpleLightOn");
        SimpleLight light = new SimpleLight();
        light.TurnOn();
        bool isOn = light.IsOn();
        light.TurnOff();

        Assert.AreEqual(true, isOn);
    }

    /// <summary>
    /// Tests TurnOff function of light.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestSimpleLightOff()
    {
        Logger.LogMessage("Running TestSimpleLightOff");
        SimpleLight light = new SimpleLight();
        light.TurnOn();
        light.TurnOff();
        bool isOn = light.IsOn();

        Assert.AreEqual(false, isOn);
    }
}
