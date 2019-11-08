#Invites#

Area
Networking & Web Services
Submitted
11/14/2008
Code Sample

---
 
Description:

This sample builds on the Peer-to-Peer sample, adding support for invites.

 
Sample Overview

To test invites, you need two machines (either Xbox 360 or PC) with two XNA Creators Club subscriptions. This is because invites work only with LIVE PlayerMatch sessions, unlike other networking features that can be tested locally by using system link. If you don't have two subscriptions, the easiest way to try this out is to get a friend to help, or ask for assistance on the creators.xna.com forums.

To join a session through an invite, run this sample on two machines, using LIVE profiles that are friends. Press A to create a session on the first machine. There are three ways the second machine can join this session:

    By using regular matchmaking, the second player can press B to search and join the session that was created by the first player.
    The first profile (which is hosting the session) can go to their friends list, select their friend on the second machine, and choose the Invite to Game option. An invite notification will appear on the second machine. If the second profile presses their Guide button and accepts the invite message, they will automatically be joined into the session. This can be thought of as a "pull mode invite," because the first profile sends a message to pull the second into their session.
    The player on the second machine can press the Guide button, go to their friends list, select the first profile (who is hosting the session), and choose the Join Session In Progress option. This is a "push mode invite," because the second player pushes themselves into the session without any direct involvement from the first.

Although pull and push mode invites appear very different to the user, they are implemented in the same way. This sample supports both scenarios by using the InviteAcceptedEventHandler method.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

Download | Size | Description
---|---|---|
[InvitesSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/InvitesSample_4_0.zip?raw=true) | 0.08MB | Contains the source and assets for the Invites Sample (XNA Game Studio 4.0). 