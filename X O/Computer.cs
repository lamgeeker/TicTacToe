using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    internal class Computer : IParticipant
    {
       
        public char Symbol { get; set; }

        string IParticipant.Name { get; set; } = "Компуктер";

        public void MakeMove(Board board)
        {
            while (true)
            {
              
                int goruz = (new Random()).Next(0, 10);
                if (goruz == 0 || goruz == 5 || goruz == 8)
                {
                    goruz = 0;
                }
                else if (goruz == 1 || goruz == 7 || goruz == 9) { goruz = 1; }
                else
                    goruz = 2;
                
                int vert = (new Random()).Next(0, 10);
                if (vert == 0 || vert == 5 || vert == 8)
                {
                    vert = 2;
                }
                else if (vert == 1 || vert == 7 || vert == 9) { vert = 0; }
                else
                    vert = 1;
             
                if (board.board[goruz, vert] != 'o' && board.board[goruz, vert] != 'x')
                {
                    
                    board.board[goruz, vert] = Symbol;
                    break;
                }
                else
                {
                   
                    continue;
                }

            }
           
            
        }
    }
}
