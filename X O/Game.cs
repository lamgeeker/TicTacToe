using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    internal class Game
    {
        

        public string WhoIsWinner(Board board, IParticipant participant, IParticipant participant1)
        {
           
                if (board.board[0, 0] == participant.Symbol && board.board[0, 1] == participant.Symbol && board.board[0, 2] == participant.Symbol || board.board[1, 0] == participant.Symbol && board.board[1, 1] == participant.Symbol && board.board[1, 2] == participant.Symbol || board.board[2, 0] == participant.Symbol && board.board[2, 1] == participant.Symbol && board.board[2, 2] == participant.Symbol || board.board[0, 0] == participant.Symbol && board.board[1, 0] == participant.Symbol && board.board[2, 0] == participant.Symbol || board.board[0, 1] == participant.Symbol && board.board[1, 1] == participant.Symbol && board.board[2, 1] == participant.Symbol || board.board[0, 2] == participant.Symbol && board.board[1, 2] == participant.Symbol && board.board[2, 2] == participant.Symbol || board.board[0, 0] == participant.Symbol && board.board[1, 1] == participant.Symbol && board.board[2, 2] == participant.Symbol || board.board[0, 2] == participant.Symbol && board.board[1, 1] == participant.Symbol && board.board[2, 0] == participant.Symbol)
                {
                    
                    
                    return participant.Name + " переміг";
                }
                else if (board.board[0, 0] == participant1.Symbol && board.board[0, 1] == participant1.Symbol && board.board[0, 2] == participant1.Symbol || board.board[1, 0] == participant1.Symbol && board.board[1, 1] == participant1.Symbol && board.board[1, 2] == participant1.Symbol || board.board[2, 0] == participant1.Symbol && board.board[2, 1] == participant1.Symbol && board.board[2, 2] == participant1.Symbol || board.board[0, 0] == participant1.Symbol && board.board[1, 0] == participant1.Symbol && board.board[2, 0] == participant1.Symbol || board.board[0, 1] == participant1.Symbol && board.board[1, 1] == participant1.Symbol && board.board[2, 1] == participant1.Symbol || board.board[0, 2] == participant1.Symbol && board.board[1, 2] == participant1.Symbol && board.board[2, 2] == participant1.Symbol || board.board[0, 0] == participant1.Symbol && board.board[1, 1] == participant1.Symbol && board.board[2, 2] == participant1.Symbol || board.board[0, 2] == participant1.Symbol && board.board[1, 1] == participant1.Symbol && board.board[2, 0] == participant1.Symbol)
                {
                   
                    
                    return participant1.Name + " переміг";
                }
          
            return "";
        }

    }
}

