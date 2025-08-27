/******************************************************************************
 * Filename    = FanUnitTest.cs
 *
 * Author      = Nandhana Sunil
 *
 * Product     = Interface Segmentation Principle - Smart Home Devices
 * 
 * Project     = Assignment1
 *
 * Description = Unit tests for the Fan class.
 *****************************************************************************/

using ControlOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace UnitTest;

/// <summary>
/// Unit tests for the Fan class.
/// </summary>
[TestClass]
public class FanUnitTests
{
    /// <summary>
    /// Tests TurnOn function of fan.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestFanOn()
    {
        Logger.LogMessage("Running TestFanOn");
        Fan fan = new Fan();
        fan.TurnOn();
        bool isOn = fan.IsOn();
        fan.TurnOff();

        Assert.AreEqual(true, isOn);
    }

    /// <summary>
    /// Tests TurnOff function of fan.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestFanOff()
    {
        Logger.LogMessage("Running TestFanOff");
        Fan fan = new Fan();
        fan.TurnOn();
        fan.TurnOff();
        bool isOn = fan.IsOn();

        Assert.AreEqual(false, isOn);
    }

    /// <summary>
    /// Tests increasing fan speed.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestFanIncreaseSpeed()
    {
        Logger.LogMessage("Running TestFanIncreaseSpeed");
        Fan fan = new Fan();
        fan.TurnOn();
        int initialSpeed = fan.GetSpeed();

        fan.IncreaseSpeed(1);
        int newSpeed = fan.GetSpeed();
        fan.TurnOff();

        Assert.AreEqual(initialSpeed + 1, newSpeed);
    }

    /// <summary>
    /// Tests decreasing fan speed.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestFanDecreaseSpeed()
    {
        Logger.LogMessage("Running TestFanDecreaseSpeed");
        Fan fan = new Fan();
        fan.TurnOn();
        int speedBefore = fan.GetSpeed();

        fan.DecreaseSpeed(1);
        int speedAfter = fan.GetSpeed();
        fan.TurnOff();

        Assert.AreEqual(speedBefore - 1, speedAfter);
    }
}
