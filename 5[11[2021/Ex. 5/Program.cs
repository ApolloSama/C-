using System;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {(i * j)}");
                }
            }
        }
    }
}
