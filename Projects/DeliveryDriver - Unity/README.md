# Delivery Driver

Delivery Driver is a small 2D Top Down car driving game made in Unity.

The assets utilized in this small beginner project were not created by me but were provided within the online course I purchased on Udemy. The game itself was a step-by-step tutorial that I followed to a certain extent before incorporating my own mechanics and ideas to enhance my comprehension of the concepts learned.

## Table of Contents

1. [Description](#description)
2. [Installation](#installation)
3. [How To Play](#how-to-play)
4. [Controls](#controls)
5. [Improvements](#improvements)
6. [Code](#Code)

## Description

In Delivery Driver, you will need to maneuver through a small town driving a delivery car. You will find packages that need to be delivered, so you pick them up by driving over them and deliver them to the waiting recipients of said packages.
On your way, you will find green boost pads that will increase your speed until you crash, so make sure not to crash to keep your speed!

![Delivery Driver](https://github.com/D0ctro/Portfolio/assets/100345820/3d3909e6-5ab1-46b9-b83b-1e4397758725)

## Installation 

*Insert Link for Installation*

## How To Play

The goal of Delivery Driver is to collect all the packages spread out in the town and bring them back to any recipient. As the game is straightforward, the objects used for the interactable are just differentiated by using different sizes, geometrical forms, and colors. 
- Package = purple square
- Boost Pad = Green Circle
- Recipient = Blue Triangle
- '...' = Orange big circle

## Controls 

The Controls are the following:

- W & S = positive and negative acceleration
- A & D = Steering right/left

## Improvements

The game was only a start to get to know Unity and get comfortable with using scripts and objects. For further improvement, I could:

- Add a timer that stops once every package has been delivered.
- Put the tracked time in a leaderboard and make yourself able to beat your own times.
- Give the player Lives that they lose under certain conditions, making them restart the level.
- Add more obstacles that might slow you down or make you lose said lives.

These improvements could help make somebody enjoy this little game for longer and would help better my programming skills.

As for things I would change that are already in the game I have a few things I would change. 
I know this game was just a beginner project for getting used to unity, but even then a few things could be fixed making it better.  

- More realistic driving, meaning your for example not able to turn while standing still or potentially speeding up by continuously driving in the same direction instead of a fixed base speed.
- Match the drivers speed, steering etc. more fitting in regards to the map layout and size making it more fun.
- Make the "assets" of the Boost, package, reciepient and future additions look better or for example the package look like a package. 

## Code

### Driver

![image](https://github.com/D0ctro/Portfolio/assets/100345820/8484918a-cdec-4c3b-bd07-fa9a20af2289)

- **Driver Object**: The driver is the object responsible for handling all user inputs and driving around the town. I began by initializing variables crucial for driving the car and placed them within a `SerializeField` attribute to make them accessible in the Unity Editor. This allows me to tweak them during game testing to enhance the user experience.

- **Update Function**: Within the `Update` function, I dynamically adjust the driving speed of the car based on whether horizontal or vertical keys are pressed. Additionally, I enable the car to rotate based on the `steerAmount` variable.

- **OnTriggerEnter2D Function**: This function manages scenarios where the player encounters another object tagged as "Boost," such as the green booster. If the tag matches "Boost," the `moveSpeed`, which determines the car's forward/backward speed, is adjusted to the `boostSpeed` variable.

- **OnCollisionEnter2D Function**: This function handles situations where the player collides with any collider-bearing object in the game. In such cases, the `moveSpeed` is set to the `slowSpeed` variable.

### Delivery

![image](https://github.com/D0ctro/Portfolio/assets/100345820/3c7d1ffc-1e8d-4022-a00b-58e44e5b061f)

The primary focus of this script is to establish variables necessary for creating the delivery system. Upon triggering the `OnTriggerEnter2D` function on an object tagged as "Package," the `HasP` Boolean is toggled to true if it was false previously. Subsequently, the car's color changes to indicate package pickup. Upon pickup, the package is destroyed, prompting the player to trigger the `OnTriggerEnter2D` function on an object tagged as "Customer" to revert to having no package.

### Delivery

![Delivery Image](https://github.com/D0ctro/Portfolio/assets/100345820/3c7d1ffc-1e8d-4022-a00b-58e44e5b061f)

The primary focus of the Delivery script is to establish variables necessary for creating the delivery system. Upon triggering the `OnTriggerEnter2D` function on an object tagged as "Package," the `HasP` Boolean is toggled to true if it was false previously. Subsequently, the car's color changes to indicate package pickup. Upon pickup, the package is destroyed, prompting the player to trigger the `OnTriggerEnter2D` function on an object tagged as "Customer" to revert to having no package.

### WorldBorder

![WorldBorder Image](https://github.com/D0ctro/Portfolio/assets/100345820/8d6370f9-5e31-49c1-887b-7ed0ae9ee327)

The WorldBorder script was developed after completing the initial project. Its purpose is to ensure the car is brought back to the center of the map in case the player drives too far or ventures outside of the map boundaries. By creating a new Vector3 that changes the car's spawnpoint to (0,0,0), and implementing a large trigger zone matching the map's size, the player's position is reset to the respawn point whenever the car exits this zone.

### FollowCamera

The FollowCamera script's sole purpose is to track the position of the `thingToFollow` GameObject attached to the Player. It updates the camera's position every frame to follow the `thingToFollow` object, providing a zoomed-out view.
