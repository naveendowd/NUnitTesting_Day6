using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class FewestNotes
    {
        public static void FewestNote()

        {
            Console.WriteLine("Enter the total amount of currency: ");
            int totalAmt = Convert.ToInt32(Console.ReadLine()); // Total amount
            int amt = totalAmt;
            int totalNoOfNotes = 0;
            int[] currencyDenominatios = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("Currency denominations available are : ");
            foreach (int denomination in currencyDenominatios)
            {
                Console.Write(denomination + " ");
            }
            
            int[] noOfNotes = new int[currencyDenominatios.Length];
            for (int i = 0; i < currencyDenominatios.Length; i++)
            {
                noOfNotes[i] = amt / (currencyDenominatios[i]);
                amt = amt % (currencyDenominatios[i]);
            }
            Console.WriteLine("To disburse minimum number of notes:");
            for (int i = 0; i < currencyDenominatios.Length; i++)
            {
                Console.WriteLine("Number of {0} Rupee notes required are {1}", currencyDenominatios[i], noOfNotes[i]);
                totalNoOfNotes += noOfNotes[i];
            }
            Console.WriteLine("Total number of notes disbursed are {0}", totalNoOfNotes);
        }
    }
}