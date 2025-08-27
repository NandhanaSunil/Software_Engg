/******************************************************************************
* Filename    = Fan.cs
*
* Author      = Nandhana Sunil
*
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Create Fans which can be turned on, off, and increase or decrease speeds.
*****************************************************************************/

using System;
namespace ControlOptions;

/// <summary>
/// Fan class implements ISwitchable and IFanControl interfaces.
/// These fans can be switched on or off and have their speed adjusted.
/// </summary>
public class Fan : ISwitchable, IFanControl
{
    private int _fanSpeed;
    private bool _isOn;

    /// <summary>
    /// Constructor for creating a fan with default speed 0 (off).
    /// </summary>
    public Fan()
    {
        _fanSpeed = 0;
        _isOn = false;
    }

    /// <summary>
    /// Turns the fan on. Default speed set to 1.
    /// </summary>
    public void TurnOn()
    {
        if (_isOn)
        {
            Console.WriteLine("The fan is already on.");
            return;
        }
        _isOn = true;
        _fanSpeed = 1;
        Console.WriteLine("The fan is switched on with speed = 1.");
    }

    /// <summary>
    /// Turns the fan off and sets speed to 0.
    /// </summary>
    public void TurnOff()
    {
        if (!_isOn)
        {
            Console.WriteLine("The fan is already off.");
            return;
        }
        _isOn = false;
        _fanSpeed = 0;
        Console.WriteLine("The fan is switched off.");
    }

    /// <summary>
    /// Increases the fan speed by the specified value.
    /// </summary>
    /// <param name="speed">The value to increase fan speed by.</param>
    public void IncreaseSpeed(int speed)
    {
        if (!_isOn)
        {
            Console.WriteLine("The fan is off. Please turn it on first.");
            return;
        }
        _fanSpeed += speed;
        Console.WriteLine($"The fan speed is increased by {speed}. Current speed: {_fanSpeed}.");
    }

    /// <summary>
    /// Decreases the fan speed by the specified value.
    /// </summary>
    /// <param name="speed">The value to decrease fan speed by.</param>
    public void DecreaseSpeed(int speed)
    {
        if (!_isOn)
        {
            Console.WriteLine("The fan is off. Please turn it on first.");
            return;
        }
        _fanSpeed -= speed;
        if (_fanSpeed < 0)
        {
            _fanSpeed = 0;
        }
        Console.WriteLine($"The fan speed is decreased by {speed}. Current speed: {_fanSpeed}.");
    }

    /// <summary>
    /// Gets the current fan speed.
    /// </summary>
    public int GetSpeed()
    {
        return _fanSpeed;
    }

    /// <summary>
    /// Checks if the fan is on or off.
    /// </summary>
    public bool IsOn()
    {
        return _isOn;
    }
}
