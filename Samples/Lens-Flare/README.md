#Lens Flare#

Area
Games: 3D Graphics, Games: Graphics
Submitted
1/17/2008
Code Sample

---

Description:

This sample shows how to implement a lens flare effect by using occlusion queries to detect when the sun is hidden behind the landscape.

Sample Overview

The visual phenomenon known as lens flare determines how bright lights behave when they shine into a camera lens. Computer games often have a hard time conveying an impression of brightness because monitors and televisions have only a limited brightness range. After all, it's impossible for a pixel to be brighter than white. How can you show the difference between a character wearing a white t-shirt, which is not very bright, and the sun, which is very bright indeed? The solution is to simulate what happens when a movie director points a camera directly at a bright light source. Games can simulate the flares that would be produced inside a physical camera. The flares provide a visual cue to the brightness of the light.

The lens flare effect in this sample is formed of two components: a large, soft glow, plus a row of smaller circular flare shapes.

The sample uses hardware occlusion queries to efficiently detect when the sun is hidden behind the landscape. This enables you to fade out the lens flare effect when the sun isn't visible.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_LensFlare_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_LensFlare_01_small.jpg)![XNA_LensFlare_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_LensFlare_02_small.jpg)

	
Download | Size | Description
---|---|---|
[LensFlareSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/LensFlareSample_4_0.zip?raw=true) | 1.57MB | Source code and assets for the Lens Flare Sample (XNA Game Studio 4.0). 