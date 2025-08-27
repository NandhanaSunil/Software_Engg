/******************************************************************************
 * Filename    = SmartLightUnitTest.cs
 *
 * Author      = Nandhana Sunil
 *
 * Product     = Interface Segmentation Principle - Smart Home Devices
 * 
 * Project     = Assignment1
 *
 * Description = Unit tests for the Smart lights.
 *****************************************************************************/

using System.Dynamic;
using System.Linq;
using ControlOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace UnitTest;

/// <summary>
/// Unit tests for the SmartLight class.
/// </summary>
[TestClass]
public class SmartLightUnitTests
{
    /// <summary>
    /// Tests TurnOn function of light.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestSmartLightOn()
    {
        Logger.LogMessage("Running TestSmartLightOn");
        SmartLight light = new SmartLight();
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
    public void TestSmartLightOff()
    {
        Logger.LogMessage("Running TestSmartLightOff");
        SmartLight light = new SmartLight();
        light.TurnOn();
        light.TurnOff();
        bool isOn = light.IsOn();

        Assert.AreEqual(false, isOn);
    }

    /// <summary>
    /// Tests default color is set to white.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestSmartLightDefault()
    {
        Logger.LogMessage("Running TestSmartLightDefault");
        SmartLight light = new SmartLight();
        light.TurnOn();
        string lightColor = light.GetColor();
        light.TurnOff();

        Assert.AreEqual("White", lightColor);
    }

    /// <summary>
    /// Tests color is set to argument given to constructor.
    /// </summary>
    [TestMethod]
    [Owner("Nandhana Sunil")]
    [Priority(1)]
    public void TestSmartLightColor()
    {
        Logger.LogMessage("Running TestSmartLightColor");
        SmartLight light = new SmartLight("Red");
        light.TurnOn();
        string lightColor = light.GetColor();
        light.TurnOff();

        Assert.AreEqual("Red", lightColor);
    }
}
