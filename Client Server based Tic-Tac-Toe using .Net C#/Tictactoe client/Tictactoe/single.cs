using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class single : Form
    {
        private static Pen pen;
        private static Graphics g;
        private static string[,] cell = new string[9,2];
        private static string currentplayer;
        private static Random r = new Random();
        public struct AIMove
        {
            public int currentcell;
            public int score;
            public AIMove(int Score) : this()
            {
                score = Score;
            }
        }

            
        public int CheckVictory()
        {
            
            //CHECK X
            if (cell[0, 1] == "X" && cell[1, 1] == "X" && cell[2, 1] == "X")
            {
                return 1;
            }
            if (cell[3, 1] == "X" && cell[4, 1] == "X" && cell[5, 1] == "X")
            {
                return 1;
            }
            if (cell[6, 1] == "X" && cell[7, 1] == "X" && cell[8, 1] == "X")
            {
                return 1;
            }
            if (cell[0, 1] == "X" && cell[3, 1] == "X" && cell[6, 1] == "X")
            {
                return 1;
            }
            if (cell[1, 1] == "X" && cell[4, 1] == "X" && cell[7, 1] == "X")
            {
                return 1;
            }
            if (cell[2, 1] == "X" && cell[5, 1] == "X" && cell[8, 1] == "X")
            {
                return 1;
            }
            if (cell[0, 1] == "X" && cell[4, 1] == "X" && cell[8, 1] == "X")
            {
                return 1;
            }
            if (cell[2, 1] == "X" && cell[4, 1] == "X" && cell[6, 1] == "X")
            {
                return 1;
            }
            //CHECK 0
            if (cell[0, 1] == "0" && cell[1, 1] == "0" && cell[2, 1] == "0")
            {
                return 2;
            }
            if (cell[3, 1] == "0" && cell[4, 1] == "0" && cell[5, 1] == "0")
            {
                return 2;
            }
            if (cell[6, 1] == "0" && cell[7, 1] == "0" && cell[8, 1] == "0")
            {
                return 2;
            }
            if (cell[0, 1] == "0" && cell[3, 1] == "0" && cell[6, 1] == "0")
            {
                return 2;
            }
            if (cell[1, 1] == "0" && cell[4, 1] == "0" && cell[7, 1] == "0")
            {
                return 2;
            }
            if (cell[2, 1] == "0" && cell[5, 1] == "0" && cell[8, 1] == "0")
            {
                return 2;
            }
            if (cell[0, 1] == "0" && cell[4, 1] == "0" && cell[8, 1] == "0")
            {
                return 2;
            }
            if (cell[2, 1] == "0" && cell[4, 1] == "0" && cell[6, 1] == "0")
            {
                return 2;
            }

            //CHECK TIE
            int db = 0;
            for (int i = 0; i < 9; i++)
            {
                if (cell[i, 0] == "1") db++;
            }
            if (db == 9)
            {
                return 0;
            }



            return 3;
        }
        AIMove getBestMove(string player)
        {
           
            int rv = CheckVictory();
            if (rv == 2)
            {
                return new AIMove(10);
            }else if (rv == 1)
            {
                return new AIMove(-10);
            }else if (rv == 0)
            {
                return new AIMove(0);
            }

            List<AIMove> moves = new List<AIMove>();

            for (int i = 0; i < 9; i++)
            {
                if (cell[i, 0] != "1")
                {
                    AIMove move = new AIMove();
                    move.currentcell = i;
                    cell[i, 0] = "1";
                    cell[i, 1] = player;
                    if (player == "0")
                    {
                        move.score = getBestMove("X").score;
                    }
                    else if (player == "X")
                    {
                        move.score = getBestMove("0").score;
                    }
                    moves.Add(move);
                    cell[i, 0] = "0";
                    cell[i, 1] = null;
                }
            }
            int bestMove = 0;
            if (player == "0")
            {
                int bestScore = -100000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].score > bestScore)
                    {
                        bestMove = i;
                        bestScore = moves[i].score;

                    }
                }
            }
            else if(player == "X")
            {
                int bestScore = 100000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].score < bestScore)
                    {
                        bestMove = i;
                        bestScore = moves[i].score;

                    }
                }
            }

            return moves[bestMove];
        }

        private void AIputO()
        {
            AIMove bestMove = getBestMove("0");
            DrawO(pen, g, (bestMove.currentcell) + 1);
            cell[bestMove.currentcell, 0] = "1";
            cell[bestMove.currentcell, 1] = "0";
            currentplayer = "X";
        }
        private void AIputX()
        {
            AIMove bestMove = getBestMove("X");
            DrawO(pen, g, (bestMove.currentcell) + 1);
            cell[bestMove.currentcell, 0] = "1";
            cell[bestMove.currentcell, 1] = "X";
            currentplayer = "0";
        }
        private void DrawO(Pen pen, Graphics g, int cells)
        {
            pen = new Pen(Color.Red, 4);
            pen.Brush = new HatchBrush(HatchStyle.OutlinedDiamond, Color.Blue);
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switch (cells)
            {
                case 1:
                    if (cell[0, 0] != "1")
                    {
                        g.DrawEllipse(pen,0,0,98,78);
                        cell[0, 0] = "1";
                        cell[0, 1] = "0";
                    }
                    break;
                case 2:
                    if (cell[1, 0] != "1")
                    {
                        g.DrawEllipse(pen, 100, 0, 98, 78);
                        cell[1, 0] = "1";
                        cell[1, 1] = "0";
                    }
                    break;
                case 3:
                    if (cell[2, 0] != "1")
                    {
                        g.DrawEllipse(pen, 200, 0, 98, 78);
                        cell[2, 0] = "1";
                        cell[2, 1] = "0";
                    }
                    break;
                case 4:
                    if (cell[3, 0] != "1")
                    {
                        g.DrawEllipse(pen, 0, 80, 98, 78);
                        cell[3, 0] = "1";
                        cell[3, 1] = "0";
                    }
                    break;
                case 5:
                    if (cell[4, 0] != "1")
                    {
                        g.DrawEllipse(pen, 100, 80, 98, 78);
                        cell[4, 0] = "1";
                        cell[4, 1] = "0";
                    }
                    break;
                case 6:
                    if (cell[5, 0] != "1")
                    {
                        g.DrawEllipse(pen, 200, 80, 98, 78);
                        cell[5, 0] = "1";
                        cell[5, 1] = "0";
                    }
                    break;
                case 7:
                    if (cell[6, 0] != "1")
                    {
                        g.DrawEllipse(pen, 0, 160, 98, 78);
                        cell[6, 0] = "1";
                        cell[6, 1] = "0";
                    }
                    break;
                case 8:
                    if (cell[7, 0] != "1")
                    {
                        g.DrawEllipse(pen, 100, 160, 98, 78);
                        cell[7, 0] = "1";
                        cell[7, 1] = "0";
                    }
                    break;
                case 9:
                    if (cell[8, 0] != "1")
                    {
                        g.DrawEllipse(pen, 200, 160, 98, 78);
                        cell[8, 0] = "1";
                        cell[8, 1] = "0";
                    }
                    break;
                default:
                    break;
            }
        }
        private void DrawX(Pen pen,Graphics g,int cells)
        {
            pen = new Pen(Color.DarkOrange, 4);
            pen.Brush = new HatchBrush(HatchStyle.Cross,Color.Chocolate);
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switch (cells)
            {
                case 1:
                    if (cell[0, 0] != "1")
                    {
                        g.DrawLine(pen, 0, 0, 100, 80);
                        g.DrawLine(pen, 100, 0, 0, 80);
                        cell[0, 0] = "1";
                        cell[0, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 2:
                    if (cell[1, 0] != "1")
                    {
                        g.DrawLine(pen, 100, 0, 200, 80);
                        g.DrawLine(pen, 200, 0, 100, 80);
                        cell[1, 0] = "1";
                        cell[1, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 3:
                    if (cell[2, 0] != "1")
                    {
                        g.DrawLine(pen, 200, 0, 300, 80);
                        g.DrawLine(pen, 300, 0, 200, 80);
                        cell[2, 0] = "1";
                        cell[2, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 4:
                    if (cell[3, 0] != "1")
                    {
                        g.DrawLine(pen, 0, 80, 100, 160);
                        g.DrawLine(pen, 100, 80, 0, 160);
                        cell[3, 0] = "1";
                        cell[3, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 5:
                    if (cell[4, 0] != "1")
                    {
                        g.DrawLine(pen, 100, 80, 200, 160);
                        g.DrawLine(pen, 200, 80, 100, 160);
                        cell[4, 0] = "1";
                        cell[4, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 6:
                    if (cell[5, 0] != "1")
                    {
                        g.DrawLine(pen, 200, 80, 300, 160);
                        g.DrawLine(pen, 300, 80, 200, 160);
                        cell[5, 0] = "1";
                        cell[5, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 7:
                    if (cell[6, 0] != "1")
                    {
                        g.DrawLine(pen, 0, 160, 100, 240);
                        g.DrawLine(pen, 100, 160, 0, 240);
                        cell[6, 0] = "1";
                        cell[6, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 8:
                    if (cell[7, 0] != "1")
                    {
                        g.DrawLine(pen, 100, 160, 200, 240);
                        g.DrawLine(pen, 200, 160, 100, 240);
                        cell[7, 0] = "1";
                        cell[7, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                case 9:
                    if (cell[8, 0] != "1")
                    {
                        g.DrawLine(pen, 200, 160, 300, 240);
                        g.DrawLine(pen, 300, 160, 200, 240);
                        cell[8, 0] = "1";
                        cell[8, 1] = "X";
                        currentplayer = "0";
                    }
                    break;
                default:
                break;
            }
          
        }

        private void NewGame()
        {
            panel1.Invalidate();
            int start = r.Next(0, 2);
            if (start == 1)
            {
                currentplayer = "X";
            }
            else
            {
                currentplayer = "0";
                AIputO();

            }
            for (int i = 0; i < 9; i++)
            {
                cell[i, 0] = "0";
                cell[i, 1] = null;
            }
        }
        
        public single()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pen = new Pen(Color.Black);
            g = panel1.CreateGraphics();
            for (int i = 0; i < 9; i++)
            {
                cell[i, 0] = null;
            }
            int start = r.Next(0, 2);
            if (start == 1)
            {
                currentplayer = "X";
                
            }
            else
            {
                currentplayer = "0";
                DrawO(pen,g,r.Next(1,10));
                currentplayer = "X";
            }
            g.DrawLine(pen, 100, 0, 100, 250);
            g.DrawLine(pen, 200, 0, 200, 250);
            g.DrawLine(pen, 0, 80, 300, 80);
            g.DrawLine(pen, 0, 160, 300, 160);
            pen.Dispose();
            g.Dispose();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            if (currentplayer == "X" && e.X > 0 && e.Y > 0 && e.X < 100 && e.Y < 80)
            {
                DrawX(pen, g, 1);
            }
            if (currentplayer == "X" && e.X > 0 && e.Y > 0 && e.X < 100 && e.Y < 80 && cell[0,0] == "1")
            {
               return;
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 0 && e.X < 200 && e.Y < 80)
            {
                DrawX(pen, g, 2);
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 0 && e.X < 200 && e.Y < 80 && cell[1, 0] == "1")
            {
                return;
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 0 && e.X < 300 && e.Y < 80)
            {
                DrawX(pen, g, 3);
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 0 && e.X < 300 && e.Y < 80 && cell[2, 0] == "1") 
            {
                return;
            }
            if (currentplayer == "X" && e.X > 0 && e.Y > 80 && e.X < 100 && e.Y < 160)
            {
                DrawX(pen, g, 4);
            }
            if (currentplayer == "X" && e.X > 0 && e.Y > 80 && e.X < 100 && e.Y < 160 && cell[3, 0] == "1")
            {
                return;
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 80 && e.X < 200 && e.Y < 160)
            {
                DrawX(pen, g, 5);
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 80 && e.X < 200 && e.Y < 160 && cell[4, 0] == "1")
            {
               return;
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 80 && e.X < 300 && e.Y < 160)
            {
                DrawX(pen, g, 6);
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 80 && e.X < 300 && e.Y < 160 && cell[5, 0] == "1")
            {
                return;
            }
            if (currentplayer == "X" && e.X > 0 && e.Y > 160 && e.X < 100 && e.Y < 240)
            {
                DrawX(pen, g, 7);
            }
            if (currentplayer == "X" && e.X > 0 && e.Y > 160 && e.X < 100 && e.Y < 240 && cell[6, 0] == "1")
            {
                return;
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 160 && e.X < 200 && e.Y < 240)
            {
                DrawX(pen, g, 8);
            }
            if (currentplayer == "X" && e.X > 100 && e.Y > 160 && e.X < 200 && e.Y < 240 && cell[7, 0] == "1")
            {
               return;
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 160 && e.X < 300 && e.Y < 240)
            {
                DrawX(pen, g, 9);
            }
            if (currentplayer == "X" && e.X > 200 && e.Y > 160 && e.X < 300 && e.Y < 240 && cell[8, 0] == "1")
            {
                return;
            }
            AIputO();
            if (CheckVictory() == 0)
            {
                if (MessageBox.Show("It's a tie, new game?", "TIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        cell[i, 0] = "1";
                        cell[i, 1] = null;
                    }
                }
            }
            else if (CheckVictory() == 1)
            {
                if (MessageBox.Show("X won, new game?", "X WINS",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        cell[i, 0] = "1";
                        cell[i, 1] = null;
                    }

                }
            }
            else if (CheckVictory() == 2)
            {
                if (MessageBox.Show("Computer won, new game?","Computer wins", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        cell[i, 0] = "1";
                        cell[i, 1] = null;
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void single_Load(object sender, EventArgs e)
        {

        }
    }
}
