/******************************************************************************
* Filename    = SmartLight.cs
*
* Author      = Nandhana Sunil
* 
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Create Smart lights which can be turned off and on, and color of light can be set.
*****************************************************************************/

using System;
namespace ControlOptions;

/// <summary>
/// SmartLight class implements ISwitchable and ILightControls interfaces.
/// These lights can change color and can be switched on and off.
/// </summary>
public class SmartLight : ISwitchable, ILightControls
{
    private string _lightColor;
    private bool _isOn;

    /// <summary>
    /// Constructor for creating a new light with default color as White.
    /// </summary>
    public SmartLight()
    {
        _lightColor = "White";
        _isOn = false;
    }

    /// <summary>
    /// Used to create a new light with a specific color.
    /// 
    public SmartLight(string color)
    {
        _lightColor = color;
        _isOn = false;
    }

    /// <summary>
    /// Used to switch on the light.
    /// </summary>
    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"The light is switched on with color {_lightColor}.");
    }

    /// <summary>
    /// Used to switch off the light.
    /// </summary>
    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine("The light is switched off.");
    }

    /// <summary>
    /// Used to change the color of the light.
    /// </summary>
    public void ChangeColor(string color)
    {
        if (!_isOn)
        {
            Console.WriteLine("The light is off. Please turn on the light to change its color.");
            return;
        }
        _lightColor = color;
        Console.WriteLine($"The light color is changed to {_lightColor}.");
    }

    /// <summary>
    /// Used to get the color of the light.
    /// </summary>
    public string GetColor()
    {
        if (!_isOn)
        {
            Console.WriteLine("The light is off. Please turn on the light to get its color.");
            return "No color - Light is off";
        }
        return _lightColor;
    }

    /// <summary>
    /// Checks if the light is on or off.
    /// </summary>
    public bool IsOn()
    {
        return _isOn;
    }
}
