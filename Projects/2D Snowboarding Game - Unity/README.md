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
- Hold S = Slow down your speed
- Hold W = Increase your speed 
- Spacebar = Jumping upwards

# Improvements

For enhancing this game or continuing its development, consider the following additions and improvements:

- Adding Collectibles and Currency**: Incorporate collectibles with corresponding sound effects. Scatter them across existing maps or introduce new ones for added variety.

- Procedurally Generated Infinite Mode**: As a long-term goal, implement a mode featuring procedurally generated terrain for endless driving enjoyment until the player crashes.

- Diversified Obstacles and Mountain Design**: Introduce more obstacles or redesign the mountain layout to provide increased challenge and engagement for players.

- Refinement of PlayerController**: Continuously improve the PlayerController for smoother gameplay and an enhanced user experience.

- Integration of Timer System**: Consider integrating a timer system to encourage players to achieve faster completion times on maps and improve their personal records.

This revised version maintains clarity and conciseness while offering suggestions for potential enhancements and developments in your game.

# Code

### PlayerController

![image](https://github.com/D0ctro/Portfolio/assets/100345820/5b7e6562-632f-4f6b-8239-9fa78474614b)
![image](https://github.com/D0ctro/Portfolio/assets/100345820/35cd69ed-f300-4505-8762-18a75f3be739)

The PlayerController governs the player's movement and behavior. Key variables such as `torqueAmount`, `boostSpeed`, `baseSpeed`, and `slowSpeed` determine the player's rotational torque and speed characteristics. The `DisableControls()` method halts player movement when called. The `RespondToBoost()` function adjusts the player's speed based on keyboard input, with `S` reducing speed, `W` activating a boost, and defaulting to `baseSpeed`. The `Rotation()` method applies torque to the player object when the corresponding keys `A` or `D` are pressed, allowing for directional control.

### CrashDetector

![image](https://github.com/D0ctro/Portfolio/assets/100345820/ebfc4d8f-4220-4563-b6c6-2046cf7badec)
The CrashDetector manages collision detection and player respawn functionality. Key components include the `CrashEffect` particle system, `DeathDelay` for respawn timing, and `crashSFX` for crash sound effects. Update listens for the `R` key to restart the scene aka making the player Respawn at will. When the player collides with an object tagged as "Respawn" and hasn't crashed previously, the `OnTriggerEnter2D()` method triggers crash effects, disables player controls by calling the mentioned `DisableControls()` method from the PlayerController , plays the crash sound, and schedules respawn after a delay using `Invoke()`. The `Respawn()` function reloads the scene after a `DeathDelay`.

### FinishLine

![image](https://github.com/D0ctro/Portfolio/assets/100345820/4950ce6c-6691-4e0b-91d4-8d68a4098756)
FinishLine handles the interaction of the player reaching the finish line and "wins" the game. Key components include the `WinDelay` for timing the scene reload after crossing the finish line, and various `finishEffect` particle systems for visual effects. The `OnTriggerEnter2D()` method detects when the player collides with the finish line, triggering finish line effects, playing an audio cue, and reloades the scene using `Invoke()` if the player hasn't finished previously. The `FinishLineEffects()` function plays my own particle effects while stopping the `finishLingerEffect`. Finally, the `ReloadScene()` function reloads the scene after a delay.

### DustTrail

![image](https://github.com/D0ctro/Portfolio/assets/100345820/a48a15bb-64da-4cf3-9704-64ba40ee15b3)
DustTrail manages the generation of dust trails behind the player. It includes particles such as `SnowTrail`, `SnowBump1`, and `SnowBump2` for creating visual effects. The `OnCollisionEnter2D()` method triggers the particles to play when the player collides with an object tagged as "Respawn" same as in the CrashDetector. `OnCollisionExit2D()` method stops the `SnowTrail` particle system when the player exits the collision with the "Respawn" object, ensuring the dust trail effect ceases appropriately and does not play after respawning at the start of the scene.

### BGM

![image](https://github.com/D0ctro/Portfolio/assets/100345820/fcec0e2e-e04b-49ba-9f9d-50e1261d79e7)
BGM lets me play Music in the background. It features three different audio clips: `BGM1`, `BGM2`, and `BGM3`. The `Start()` method ensures that only one instance of the `BGM` object exists throughout the game. If there's already an existing instance, it destroys the current game object to prevent duplication. Otherwise, it sets the current instance to this object, plays the `BGM2` audio clip, and ensures that the object persists across scene changes using `DontDestroyOnLoad()`. This structure ensures consistent background music across the game without interruption due to respawning through crashing or finishing the game.
