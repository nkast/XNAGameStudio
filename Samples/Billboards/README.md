#Billboards#

Area
Games: 3D Graphics, Games: Graphics, Games: Shaders
Submitted
2/19/2007
Code Sample

---

Description:

This sample shows how to efficiently render large numbers of billboard sprites by using a vertex shader to perform the billboard computations entirely on the GPU.

Sample Overview

A billboard is a way of faking complex objects without bothering to render a full 3D model. The idea is that where the 3D object would have been, you simply render a 2D sprite with a picture of the object textured onto it. If the player moves around to look at the object from a different direction, you rotate the sprite so that it will always face toward the camera, thus preventing the player from ever seeing it "edge on" and being able to tell that it is just a 2D image.

This technique is obviously not as convincing as rendering a true 3D model, but it can be much faster, especially for large numbers of objects such as the field of grass shown in this sample. By moving the camera around, you can get an idea of what situations the billboards look good in, and also where the illusion starts to break down.

Because this billboard implementation runs entirely in the vertex shader, there is no additional CPU load from rendering billboards compared to normal static geometry. This makes it feasible to render very large numbers of billboards at a good framerate.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Billboard_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Billboard_02_small.jpg)

	

Download | Size | Description
---|---|---|
[BillboardSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/BillboardSample_4_0.zip?raw=true) | 0.42MB | Source code and assets for the Billboard Sample (XNA Game Studio 4.0). 