# VRTigo - A VR Minigame

## By Lavanya Sajwan, Cameron Hopkinson, Rachel Anderson, Nicholas Snellgrove, Brandon Scott-Hill and Jaime Milne

This game is a simple navigation time trial using portals. Players are able to place portals on almost any surface by using the left and right triggers. The goal is to get to the end of the level as quickly as possible. There are no penalties for taking your time, but the previous time is recorded so that you can challenge yourself if you would like to play again.

## How to Run

This minigame was built using the Unity game engine, version 2019.2.7. Due to conflicts with SteamVR, we were unable to package this into a separate executable. The minigame can be run through the Unity engine, as long as Steam and SteamVR are both running. 

The team did encounter some issues with SteamVR spontaneously resetting the default bindings for in-game controls. If this is an issue during testing, please get in contact so we can resolve these ASAP. 

## Controls
This minigame requires an HTC Vive headset to play.

* The player can move around in the virtual environment in two ways. 
    * Firstly, by moving in the physical world (be careful of your surroundings when in VR). 
    * Secondly, by using the position of the thumb on the left trackpad (like an analog stick) to move the player around the virtual world.
* The player can rotate themselves in the virtual world by clicking left or right on the trackpad of the left controller. 
* The player has two portal which they can launch from either controller. Each controller creates a different portal projectile. These can be launched using the trigger on the controllers.
* Buttons in the scene can be interacted with by launching a projectile at them. 

## How to Play

The objective in each level is simply for the player to make their way to the exit, which is signified by a glowing green pedestal somewhere in the level. Getting to the exit will require the player to use their portals to solve some kind of puzzle. 

There are two types of surface in the game world - portalable and non-portalable surfaces. 
* Portalable surfaces are distinguished by their white colouration, portals can be created on these. 
* Non-portalable surfaces cannot have portals created on them. These could be windows (transparent) or walls. Portal projectiles will bounce off of these surfaces. 

There are two portals which exist in each game level - blue and orange. These portals are linked together, if the player walks into one, they will come out of the other. These portals can be moved around the level by using the portal projectiles onto portalable surfaces. 

The time taken to complete a level is recorded, and the best times are stored on the leaderboard.

## Evaluations

This project had two stages of evaluations. For details on this, see [here](https://gitlab.ecs.vuw.ac.nz/swen422-2019-a2/t19/swen422-assignment2/blob/master/User%20Testing/Usability%20Test%20Report.md).

## Video
A short gameplay demo, and a video of the real-life interactions which go along with this are available in the Videos folder.