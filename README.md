# TicTacToe
5 hour to complete

Module Name: TicTacToe Game

Summary:
The TicTacToe Game module is designed to fulfill the consumer's need for a playable Tic-Tac-Toe game in a console application. It allows two players to compete against each other on a 3x3 game board, taking turns marking spaces until a winner is determined or the game ends in a draw.

Step-by-Step Directions (Happy Path Walkthrough):

Launch the TicTacToe Game module in a console environment.
Enter the name of Player 1 when prompted.
Enter the name of Player 2 when prompted.
The game board is displayed, showing the initial state with numbered slots.
Player 1 starts the game. The current player's name is displayed.
Players take turns selecting a slot by entering the corresponding number and pressing Enter.
The selected slot is marked with the player's marker (X or O) on the board.
The game continues until a player wins or the game ends in a draw.
If a player wins, a message is displayed with the winner's name.
If the game ends in a draw, a message indicating a tie is displayed.
The game prompts the user to play again or exit the module.
Relevant Details:

The module allows two players to play against each other on the same device.
Players take turns marking slots on the game board until there is a winner or a draw.
The module validates the player's input and prevents selecting an already marked slot.
The winner is determined by matching markers in a row, column, or diagonal on the game board.
The module provides clear instructions and prompts to guide the players throughout the game.
The game ends with an option to play again or exit the module.


Hi. Let's play TicTacToe!!
Player1's name: fred
Player2's name: dav
====== fred vs dav =====
Here's the board
|1||2||3|
|4||5||6|
|7||8||9|
It's fred's turn!
Please choose a slot.
|1||2||3|
|4||5||6|
|7||8||9|
1
It's dav's turn!
Please choose a slot.
|X||2||3|
|4||5||6|
|7||8||9|
2
It's fred's turn!
Please choose a slot.
|X||O||3|
|4||5||6|
|7||8||9|
5
It's dav's turn!
Please choose a slot.
|X||O||3|
|4||X||6|
|7||8||9|
3
It's fred's turn!
Please choose a slot.
|X||O||O|
|4||X||6|
|7||8||9|
9
Congratulations, fred! You are the winner!
