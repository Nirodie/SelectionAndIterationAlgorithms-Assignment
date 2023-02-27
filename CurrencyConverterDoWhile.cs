using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// Sums up numbers and converts them into desired currency input by the user using a do-while loop
    /// </summary>
    class CurrencyConverterDoWhile
    {
        private decimal num; //Stores the input and gives results
        private string currency; //Stores the input currency
        private decimal rate; //Stores the input rate
        private decimal value; //Shows the value of the calculation
        public void start()
        {
            WriteProgramInfo();
            ReadInputandSumNumbers();
            ShowResults();
        }
        private void WriteProgramInfo()//Writes what the current program is about
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.WriteLine();
            Console.WriteLine("Currency converter with do-while");
            Console.WriteLine();
        }
        private void ReadInputandSumNumbers()//Reads inputs of the user and calculates
        {

            bool done = false;

            do
            {
                decimal cont = (decimal)ReadInput();
                if (cont == 0) //Checks if number is 0 and sets "done" to true if it is
                {
                    done = true;
                }
                else
                {
                    num += cont;
                }
            } while (!done);//Continues onward if 0 is given
            {
                Console.Write("Name of the foreign currency: ");
                currency = Console.ReadLine();
                Console.Write($"Exchange rate of SEK to {currency}: ");
                rate = InputControl.ReadDecimalConsole();
            }
            value = num / rate;//Calculates
           value = Decimal.Round(value,2);//Rounds up to 2 decimals
            {
                return;
            }




        }
        private double ReadInput()//Reads input
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            decimal num = InputControl.ReadDecimalConsole();
            return (double)num;
        }
        private void ShowResults()//Shows the final results
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.WriteLine("The total sum is \t{0}", num); //Needs to be changed to show appropriate text
            Console.WriteLine($"{num} SEK is converted to {value} {currency} at the rate of {rate} SEK/{currency}");
        }
    }
}
