using System;

namespace ConnectFour
{
    public class Controller
    {
        private GameBoard board;

        public Controller()
        {
            board = new GameBoard();
        }
    }

    public class GameBoard
    {
        private char[,] board;

        public GameBoard()
        {
            board = new char[6, 7];
        }
    }

    public abstract class Player
    {
        public string Name { get; set; } = "";
        public char Symbol { get; set; }
    }

    public class HumanPlayer : Player
    {
    }

    public class View
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Controller game = new Controller();

            Console.WriteLine("Connect Four");
        }
    }
}