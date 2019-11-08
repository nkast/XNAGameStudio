#Tiled Sprites (ARCHIVED)#

Area
Games: 2D Graphics, Games: Graphics
Submitted
2/19/2007
Code Sample

---

Note: This item is no longer supported. It may demonstrate techniques that are no longer valid in current versions of XNA Game Studio. The item is archived here, but will not be updated.

Description: 

This sample shows how to manage data for tiling, animation, visibility determination, and virtualization of a 2D camera. 

Sample Overview

A common technique for getting the most mileage out of sprites is to use grids of sprite "tiles" to reduce the amount of texture data needed at any one time to draw a scene. Tiles are individual sprites that are repeated to create a composite 2D image. Often, multiple source tiles are stored in a single texture, sometimes called a sprite sheet.

Although a game level might have tens of thousands of tiles in the game world, only those that are visible should be drawn. Otherwise, you see a severe performance hit for submitting more draw calls than are needed to render the scene.

To simplify interactions with the tiles in the game world, the sample provides a 2D Camera implementation. You will find a camera abstraction useful, particularly when rotating or zooming the world. This enables you to rapidly translate screen space to world space.

Sprite animation is a similar data management task to tiling, since several source sprites make up multiple frames of an animation. This sample shows a way to quickly generate a series of animation frames from a sprite sheet and step through the animation.


All content and source code downloaded from this page is bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_TiledSprites_01_small.jpg)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_TiledSprites_02_small.jpg)

		 
Download | Size | Description
---|---|---|
[TiledSpritesSample_ARCHIVE_3_1.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/TiledSpritesSample_ARCHIVE_3_1.zip?raw=true) | 0.06MB | Source code and assets for the Tiled Sprites Sample (XNA Game Studio 3.1, Archived). 