# CST238
Zommo
// Logo <BR>

<B> Description </B> 
This project will be a framework towards making a RPG/MMO based on medieval world where magic was once a powerful
force with the world, but died out roughly thousand years ago after a huge war against the undead and reanimated 
corpses of fallen hereos.  Because the scope of a full RPG/MMO would be well beyond what is feasible within the time
frame of this class, we will be focusing on just the framework to build off of. The portions of the framework that
we will be working on is largely GUI heavy as that portion is the closest relation to this class.  Below is a
breakdown of each individual element we plan on having done for a deliverable plus many extended goals if time
permits.

Storyline
Minor details of the storyline worked out, which leads to the environmental choices for the game. Although the storyline 
will not be revealed to the user by the end of this assignment, the asset choices for character, environment and monsters
will play heavily upon the storyline that we will come up with.

Pre-Game Screens
This is where we will have a start screen, a character select screen and possibly a small story snippet for new characters. 
If we reach the extended part for saving characters, we will also add a load screen here.

Environment
We will create a single zone for this assignment which will contain grass, trees, rocks, a couple buildings and some dirt 
paths, and perhaps more depending on what feels right for the scene. Trees and buildings will have colliders preventing the 
player and enemies from walking through them

Default Interface
We will have a screen that has a mini-map. A portrait for the character, A health bar for the character. The character’s targets portrait and health bar.  A small list of abilities, along with an inventory (if we reach this on the extended portion).

Character
We will have 2 unique characters with unique play styles in this game. We plan on having a melee class which uses some sword weapons and a ranged class which will have a bow and arrow The characters will each have animations for “Walk, Idle, Attack, being attacked, and Death.

Enemies
There will be a minimum of 2 different types of enemies with different stats. Each enemy will have its own animations for Walk, Idle, Attack, being attacked, and Death. One enemy type will start out non hostile until attacked, the other will always be hostile if there is a player within range to engage him. Once engaged an enemy will follow a player either one dies, or there is not a valid pathing option to the player.

Combat
Enemies will have a limited AI for pathing and attacking. If there is too great of a distance between an engaged emery and the player who engaged it, the enemy will attempt to move to the player. If there is an obstacle between the player, such as a building, the enemy will attempt to find a path to the character to continue attacking. When an enemy is engaged, a health bar will appear over the enemy’s head showing his current health.

NPCs
We will have 4 NPCs in total (5 if we reach the vendor part of our extended project). There will be 2 other NPC’s who will be quest givers and give the player quests. Finally, there will be the final 2 NPC’s who will simply talk to the character with idle chatter.

Quests
We will have the ability to pick up quests form NPC’s, track our quests as they are in progress and turn in quests one they are completed. The quests may give rewards if we reach an inventory part of the extended project.

Extended Project
(the stuff we get to if we have time)

Loot Window
The ability to loot enemies, the enemies will pop up a loot window and the enemy will drop items the user can pick up if they wish to have the items.

Inventory
The user will have an inventory to hold items and show how much current currency the user has. The user will be able to move items around in their inventory and decide how items are sorted.

Vendor (5th NPC)
The vendor will both purchase items from the users inventory as well as sell weapons, armor, and potions.

Equipment screen
The equipment screen will have the ability to equip or remove weapons and armor that the user has in their inventory or on their character. This can be used to change the character’s stats such as attack or defense.

Stat Screen
A screen to show the character’s stats, such as attack or defense. This screen can be viewed in conjunction with the equipment screen so that a player may see their stats change in real time as they add and remove equipment.

Servers:
A server to be set up so multiple users can log in and see each other in the open world. This will also add the ability to help each other fight mobs.

Chat:
Players ability to speak to one another and read what is said in the player’s chat log.


Multi-Person combat:
The enemy’s decision to decide who to attack if multiple people are in a group attacking the same enemy. How items are distributed when an enemy dies.

Save Character Progress:
If completed the save character progress will happen each time a character completes a quest, or their inventory changes so character do not have at be manually saved and their current progress will always have an up to date save.


<B> Technologies: </B>
Unity3D, C#, SQLite

<B> Screenshots: </B>

<B> Installation: </B>

<B> Contribution Guidelines: </B>

<B> Bounty List (bugs): </B>

<B> Constributors: past, present, and future </B>

<B> Inspirition: </B>

<B> Lisense: </B>

