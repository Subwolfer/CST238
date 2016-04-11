# CST238
Zommo, A subwolfer studios production.

Logo <BR>
![alt text](/img/index.jpg) <BR>
Dead trees in zone
<BR>
<BR>

<B> Description </B> <BR>
This project will be a framework towards making a RPG/MMO based on medieval world where magic was once a powerful
force with the world, but died out roughly thousand years ago after a huge war against the undead and reanimated 
corpses of fallen hereos.  Because the scope of a full RPG/MMO would be well beyond what is feasible within the time
frame of this class, we will be focusing on just the framework to build off of. The portions of the framework that
we will be working on is largely GUI heavy as that portion is the closest relation to this class.  Below is a
breakdown of each individual element we plan on having done for a deliverable plus many extended goals if time
permits.

Storyline: <BR>
Minor details of the storyline worked out, which leads to the environmental choices for the game. Although the storyline 
will not be revealed to the user by the end of this assignment, the asset choices for character, environment and monsters
will play heavily upon the storyline that we will come up with.

Pre-Game Screens: <BR>
This is where we will have a start screen, a character select screen and possibly a small story snippet for new characters. 
If we reach the extended part for saving characters, we will also add a load screen here.

Environment:<BR>
We will create a single zone for this assignment which will contain grass, trees, rocks, a couple buildings and some dirt 
paths, and perhaps more depending on what feels right for the scene. Trees and buildings will have colliders preventing the 
player and enemies from walking through them

Default Interface:<BR>
We will have a screen that has a mini-map. A portrait for the character, A health bar for the character. The character’s targets portrait and health bar.  A small list of abilities, along with an inventory (if we reach this on the extended portion).

Character<BR>
We will have 2 unique characters with unique play styles in this game. We plan on having a melee class which uses some sword weapons and a ranged class which will have a bow and arrow The characters will each have animations for “Walk, Idle, Attack, being attacked, and Death.

Enemies:<BR>
There will be a minimum of 2 different types of enemies with different stats. Each enemy will have its own animations for Walk, Idle, Attack, being attacked, and Death. One enemy type will start out non hostile until attacked, the other will always be hostile if there is a player within range to engage him. Once engaged an enemy will follow a player either one dies, or there is not a valid pathing option to the player.

Combat:<BR>
Enemies will have a limited AI for pathing and attacking. If there is too great of a distance between an engaged emery and the player who engaged it, the enemy will attempt to move to the player. If there is an obstacle between the player, such as a building, the enemy will attempt to find a path to the character to continue attacking. When an enemy is engaged, a health bar will appear over the enemy’s head showing his current health.

NPCs:<BR>
We will have 4 NPCs in total (5 if we reach the vendor part of our extended project). There will be 2 other NPC’s who will be quest givers and give the player quests. Finally, there will be the final 2 NPC’s who will simply talk to the character with idle chatter.

Quests:<BR>
We will have the ability to pick up quests form NPC’s, track our quests as they are in progress and turn in quests one they are completed. The quests may give rewards if we reach an inventory part of the extended project.

Extended Project:<BR>
(the stuff we get to if we have time)

Loot Window:<BR>
The ability to loot enemies, the enemies will pop up a loot window and the enemy will drop items the user can pick up if they wish to have the items.

Inventory:<BR>
The user will have an inventory to hold items and show how much current currency the user has. The user will be able to move items around in their inventory and decide how items are sorted.

Vendor (5th NPC):<BR>
The vendor will both purchase items from the users inventory as well as sell weapons, armor, and potions.

Equipment screen:<BR>
The equipment screen will have the ability to equip or remove weapons and armor that the user has in their inventory or on their character. This can be used to change the character’s stats such as attack or defense.

Stat Screen:<BR>
A screen to show the character’s stats, such as attack or defense. This screen can be viewed in conjunction with the equipment screen so that a player may see their stats change in real time as they add and remove equipment.

Servers:<BR>
A server to be set up so multiple users can log in and see each other in the open world. This will also add the ability to help each other fight mobs.

Chat:<BR>
Players ability to speak to one another and read what is said in the player’s chat log.


Multi-Person combat:<BR>
The enemy’s decision to decide who to attack if multiple people are in a group attacking the same enemy. How items are distributed when an enemy dies.

Save Character Progress:<BR>
If completed the save character progress will happen each time a character completes a quest, or their inventory changes so character do not have at be manually saved and their current progress will always have an up to date save.
<BR>
<BR>
<B> Technologies: </B> <BR>
Unity3D, C#, SQLite

<B> Screenshots: </B> <BR>
![alt text](img/1dfba1de-3b43-4a80-babf-767f6d1669a6_scaled.jpg) <BR>
Small village where you might find some NPC's
<BR>
<BR>
![alt text](img/77da476d-4348-4b3f-b2c5-e582b01830a0_scaled.jpg) <BR>
overhead view of village
<BR>
<BR>
![alt text](img/9659a0f5-cc37-45e4-ab27-7028a5b11c39_scaled.jpg) <BR>
A small area outside the village
<BR>
<BR>
![alt text](img/9659a0f5-cc37-45e4-ab27-7028a5b11c39_scaled.jpg) <BR>
Right outside the village
<BR>
<BR>
![alt text](img/a3b0117a-061a-4ce5-b333-b9cfbb6f2310_scaled.jpg) <BR>
Dead trees in zone
<BR>
<BR>
<B> Installation: </B> <BR>
1. Install Unity3D (it can be found at https://unity3d.com/ )
2. Open Project
3. Click play or Build an executable (may not be compatable with all build types)

<B> Contribution Guidelines: </B>
All contributions at this point to this project should only be made by the developers working on this school project or the
teachers aide in assistance of the project.  The developers of this project reserve the right to add additional contributors to this project at a later date. Upon that timeframe the contribution guidelines will be updated.

For this point of time, all Contributions will follow the naming and commening conventions of the OIT coding stnadards some of these include all non constant variables starting with a lower cased letter for an underscore. All functions starting with a capital letter. Multiple word function or variables will either be camel cased or have underscores between the words. All variables and functions will be commented with thier purpose.

<B> Bounty List (bugs): </B>
The only bugs at this point are in the thinking process of the developers. If you have the ability to solve these I would
be quite impressed.

<B> Constributors: past, present, and future </B> <BR>
Michel Koopman<BR>
https://github.com/Subwolfer
<BR>
Rie Kumar<BR>
http://github.com/verte200

<B> Inspirition: </B>
Its a merge of two popular genres that both of the developers are interested in. The inspiration for this comes from the desire to make a game that sounds fun and enjoyable but doens't follow the standard fantasy or zombie tropes such as magic and random monsters, but instead blend both words into one.  We are veering away from the modern day, guns vs zombies as the predominant means of surviving against them.

<B> Lisense: </B>
Copyright (c) 2016 Subwolfer Studios LLC - all rights reserved
