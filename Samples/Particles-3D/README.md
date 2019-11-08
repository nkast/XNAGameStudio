#Particles 3D#

Area
Games: 3D Graphics, Games: Graphics, Games: Shaders
Submitted
5/24/2007
Code Sample

---

Description:

This sample shows how to implement a 3D particle system by using point sprites. It animates the particles entirely on the graphics card by using a custom vertex shader, so it can draw large numbers of particles with minimal CPU overhead.

Sample Overview

When displaying large numbers of particles, games can easily become bottlenecked by the amount of CPU work involved in updating everything and transferring the latest particle positions across to the GPU for drawing. This sample avoids that by animating particles entirely on the GPU, so the CPU overhead remains low regardless of how many particles are active. Moving eye candy to the GPU leaves the CPU free for other things, such as gameplay, physics, or AI.

When a new particle is created, the CPU fills a vertex structure with the position, velocity, and creation time. After this vertex is uploaded to the GPU, the CPU never needs to touch it again. Every frame, the current time is set as a vertex shader parameter. When the GPU draws the particles, it can work out the age of each one by comparing the creation time (which is stored as part of the vertex data) with the current time. Knowing the starting position, velocity, and age, the shader can then compute the current position and draw a point sprite at this location.

New particles are always added to the end of the vertex buffer, and old ones are removed from the start. Because all particles last the same amount of time, this means the active particles will always be grouped together in a consecutive region of the buffer, and so can all be drawn in a single call. The CPU is responsible for adding new particle vertices to the end of the buffer, and for retiring old ones from the start, but it doesn't need to do anything with the active particles in the middle of the buffer. Even games with thousands of particles typically only create and retire a few each frame, so the resulting CPU workload is very low.

Although this sample works in 3D, the same code can be used for efficient 2D particle systems by setting an orthographic matrix as the camera projection.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle3D_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle3D_02_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle3D_03_small.jpg)

		
Download | Size | Description
---|---|---|
[Particles3DSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/Particles3DSample_4_0.zip?raw=true) | 0.38MB | Source code and assets for the Particles 3D Sample (XNA Game Studio 4.0). 