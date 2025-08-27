/******************************************************************************
* Filename    = IFanControl.cs
*
* Author      = Nandhana Sunil
*
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Interface for fan to adjust speed.
*****************************************************************************/

using System;

namespace ControlOptions;

/// <summary>
/// Sets the contract for fan controls to adjust speed.
/// </summary>
public interface IFanControl
{
    /// <summary>
    /// Called to increase the speed of the fan.
    /// </summary>
    /// <param name="speed">The value of speed to which the fan speed should be increased by.</param>
    void IncreaseSpeed(int speed);

    /// <summary>
    /// Called to increase the speed of the fan.
    /// </summary>
    /// <param name="speed">The value of speed to which the fan speed should be decreased by.</param>
    void DecreaseSpeed(int speed);
}
