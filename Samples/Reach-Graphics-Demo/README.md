#Reach Graphics Demo#

Area
Games: 2D Graphics, Games: 3D Graphics
Submitted
3/31/2010
Code Sample

---

This demo was shown at the GDC and MIX 2010 conferences, showing XNA Game Studio 4.0 graphics capabilities on Windows Phone 7. 

Demo Overview

This demo contains projects for both Windows and Windows Phone 7. To build and run it, you must first download the Windows Phone Developer Tools, which includes XNA Game Studio 4.0.

The demo has a menu for switching between the palette of five built-in effects which are supported by Windows Phone 7: BasicEffect, DualTextureEffect, AlphaTestEffect, SkinnedEffect, and EnvironmentMapEffect. Also included is a 2D particle system, which uses SpriteBatch. Most of the demos provide further menu options for altering their settings, which can be clicked with the mouse or dragged from left to right to change the value of a slider bar. Some demos also support camera adjustment by clicking and dragging on the background.

If you leave the demo running without moving the mouse, it will enter an 'attract' mode, where it automatically cycles through the different modes.

This sample was originally developed as a demo for MIX; you can see the sample in action during the second half of the Building a High Performance 3D Game For Windows Phone talk from MIX10.

Credits

Much of the code in this demo, especially the custom content processors that are used to prepare the graphics content, is borrowed from existing XNA Game Studio samples. Specifically:

[Skinned Model](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Skinned-Model/) 	*SkinnedModelProcessor, SkinningData, Keyframe, AnimationPlayer, and AnimationClip*

[Custom Model Effect](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Custom-Model-Effect/) 	*EnvironmentMappedModelProcessor, EnvironmentMappedMaterialProcessor, and CubemapProcessor*

[Generated Geometry](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Generated-Geometry/) 	*SkyProcessor, SkyContent, and Sky*

[Sprite Effects](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Sprite-Effects/) 	*TexturePlusAlphaProcessor*

[Simple Animation](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Simple-Animation/) 	*Tank class*

All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).


Download | Size | Description
---|---|---|
[ReachGraphicsDemo_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ReachGraphicsDemo_4_0.zip?raw=true) | 7.12MB | Source code and assets for the Reach Graphics Demo (XNA Game Studio 4.0). 