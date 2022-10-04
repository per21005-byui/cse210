using System;

namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board;
            board = new string[9];
            bool xTurn = true;
            bool wonGame=false;
            string player;
            for(int i =0;i<9;i++)
            {
                int boardValue=i+1;
                board[i]=boardValue.ToString();
            }
            Console.WriteLine("Wellcome to Tic-Tac-Toe");
            
            while (wonGame==false)
            {
                if(xTurn){player="X";}else{player="O";}
                verifiedIntInput($"Player {player}'s turn:",ref board,player);
                if(checkWins(ref board,player))
                {
                    Console.WriteLine($"Congratulations {player}, you won the game!");
                    break;
                }
                else
                {
                    xTurn=!xTurn;
                    continue;
                }
                
            }
        }
        static void printBoard(ref string[] board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]} \n-+-+- \n{board[3]}|{board[4]}|{board[5]} \n-+-+- \n{board[6]}|{board[7]}|{board[8]} \n\n\n");
        }
        static bool checkWins(ref string[] board, string XorO)
        {
            bool returnVal=false;
            if    ((board[0] == XorO && board[1] == XorO && board[2] == XorO)
                || (board[3] == XorO && board[4] == XorO && board[5] == XorO)
                || (board[6] == XorO && board[7] == XorO && board[8] == XorO)
                || (board[0] == XorO && board[3] == XorO && board[6] == XorO)
                || (board[1] == XorO && board[4] == XorO && board[7] == XorO)
                || (board[2] == XorO && board[5] == XorO && board[8] == XorO)
                || (board[0] == XorO && board[4] == XorO && board[8] == XorO)
                || (board[2] == XorO && board[4] == XorO && board[6] == XorO))
            {
                returnVal=true;
            }
            return returnVal;
        }
        static void verifiedIntInput(string message,ref string[] board, string XorO)
        {
            int returnInteger=0;
            bool verified=false;
            printBoard(ref board);
            Console.WriteLine(message);
            while(!verified)
            {
                if(int.TryParse(Console.ReadLine(), out returnInteger))
                {
                    if(board[returnInteger-1]==returnInteger.ToString() && returnInteger>0 && returnInteger<10)
                    {
                        board[returnInteger-1]=XorO;
                        verified=true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Select an unplayed position.");
                    }
                }
                else
                {
                    Console.WriteLine("Write a valid number!");
                }
            };
        }
    }
}
