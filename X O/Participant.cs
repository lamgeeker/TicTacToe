using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O;

namespace X_O
{
    internal interface IParticipant
    {
       
        string Name { get; set; }    
        char Symbol { get; set; }
        void MakeMove(Board board);
    }
}
