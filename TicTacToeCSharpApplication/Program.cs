using System;

namespace TicTacToeCSharpApplication
{
    class TicTactoe
    {
        public static string PLAYER_1;
        public const int LETTERX = 0;
        public const int LETTERO = 1;

        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void createBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Empty board:" + i + ": " + board[i]);
            }
        }

        public static void chooseLetter()
        {

            Random rand = new Random();
            int letterComputer = rand.Next(0, 2);
            Console.WriteLine(" Choose a Letter");
            int letterPlayer = Convert.ToInt32(Console.ReadLine());

            switch (letterPlayer)
            {
                case LETTERX:
                    Console.WriteLine(" Player choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine("  Player choose O Option  ");
                    break;
            }

            switch (letterComputer)
            {
                case LETTERX:
                    Console.WriteLine(" Computer choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine(" Computer choose O Option  ");
                    break;
            }
        }

        public static void showBoard()
        {
                Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");
                Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
                Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Tic Tac Toe Game");
            TicTactoe.createBoard();
            TicTactoe.chooseLetter();
            TicTactoe.showBoard();

        }
    }
}
