using System;

namespace Mod5Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i=1; i <= 20;i++)
            {
                sum += i;
            }
            Console.WriteLine("the sum is:" + sum);
        }
    }
}
