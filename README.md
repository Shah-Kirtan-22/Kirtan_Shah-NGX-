# Kirtan_Shah-NGX
 
This project comprises of 2 scenes -

The INTRO scene

In this scene, there is a simple GUI, with a couple of buttons.
The Start button calls a script and begins the game,
The Quit button calls the same script and quits the application

The BREAKOUT scene

This scene comprises of a GameManager (Sound, spawn, lives), a player (the board), an NPC (the ball), and the environment (walls and tiles).


Game Workings:
Intro Scene --> (1) Press "Play" , (2) Press "Quit"

Upon play, simply move the board using either the left and right arrow keys or the "A" and "D" letter keys.
A user will have 3 lives as shown on the top left corner.
If the ball falls through, a life will be lost.
A gameover GUI will show up if all of the lives have been lost or all of the tiles have been destroyed.
If, press Escape, the application will close.

Techniques Used:

1) Simple sprites
2) Physics material
3) Coroutine
4) Interaction between scripts
5) Player movements
6) Game over logic
7) Audio management
8) No unnecessary usage of Update method
9) Good frame rate
10) Same speed across all devices 
