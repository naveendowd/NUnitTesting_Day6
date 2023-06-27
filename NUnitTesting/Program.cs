using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a program number to run it:\n1.Fewest notes for given amount of currency.\n2.Day of the week.\n3.Temperature conversion\n4.Monthly payment on the borrowed amount\n5.Square root of a Number\n6.Number to Binary\n7.Swap nibbles in Binary");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FewestNotes.FewestNote();
                    break;
                case 2:
                    {
                        int d, m, y;
                        Console.WriteLine("Enter the day in the date:");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the month in the date:");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the year in the date:");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Day of the week: {0}", Util.DayOfTheWeek(d, m, y));
                    };
                    break;
                case 3:
                    Util.TemperatureConversion();
                    break;

                case 4:
                    {
                        Console.Write("Enter the amount of principal: ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        // What exactly is the difference between Double.Parse and Convert.ToDouble

                        Console.Write("Enter the number of years for repayment: ");
                        double y = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the rate of interest: ");
                        double r = Convert.ToDouble(Console.ReadLine());

                        Util.MonthlyPayment(p, y, r);
                    };
                    break;

                case 5:
                    {
                        Console.WriteLine("Enter a number to find it's square root");
                        double num = Convert.ToDouble(Console.ReadLine());
                        double sqrt = Util.Sqrt(num);
                        Console.WriteLine("The square root of {0} is {1}", num, sqrt);
                    };
                    break;

                case 6:
                    {
                        Console.WriteLine("Enter a number to see it's binary representation: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        string binary = Util.NumberToBinary(number);

                        Console.WriteLine("Binary representation of the number {0} is {1}", number, binary);

                        //Console.WriteLine("Binary representation of the number is {0}", binary);
                    };
                    break;

                case 7:
                    Binary.SwapNibbles();
                    break;
                default:
                    Console.WriteLine("Incorrect input, program ends here");
                    break;
            }
        }

    }
}
