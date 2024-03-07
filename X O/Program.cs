using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Game game = new Game();
            Board board = new Board();
            Console.WriteLine("Проти кого будете грати: компуктер(1) чи ваш друг(2)");
           
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice > 2)
                    {
                        Console.WriteLine("Немає третього варіанту");
                        return;
                    }

                    IParticipant participant1 = new Player();
                    IParticipant participant2 = new Player();
                    IParticipant participant3 = new Computer();
                    int WhoMovesFirst = (new Random()).Next(4);

                    Console.WriteLine("Введіть ваше ім'я (1-ий гравець)");
                    participant1.Name = Console.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("Обери символ, яким будеш грати (х чи о)");
                        try
                        {
                            participant1.Symbol = char.Parse(Console.ReadLine());
                        }
                        catch { }
                        if (participant1.Symbol == 'x')
                        {
                            participant2.Symbol = 'o';
                            participant3.Symbol = 'o';
                            break;
                        }
                        else if (participant1.Symbol == 'o')
                        {
                            participant2.Symbol = 'x';
                            participant3.Symbol = 'x';
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введіть коректний символ");
                            continue;
                        }
                    }
                    if (choice == 1)
                    {
                        Console.WriteLine("Зараз оберемо, хто ходить першим");
                        Console.WriteLine("ТККККК.....");
                        Console.WriteLine("ТККККК.....");
                        Console.WriteLine("ТККККК.....");

                        while (true)
                        {

                            if (WhoMovesFirst == 1 || WhoMovesFirst == 2)
                            {

                                Console.WriteLine(participant1.Name + " ходить перший");
                                participant1.MakeMove(board);


                                Console.WriteLine();
                                board.PrintBoard();
                                string res = game.WhoIsWinner(board, participant1, participant3);
                                Console.WriteLine(res);
                            if (res == participant1.Name + " переміг")
                            {
                                break;
                            }
                            else if (res == participant3.Name + " переміг")
                            {
                                break;
                            }
                            else if (board.IsBoardFull())
                            {
                                Console.WriteLine("Нічия");
                                break;
                            }
                            
                                participant3.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine(participant3.Name + " ходить перший");
                                participant3.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                                string res = game.WhoIsWinner(board, participant1, participant3);
                                Console.WriteLine(res);
                                if (res == participant1.Name + " переміг")
                                {
                                    break;
                                }
                                else if (res == participant3.Name + " переміг")
                                {
                                    break;
                                }
                            else if (board.IsBoardFull())
                            {
                                Console.WriteLine("Нічия");
                                break;
                            }
                            participant1.MakeMove(board);


                                Console.WriteLine();
                                board.PrintBoard();
                            }
                            string result = game.WhoIsWinner(board, participant1, participant3);
                            Console.WriteLine(result);
                            if (result == participant1.Name + " переміг")
                            {
                             
                                break;
                            }
                            else if (result == participant3.Name + " переміг")
                            {
                            
                                break;
                            }
                           else if (board.IsBoardFull())
                        {
                            Console.WriteLine("Нічия");
                            break;
                        }
                         }

                    
                    }

                    else if (choice == 2)
                    {
                        Console.WriteLine("Введіть ваше ім'я (2-ий гравець)");
                        participant2.Name = Console.ReadLine();
                        Console.WriteLine("Зараз оберемо, хто ходить першим");
                        Console.WriteLine("ТККККК.....");
                        Console.WriteLine("ТККККК.....");
                        Console.WriteLine("ТККККК.....");
                        while (true)
                        {

                            if (WhoMovesFirst == 1 || WhoMovesFirst == 2)
                            {
                                Console.WriteLine(participant1.Name + " ходить перший");
                                participant1.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                                string res = game.WhoIsWinner(board, participant1, participant2);
                                Console.WriteLine(res);
                                if (res == participant1.Name + " переміг")
                                {
                                    break;
                                }
                                else if (res == participant2.Name + " переміг")
                                {
                                    break;
                                }
                            else if (board.IsBoardFull())
                            {
                                Console.WriteLine("Нічия");
                                break;
                            }
                            participant2.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine(participant2.Name + " ходить перший");
                                participant2.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                                string res = game.WhoIsWinner(board, participant1, participant2);
                                Console.WriteLine(res);
                                if (res == participant1.Name + " переміг")
                                {
                                    break;
                                }
                                else if (res == participant2.Name + " переміг")
                                {
                                    break;
                                }
                            else if (board.IsBoardFull())
                            {
                                Console.WriteLine("Нічия");
                                break;
                            }
                            participant1.MakeMove(board);
                                Console.WriteLine();
                                board.PrintBoard();
                            }
                            string result = game.WhoIsWinner(board, participant1, participant2);
                            Console.WriteLine(result);
                            if (result == participant1.Name + " переміг")
                            {
                                break;
                            }
                            else if (result == participant2.Name + " переміг")
                            {
                                break;
                            }
                        else if (board.IsBoardFull())
                        {
                            Console.WriteLine("Нічия");
                            break;
                        }
                    }
                    }
                }
                catch { Console.WriteLine("Введіть коректне значення"); }
              
            














            //Console.OutputEncoding = UTF8Encoding.UTF8;
            //Game game = new Game();
            //Board board = new Board();
            //Console.WriteLine("Проти кого будете грати: компуктер(1) чи ваш друг(2)");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    IParticipant participant1 = new Player();
            //    IParticipant participant2 = new Computer();
            //    Console.WriteLine("Введіть ваше ім'я");
            //    participant1.Name = Console.ReadLine();
            //    while (true)
            //    {
            //        Console.WriteLine("Оберіть ваш символ (х чи о)");
            //    participant1.Symbol = char.Parse(Console.ReadLine());


            //        if (participant1.Symbol == 'x')
            //        {

            //            participant2.Symbol = 'o';
            //            break;
            //        }
            //        else if (participant1.Symbol == 'o')
            //        {

            //            participant2.Symbol = 'x';
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введіть коректний символ");
            //            continue;
            //        }
            //    }
            //    Console.WriteLine("Зараз оберемо, хто ходить першим");
            //    Console.WriteLine("ТККККК.....");
            //    Console.WriteLine("ТККККК.....");
            //    Console.WriteLine("ТККККК.....");
            //    int whosMoveFirst = (new Random()).Next(3);
            //    if(whosMoveFirst == 1)
            //    {
            //        Console.WriteLine($"Гравець {participant1.Name} ходить першим");
            //        while (true)
            //        {
            //            participant1.MakeMove(board);
            //            board.PrintBoard();
            //            string res = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(res);
            //            if (res == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (res == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }
            //            participant2.MakeMove(board);
            //            Console.WriteLine();
            //            Console.WriteLine("--------------------");
            //            Console.WriteLine();
            //            board.PrintBoard();
            //            string result = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(result);
            //            if(result == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if(result == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Гравець {participant2.Name} ходить першим");

            //        while (true)
            //        {
            //            participant2.MakeMove(board);
            //            board.PrintBoard();
            //            string res = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(res);
            //            if (res == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (res == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }
            //            participant1.MakeMove(board);
            //            Console.WriteLine();
            //            Console.WriteLine("--------------------");
            //            Console.WriteLine();
            //            board.PrintBoard();
            //            string result = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(result);
            //            if (result == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (result == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }

            //        }
            //    }

            //}
            //else if(choice == 2)
            //{
            //    IParticipant participant1 = new Player();
            //    IParticipant participant2 = new Player();
            //    Console.WriteLine("Введіть ваше ім'я (1-й гравець)");
            //    participant1.Name = Console.ReadLine();
            //    Console.WriteLine("Введіть ваше ім'я (2-й гравець)");
            //    participant2.Name = Console.ReadLine();
            //    while (true)
            //    {
            //        Console.WriteLine("Оберіть ваш символ (х чи о)");
            //        participant1.Symbol = char.Parse(Console.ReadLine());
            //        if (participant1.Symbol == 'x')
            //        {

            //            participant2.Symbol = 'o';
            //            break;
            //        }
            //        else if (participant1.Symbol == 'o')
            //        {

            //            participant2.Symbol = 'x';
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введіть коректний символ");
            //            continue;
            //        }
            //    }
            //    Console.WriteLine("Зараз оберемо, хто ходить першим");
            //    Console.WriteLine("ТККККК.....");
            //    Console.WriteLine("ТККККК.....");
            //    Console.WriteLine("ТККККК.....");
            //    int whosMoveFirst = (new Random()).Next(4);
            //    if (whosMoveFirst == 1 || whosMoveFirst == 3)
            //    {
            //        Console.WriteLine($"Гравець {participant1.Name} ходить першим");
            //        while (true)
            //        {
            //            participant1.MakeMove(board);
            //            board.PrintBoard();
            //            string res = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(res);
            //            if (res == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (res == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }
            //            participant2.MakeMove(board);
            //            Console.WriteLine();
            //            Console.WriteLine("--------------------");
            //            Console.WriteLine();
            //            board.PrintBoard();
            //            string result = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(result);
            //            if (result == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (result == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Гравець {participant2.Name} ходить першим");

            //        while (true)
            //        {
            //            participant2.MakeMove(board);
            //            board.PrintBoard();
            //            string res = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(res);
            //            if (res == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (res == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }
            //            participant1.MakeMove(board);
            //            Console.WriteLine();
            //            Console.WriteLine("--------------------");
            //            Console.WriteLine();
            //            board.PrintBoard();
            //            string result = game.WhoIsWinner(board, participant1, participant2);
            //            Console.WriteLine(result);
            //            if (result == $"{participant1.Name} переміг")
            //            {
            //                break;
            //            }
            //            else if (result == $"{participant2.Name} переміг")
            //            {
            //                break;
            //            }

            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Вибачте, немає 3-го варіанту");
            //}
        }
    }
}
