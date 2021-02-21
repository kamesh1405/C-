using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Programming
{
    public partial class Game : Form
    {
        Bitmap[] HangImages = { Network_Programming.Properties.Resources.hang1, 
                                Network_Programming.Properties.Resources.hang2,
                                Network_Programming.Properties.Resources.hang3,
                                Network_Programming.Properties.Resources.hang4,
                                Network_Programming.Properties.Resources.hang5,
                                Network_Programming.Properties.Resources.hang6,
                                Network_Programming.Properties.Resources.hang7 };

        int WrongGuesses = 0;
        string CurrentWord = "";
        string CopyCurrentWord = "";
        string[] Words;
        ClientClass cc = new ClientClass();

        public Game()
        {
            InitializeComponent();
        }

        private void LoadWords()
        {
            string[] TextInFile = File.ReadAllLines("List.txt");
            char[] space = { ',', ' ', '.', ':', ';' };
            Words = new string[TextInFile.Length];
            int index = 0;

            foreach(string s in TextInFile)
            {
                string[] line = s.Split(space);
                Words[index++] = line[0];
            }
        }

        private void SetUpWords()
        {
            WrongGuesses = 0;
            pictureBox1.Image = HangImages[WrongGuesses];
            CurrentWord = getWord();
            CopyCurrentWord = "";
            for (int i = 0; i < CurrentWord.Length; i++)
            {
                CopyCurrentWord =  CopyCurrentWord + "_";
            }
            DisplayCopyCurrentWord();            
        }

        private void DisplayCopyCurrentWord()
        {
            label2.Text = "";
            for (int i = 0; i < CurrentWord.Length ; i++)
            {
                label2.Text = label2.Text + CopyCurrentWord.Substring(i, 1);
                label2.Text = label2.Text + " ";                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpWords();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if(CurrentWord.Contains(choice.Text))
            {
                char[] temp = CopyCurrentWord.ToCharArray();
                char[] find = CurrentWord.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);

                for (int i = 0; i < find.Length; i++)
                {
                    if(find[i]==guessChar)
                    {
                        temp[i] = guessChar;
                    }
                }
                CopyCurrentWord = new string(temp);
                DisplayCopyCurrentWord();
            }
            else
            {
                WrongGuesses++;
            }
            if(WrongGuesses < 7)
            {
                pictureBox1.Image = HangImages[WrongGuesses];
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "You Lose";
                label3.Text = "The word was " + CurrentWord;
            }
            if(CopyCurrentWord.Equals(CurrentWord))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "You Win";
                label3.Text = "The word was " + CurrentWord;
            }
        }
        private string backup()
        {
            Random rand = new Random();
            int RandomWord = rand.Next(0, Words.Length);
            CurrentWord = Words[RandomWord];
            return CurrentWord;
        }

        private string getWord()
        {
            string text = cc.recieve();
            string word = "";
            if (text != "N" && text.Length > 0)
            {
                word = text;
            }
            else
            {
                LoadWords();
                word = backup();
            }
            return word;
        }

        private void timer1_Tick(object sender,EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = cc.send("exit");
            Environment.Exit(0);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string msg = cc.send("exit");
            Environment.Exit(0);
        }
    }
}
