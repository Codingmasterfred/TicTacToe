﻿

namespace TicTacToe
{
    public class Player
    {
        public string Name;
        public string Marker;

        public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;
        }
    }

    internal class Program
    {
        public static string[][] Board;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Let's play TicTacToe!!");
            Console.Write("Player1's name: ");
            string player1name = Console.ReadLine();
            Player player1 = new Player(player1name, "X");

            Console.Write("Player2's name: ");
            string player2name = Console.ReadLine();
            Player player2 = new Player(player2name, "O");

            Console.WriteLine("====== {0} vs {1} =====", player1.Name, player2.Name);

            Board = new string[][] {
               new string[] {"1", "2", "3"},
               new string[] {"4", "5", "6"},
               new string[] {"7", "8", "9"}
            };

            Console.WriteLine("Here's the board");
            DisplayBoard();

            Player currentPlayer = player1;
            string winner = null;

            while (winner == null)
            {
                Console.WriteLine("It's {0}'s turn!", currentPlayer.Name);

                Console.WriteLine("Please choose a slot.");
                DisplayBoard();
                string selectedSlot = Console.ReadLine();

                // Check if slot has already been selected
                bool isValid = SelectionIsValid(selectedSlot);
                if (isValid)
                {
                    int[] indexes = SelectionToIndexes(selectedSlot);
                    int row = indexes[0];
                    int column = indexes[1];
                    Board[row][column] = currentPlayer.Marker;

                    // Check for a winner
                    winner = CheckForWinner();
                }
                else
                {
                    continue;
                }

                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else if (currentPlayer == player2)
                {
                    currentPlayer = player1;
                }
            }

            if (winner != null)
            {
                if (winner == player1.Marker)
                {
                    Console.WriteLine("Congratulations, {0}! You are the winner!", player1.Name);

                }
                else if(winner == player2.Marker)
                {
                    Console.WriteLine("Congratulations, {0}! You are the winner!", player2.Name);
                }

            }
            else
            {
                Console.WriteLine("It's a draw. The game ended in a tie.");
            }

            Console.ReadLine();
        }

        static void DisplayBoard()
        {
            Console.WriteLine("|{0}||{1}||{2}|", Board[0][0], Board[0][1], Board[0][2]);
            Console.WriteLine("|{0}||{1}||{2}|", Board[1][0], Board[1][1], Board[1][2]);
            Console.WriteLine("|{0}||{1}||{2}|", Board[2][0], Board[2][1], Board[2][2]);
        }

        static int[] SelectionToIndexes(string selectedSlot)
        {
            int[] indexes = new int[2];
            switch (selectedSlot)
            {
                case "1":
                    indexes[0] = 0;
                    indexes[1] = 0;
                    break;
                case "2":
                    indexes[0] = 0;
                    indexes[1] = 1;
                    break;
                case "3":
                    indexes[0] = 0;
                    indexes[1] = 2;
                    break;
                case "4":
                    indexes[0] = 1;
                    indexes[1] = 0;
                    break;
                case "5":
                    indexes[0] = 1;
                    indexes[1] = 1;
                    break;
                case "6":
                    indexes[0] = 1;
                    indexes[1] = 2;
                    break;
                case "7":
                    indexes[0] = 2;
                    indexes[1] = 0;
                    break;
                case "8":
                    indexes[0] = 2;
                    indexes[1] = 1;
                    break;
                case "9":
                    indexes[0] = 2;
                    indexes[1] = 2;
                    break;
            }
            return indexes;
        }

        static bool SelectionIsValid(string selectedSlot)
        {
            bool isValid = true;
            int[] indexes = SelectionToIndexes(selectedSlot);
            int row = indexes[0];
            int column = indexes[1];
            string slotValue = Board[row][column];
            if (slotValue == "X" || slotValue == "O")
            {
                isValid = false;
            }
            if (isValid == false)
            {
                Console.WriteLine("Selection is invalid");
            }
            return isValid;
        }

        static string CheckForWinner()
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (Board[row][0] == Board[row][1] && Board[row][1] == Board[row][2])
                {
                    return Board[row][0];
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (Board[0][col] == Board[1][col] && Board[1][col] == Board[2][col])
                {
                    return Board[0][col];
                }
            } 

            // Check diagonals
            if ((Board[0][0] == Board[1][1] && Board[1][1] == Board[2][2]) ||
                (Board[0][2] == Board[1][1] && Board[1][1] == Board[2][0]))
            {
                return Board[1][1];
            } 
             
            return null; // No winner
        } 
    }
} 
