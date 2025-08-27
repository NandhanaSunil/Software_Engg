/******************************************************************************
* Filename    = ISwitchable.cs
*
* Author      = Nandhana Sunil
*
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Interface for devices to turn on and off.
*****************************************************************************/

using System;
namespace ControlOptions;

/// <summary>
/// Sets the contract for devices to switch on and off.
/// </summary>

public interface ISwitchable
{
    /// <summary>
    /// The devices can be switched on or off. This interface is used for that.
    /// </summary>
    /// <param name="temperature">The value of temperature to which the temperature has to be set.</param>
    /// 
    void TurnOn();
    void TurnOff();
}
