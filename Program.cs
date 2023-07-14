namespace TicTacToe
{
    public class Player
    {
        public string Name;
        public string Marker;
        public Player(string name,string marker)
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
            Console.WriteLine("Hello, Welcome to TicTacToe");
            Console.WriteLine("Player One Name");
            string PlayerOneName = Console.ReadLine();
            Player Player1 = new Player(PlayerOneName,"X");
            Console.WriteLine("Player two Name");
            string PlayerTwoName = Console.ReadLine();
            Player Player2 = new Player(PlayerTwoName, "O");
            Console.WriteLine("============={0} vs {1} ==================",Player1.Name,Player2.Name);

            Board = new string[][]
             {
                new string[] {"1", "2", "3"},
                new string[] {"4", "5", "6"},
                new string[] {"7", "8", "9"}
             };

            Console.WriteLine("Heres the board");
            DisplayBoard();

            Player currentPlayer = Player1;
            string winner = null;
            while (winner == null)
            {
            Console.WriteLine("Its {0}'s Turns!", currentPlayer.Name);
                Console.WriteLine("Please choose a slot");
                DisplayBoard();
                string SelectedSlot = Console.ReadLine();

                if (SelectedSlot == "1")
                {
                    Board[0][0] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "2") 
                {
                    Board[0][1] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "3")
                {
                    Board[0][2] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "4")
                {
                    Board[1][0] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "5")
                {
                    Board[1][1] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "6")
                {
                    Board[1][2] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "7")
                {
                    Board[2][0] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "8")
                {
                    Board[2][1] = currentPlayer.Marker;
                }
                else if (SelectedSlot == "9")
                {
                    Board[2][2] = currentPlayer.Marker;
                }






                if (currentPlayer == Player1)
                {
                    currentPlayer = Player2;  
                }else if (currentPlayer == Player2) { 
                    currentPlayer = Player1;  
                }

            }

        }
        static void DisplayBoard()
        {
            Console.WriteLine("| {0} | {1} | {2} |", Board[0][0] , Board[0][1], Board[0][2]);
            Console.WriteLine("| {0} | {1} | {2} |", Board[1][0], Board[1][1], Board[1][2]);
            Console.WriteLine("| {0} | {1} | {2} |", Board[2][0], Board[2][1], Board[2][2]);
        }
    }

}