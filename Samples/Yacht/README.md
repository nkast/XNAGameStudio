#Yacht#

Area
Games: 2D Graphics, Games: Gameplay, Games: Graphics, Input, Touch & Gestures, Networking & Web Services
Submitted
12/20/2010
Code Sample

---

Sample Overview

This starter kit is a dice game where the player rolls 5 dice in an attempt to create specific combinations. Included in this starter kit is support for a Wi-Fi multiplayer game over HTTP.

In Yacht, each player has 12 turns to score the most points possible. Points are scored by matching the dice you have rolled to specific combinations on the scoring sheet. Each turn, the active player has three rolls to create the highest scoring combination possible. Any number of dice can be held out for the second and third rolls, but after the third roll the player must choose a combination to score, even if the total for the combination is zero. At the end of 12 rounds, when all combinations have been scored, the player with the most points wins.

NOTE: In order to run the multiplayer component of this game, specific instructions must be followed, or the device may not be able to properly connect to the server.

Server:

    * Ensure your computer is connected to a wireless network
    * Open YachtServer.sln in elavated mode or as an Administrator
    * Build and run YachtServer

Client (Emulator):

    * Build and run YachtClient.Sln

Client (Device):

    * Determine the IP of the Server
        ..* Start->Run->cmd->ipconfig->IPv4 Address
    * Open ServiceReferences.ClientConfig and change http://localhost:8888/GameServer/ to http://(serverIP):8888/GameServer/
    * If you have a firewall enabled, open port 8888 for incoming TCP traffic
      ..*  On Windows Firewall in Windows 7:
         ....*   Control Panel->Windows Firewall ->Advanced Settings->Inbound Rules
      ..*      Actions->New Rule
         ....*       Rule Type = Port
         ....*       Protocol = TCP
         ....*       Specific local ports = 8888
         ....*       Action = "Allow the connection"
         ....*       Profile = [Choose the type of network you have]
     ..* Build and Run YachtClient.Sln

This game includes the following features:

    * Implementation of the Game State Management sample
    * Multiplayer asynchronous gameplay over Wi-Fi
    * AI opponents for a local game
    * Gesture-based input
    * 2D Animation
    * Sound effects and game music

All content and source code downloaded from this page is bound to the Microsoft Permissive License (Ms-PL).

![](https://github.com/nkast/XNAGameStudio/blob/master/Images/yacht1.png)  	  	 

 
Download | Size | Description
---|---|---|
[Yacht_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/Yacht_4_0.zip?raw=true) | 2.86MB | Source code and assets for Yacht.