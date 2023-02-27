using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// Controls the input from the user to make sure it's not an incorrect input, this class will be used in the other classes.
    /// </summary>
   public class InputControl
    {
        public static int ReadIntConsole()//Controls int values
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Incorrect input, please try again: ");
            return ReadIntConsole();
        }

        public static double ReadDoubleConsole()//Controls double value
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Incorrect input, please try again: ");
            return ReadDoubleConsole();
        }
        public static decimal ReadDecimalConsole()//Controls decimal 
        {
            decimal input;
            if (decimal.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Incorrect input, please try again: ");
            return ReadDecimalConsole();
        }
    }
}
