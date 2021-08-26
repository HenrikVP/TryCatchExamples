using System;

namespace TryCatchExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 0;
            while (b1 == 0)
            {
                b1 = ExceptionTextExample();
            }
            Console.WriteLine("The number is : " + b1);
            Console.ReadKey();
        }

        private static byte ExceptionTextExample()
        {
            TryAgainGotoExample:
            try
            {
                Console.Write("Input byte: ");
                string str = Console.ReadLine();
                byte b;
                checked
                {
                     b = byte.Parse(str);
                }
                if (b > 150) throw new IndexOutOfRangeException("Number is above 150!");

                return b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto TryAgainGotoExample;
            }
        }
    }
}
