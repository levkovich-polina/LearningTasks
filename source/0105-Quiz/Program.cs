using System;

namespace _0105_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напиши викторину
            //Придумай 5 вопросов и выводи их по-очереди на экран
            //Выводи варианты ответов на некоторые из вопросов
            //Если пользователь отвечает правильно, то напиши об этом зелёным цветом
            //Если неправильно, то красным

            Console.WriteLine("Какого цвета ёлка?");
            var answer1 = Console.ReadLine();

            if (answer1 == "зелёная")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Это правильный ответ, вы молодец!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это неправильный ответ. Она зелёная");
            }
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("В каком месяце 28 дней?");
            var answer2 = Console.ReadLine();

            if (answer2 == "февраль")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Это правильный ответ, вы молодец!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это неправильный ответ. это февраль");
            }
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Какой из данных химических элементов самый легкий? Выберите его номер");
            Console.WriteLine("1-Литий;");
            Console.WriteLine("2-Алюминий");
            Console.WriteLine("3-Сера");
            Console.WriteLine("4-Углерод");
            var answer3 = Console.ReadLine();

            if (answer3 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Это правильный ответ, вы молодец!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это неправильный ответ. это Литий");
            }
            Console.ReadLine();
        }
    }
}
