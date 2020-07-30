using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i<= 12; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    Console.Write("1 x {0} = {1}", i, i * j);
                }
                
                //Console.WriteLine("2 x {0} = {1}", i, i * 2);
            }
        }
    }
}
