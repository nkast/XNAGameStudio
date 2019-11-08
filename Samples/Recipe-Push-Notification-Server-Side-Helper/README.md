#Recipe: Push Notification Server Side Helper#

Area
Push Notifications
Submitted
1/14/2011
Article

---

The Push Notification Server Side Helper Library, a part of the Windows Phone 7 Push Recipe, provides an easy way to send all three types of push notification message that are currently supported by Microsoft Push Notification Services (MPNS): Tile, Toast, and Raw. These types are described in more detail in the recipe documentation.

Our main goal here is to simplify the sending of PN messages from your website to the Windows Phone client. This library helps developers to send push messages by using only a few lines of code. The library can be used in an ASP.NET web project or in WCF services to send push messages to MPNS.

Push Patterns are a generalization of a common use of PN in an end–to-end solution that includes specific Windows Phone and server-side logic. This library also includes detailed implementations of common Push Notifications patterns that describe end-to-end scenarios, such as Rest Push Counters, Ask to Pin Tile, Schedule Tile, and others. To illustrate the use of the Push Notification Server Side Helper, we’ve create a WPF application that acts like a web service, mimicking a third-party server. To enable this, the WPF application has a WCF service that lets the Windows Phone application register and communicate with MPNS. The WPF has tabs, each of which represents a specific Push Pattern that we wish to illustrate.

For more detail on this helper library, see the Windows Phone Developer Blog post.

All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).


Download | Size | Description
---|---|---|
[PushRecipe_WP7_SL.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/PushRecipe_WP7_SL.zip?raw=true) | 2.80MB | Windows Phone 7 Recipe: Push Notification Server Side Helper Library 