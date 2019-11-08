#Shadow Mapping#

Area
Games: 3D Graphics, Games: Content Pipeline, Games: Graphics, Games: Shaders
Submitted
8/29/2008
Code Sample

---

Description:

This sample shows you how to implement basic shadow mapping from a directional light where the view and projection of the shadow map adapt to the viewing frustum of the viewer's camera. You can use the sample to shadow a large scene with multiple dynamic objects that cast dynamic shadows

Sample Overview

Shadow mapping refers to a shadowing technique where you can use a texture to store an object's distance from a light. When you render the scene, you can then use the distance from the light to determine whether the pixel being rendered is behind the value stored in the shadow map.

All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).


		
![XNA_ShadowMapping_01_small.JPG](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_ShadowMapping_01_small.JPG)![XNA_ShadowMapping_02_small.JPG](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_ShadowMapping_02_small.JPG)![XNA_ShadowMapping_03_small.JPG](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_ShadowMapping_03_small.JPG)
 

 
Download | Size | Description
---|---|---|
[ShadowMappingSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ShadowMappingSample_4_0.zip?raw=true) | 21.61MB | Source code and assets for the Shadow Mapping Sample (XNA Game Studio 4.0). 