using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Network_Programming
{
    class GetWord
    {
        int WrongGuesses = 0;
        string CurrentWord = "";
        string CopyCurrentWord = "";
        string[] Words;
        public void LoadWords()
        {
            string[] TextInFile = File.ReadAllLines("List.txt");
            char[] space = { ',', ' ', '.', ':', ';' };
            Words = new string[TextInFile.Length];
            int index = 0;

            foreach (string s in TextInFile)
            {
                string[] line = s.Split(space);
                Words[index++] = line[0];
            }
        }
        public string sendword()
        {
            Random rand = new Random();
            int RandomWord = rand.Next(0, Words.Length);
            CurrentWord = Words[RandomWord];
            return CurrentWord;
        }
    }
}
