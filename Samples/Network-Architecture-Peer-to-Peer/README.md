#Network Architecture: Peer-to-Peer#

Area
Networking & Web Services
Submitted
12/17/2007
Code Sample

---

Description:

This sample implements a simple multiplayer network session by using a peer-to-peer network topology in which each computer is responsible for updating the state of its locally controlled players.

Sample Overview

This sample shows how to create and join network sessions, and how to exchange data using a peer-to-peer network topology. Each player controls a tank, which they can drive around the screen while rotating the turret. The game simulation is distributed over all the computers in the session, with each computer being responsible for updating the tanks belonging to its local players.

For an alternative way to handle networked game simulation, see the [Client/Server](https://github.com/nkast/XNAGameStudio/tree/master/Samples/Network-Architecture-Client-Server/) sample, which implements the same tank movement by using a client/server network topology.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_Peer2Peer_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Peer2Peer_01_small.jpg)![XNA_Peer2Peer_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_Peer2Peer_02_small.jpg)
	

Download | Size | Description
---|---|---|
[PeerToPeerSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/PeerToPeerSample_4_0.zip?raw=true) | 0.09MB | Source code and assets for the Network Architecture: Peer-to-Peer Sample (XNA Game Studio 4.0). 