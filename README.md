# Rock of Ages

This is an exercise for the coursera course [Introduction to C# Programming and Unity](https://www.coursera.org/learn/introduction-programming-unity)


### Implementation Steps

Now that you've made it to the third week of the course, these aren't really implementation steps. Instead, they're functional requirements; you have to figure out how to implement them on your own. Here's what your solution has to do:

● Start with an empty window. Don't worry, your first rock should appear after about a second

● Every second, if there are fewer than 3 rocks in the window, spawn a new rock, centered in the window, with a random sprite. You should use the random velocity code I provided to get the new rock moving, though you might need to change the **MinImpulseForce** and **MaxImpulseForce** values to make sure your rocks don't move too fast. In other words, make sure the resulting speed is slow enough that you get to see all 3 rocks in the window before any of them disappear

● When a rock leaves the window, it should destroy itself. It will be replaced by the functionality in the previous bullet within a second

## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/coursera-c-sharp-rockofages.git`  

add folder to [Unity](https://unity.com/) with [Unity Hub](https://unity3d.com/get-unity/download).
