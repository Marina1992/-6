using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ввести с клавиатуры предложение. 
             * Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Составить программу, 
             * определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).  */

            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            char[] charText = text.ToCharArray();
            Array.Reverse(charText);
            string text2 = new string(charText);
            if (text == text2)
            {
                Console.WriteLine("Данная запись является палиндромом.");
            }
            if (text != text2)
            {
                Console.WriteLine("Данная запись не является палиндромом.");
            }

            Console.ReadKey();

        }
    }
}
