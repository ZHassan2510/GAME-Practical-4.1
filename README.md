# Practical 4.1 Implementing the Controls for a Tank

In the first lecture, you learned about transforms and how they are used to position, rotate and scale objects in a Unity scene (and most other 3D environments). In this practical, you are going to use transforms to implement the controls for the tank object that you saw in the lecture.

By the end of this practical you will be able to:

- Place a game object in another’s local space using the hierarchy panel
- Write scripts that manipulate game objects’ transforms in world and local space

This repository includes a Unity project with some assets that you will use to complete the tasks in this class. To get started make a copy of this repository on your GitHub account and clone it onto your local computer.

## Task 1: Adding the Tank to a Scene and Creating the Floor

You can find models for the tank in the “Tank Models” folder in the project. Once you have found this, add the hull and the turret to a new Unity scene, such that the turret is the child of the hull and both are correctly positioned, rotated and scaled relative to each other.

You should also add some land for the tank to drive on, so you can tell it’s moving. A simple flat plane will be enough for now though.

## Task 2: Driving Controls

Your next task is to create a script that allows a user to drive the tank using the WASD keys, such that:

- The W/S keys control acceleration forwards and backwards
- The A/D keys control steering

The script you create should be assigned to the hull game object, so that its child, the turret game object, moves also when the hull moves.

If you’re not sure how to read input from these keys, take a look back at how you made the maze tilt in practical a couple of weeks back.

## Task 3: Turret Control

To finish off your tank’s controls, you should write a second script that allows the user to control the rotation of the turret using the Q & E keys.

Note: This was covered in the lectures, try and work on it with help from the GTAs and consult the lecture slides if you get stuck! 

## Optional Extensions

If you complete both practical sheets before the end of the practical, consider the following tasks to complete in the Peer learning sessions. 

- Explore how to use local space coordinates to make the camera follow the tank as it moves (3rd person) and to make the camera rotate with the turret (1st person)

