using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Marcus Beach");
            Console.WriteLine("Goodbye Cruel World!");

            int i;
            for(i=0;i<=10;i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("\a");
            }

            Console.WriteLine("Enter Value");
            i = Convert.ToInt32(Console.ReadLine());

            int j;
            int k;

            for(j=0;j<i;j++)
            {
                for(k=0;k<i;k++)
                {
                    if ((k==0) || (k==(i-1))) { Console.Write("*"); }
                    else if ((j==0) || (j==(i-1))) { Console.Write("*"); }
                    else { Console.Write(" "); }
                }
                Console.Write("\n");
            } 


            
        }
    }
}
