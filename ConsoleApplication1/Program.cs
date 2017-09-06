using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш текст: ");
            string str = Console.ReadLine();
            string result = "";

            for (int i = 0; i < str.Length; i++)
                result += char.ConvertFromUtf32((char.ConvertToUtf32(str, i) + 1));

            Console.Write(@"Выш зашифрованный текст: 
" + result);
            Console.WriteLine();

            str = result;
            result = "";

            for (int i = 0; i < str.Length; i++)
                result += char.ConvertFromUtf32((char.ConvertToUtf32(str, i) - 1));

            Console.Write(@"Выш расшифрованный текст:
" + result);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
