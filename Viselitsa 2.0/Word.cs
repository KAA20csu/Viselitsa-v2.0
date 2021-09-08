using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Viselitsa_2._0
{
    public class Word
    {
        public char[] Letters { get; set; }
        public char[] Lines { get; set; }
        public bool IsGuessed { get; set; }
        public Word(char[] letters,char[] lines, bool isGuessed)
        {
            Letters = letters;
            Lines = lines;
            IsGuessed = isGuessed;
        }

        public static string GetWord()
        {
            string[] words = File.ReadAllLines("words.txt");
            string word;
            Random rnd = new Random();
            return word = words[rnd.Next(0, words.Length)];
        }

        public static Word EncodeWord()
        {
            var current = GetWord().ToCharArray();
            Word word = new Word(current, current, false);
            word.Lines = word.Lines.Select(x => '_').ToArray();
            for (int i = 0; i < word.Letters.Length; i++)
            {
                
                Console.Write("_ ");
            }
            return word;
        }
    }
}
