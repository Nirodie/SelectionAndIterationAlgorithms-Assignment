using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// Repeats and reads numbers the user inputs until the value 0 is added then displays the sum of the numbers given
    /// </summary>
   public class FloatNumbersWhileAdd
    {
        private double num;// Stores the input and gives result

        public void start()
        {
            WriteProgramInfo();
            ReadInputandSumNumbers();
            ShowResults();
        }
        private void WriteProgramInfo()//Displays the info of the current program
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.WriteLine();
            Console.WriteLine("Summation of real numbers using a whole-loop");
            Console.WriteLine();
        }
        private void ReadInputandSumNumbers() //Reads input and calculates
        {

            bool done = false;

            while (!done)
            {
               double cont = ReadInput();
                if(cont==0) //Checks if number is 0 and sets "done" to true if it is
                {
                    done = true;
                }
                else
                {
                    num += cont; //Adds the numbers together and stores them into "num"
                }
            }
        }
        private double ReadInput()//Reads input
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            double num = InputControl.ReadDoubleConsole();
            return num;
        }
        private void ShowResults()//Shows the results of the calculation
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.WriteLine("The total sum is \t{0}", num);
        }
    }
}
