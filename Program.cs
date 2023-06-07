using System;
namespace Числа_Фібоначчі
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < 38; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(n3 + " ");
            }
            Console.Read();
        }
    }
}

