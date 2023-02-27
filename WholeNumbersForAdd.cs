using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// The whole numbers class that will read whole numbers input by the user then add them together and display the sum and also using a for-loop
    /// </summary>
   public class WholeNumbersForAdd
    {
        private int numberOfInput; //Number of values to be added
        private int sum; //Results after adding the numbers


        public void start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            ShowResults();
        }

        private void ReadInput() //Determines the amount of numbers that will be added
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.Write("Number of values to sum?: "); //Writes the line and lets the user answer
            numberOfInput = InputControl.ReadIntConsole(); //Reads input above
            Console.WriteLine(); //Blankspace
        }

        private void WriteProgramInfo() //Writes the description of the program
        {
            Console.WriteLine();
            Console.WriteLine("Summation of the numbers using the for-statement");
            Console.WriteLine();
        }
        private void SumNumbers()//Sums the numbers as they are read
        {
            //Local variables
            int num = 0; //stores the value that the user gives

            for(int index = 0; index < numberOfInput; index++) 
            {
                Console.Write($"Please give a value to number {index+1}: ");
                num += InputControl.ReadIntConsole();

            }
            sum = num; //Displays the summation of the numbers added above
        }
        private void ShowResults()//Shows the sum of the numbers
        {
            Console.WriteLine("_________________________________________________________________________________\n");
            Console.WriteLine("The total sum is \t{0}", sum);
        }
    }
}
