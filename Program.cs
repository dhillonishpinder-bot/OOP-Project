using System;

namespace ConnectFour
{
    public abstract class Player
{
    public string Name { get; set; }
    public char Symbol { get; set; }

    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public abstract int GetMove();
}

        // Human Player Class
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol)
            : base(name, symbol)
        {
        }

        public override int GetMove()
        {
            while (true)
            {
                Console.Write($"{Name}, choose a column (1-7): ");

                if (int.TryParse(Console.ReadLine(), out int column))
                {
                    if (column >= 1 && column <= 7)
                    {
                        return column - 1;
                    }
                }

                Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
            }
        }
    }
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


   public class HumanPlayer:Player
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

using System;

namespace ConnectFour
{
    // Player Abstract Class
    public abstract class Player
    {
        public string Name { get; private set; }
        public char Symbol { get; private set; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public abstract int GetMove();
    }



     // GameBoard Class
    public class GameBoard
    {
        private const int Rows = 6;
        private const int Columns = 7;
        private char[,] board;

        public GameBoard()
        {
            board = new char[Rows, Columns];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    board[row, col] = '.';
                }
            }
        }
