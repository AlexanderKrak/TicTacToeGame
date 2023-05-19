using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTacToeGame
{
    internal class Program
    {

        public static void Refresh(string[,] board)
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("      " + board[i, j] + "   ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        public static void Restart()
        {
            string[,] resetBoard =
            {
                {"1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8","9" },
            };

          
        }

        public static bool Check(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i]) 
                    return true;
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2,2 ])
                    return true;
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                    return true;
            }
            return false;   
        }

        static void Main(string[] args)
        {
            string p1 = "O";
            string p2 = "X";
            bool playerOne = false;
            bool playerTwo = false;
            byte tipp;


            string[,] board =
            {
                {"1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8","9" },
            };
            Refresh(board);

            
            
            
            do
            {
                Console.Write("      " + "Player one: ");
                tipp = byte.Parse(Console.ReadLine());

                switch (tipp)
                {
                    case 1:
                            board[0, 0] = p1;
                            Refresh(board);
                        break;
                    case 2:
                            board[0, 1] = p1;
                            Refresh(board);
                        break;
                    case 3:
                            board[0, 2] = p1;
                            Refresh(board);
                        break;
                    case 4:
                            board[1, 0] = p1;
                            Refresh(board);
                        break;
                    case 5:
                            board[1, 1] = p1;
                            Refresh(board);
                        break;
                    case 6:
                            board[1, 2] = p1;
                            Refresh(board);
                        break;
                    case 7:
                            board[2, 0] = p1;
                            Refresh(board);
                        break;
                    case 8:
                            board[2, 1] = p1;
                            Refresh(board);
                        break;
                    case 9:
                            board[2, 2] = p1;
                            Refresh(board);
                        break;
                        default: 
                        break;
                }
                Check(board);
                if(Check(board) == true)
                {
                    Console.WriteLine("Player one won the game");
                    break;
                }
                Console.Write("      " + "Player two: ");
                tipp = byte.Parse(Console.ReadLine());

                switch (tipp)
                {
                    case 1:
                        board[0, 0] = p2;
                        Refresh(board);
                        break;
                    case 2:
                        board[0, 1] = p2;
                        Refresh(board);
                        break;
                    case 3:
                        board[0, 2] = p2;
                        Refresh(board);
                        break;
                    case 4:
                        board[1, 0] = p2;
                        Refresh(board);
                        break;
                    case 5:
                        board[1, 1] = p2;
                        Refresh(board);
                        break;
                    case 6:
                        board[1, 2] = p2;
                        Refresh(board);
                        break;
                    case 7:
                        board[2, 0] = p2;
                        Refresh(board);
                        break;
                    case 8:
                        board[2, 1] = p2;
                        Refresh(board);
                        break;
                    case 9:
                        board[2, 2] = p2;
                        Refresh(board);
                        break;
                    default:
                        break;
                }
                Check(board);
                if(Check(board) == true)
                {
                    Console.WriteLine("Player two won the game");
                }


            } while (Check(board) != true);
            
            
        }
    }
}