#Spaceshooter (ARCHIVED)#

Area
Games: Artificial Intelligence, Games: Collision, Games: Content Pipeline
Submitted
4/30/2009
Code Sample

---

    Note: This item is no longer supported. It may demonstrate techniques that are no longer valid in current versions of XNA Game Studio. The item is archived here, but will not be updated.

Description

The SpaceShooter Sample is the released version of a tutorial session created for the Korea Game Conference in 2008 by Frank Savage, a member of the XNA Game Studio Team.

Notes from the Developer
The idea was to try and create a basic prototype of a Wing Commander-style game using XNA Game Studio. Despite having worked with XNA Game Studio for nearly 4 years, I was still surprised at how easy it was to create this minigame. This represents a grand total of 25 hours of coding, finding data on the web, building a procedural star field with MapZone, and lifting the rest of content from other XNA Game Studio samples and starter kits. Add to that another 5 hours of bug fixes, FxCop cleanup, garbage collector cleanup, and writing this document!


Getting Started

Most everything in SpaceShooter is a GameComponent. I did this to demonstrate the enormous flexibility inherent in the GameComponent class in terms of updating, rendering, loading content, initializing, and so on. This also means that most pieces of SpaceShooter are reusable in your own games. Because I wanted to show all of the different ways you can use GameComponent, the usage from one component to another varies greatly in terms of how update, draw, load content, and initialize are called.

The game is pretty simple. We simply call update and draw for all of the game components, either explicitly or the base update and draw methods call them if they are added to the list of game components. There is also a collision detection routine that runs in the update function to detect when the ships hit each other or when the ships are hit by the bolts. The draw simply draws everything.

There is a simple AI for the enemy ship that just keeps him moving to evade you. Once he takes a certain amount of damage, he explodes and the game is over, you win! If he somehow manages to destroy you, you lose. (Note that you probably have to be pretty bad at the game to lose since he doesn’t even shoot at you.)

The particle system is from the GPU particle sample, and the game includes the bloom effect sample as well to ensure the game looks as next gen as possible.

Artificial Intelligence

Many people starting out as game developers make some serious mistakes around the game AI. This is because most beginner game developers (and many seasoned veterans, I might add) do not understand the real purpose behind the game's AI. The AI in a game exists to show the player a good time. Period. It's all too easy to make a game AI that is very hard and punishes the player mercilessly and too often. In fact, many game designers feel like they've achieved their goal when this happens. Most people playing games, however, are not trained fighter pilots or soldiers or race car drivers or sword-wielding barbarians. The game's job is to make them feel like they are! The AI must be designed to reinforce the illusion that if you just had a space fighter, you are the right guy to protect the Earth from thousands upon thousands of bad guys. The AI in SpaceShooter has one key component needed to do that. It simply flies and turns, varying the speed at which the fighter is moving and the direction and turn rates as it turns. That's it. Very simple behavior that results in a fun chase to swat the bad guy down!

The code is also simple. Every two seconds, the AI checks to see if it wants to change its current behavior. If the answer is no, we move on. If yes, we then create a new random amount to move the thumbsticks to represent a new direction to turn to and new velocity to drive the ship at. (Note how the enemy ship AI uses the exact same input mechanism and physics as the player! No cheating!) Over time, the AI simply eases back on the thumbsticks so that ship straightens out in the new direction. This generates surprisingly effective behavior. When you play against it, you will be amazed at the enemy ship seems to turn in response to your actions or heads towards the Earth with a sinister purpose or is just great at avoiding your shots, etc. All from this really simple AI!

The next step in improving the game is to create a pursuit and fire AI and to add more than one ship. You can also coordinate the AIs so that the AI the player has targeted goes into evade mode and the other ship goes into pursuit and fire mode. Look for a future installment that adds the pursuit and fire AI and pits these two ships against you.


Collision Detection

The XNA Framework ships with a number of useful collision detection primitives, but tying them together into a coherent collision detection system is still not easy. In the SpaceShooter case, I ran into two problems.

The first was reproducing the same bug I've created every single time I've built a game when I first add weapon fire and collision detection. (You would think after 20 years of doing game development, I would know better. The only thing I can say in my defense is that when it happens, I know exactly how to fix it!) Whenever I first add bolts and collision detection and fire the first time, I create a bolt near my ship and set it loose. It then promptly collides with my ship, either blowing it up or severely damaging it. There are a number of interesting ways to fix this. My favorite is to simply tag the bolt with an owner and, if the bolt hits the thing that created it, ignore the collision, which is what I do in SpaceShooter.

The other problem is the "bullet through tissue paper" problem. This refers to a collision that should have happened but didn't because the colliding objects passed right through each other between two frames of game updates. If the bullet moves farther than its extent radius every 60th of second, this problem is almost guaranteed to occur. There are a number of solutions to this problem as well, and the one I adopted was a variation on the ones I've seen used in the past tailored to the collision primitives we have. I simply cast a ray in the direction the bolt is moving and see if the ray intersects the collision volume of any of the ships in the game. If it does, I change the bolt's collision sphere radius to the distance it will move in one frame and if that collision sphere intersects or contains the sphere of the ship hit by the ray, we have a collision.

Note that there are also simple mathematical ways to find the closest point between any two moving objects over some time interval. If I know the time of closest approach for any two objects across a given frame, I can simply move them to that location and check the collision extents. This avoids the problem as well and is somewhat less complex than the solution I adopted, but the idea here was to provide the community with ways to solve these kinds of problems that didn't require a textbook on linear algebra.


Content

Space games are also fun to build because it's typically pretty easy to find content on the web or generate yourself, even if you (like me) are terrible at creating art.

* The sun's texture is hand-built from some close-ups of sunspots, which are quite easy to find on the web. All of the Earth's textures came from the http://visibleearth.nasa.gov/ website. There are some very large textures available there, but I chose a size of 2K × 1K or the download for this game would have been awfully big! It's easy to grab higher resolution versions of the clouds, diffuse textures, height maps, and night lights. Doing this really improves the representation of Earth in terms of visual quality.
* The starfield was made using the MapZone Pro tool available from Allegorithmic.
* The ships were taken from the ShipGame Sample. Note that the ships are using a different shader than the default shader from ShipGame. Luckily, SpaceShooter includes a Content Pipeline processor that shows you how to do this.
* There are also Content Pipeline processors to create a normal map from a height map since this is apparently becoming something of a lost art on the web today in terms of available code. The Earth’s height map is simply grayscale texture, which the processor changes into a normal map.
* The sound effects and bolts are from the original Spacewar sample.
* The explosions and particle trails are simply instances of particle emitters based on the GPU Particle sample.




All content and source code downloaded from this page is bound to the Microsoft Permissive License (Ms-PL).

Download | Size | Description
---|---|---|
[SpaceShooter_ARCHIVE_3_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/SpaceShooter_ARCHIVE_3_0.zip?raw=true) | 11.71MB | Contains all source and assets for the SpaceShooter Sample (XNA Game Studio 3.0, Archived). 