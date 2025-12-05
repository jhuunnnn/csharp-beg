using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0,b= 0, total = 0; i <= 100; i++,b++)
            {
                if (b <= 10)
                {
                    total+=i;
                }
                if (b >= 20)
                {
                    b=0;
                }
                // else if (b >= 11)
                // {
                //     b=0;
                // }
              
                Console.WriteLine($"i : {i}  b : {b} total : {total}");               
            }
        }
    }
}
