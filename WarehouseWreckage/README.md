# Warehouse Wreckage

I developed a game in Unreal 5.1 to explore physics simulations and get familiar with Unreal Engine.

The assets utilized in this introductory project were provided within an online course I purchased on Udemy, offered by GameDev.TV.

## Table of Contents

1. [Description](#description)
2. [Installation](#installation)
3. [How To Play](#how-to-play)
4. [Controls](#controls)
5. [Improvements](#improvements)
6. [Code](#Code)
7. [Gained Knowledge](#Gained-Knowledge)

# Description

![image](https://github.com/D0ctro/Portfolio/assets/100345820/2011da05-c557-4f52-8a5d-96bc0528d9c8)

Warehouse Wreckage is a small game where I explored fundamental aspects of UE5. The player can navigate around the level and, by pressing spacebar, shoot metal balls in the direction they are facing.
These balls can collide with barrels and racks in the level, simulating real physics.   

# How To Play

The objective of the game is to knock down as many barrels as possible. However, players have a limited amount of ammo and must use it sparingly.
If the player runs out of ammo, they cannot shoot anymore, and the level automatically restarts.

# Controls

The controls are as follows:

Move around the level: "WASD"
Move up and down: "Q" & "E"
Shoot metal ball: "Spacebar"

# Improvements

To enhance or continue the development of this game, consider the following additions and improvements:

- Tracking the number of barrels hit or moved from their original position
- Displaying tracked hit barrels on the screen
- Adding a highscore functionality
- Incorporating an actual player model that can traverse the level instead of flying
- Adding more assets and designing additional levels
- Implementing a time limit
- Introducing explosive barrels that can cause chain reactions

# Code

## MainLevel Blueprint

![image](https://github.com/D0ctro/Portfolio/assets/100345820/ba8556b7-cc1f-4ae9-82d2-53ed14550b4d)
In the EventGraph of the MainLevel Blueprint, string operations, the 'ammo' variable, and level reloading are handled.

The MainLevel Blueprint of Warehouse Wreckage is straightforward, with all functionalities contained within visible functions.

### Relevant functions 

![image](https://github.com/D0ctro/Portfolio/assets/100345820/a09b77bd-893a-4ac6-b46f-1a267f7aca19)
The 'Spawn Projectile' function generates an actor called BP_Projectile at the player's position, followed by initiating the 'Launch' function.

## BP_Projectile
BP_Projectile consists of functions and represents the metal ball that gets shot when you press the spacebar. 

### Relevant functions

![image](https://github.com/D0ctro/Portfolio/assets/100345820/aca6e01e-0000-47a4-8e2d-079b1c30427c)
The 'Launch' function, opened in the Level Blueprint, assigns a forward vector to the spawned metal ball, aligning it with the player's facing direction.

# Gained Knowledge

Developing Warehouse Wreckage expanded my understanding of UE5. I gained insights into:

- Utilizing Geometry brushes (BSP)
- Navigating Unreal Engine and mastering basic functionalities
- Understanding data types and basic programming logic in Blueprints, emphasizing the synergy between Blueprints and C++ in UE5.

Completing this initial game from the course prepared me to delve into coding UE5 games using C++ in conjunction with Blueprints.
