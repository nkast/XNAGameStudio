#3D Audio#

Area
Games: 2D Graphics, Games: Audio
Submitted
4/26/2007
Code Sample

---

Description:

This sample shows how to position sounds in 3D space by implementing panning, Doppler, and distance attenuation effects.

Sample Overview

3D audio is a bit more complicated than playing regular cues. It's not good enough to just "fire and forget" a 3D sound. As the listener or the entity that created a sound moves around the world, you must update the 3D audio settings to reflect these changes.

This sample demonstrates how to overcome this problem by implementing an AudioManager component that keeps track of cue instances and automatically updates their 3D settings.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Audio3D_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Audio3D_02_small.jpg)

	

Download | Size | Description
---|---|---|
[Audio3DSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/Audio3DSample_4_0.zip?raw=true) | 0.70MB | Source code and assets for the 3D Audio Sample (XNA Game Studio 4.0). 