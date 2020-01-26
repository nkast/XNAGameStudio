#WinForms Series 1: Graphics Device#

Area
Games: Graphics
Submitted
1/10/2008
Code Sample

---

Description:

This sample shows you how to use an XNA Framework GraphicsDevice object to display 3D graphics inside a WinForms application.

Sample Overview

The XNA Framework Game class provides a quick, easy, and portable way to host your game. It automatically creates a window for the game to run inside, initializes the graphics hardware, and offers simple Update and Draw methods for you to override. Sometimes the Game behavior just isn't flexible enough, though. Perhaps you want more control over how the window is created, or maybe you're writing a level editor and want to place Windows user interface controls around the 3D drawing surface.

Fortunately, the XNA Framework was designed with these scenarios in mind. The framework is actually made up of two separate assemblies: Microsoft.Xna.Framework provides core functionality such as the math, graphics, input, and audio classes, and Microsoft.Xna.Framework.Game provides optional higher-level code such as the Game class. If you want to host your game in some other way, you can replace the functionality from Microsoft.Xna.Framework.Game with your own code.

This sample implements a GraphicsDeviceControl class, which inherits from System.Windows.Forms.Control and provides the ability for a WinForms control to draw itself by using an XNA Framework GraphicsDevice object. It demonstrates how to share a single GraphicsDevice object among multiple controls, how to handle resizing and lost devices, and how to implement the IGraphicsDeviceService interface in order to support loading data through the ContentManager.

Note that this sample runs only on Windows. WinForms isn't available on Xbox 360.

Other items in the Winforms Series

[WinForms Series 2: Content Loading](https://github.com/nkast/XNAGameStudio/tree/master/Samples/WinForms-Series-2-Content-Loading/)


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_WinForms1_GraphicsDevice_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_WinForms1_GraphicsDevice_01_small.jpg)![XNA_WinForms1_GraphicsDevice_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_WinForms1_GraphicsDevice_02_small.jpg)
	

Download | Size | Description
---|---|---|
[WinFormsGraphicsSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/WinFormsGraphicsSample_4_0.zip?raw=true) | 0.04MB | Source code and assets for the WinForms Series 1: Graphics Device Sample (XNA Game Studio 4.0). 