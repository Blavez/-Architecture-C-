using System;

namespace Homework1
{
    class Result
    {
        public int c1,c2,c3;
        public Result Calculation(int M) 
        {
            Result result = new Result();
            Console.WriteLine (M);
            result.c1 = 1;
            result.c2 = 0;
            result.c3 = 0;
            for (int i = 1; i <= M; i++)
            {
                result.c1 = result.c1 * i;
                result.c2 = result.c2 + i;
                if (i % 2 == 0)
                {
                    result.c3 = i;
                }
                Console.WriteLine(c1);
            }
            return result;
           
        }
    }

}
