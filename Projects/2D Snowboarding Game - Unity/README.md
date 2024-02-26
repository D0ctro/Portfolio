# 2D Snowboard Game

I made a 2D Side scroller Snowboarding game with the goal to drive down the mountain and reach the finish line. 

The assets utilized in this small beginner project were not created by me but were provided within the online course I purchased on Udemy. The game itself was a step-by-step tutorial that I followed to a certain extent before incorporating my own mechanics and ideas to enhance my comprehension of the concepts learned.

## Table of Contents

1. [Description](#description)
2. [Installation](#installation)
3. [How To Play](#how-to-play)
4. [Controls](#controls)
5. [Improvements](#improvements)
6. [Code](#Code)

# Description

![image](https://github.com/D0ctro/Portfolio/assets/100345820/5387f1a9-2942-442d-90d8-13d8838c67d7)

In my first side scroller is a snowboarding game where you try to reach the finish line while not falling on your head and thus resetting the level. 
In this game you can rotate your character mid air and gain speed when landing a "trick". 

# Installation

*Insert Link for Installation*

# How To Play

In order to play my Snowboarding game you will need to drive down the mountain safely and reach the goal. 
Doing tricks will speed up this process as you will get a speedboost landing on the ground. 
If you land on your head you will respawn in the beginning of the track so try not to. 

# Controls

The Controls are the following:

- Hold A/D = turning clockwise/ anti clockwise
- Spacebar = Jumping upwards

# Improvements



# Code

### PlayerController

![image](https://github.com/D0ctro/Portfolio/assets/100345820/5b7e6562-632f-4f6b-8239-9fa78474614b)
![image](https://github.com/D0ctro/Portfolio/assets/100345820/35cd69ed-f300-4505-8762-18a75f3be739)

The PlayerController governs the player's movement and behavior. Key variables such as `torqueAmount`, `boostSpeed`, `baseSpeed`, and `slowSpeed` determine the player's rotational torque and speed characteristics. The `DisableControls()` method halts player movement when called. The `RespondToBoost()` function adjusts the player's speed based on keyboard input, with `S` reducing speed, `W` activating a boost, and defaulting to `baseSpeed`. The `Rotation()` method applies torque to the player object when the corresponding keys `A` or `D` are pressed, allowing for directional control.

### CrashDetector

![image](https://github.com/D0ctro/Portfolio/assets/100345820/ebfc4d8f-4220-4563-b6c6-2046cf7badec)

### FinishLine

![image](https://github.com/D0ctro/Portfolio/assets/100345820/4950ce6c-6691-4e0b-91d4-8d68a4098756)

### DustTrail

![image](https://github.com/D0ctro/Portfolio/assets/100345820/a48a15bb-64da-4cf3-9704-64ba40ee15b3)

### BGM

![image](https://github.com/D0ctro/Portfolio/assets/100345820/fcec0e2e-e04b-49ba-9f9d-50e1261d79e7)
