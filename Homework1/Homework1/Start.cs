using System;
namespace Homework1
{
    class Start
    {
        public void Print(int a, Result final)
        {
            if (a == 0)
            {
                Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
                Console.WriteLine("пожалуйста, введите число. ");
            }
            if (a == 1)
            {
                Console.WriteLine("Факториал равен " + final.c1); Console.WriteLine("Сума от 1 до N равна " + final.c2);
                Console.WriteLine("максимальное четное число меньше N равно " + final.c3);
            }
        }
    }

}
