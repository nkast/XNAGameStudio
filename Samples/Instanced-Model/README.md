#Instanced Model#

Area
Games: 3D Graphics, Games: Graphics, Games: Shaders
Submitted
9/27/2007
Code Sample

---

Description:

This sample shows how to efficiently render many copies of the same model by using GPU instancing techniques to reduce the cost of repeated draw calls.


Sample Overview

Games often must render many copies of the same model, for instance by covering a landscape with trees or by filling a room with crates. The calls needed to render a model are relatively expensive and can quickly add up if you're drawing hundreds or thousands of models. This sample demonstrates several techniques you can use to reduce the overhead of drawing many copies of the same model.

There's no single perfect instancing technique. Instancing must be implemented differently on Windows compared to Xbox 360, and on Windows the ideal technique requires shader 3.0, but there's a fallback approach that will work with shader 2.0. This sample implements several different instancing techniques, so it can work on both platforms and shader versions.

These instancing techniques can dramatically reduce the amount of CPU work required to draw models; however, they will make little difference or may even slightly increase the GPU cost. The CPU cost of drawing a model is constant regardless of how complex the model may be, but the GPU cost increases in proportion to the number of triangles and the shader complexity. For this reason, drawing low polygon models with simple shaders is likely to be limited mainly by CPU performance, while more detailed meshes are likely to be bottlenecked on the GPU side. If the GPU is your bottleneck, there's nothing to be gained from using these instancing techniques. Also, if your models are large and complex, the memory overhead required to instance them may be prohibitive. Instancing yields the most dramatic performance gains when used with relatively small and simple models, typically 1,000 or fewer triangles.

Instancing requires the vertex and index data to be organized in a particular way. The Model class that comes built into the XNA Framework isn't flexible enough to properly support instanced rendering, so this sample implements an alternative InstancedModel class. A custom Content Pipeline processor is used to convert model data from input file formats such as .X and .FBX into our InstancedModel class. See the [Custom Model Class](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Custom-Model-Class/) sample for more information about how this works.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_MeshInstancing_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_MeshInstancing_01_small.jpg)![XNA_MeshInstancing_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_MeshInstancing_02_small.jpg)
	

Download | Size | Description
---|---|---|
[InstancedModelSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/InstancedModelSample_4_0.zip?raw=true) | 0.31MB | Source code and assets for the Instanced Model Sample (XNA Game Studio 4.0). 