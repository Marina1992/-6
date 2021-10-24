using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             *  Знаки препинания не используются. 
             *  Найти самое длинное слово в строке.  */


            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string maxWord = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxWord.Length)
                    maxWord = stringArray[i];
            }


            Console.WriteLine(maxWord);
            Console.ReadKey();

        }
    }
}
