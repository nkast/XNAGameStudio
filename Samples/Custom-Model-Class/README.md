Custom Model Class
Area
Games: 3D Graphics, Games: Content Pipeline, Games: Graphics
Submitted
9/27/2007
Code Sample

Description:

This sample shows how to go beyond the limits of the Model class that comes built in to the XNA Framework, by loading geometry data into a custom class that can be extended more easily to cope with specialized requirements.

 

Sample Overview

The Model class that comes built into the XNA Framework provides a convenient way to load and display graphics, but it's not very flexible. Model can be extended in a limited manner by attaching custom data to the Tag property (in fact, many other samples such as the Skinned Model Sample and Picking with Triangle-Accuracy do just that), but beyond a certain point, trying to cajole Model into handling scenarios that it was never designed for can become more trouble than it's worth.

Fortunately, the layered design of the Content Pipeline makes it easy to replace Model with a custom (and hence more easily extensible) alternative. There's no need to alter the importer behavior, so our custom model replacement can still import data from standard file formats such as .X or .FBX. This sample implements a CustomModel class, along with a CustomModelProcessor that extracts the necessary geometry data from the NodeContent format that was output by the importer.

 

All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_CustomModelClass_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_CustomModelClass_01_small.jpg)![XNA_CustomModelClass_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_CustomModelClass_02_small.jpg) 
	

 
Download | Size | Description
---|---|---|
[CustomModelClassSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/CustomModelClassSample_4_0.zip?raw=true) | 1.98MB | Source code and assets for the Custom Model Class Sample (XNA Game Studio 4.0). 