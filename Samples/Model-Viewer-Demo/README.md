#Model Viewer Demo (Mango)#

Area
Controls, Games: 2D Graphics, Games: Graphics, User Experience
Submitted
5/24/2011
Code Sample

---

##Description:##

This sample showcases a complex application built on top of the Silverlight/XNA application model, leveraging full 3D rendering, Silverlight’s animation engine, and the use of dependency properties to act as the proxy between Silverlight UI and the XNA Framework based rendering system.

##Sample Overview##

The new Silverlight/XNA feature for Windows Phone OS 7.1 opens a lot of possibilities for application developers. Aside from using Silverlight to render the UI for games, you can also build complex applications leveraging 3D graphics. This sample is one such example, showing an application that allows the viewing of a tank model while having lots of control over the display of the tank.

Please note that this sample was written as a demonstration of the Silverlight/XNA feature. It is not intended to be a beginner’s example to the feature and is intended for developers with some level of familiarity with both Silverlight and the XNA Framework. If you are just getting started with Silverlight or XNA Game Studio and want to see a simpler example of the Silverlight/XNA integration, please take a look at our Paddle Battle sample.

The sample demonstrates a lot of features throughout the application and takes advantage of many features from both Silverlight and XNA Game Studio to make it happen. Here are a few of those features broken down into more detail:

##3D Rendering with XNA Framework##

The core of the application is the 3D rendering of a tank model with the ability to toggle a number of animations, change how the tank is rendered, and adjust properties of the lights affecting the model. Under the covers this is implemented through the Renderer class which reads information from the RendererState and draws the tank.

The RendererState and associated LightState objects are DependencyObjects that contain information regarding how to render the scene, such as the camera’s location, which animations are active, and the properties of the lights in the scene. The state objects subclass DependencyObject and expose a large number of dependency properties to enable databinding directly to the Silverlight UI. This greatly reduces the need for complex code behinds. Additionally the dependency properties enable any of the rendering state values to be animated with Storyboards.

##Page Navigation##

The sample takes advantage of the built in page navigation system of Silverlight on Windows Phone, breaking each section of application functionality into a new page. This enables very consolidated pieces of functionality and is much easier to work with than trying to maintain all the application’s state on a single page.

In addition to the basic system of pages, the sample also leverages its own BasePage class which provides a lot of common functionality to pages, such as full screen UIElementRenderer support for drawing Silverlight UI on top of the screen as well as invoking the 3D rendering system.

##Storyboard Animation##

The sample takes advantage of the Silverlight Storyboard animation system to drive the movement of the camera in between pages. By leveraging dependency properties on the RendererState, the app creates a Storyboard with a few animations and attaches them to the camera properties of the state object. Silverlight then takes care of all the animations, including applying animation curves. All of this is retrieved by the Renderer through the RendererState object.

All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/model viewer 1_small.png)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/model viewer 2_small.png)
	
Download | Size | Description
---|---|---|
[ModelViewerDemo_4_0_Mango.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ModelViewerDemo_4_0_Mango.zip?raw=true) | 6.83MB | Source code and assets for the Model Viewer Demo.