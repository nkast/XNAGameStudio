#Particles#

Area
Games: 2D Graphics, Games: Graphics
Submitted
4/26/2007
Code Sample

---

Description:

This sample introduces the concept of a particle system, and shows how to draw particle effects by using SpriteBatch. Two particle effects are demonstrated: an explosion and a rising plume of smoke.

Sample Overview

Particle systems are a technique for rendering special effects that are typically very fluid and organic. They are common in games, generally being used for smoke, fire, sparks, and splashes of water.

A particle system consists of any number of small particles. Each particle has its own physical properties, typically including position, velocity, and acceleration. More complex particle systems may include even more properties. Particles are created and initialized with some initial properties determined by the overall particle system, but once the system has begun, the particles all act independently of one another. Particles are typically drawn as 2D alpha blended sprites. Once many of these independently updating particles are drawn on top of one another, the particle system has the appearance of a chaotic and natural system.

This sample demonstrates the use of up-front allocations to avoid garbage collections. Also, the particle systems inherit from DrawableGameComponent, so they can be easily plugged into any XNA Framework game.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle_02_small.jpg)

	

Download | Size | Description
---|---|---|
[ParticleSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ParticleSample_4_0.zip?raw=true) | 0.47MB | Source code and assets for the Particles Sample (XNA Game Studio 4.0) 