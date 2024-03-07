using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    internal class Board
    {
       public char[,] board = { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } };


        public void PrintBoard()
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j< board.GetLength(1); j++)
                {
                    
                    Console.Write(board[i,j] + "       ");
                  
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }

        public bool IsBoardFull()
        {
            if (board[0,0] != '.' && board[0, 1] != '.' && board[0, 2] != '.' && board[1, 0] != '.' && board[1, 1] != '.' && board[1, 2] != '.' && board[2, 0] != '.' && board[2, 1] != '.' && board[2, 2] != '.')
            {
                return true;
            }
            return false;
        }
    }
}
