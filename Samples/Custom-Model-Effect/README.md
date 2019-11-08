#Custom Model Effect#

Area
Games: Content Pipeline, Games: Graphics, Games: Shaders
Submitted
2/19/2007
Code Sample

---

Description:

This sample shows how custom effects can be applied to a model by using the XNA Framework Content Pipeline.

 

Sample Overview

This sample demonstrates how to use a custom effect to render a model with a static environment cube map, creating a shiny, reflective surface. The sample uses two custom content pipeline processors.

The first processor applies the environment mapping effect to the model during the content build process. The runtime code doesn't then have to do anything special to render by using the custom effect, because the model will be loaded in automatically with the new effect set up and ready to use.

The second custom content pipeline processor converts a regular 2D photograph into a cube map that can be used for the environment mapping.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).


![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_CustomModelEffect_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_CustomModelEffect_02_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_CustomModelEffect_03_small.jpg)		

 
Download | Size | Description
---|---|---|
[CustomModelEffectSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/CustomModelEffectSample_4_0.zip?raw=true) | 0.94MB | Source code and assets for the Custom Model Effect Sample (XNA Game Studio 4.0). 