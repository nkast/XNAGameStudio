#HTTP Multiplayer: Tic Tac Toe#

Area
Networking & Web Services
Submitted
12/10/2010
Code Sample

---

Sample Overview
A standard multiplayer game involves at least two individual players. This sample, however, is fully playable with only a single remote client. This makes the sample easier to run and understand.

The sample’s client enables the player to make a move, and then makes an additional move by using artificial intelligence. The sample demonstrates how to notify all clients about game flow events, such as the end of the opposing player’s step, by using push notifications.

In order to use push notifications, the client first sends a simple request-response message to the server. The message contains a callback URI that the server can use to reach the client. The server responds to the request by acknowledging the client’s registration. When the server needs to notify clients of changes, it uses the URI supplied during registration to send a push notification. Once registered, the client will only send one-way messages to the server.

The sample uses a self-hosted WCF service to simulate the server. The service’s Register method is the only method that returns data to the client. All other communication is performed by using one-way calls and push notifications.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

 ![](https://github.com/nkast/XNAGameStudio/blob/master/Images/tictactoe1.png)![](https://github.com/nkast/XNAGameStudio/blob/master/Images/tictactoe2.png)
 	 

 
Download | Size | Description
---|---|---|
[TicTacToe_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/TicTacToe_4_0.zip?raw=true) | 0.12MB | Source code and assets for the Tic-Tac-Toe sample.