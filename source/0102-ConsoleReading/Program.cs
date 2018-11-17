
using System;

namespace _0102_ConsoleReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            //Console.ReadLine считает текст после нажатия ENTER и сохранит его в переменную 'text'
            Console.WriteLine("Как вас зовут?");
            var text = Console.ReadLine();
            //Console.WriteLine выведет то, что сохранили в 'text' на экран
            Console.Write("Здравствуйте, ");
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
