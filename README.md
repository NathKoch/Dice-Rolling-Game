# Dice Rolling Game

This C# project uses Windows Forms to create a graphical user interface (GUI). It is designed to implement a simple dice rolling game for two players. The project is part of an object-oriented programming course.



### Example Usage

1. Click on the Start New button to begin a new game.
2. Click on the Play First button to roll the dice for the first player. The results of the roll and the sum of the points will be displayed.
3. Click on the Play Second button to roll the dice for the second player. The results of the roll and the sum of the points will be displayed. The game result (winner or draw) will be shown on the screen.

## Usage

The project includes a graphical interface with buttons, labels, and images. The main control elements include:

- `NK_btn_StartNew`: Button to start a new game. Resets the scores and hides the dice images.
- `NK_btn_PlayFirst`: Button for the first player, which generates the results of rolling two dice and displays them.
- `NK_imgList`: List of images of dice rolls.
- `NK_btn_PlaySecond`: Button for the second player, which generates the results of rolling two dice, displays them, and determines the winner.
- `NK_lbl_Points1` and `NK_lbl_Points2`: Labels to display the points of the first and second players respectively.
- `NK_pic_FpD1`, `NK_pic_FpD2`, `NK_pic_SpD1`, `NK_pic_SpD2`: Images to display the results of dice rolls.
- `NK_lbl_Result`: Label to display the game result (first player wins, second player wins, or draw).


## Core Features

- Starting a new game: Initializes the game state when NK_btn_StartNew button is clicked, resets all scores, and hides dice images.
- Rolling dice for the first player: Generates random numbers for two dice, displays the results, and updates the first player's scores when NK_btn_PlayFirst button is clicked.
- Rolling dice for the second player: Generates random numbers for two dice, displays the results, updates the second player's scores, and determines the winner when NK_btn_PlaySecond button is clicked.
