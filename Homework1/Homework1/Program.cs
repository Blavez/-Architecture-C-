using System;
using System.Collections;
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            Start start = new Start();
            start.Print(0, result);
            Input temp = new Input();
            result=temp.Check();
            start.Print(1, result);
            Console.ReadLine();
        }
        
    }

}
