/******************************************************************************
* Filename    = ILightControl.cs
*
* Author      = Nandhana Sunil
*
* Product     = Interface Segmentation Principle - Smart Home Devices
* 
* Project     = Assignment1
*
* Description = Interface for light bulbs to change color.
*****************************************************************************/

using System;
namespace ControlOptions;

/// <summary>
/// Sets the contract for light bulbs to change color.
/// </summary>
/// 
public interface ILightControls
{   /// <summary>
    /// Called to change the color of the light.
    /// </summary>
    /// <param name="color">The color to which the light of color should be set.</param>
    void ChangeColor(string color);
}
