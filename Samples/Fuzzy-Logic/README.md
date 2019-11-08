#Fuzzy Logic#

Area
Games: Artificial Intelligence
Submitted
1/24/2008
Code Sample

---

Description:

This sample shows how an AI can use fuzzy logic to make decisions. It also demonstrates a method for organizing different AI behaviors, similar to a state machine.

Sample Overview

When you program the AI for your games, you know that your actors often have to choose between several different options. In many cases, the choice is black and white: if you see the player, attack him. However, the decision-making process is often much less clear cut. If you are low on health, go find a med kit. If there is a powerup nearby, pick it up. But how do you define low on health or nearby? And what if you're both low on health and also near a powerup? Which action is more important? You can give your AI actors the ability to make these kinds of decisions by using fuzzy logic.

In this sample, we use some of the behaviors introduced in the Chase & Evade sample to demonstrate one way that an AI actor can use fuzzy logic to make a decision. The sample employs a tank and 15 mice. The tank chases the mice, and the mice flee from the tank. The tank uses fuzzy logic to decide which mouse would be best to chase. The user is given control over several factors that influence the tank's decision-making process.

In addition, the sample demonstrates a design pattern that can be useful when programming AI: pluggable behaviors. This pattern separates an entity from the logic for its AI behavior, allowing the behavior logic to be reused by multiple entities.

This sample is based on the Chase & Evade sample and assumes that the reader is familiar with the code and concepts explained in that sample.


All content and source code downloaded from this page are bound to the Microsoft Permissive License (Ms-PL).

![XNA_FuzzyLogic_01_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_FuzzyLogic_01_small.jpg)![XNA_FuzzyLogic_02_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_FuzzyLogic_02_small.jpg)![XNA_FuzzyLogic_03_small.jpg](https://github.com/nkast/XNAGameStudio/blob/master/Images/XNA_FuzzyLogic_03_small.jpg)
		

Download | Size | Description
---|---|---|
[FuzzyLogicSample_4_0.zip](https://github.com/nkast/XNAGameStudio/blob/master/Samples/FuzzyLogicSample_4_0.zip?raw=true) | 0.09MB | Source code and assets for the Fuzzy Logic Sample (XNA Game Studio 4.0). 