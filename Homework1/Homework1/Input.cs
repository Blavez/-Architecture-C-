using System;
namespace Homework1
{
    class Input
    {
       public Result Check()
        {
            Result result1 = new Result();
            String S = Console.ReadLine();
            if (S == "q")
            {
                
            }
            int M = Int32.Parse(S);
            Result test = new Result();
            result1=test.Calculation(M);
            return result1;
        }
    }

}
