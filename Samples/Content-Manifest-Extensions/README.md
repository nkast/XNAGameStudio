#Content Manifest Extensions#

Area
Games: Content Pipeline
Submitted
7/28/2010
Code Sample

---

Description:

This sample shows how to build a list of deployed content for your game.

Sample Overview

In XNA Game Studio 3.1 and earlier, games could use Directory.GetFiles along with StorageContainer.TitleLocation to get a list of all files in the game directory. This was useful for games that didn’t want to hard code level files or other assets. However, this method no longer works with XNA Game Studio 4.0 because the framework no longer exposes the TitleLocation property. This means that games will need to generate a list of files they want to be able to load if they wish to avoid hard coding those files into their game code.

This sample shows a method of generating this list automatically by using the content pipeline. With the provided content pipeline extension, games can simply load a list of strings that the pipeline generates for them, and use that list to load all of the content the game has access to. This method is not only useful due to the lack of the TitleLocation, but also because file I/O is generally a slow operation on Xbox. By creating this list as part of the build process, you ensure that the files actually exist and can be loaded without having to get a list of files or verify the files exist.

Games looking to incorporate this functionality will either need to add the project to their solution or build the project into a DLL. Then the developer should add a reference to the extension library to their content project. Finally a “.manifest” file should be added and set to use the ManifestImporter and ManifestProcessor. When the content project is built, all compiled content, as well as files marked with “Copy if newer” or “Copy always” will be recorded and built into an asset that the game can load in order to open or load other files.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

Download | Size | Description
---|---|---|
[ContentManifestExtensions_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/ContentManifestExtensions_4_0.zip?raw=true) | 0.05MB | Source code and assets for the Content Manifest Extensions Sample (XNA Game Studio 4.0). 