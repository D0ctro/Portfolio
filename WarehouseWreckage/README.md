# Warehouse Wreckage

I made a game in Unreal 5.1 to learn about physics and get used to Unreal Engine. 

The assets utilized in this small beginner project were not created by me but were provided within the online course I purchased on Udemy.
The course I followed is provided by GameDev.TV.

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

Warehouse Wreckage is a small game where I got used to important basics of UE5. 
The player can fly around the level, and by pressing spacebar, shoot out metall balls where is is looking at. 
Those can knock over Barrels and Racks in the level to simulate real physics.   

# Installation

*Insert Link for Installation*

# How To Play

The Goal of the game is to knock down as many barrels as possible. 
The catch is, that you have a limited amount of ammo and need to use it wisely.
Otherwise if you are on 0 ammo you cant shoot anymore and the level will automatically restart. 

# Controls

The Controls are the following:

- Move around the Level = "WASD"
- Move up and down = "Q" & "E"
- Shoot metall ball = "Spacebar"

# Improvements

For enhancing this game or continuing its development, consider the following additions and improvements:

- Tracking the amount of barrels hit or barrels that moved off of their start position making them count as hit.
- Showing the tracked hit barrels on screen
- Adding a highscore functionality
- An actual player + Model that can run around a level instead of flying around
- More Assets and actual level design
- Time limit?
- Perhaps an explosive barrel that can explode on hit making other barrels fall over as well

# Code

## MainLevel Blueprint

![image](https://github.com/D0ctro/Portfolio/assets/100345820/ba8556b7-cc1f-4ae9-82d2-53ed14550b4d)
Inside this EventGraph every string, the variable "ammo" and the reloading of the level is handled.

The Level Blueprint of Warehouse wreckage is rather self explanatory and straightforward. 
All of its funcionality is inside the seen functions. 

### Relevant functions 

![image](https://github.com/D0ctro/Portfolio/assets/100345820/a09b77bd-893a-4ac6-b46f-1a267f7aca19)
The Spawn Projectile function spawns an actor called BP_Projectile on the players position. 
afterwards the function "Launch" is opened.

## BP_Projectile
BP_Projectile only consists out of functions and is the metall ball that is shot out when pressing spacebar. 

### Releven functions

![image](https://github.com/D0ctro/Portfolio/assets/100345820/aca6e01e-0000-47a4-8e2d-079b1c30427c)
the Launch function is opened in the Level Blueprint. 
Its purpose is to give the metall ball, that is spawned after pressing spacebar, a forward vector in direction the player is facing. 

# Gained Knowledge

By making Warehouse Wreckage I got more familiar with UE5 than before. 
I learned...
- How to use Geometry brushes (BSP)
- How to navigate through Unreal Engine and many basic necessities
- About data types, basic programming logic in Blueprints and why Blueprints and c++ go hand in hand in UE5

After finishing this first game of this course, I was ready and set to learn how to code UE5 games using c++ code combined with Blueprints.
