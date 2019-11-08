#Non-Realistic Rendering#

Area
Games: Graphics, Games: Postprocessing, Games: Shaders
Submitted
6/28/2007
Code Sample

---

Description:

This sample shows how to implement stylized, non-photorealistic rendering techniques, such as cartoon shading, edge detection, and a pencil sketch effect.

Sample Overview

The sample provides three specialized rendering techniques.

    Toon shading displays models using a banded lighting technique. Rather than the usual smooth gradients from light to dark, it uses just three discrete levels of brightness, with sudden transitions where the object goes from light into shadow.
    Edge detection adds black lines around the silhouette of the model.
    The sketch postprocess adds a pencil stroke pattern over the top of the scene.

Many graphical effects can be achieved by combining these techniques in various ways. For instance, a cartoon effect is created by using the toon shading and edge detection together, or a pencil sketch effect by combining edge detection with the sketch postprocess.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_NonRealisticRendering_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_NonRealisticRendering_02_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_NonRealisticRendering_03_small.jpg)

		

Download | Size | Description
---|---|---|
[NonPhotoRealisticSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/NonPhotoRealisticSample_4_0.zip?raw=true) | 3.65MB | Source code and assets for the Non-Realistic Rendering Sample (XNA Game Studio 4.0). 