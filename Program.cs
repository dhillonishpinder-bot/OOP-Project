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

        public void DisplayBoard()
       {
           Console.Clear();

           Console.WriteLine(" 1 2 3 4 5 6 7");

           for (int row = 0; row < Rows; row++)
           {
               for (int col = 0; col < Columns; col++)
               {
                   Console.Write(" " + board[row, col]);
               }

               Console.WriteLine();
           }

           Console.WriteLine();
       }

         public bool DropDisc(int column, char symbol)
  {
      for (int row = Rows - 1; row >= 0; row--)
      {
          if (board[row, column] == '.')
          {
              board[row, column] = symbol;
              return true;
          }
      }

      return false;
  }
      public bool IsBoardFull()
  {
      for (int col = 0; col < Columns; col++)
      {
          if (board[0, col] == '.')
          {
              return false;
          }
      }

      return true;
  }
    public bool CheckWin(char symbol)
{

}
            
    public class Controller
    {
        private GameBoard board;

        public Controller()
        {
            board = new GameBoard();
        }
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





     // GameBoard Class

