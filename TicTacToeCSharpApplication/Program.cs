using System;

namespace TicTacToeCSharpApplication
{
    class TicTactoe
    {
        public static string PLAYER_1;
        public const char LETTERX = 'X';
        public const char LETTERO = 'O';
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void createBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Empty board:" + i + ": " + board[i]);
            }
        }

        public static char chooseLetter(char letterPlayer, char letterComputer)
        {
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
            return letterPlayer;
        }

        public static void showBoard()
        {
                Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");
                Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
                Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");

        }

        public static void makeAMove(char letterPlayer)
        {
            char freeSpace = ' ';
            Random rand = new Random();
            Console.WriteLine(" Desired Location ");
            int index = Convert.ToInt32(Console.ReadLine());
            if ( board[index] == ' ')
            {
                if (letterPlayer == 'X')
                {
                    board[index] = letterPlayer;
                }
                else if (letterPlayer == 'O')
                {
                    board[index] = letterPlayer;
                }
            }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            char[] letterComputer = { 'X', 'O' };
            Console.WriteLine(" Welcome to Tic Tac Toe Game");
            Random rand = new Random();
            Console.WriteLine(" Computer choose a letter");
            int i = rand.Next(letterComputer.Length);

            Console.WriteLine(" Player choose a letter");
            char letterPlayer = Console.ReadLine()[0];
            TicTactoe.chooseLetter(letterPlayer, letterComputer[i]);
            
            TicTactoe.makeAMove(letterPlayer);
            TicTactoe.showBoard();


        }
    }
}
