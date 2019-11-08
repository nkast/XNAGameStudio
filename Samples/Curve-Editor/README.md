#Curve Editor#

Area
Games: Math
Submitted
9/27/2007
Tool

---

Description: 

The Curve Editor Tool enables you to graphically construct and edit curves in a format that can be loaded by the XNA Framework into a Curve object. Curve Editor contains three projects, each in its own folder.

    * CurveEditor – A standalone utility that enables you to edit and save curves for use with the XNA Framework Curve class.
    * CurveControl – A component that can be imported into a WinForms application to provide curve display and editing capabilities.
    * CurveControlUsageSample – An example of how to use the CurveControl component in a WinForms application.

Tool Overview

The XNA Framework Curve class represents a two-dimensional (2D) curve—a function relating two axes of values. Curves are useful for a variety of relationships used in games. Physics, animation, and input can all benefit from using curves.

Curve classes are defined by a set of keys. These keys have an X and a Y value, and they contain mathematical data about the curve tangent that defines how the Y value changes as it approaches the given X value.

You can create a Curve class in your XNA Framework game code and fill in the keys manually. However, it is much easier to design and refine a curve graphically; the curve can be displayed and manipulated in 2D Cartesian coordinates. The Curve Editor provides a way to graphically create, modify, and save curves in an XML format. To create Curve objects that behave the way they were drawn in the Curve Editor, use the XNA Framework Content Pipeline at run time to load the XML.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Curve-Editor_01_small.JPG)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Curve-Editor_02_small.JPG)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Curve-Editor_03_small.JPG)

  	  	 

Download | Size | Description
---|---|---|
[CurveEditor_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/CurveEditor_4_0.zip?raw=true) | 0.28MB | Source code and content for the Curve Editor Tool. 