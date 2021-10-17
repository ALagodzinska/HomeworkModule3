using System;

namespace HomeworkModule3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input decimal number: ");
            string inputString1 = Console.ReadLine();
            decimal decimalNumber = Convert.ToDecimal(inputString1);

            Console.WriteLine("Input double number: ");
            string inputString2 = Console.ReadLine();
            double doubleNumber = Convert.ToDouble(inputString2);

            Console.WriteLine("Input Int16 number: ");
            string inputString3 = Console.ReadLine();
            Int16 int16Number = Convert.ToInt16(inputString3);

            Console.WriteLine("Input Int32 number: ");
            string inputString4 = Console.ReadLine();
            Int32 int32Number = Convert.ToInt32(inputString4);

            Console.WriteLine("Input Int64 number: ");
            string inputString5 = Console.ReadLine();
            Int64 int64Number = Convert.ToInt64(inputString5);

            Console.WriteLine($"Absolute decimal number ({decimalNumber}) = {Math.Abs(decimalNumber)}");
            Console.WriteLine($"Absolute double number ({doubleNumber}) = {Math.Abs(doubleNumber)}");
            Console.WriteLine($"Absolute Int16 number ({int16Number}) = {Math.Abs(int16Number)}");
            Console.WriteLine($"Absolute Int32 number ({int32Number}) = {Math.Abs(int32Number)}");
            Console.WriteLine($"Absolute Int64 number ({int64Number}) = {Math.Abs(int64Number)}");

            Console.ReadLine();


        }
    }
}
