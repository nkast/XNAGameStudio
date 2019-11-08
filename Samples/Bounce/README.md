#Bounce#

Area
Games: 3D Graphics, Games: Collision, Games: Physics
Submitted
8/4/2010
Code Sample

---

Description:

The bounce sample draws and physically simulates 100 spheres of varying size, mass, and weight.

Sample Overview

The physics simulation uses an implicit solver for collision detection and response. An implicit solver was chosen for its stability and speed. The spheres are modeled with some elasticity, and the simulation loses energy by simulating air friction. The sphereCollisionImplicit function contains the physics algorithm for collision detection and response.

The simulation is affected by the accelerometer, which generates a gravity vector. This enables the user to tilt the simulated world by tilting the phone. The input-driven gravity vector is bound to reasonable thresholds. Beyond the tilt-driven gravity vector, the update loop also detects shake input gestures. These add energy to each ball, causing the balls to accelerate rapidly. The input code is found in the UpdateSpheres function.  

The primary rendering takes place in the Draw function. Each sphere draws a shadow by redrawing itself with a modified transformation matrix with a flat Y axis and Y position fixed at the ground plane. The spheres themselves are procedurally generated and use vertex lighting. See SpherePrimitive.cs for details about this implementation.

When using the Emulator, the Y axis will be inverted when the emulator is rotated to the right, which results in the input controls being reversed along the Y axis.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

 
![](https://github.com/nkast/XNAGameStudio/blob/master/Images/Bounce1.png)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/Bounce2.png)	

 

 
Download | Size | Description
---|---|---|
[BounceSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/BounceSample_4_0.zip?raw=true) | 0.06MB | Source code and assets for the Bounce Sample (XNA Game Studio 4.0). 