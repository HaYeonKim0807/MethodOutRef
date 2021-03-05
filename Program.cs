using System;

namespace MethodOut
{
    class Program
    {
        static void Divide( ref int a, ref int b, out int result1, out int result2 )
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 3;

            int result1;
            int result2;

            Divide(ref num1, ref num2, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}
