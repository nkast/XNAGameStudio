#What's New for Games (Mango)#

Submitted
5/24/2011
Article

---

This document aims to call out a few of the changes in Windows Phone OS 7.1 and Windows Phone Developer Tools that affect game developers. For a more complete list of new features and APIs coming to Windows Phone OS 7.1, see What’s New in [Windows Phone Developer Tools on MSDN](http://msdn.microsoft.com/en-us/library/ff637516(v=VS.92).aspx)

##Integration of Silverlight and the XNA Framework##

One of the largest new features is the ability to leverage Silverlight and the XNA Framework rendering APIs in the same application. This enables a wide range of new scenarios, such as games that use the WebBrowser control to perform Open Authentication for social network integration and applications that display GPU-accelerated 2D and 3D content.

For a guide on migrating from the XNA Game Studio Game class to the integrated Silverlight/XNA Framework application model, see [Migration Guide: Moving from the Game class to Silverlight/XNA](http://xbox.create.msdn.com/education/catalog/article/migration_guide_moving_to_silverlight_xna). For examples of Silverlight/XNA Framework integration, see our new educational content: [Paddle Battle](), [Model Viewer Demo]() and [Silverlight/XNA Game Components]().

##The Execution Model and Fast App Switching##

Fast application switching is a general change in the way application lifetime is managed on Windows Phone. With the new changes to the execution model, titles are no longer implicitly terminated by another application or an interruption (such as a phone call). Titles may remain in the background and be reactivated without needing to pass-through the exit and resume states, though titles may still be terminated based on resource needs and time since deactivation.

For games, this model means that users can return to their home screens, take phone calls, or browse the web before returning to your game quickly and easily. As long as sufficient device resources are available, your game can resume quickly without needing to reload content or game state from storage.

For more information, see [Execution Model Overview on MSDN](http://msdn.microsoft.com/en-us/library/ff817008(v=VS.92).aspx).

##Windows Phone Profiler##

Now included in the Windows Phone Developer Tools is a code and memory profiler that allows developers to analyze the performance of their games and applications. This includes support for CPU and memory profiling for XNA Game Studio titles as well as a visual profiling system for Silverlight applications.

For more information about the profiler, see [Windows Phone Profiler on MSDN](http://msdn.microsoft.com/en-us/library/hh202934(v=VS.92).aspx).

##Combined Motion API##

Windows Phone hardware now supports the inclusion of compass and gyroscope, and there are new APIs to access these features individually, alongside the existing accelerometer. However there is also a new API in Windows Phone that makes it easier to build games and applications that leverage these sensors.

The new Combined Motion API combines accelerometer, gyroscope, and compass into a higher level processed data structure, making it great for games that take advantage of a mobile device’s orientation and movement.

For more information about the Combined Motion API, see the How to: [Use the Combined Motion API for Windows Phone on MSDN](http://msdn.microsoft.com/en-us/library/hh202984(v=VS.92).aspx).

##More New Features##

As mentioned in the introduction, this document describes only a subset of the new features in Windows Phone OS 7.1 and Windows Phone Developer Tools. For the complete list, see [What’s New in Windows Phone Developer Tools on MSDN](http://msdn.microsoft.com/en-us/library/ff637516(v=VS.92).aspx).
