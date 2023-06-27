using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Util
    {
        public static int DayOfTheWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }

        public static void TemperatureConversion()
        {
            Console.WriteLine("Chose a type of conversion:\n1.Celsius to Fahrenheit:\n2.Fahrenheit to Celsius:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        double c, f; //Celsius & Farenheit
                        Console.WriteLine("Enter the temperature in Celsius (output will be in Farenheit): ");
                        c = Convert.ToDouble(Console.ReadLine());
                        f = 32 + 1.8 * c;
                        Console.WriteLine("Temperature in Farenheit is {0}", f);
                    };
                    break;
                case 2:
                    {
                        double c, f; //Celsius & Farenheit
                        Console.WriteLine("Enter the temperature in Farenheit (output will be in Celsius): ");
                        f = Convert.ToDouble(Console.ReadLine());
                        c = (f - 32) * (5.0 / 9.0);
                        Console.WriteLine("Temperature in celsius is {0}", c);
                    };
                    break;
                default:
                    Console.WriteLine("Incorrect Input, program ends here");
                    break;
            }
        }

        public static void MonthlyPayment(double p, double y, double r)
        {
            double noOfMonths = 12 * y;
            double ratePerMonth = r / (12 * 100);
            double monthlyPayment = (p * ratePerMonth) / (1 - (Math.Pow(1 + ratePerMonth, -noOfMonths)));
            Console.WriteLine("Monthly payment: {0}", monthlyPayment);

        }

        public static double Sqrt(double c)
        {
            //return Math.Sqrt(num);
            if (c < 0) return double.NaN;
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }

        public static string NumberToBinary(int num)
        {
            int tempNum = num;

            ///*if (num == 0)
            //{
            //    return "0";
            //}

            //string binary = string.Empty;

            //while (tempNum > 0)
            //{
            //    int remainder = tempNum % 2;
            //    binary = remainder + binary;
            //    tempNum /= 2;
            //}*/

            if (num < 0)
            {
                tempNum = -num;
            }
            string binary = "";
            while (tempNum != 0)
            {
                binary = tempNum % 2 + binary;
                tempNum = tempNum / 2;
            }
            if (num < 0)
            {
                binary = "-" + binary;
            }
            //Console.WriteLine("Binary representation of the number {0} is {1}", num, binary);
            return binary;

            //string binary = Convert.ToString(num, 2).PadLeft(8, '0');
        }
    }
}
