using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacAndAI
{
    class Program
    {
        public static int[] grid = new int[9];
        public static int currentuser = 1;
        static void Main(string[] args)
        {
         //  Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome To TIC_TAC_TOE GAME\nPlease Enter Any input from 0-8\nPLAYER MARK IS '1' & COMPUTER MARK IS '2'");
           
            for (; ; )
            {


                int input = Convert.ToInt32(Console.ReadLine());
                if (grid[input] == 0)
                {
                    grid[input] = currentuser;
                    bool gameover = checkwin();


                    if (gameover == true)
                    {
                        Console.WriteLine(currentuser + " wins");
                        break;
                    }
                    flipuser();
                    printgrid();
                }
                else
                {
                    Console.WriteLine("Already marked please select someother");
                }


            }

        }
        public static void printgrid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", grid[0], grid[1], grid[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", grid[3], grid[4], grid[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", grid[6], grid[7], grid[8]);
        }
        public static void AIKHELO()
        {

            string comb1 = Convert.ToString(grid[0]) + grid[1].ToString() + grid[2].ToString();
            string comb2 = Convert.ToString(grid[3]) + grid[4].ToString() + grid[5].ToString();
            string comb3 = Convert.ToString(grid[6]) + grid[7].ToString() + grid[8].ToString();
            string comb4 = Convert.ToString(grid[0]) + grid[3].ToString() + grid[6].ToString();
            string comb5 = Convert.ToString(grid[1]) + grid[4].ToString() + grid[7].ToString();
            string comb6 = Convert.ToString(grid[2]) + grid[5].ToString() + grid[8].ToString();
            string comb7 = Convert.ToString(grid[0]) + grid[4].ToString() + grid[8].ToString();
            string comb8 = Convert.ToString(grid[2]) + grid[4].ToString() + grid[6].ToString();


            if (comb1 == "202")
            {
                grid[1] = 2;
            }
            else
                if (comb1 == "220")
                {
                    grid[2] = 2;
                }
                else
                    if (comb1 == "022")
                    {
                        grid[0] = 2;
                    }
                    else
                        if (comb2 == "202")
                        {
                            grid[4] = 2;
                        }
                        else
                            if (comb2 == "220")
                            {
                                grid[5] = 2;
                            }
                            else
                                if (comb2 == "022")
                                {
                                    grid[3] = 2;
                                }
                                else
                                    if (comb3 == "202")
                                    {
                                        grid[7] = 2;
                                    }
                                    else
                                        if (comb3 == "220")
                                        {
                                            grid[8] = 2;
                                        }
                                        else
                                            if (comb3 == "022")
                                            {
                                                grid[6] = 2;
                                            }
                                            else
                                                if (comb4 == "202")
                                                {
                                                    grid[3] = 2;
                                                }
                                                else
                                                    if (comb4 == "220")
                                                    {
                                                        grid[6] = 2;
                                                    }
                                                    else
                                                        if (comb4 == "022")
                                                        {
                                                            grid[0] = 2;
                                                        }
                                                        else
                                                            if (comb5 == "202")
                                                            {
                                                                grid[4] = 2;
                                                            }
                                                            else
                                                                if (comb5 == "220")
                                                                {
                                                                    grid[7] = 2;
                                                                }
                                                                else
                                                                    if (comb5 == "022")
                                                                    {
                                                                        grid[1] = 2;
                                                                    }
                                                                    else
                                                                        if (comb6 == "202")
                                                                        {
                                                                            grid[5] = 2;
                                                                        }
                                                                        else
                                                                            if (comb6 == "220")
                                                                            {
                                                                                grid[8] = 2;
                                                                            }
                                                                            else
                                                                                if (comb6 == "022")
                                                                                {
                                                                                    grid[2] = 2;
                                                                                }
                                                                                else
                                                                                    if (comb7 == "202")
                                                                                    {
                                                                                        grid[4] = 2;
                                                                                    }
                                                                                    else
                                                                                        if (comb7 == "220")
                                                                                        {
                                                                                            grid[8] = 2;
                                                                                        }
                                                                                        else
                                                                                            if (comb7 == "022")
                                                                                            {
                                                                                                grid[0] = 2;
                                                                                            }
                                                                                            else
                                                                                                if (comb8 == "202")
                                                                                                {
                                                                                                    grid[4] = 2;
                                                                                                }
                                                                                                else
                                                                                                    if (comb8 == "220")
                                                                                                    {
                                                                                                        grid[6] = 2;
                                                                                                    }
                                                                                                    else
                                                                                                        if (comb8 == "022")
                                                                                                        {
                                                                                                            grid[2] = 2;
                                                                                                        }
                                                                                                        else
                                                                                                            if (comb1 == "101")
                                                                                                            {
                                                                                                                grid[1] = 2;
                                                                                                            }
                                                                                                            else
                                                                                                                if (comb1 == "110")
                                                                                                                {
                                                                                                                    grid[2] = 2;
                                                                                                                }
                                                                                                                else
                                                                                                                    if (comb1 == "011")
                                                                                                                    {
                                                                                                                        grid[0] = 2;
                                                                                                                    }
                                                                                                                    else
                                                                                                                        if (comb2 == "101")
                                                                                                                        {
                                                                                                                            grid[4] = 2;
                                                                                                                        }
                                                                                                                        else
                                                                                                                            if (comb2 == "110")
                                                                                                                            {
                                                                                                                                grid[5] = 2;
                                                                                                                            }
                                                                                                                            else
                                                                                                                                if (comb2 == "011")
                                                                                                                                {
                                                                                                                                    grid[3] = 2;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                    if (comb3 == "101")
                                                                                                                                    {
                                                                                                                                        grid[7] = 2;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                        if (comb3 == "110")
                                                                                                                                        {
                                                                                                                                            grid[8] = 2;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                            if (comb3 == "011")
                                                                                                                                            {
                                                                                                                                                grid[6] = 2;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                if (comb4 == "101")
                                                                                                                                                {
                                                                                                                                                    grid[3] = 2;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                    if (comb4 == "110")
                                                                                                                                                    {
                                                                                                                                                        grid[6] = 2;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                        if (comb4 == "011")
                                                                                                                                                        {
                                                                                                                                                            grid[0] = 2;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                            if (comb5 == "101")
                                                                                                                                                            {
                                                                                                                                                                grid[4] = 2;
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                                if (comb5 == "110")
                                                                                                                                                                {
                                                                                                                                                                    grid[7] = 2;
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                    if (comb5 == "011")
                                                                                                                                                                    {
                                                                                                                                                                        grid[1] = 2;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                        if (comb6 == "101")
                                                                                                                                                                        {
                                                                                                                                                                            grid[5] = 2;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                            if (comb6 == "110")
                                                                                                                                                                            {
                                                                                                                                                                                grid[8] = 2;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                                if (comb6 == "011")
                                                                                                                                                                                {
                                                                                                                                                                                    grid[2] = 2;
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                    if (comb7 == "101")
                                                                                                                                                                                    {
                                                                                                                                                                                        grid[4] = 2;
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                        if (comb7 == "110")
                                                                                                                                                                                        {
                                                                                                                                                                                            grid[8] = 2;
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                            if (comb7 == "011")
                                                                                                                                                                                            {
                                                                                                                                                                                                grid[0] = 2;
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                                if (comb8 == "101")
                                                                                                                                                                                                {
                                                                                                                                                                                                    grid[4] = 2;
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                    if (comb8 == "110")
                                                                                                                                                                                                    {
                                                                                                                                                                                                        grid[6] = 2;
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if (comb8 == "011")
                                                                                                                                                                                                        {
                                                                                                                                                                                                            grid[2] = 2;
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                        {
                                                                                                                                                                                                            markrandomly();
                                                                                                                                                                                                        }







        }
        public static void markrandomly()
        {
            Random r = new Random();
            for (; ; )
            {
                int y = r.Next(0, 8);
                if (grid[y] == 0)
                {
                    grid[y] = 2;
                    break;
                }
            }
        }
        public static void flipuser()
        {
            if (currentuser == 1)
            {
                currentuser = 2;
                AIKHELO();
                currentuser = 1;
               //flipuser();
            }
            else
            {
                currentuser = 1;
            }
        }
        public static bool checkwin()
        {
            bool win = false;
            if (grid[0] == currentuser && grid[1] == currentuser && grid[2] == currentuser)
            {
                win = true;
            }
            else
                if (grid[3] == currentuser && grid[4] == currentuser && grid[5] == currentuser)
                {
                    win = true;
                }
                else
                    if (grid[6] == currentuser && grid[7] == currentuser && grid[8] == currentuser)
                    {
                        win = true;
                    }
                    else
                        if (grid[0] == currentuser && grid[3] == currentuser && grid[6] == currentuser)
                        {
                            win = true;
                        }
                        else
                            if (grid[1] == currentuser && grid[4] == currentuser && grid[7] == currentuser)
                            {
                                win = true;
                            }
                            else
                                if (grid[2] == currentuser && grid[5] == currentuser && grid[8] == currentuser)
                                {
                                    win = true;
                                }
                                else
                                    if (grid[0] == currentuser && grid[4] == currentuser && grid[8] == currentuser)
                                    {
                                        win = true;
                                    }
                                    else
                                        if (grid[2] == currentuser && grid[4] == currentuser && grid[6] == currentuser)
                                        {
                                            win = true;
                                        }

            return win;
        }
    }
}
