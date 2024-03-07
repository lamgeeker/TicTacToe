using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    internal class Player : IParticipant
    {
        
        public char Symbol { get; set; }
       
        string IParticipant.Name { get ; set ; }

      
        public void MakeMove(Board board)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("По горизонті (поле 3 на 3)");
                    int goruz = int.Parse(Console.ReadLine());
                    Console.WriteLine("По вертикалі (поле 3 на 3)");
                    int vert = int.Parse(Console.ReadLine());


                    if (vert < 4 && goruz < 4)
                    {
                        if (board.board[goruz - 1, vert - 1] != 'x' && board.board[goruz - 1, vert - 1] != 'o')
                        {
                            board.board[goruz - 1, vert - 1] = Symbol;

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Тут уже стоїть символ, обдумайте ваш вибір краще");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нагадування: поле 3 на 3");
                        continue;
                    }
                }
                catch { Console.WriteLine("Введіть коректне значення"); }
            }
          
        }
    }
}
