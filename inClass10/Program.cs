using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            string allText = System.IO.File.ReadAllText(@"C:\Users\noahv\OneDrive\Desktop\College\Computer Programming\C#\FilePractice.txt");


            Console.WriteLine("Contents of FilePractice.txt " + allText);


            string[] words = allText.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(",", "");
                words[i] = words[i].Replace(".", "");
                words[i] = words[i].Replace("!", "");
                words[i] = words[i].Replace("?", "");
                Console.WriteLine(words[i]);
            }


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Substring(words[i].Length - 1) == "e" || words[i].Substring(words[i].Length - 1) == "t")
                {
                    count++;
                }
            }

            Console.WriteLine("There are " + count + " words that end in e or t");






        }
    }
}