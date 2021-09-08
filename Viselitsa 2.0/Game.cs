using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viselitsa_2._0
{
    public class Game
    {
        public static int Count { get; set; }
        public static void Guess()
        {
            var encoded = Word.EncodeWord();
            Count = encoded.Letters.Length;
            Console.WriteLine("Счёт: " + Count);
            do
            {
                char let = Console.ReadLine()[0];
                for (int i = 0; i < encoded.Letters.Length; i++)
                {
                    if (let == encoded.Letters[i])
                    {
                        encoded.Lines[i] = let;
                        Console.Clear();
                        Print(encoded.Lines);
                        Console.WriteLine("Cчёт: "+ Count);
                    }
                    else
                    {
                        Console.Clear();
                        Print(encoded.Lines);
                        Count = Count - 1;
                        Console.WriteLine("Cчёт: " + Count);
                    }
                }
            } while (1 > 0);
        }
        static void Print(char[] array)
        {
            foreach(var let in array)
            {
                Console.Write(let + " ");
            }
        }
            
    }
}
