#Shatter#

Area
Games: 3D Graphics, Games: Content Pipeline, Games: Graphics, Games: Shaders
Submitted
9/27/2007
Code Sample

---

Description:

This sample shows how you can apply an effect on any model in your game to shatter it apart. The effect is simulated with a vertex shader.

Sample Overview

The shatter effect operates on every triangle in the model independently. For every triangle in the model, the vertex shader rotates the vertices of the triangle around the x, y, and z axes by random velocities. At the same time, the triangle is translated along its normal. This creates the appearance of the entire model shattering outwards into small pieces. To get this effect to work properly, the model must be processed beforehand with a custom processor that derives from ModelProcessor.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_ShatterEffect_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_ShatterEffect_02_small.jpg)
	
Download | Size | Description
---|---|---|
[ShatterEffectSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ShatterEffectSample_4_0.zip?raw=true) | 11.41MB | Source code and assets for the Shatter Sample (XNA Game Studio 4.0). 