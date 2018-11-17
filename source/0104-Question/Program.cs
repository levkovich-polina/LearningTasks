using System;

namespace _0104_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пишем текст загадки
            Console.WriteLine("Отгадайте загадку:");
            Console.WriteLine("2*2=?");
        

            Console.Write("Ответ: ");
            //Пишем ответ на загадку
            var answer = Console.ReadLine();

            //Если мы написали, что ответ "петух"
            if (answer == "3")
            {
                //...то зелёным цветом пишем, что ответ верный!
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("вы экономный!");
            }
            else
            {
                if (answer == "4")
                {
                    Console.WriteLine("вы умный");
                }
                else
                {
                    if (answer == "5")
                    {
                        Console.WriteLine("вы щедрый");
                     }
                     else
                     {  
                       Console.WriteLine("вы красивый");
                     }
                 }
            }
            Console.Read();
        }
    }
}
