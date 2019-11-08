#Tombstoning Sample#

Area
Games: Data Management, Performance & Optimization
Submitted
11/19/2010
Code Sample

---

Sample Overview

To help ensure that the user experience is fast and responsive, Windows Phone prioritizes the application running in the foreground and will typically tombstone an application when the user navigates away. If your application is reactivated after being tombstoned, it's important to restore the visual state of your application so that the user experience is that of returning to a running application. It's also important that application state be restored in a way that doesn't delay the load time of the application. This sample shows how to restore the visual state of a page and also restore application data when an application is reactivated after tombstoning.

For more information on how this sample works, see [How to: Preserve and Restore Page State for Windows Phone](http://go.microsoft.com/fwlink/?LinkID=206638) and [How to: Preserve and Restore Application State for Windows Phone](http://go.microsoft.com/fwlink/?LinkID=206639).


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).


Download | Size | Description
---|---|---|
[TombstoningSample.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/TombstoningSample.zip?raw=true) | 0.05MB | This sample shows how to restore the visual state of a page and application data when an application is reactivated after tombstoning. 