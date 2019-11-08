#Input Reporter#

Area
Input, Touch & Gestures
Submitted
9/27/2007
Tool

---

Description: 

This tool reports all GamePad state and capability data available via the XNA Framework.
 
Tool Overview
 
The GamePad type provided by the XNA Framework provides an API to poll the state and capabilities of compliant devices that are connected to the computer or Xbox 360, supporting up to four concurrent controller connections. All compliant accessories, such as the Xbox 360 Wireless Racing Wheel, fill the same GamePadState and GamePadCapabilities structures as the Xbox 360 Controller.
 
This tool displays this data for all controllers connected to the system. The display updates as controllers are used, connected, and disconnected. The Ring of Light graphic at the top-right corner of the screen shows which controllers are connected. The numerals around the Ring of Light indicate which controller is currently being displayed. The active controller is switched by pressing any of the digital buttons on the controller you wish to switch to. The labels and GamePadType data provided match the method and enumeration names provided by the XNA Framework for easy correlation. Values that aren't supported, according to the GamePadCapabilities structure, are dimmed.
 
Since all of the GamePadState values are displayed as data, it would have been frustrating to map any of them directly to an action, such as the BACK button immediately exiting the application. Input Reporter implements a "charging switch" that triggers an action after a button is held down for several seconds, allowing the user to test the controllers without immediately controlling the application.
 
A common use of this tool is to investigate how the controls provided by various accessories map to the GamePadState and GamePadCapabilities values.

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Input-Reporter_01_small.jpg)


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

 
Download | Size | Description
---|---|---|
[InputReporter_4_0.zip ](https://github.com/nkast/XNAGameStudio/blob/master/Samples/InputReporter_4_0.zip ?raw=true)| 0.13MB | Source code and assets for the Input Reporter Tool. 