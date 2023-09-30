using System;

namespace CSHARP
{
    class Program
    {
        static void Clever(int c)
        {
            Console.WriteLine(c);

        }
        static void Learn(int a,int b)
        {
            int  c=0;
            for (int i = 0; i < a; i++)
            {
                c =c+ a + b;
            }
            Clever(c);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Learn(a, b);
            Console.WriteLine("This is way 123");
        }
    }
}
