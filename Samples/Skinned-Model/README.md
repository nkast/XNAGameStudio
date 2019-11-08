#Skinned Model#

Area
Games: 3D Graphics, Games: Content Pipeline, Games: Graphics, Games: Shaders
Submitted
2/19/2007
Code Sample

---

Description:

This sample shows how to process and render a skinned character model by using the XNA Framework Content Pipeline.
 

Sample Overview

Out of the box, the XNA Framework provides only partial support for animation. It defines an intermediate object model for storing animation data inside the Content Pipeline, and can import data into this object model from FBX and X formats. The built-in ModelProcessor also converts vertex channels of BoneWeightCollection data into pairs of channels with VertexElementUsage BlendIndices and BlendWeight, suitable for skinned rendering on the GPU. However, the framework doesn't include any runtime animation classes. That functionality is implemented by this sample.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).
	
![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Skinning_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Skinning_02_small.jpg)	

 
Download | Size | Description
---|---|---|
[SkinningSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/SkinningSample_4_0.zip?raw=true) | 9.59MB | Source code and assets for the Skinned Model Sample (XNA Game Studio 4.0). 