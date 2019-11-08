#Particles Pipeline#

Area
Games: 2D Graphics, Games: Content Pipeline, Games: Graphics
Submitted
10/4/2010
Code Sample

---

Description:

This sample builds on the Particles 2D sample to allow authoring of particle effects in XML files, which makes creating new particle systems and modifying particle system parameters a much simpler task. Additionally, the sample adds a few extra features such as the ParticleEmitter class, which makes it easier to attach particle systems to game objects and to get a smooth spawning of particles as the object moves around.

Sample Overview

Particle systems are a technique for rendering special effects that are typically very fluid and organic. They are common in games, generally being used for smoke, fire, sparks, and splashes of water. For example, the explosions in Spacewar are particle systems.

A particle system consists of any number of small particles. Each particle has its own physical properties, typically including position, velocity, and acceleration. More complex particle systems may include even more properties. Particles are created and initialized with some initial properties determined by the overall particle system, but once the system has begun, the particles all act independently of one another. Particles are typically drawn as 2D alpha blended sprites. Once many of these independently updating particles are drawn on top of one another, the particle system has the appearance of a chaotic and natural system.

This sample's particle systems are based on the Spacewar particle system. However, they also demonstrate the use of up-front allocations to avoid garbage collections. Also, the particle systems have been changed from Spacewar's SceneItem to a DrawableGameComponent, so they can be easily plugged into any XNA Framework game.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Particle_02_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/particlespipeline.png)		
	  	 

Download | Size | Description
---|---|---|
[Particles2DPipeline_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/Particles2DPipeline_4_0.zip?raw=true) | 0.63MB | Source code and assets for the Particles Pipeline Sample (XNA Game Studio 4.0). 