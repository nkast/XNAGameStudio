#Sprite Sheet#

Area
Games: 2D Graphics, Games: Content Pipeline, Games: Graphics
Submitted
1/10/2008
Code Sample

---

Description: 

This sample shows how to implement sprite sheets, combining many separate sprite images into a single larger texture that will be more efficient for graphics hardware.

Sample Overview

Manually combining sprite images into larger sheets works well if you have just a few sprites, but it quickly becomes a burden as your game grows larger. When you have hundreds of sprites, it can be laborious to manually pack them all into a single sprite sheet texture, and then to remember where you put each image so that you know what source rectangle to pass to SpriteBatch.Draw in your game code.

This sample automates the process of creating sprite sheets by using a custom content processor. You provide an XML file listing any number of individual bitmap files, one per sprite. The processor reads all these bitmaps, packs them into a single larger texture, and saves this new texture along with information recording which source rectangle should be used for each sprite. You can then look up your sprites by name, rather than having to remember the specific coordinates for each image.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_SpriteSheet_01_small.JPG](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_SpriteSheet_01_small.JPG)

Download | Size | Description
---|---|---|
[SpriteSheetSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/SpriteSheetSample_4_0.zip?raw=true) | 0.14MB | Source code and assets for the Sprite Sheet Sample (XNA Game Studio 4.0). 