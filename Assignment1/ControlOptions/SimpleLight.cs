/******************************************************************************
* Filename    = SimpleLight.cs
*
* Author      = Nandhana Sunil
* 
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Create simple lights which can be turned off and on.
*****************************************************************************/

using System;
namespace ControlOptions;

/// <summary>
/// SimpleLight class implements only ISwitchable interface.So lights can be switched on and off.
/// </summary>
public class SimpleLight : ISwitchable
{
    private bool _isOn;
    /// <summary>
    /// Used to switch on the light.
    /// </summary>
    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine("The light is switched on.");
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
    /// Used to check if the light is on or off.
    /// </summary>
    public bool IsOn()
    {
        return _isOn;
    }
}
