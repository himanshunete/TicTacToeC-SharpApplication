using System;

namespace TicTacToeCSharpApplication
{
    class TicTactoe
    {
        public static string PLAYER_1;
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void createBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Empty board:" + i + ": " + board[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Tic Tac Toe Game");
            TicTactoe.createBoard();
        }
    }
}
