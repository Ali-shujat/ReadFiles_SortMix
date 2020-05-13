using System;
using System.IO;
using System.Linq;

namespace ReadFiles_SortMix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5 :Read files/ Mix and Sort!");
            //Create a program to read the content of two different files and display it mixed and sorted alphabetically.

            string[] text1 = File.ReadAllLines(@"C:\C-sharp\Exersice\ReadFiles_SortMix\ReadFiles_SortMix\TextFile1.txt");
            string[] text2 = File.ReadAllLines(@"C:\C-sharp\Exersice\ReadFiles_SortMix\ReadFiles_SortMix\TextFile2.txt");

            string[] text3 = text1.Concat(text2).ToArray();
            Array.Sort(text3);
           
            foreach(string text in text3)
            {
                Console.WriteLine(text);
            }
            Console.ReadKey();

        }
    }
}
