#Graphics Profile Checker#

Area
Games: Graphics
Submitted
11/30/2010
Tool

---

Sample Overview

The XNA Framework GraphicsAdapter.IsProfileSupported API enables you to check whether the current hardware supports the Reach or HiDef graphics profiles, but this only returns a simple boolean, with no details of why a failing profile isn't supported.

This utility provides more information about hardware capabilities, by performing the same checks that are used internally by the XNA Framework and by displaying their results as a detailed failure report. This can be useful for investigating driver compatibility problems, and also to see exactly what hardware capabilities are required for each profile.

Unlike most XNA samples, which are written in C#, this utility is written in C++/CLI (the .NET version of C++). This allows it to call directly into the native Direct3D API, thus obtaining more detailed caps information than is available through the XNA Framework graphics API. You'll need to install three things before you can build this utility:

    XNA Game Studio 4.0
    A version of Visual Studio 2010 that includes C++ support (not just C# Express)
    The native DirectX SDK ([http://msdn.microsoft.com/en-us/directx](http://msdn.microsoft.com/en-us/directx))


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

Download | Size | Description
---|---|---|
[XnaGraphicsProfileChecker_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/XnaGraphicsProfileChecker_4_0.zip?raw=true) | 0.02MB | Source code and assets for the XNA Graphics Profile Checker Utility.