using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// A temperature table converting celsius to fahrenheit and vice versa
    /// </summary>
    class TemperatureTable
    {
        public void start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText();
                Console.Write("\nYour choice: ");
                choice = InputControl.ReadIntConsole(); //Uses the input control class

                switch (choice)
                {
                    case 1: //first menu choice Celsius to Fahrenheit 
                        {
                            CalculateCtoF();
                            break;
                        }
                    case 2: //second menu choice Fahrenheit to Celsius
                        {
                            CalculateFtoC();
                            break;
                        }
                }
            }
        }
        private void WriteMenuText()//Writes menu text
        {
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("Celsius to Fahrenheit 1");
            Console.WriteLine("Fahrenheit to Celsius 2");
            Console.WriteLine("Back to main menu     0");
            Console.WriteLine("_________________________________________________________________________________");
        }
        #region Celsius to fahrenheit
        public void CalculateCtoF()//menu for celsius to fahrenheit 0-100
        {
            double conValue = 0;
            string textOut = string.Empty;
            Console.WriteLine("_________________________________________________________________________________");//To seperate choice from the table
            Console.WriteLine("Celsius to Fahrenheit 0-100");
            Console.WriteLine("_________________________________________________________________________________");

            for (int index = 0; index <= 100; index += 5)//Using a for-loop as i only want the temperature to go up to 100
            {
                conValue = CtoF(index);
                
                textOut = string.Format("{0,16:f2} C = {1,6:f2} F", index, conValue);
                Console.WriteLine(textOut);
            }
        }
        private double CtoF(double celsius)//Calculation for celsius to fahrenheit
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32.0;
            return fahrenheit;
        }
        #endregion
        #region Fahrenheit to celcius
        public void CalculateFtoC()//menu for fahrenheit to celsius 0-100
        {
            double conValue = 0;
            string textOut = string.Empty;
            Console.WriteLine("_________________________________________________________________________________");//To seperate choice from the table
            Console.WriteLine("Fahrenheit to Celsius 0-100");
            Console.WriteLine("_________________________________________________________________________________");

            for (int index = 0; index <= 100; index += 5)
            {
                conValue = FtoC(index);

                textOut = string.Format("{0,16:f2} F = {1,6:f2} C", index, conValue);
                Console.WriteLine(textOut);
            }
        }
        private double FtoC(double fahrenheit)//Calculation for fahrenheit to celsius
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        #endregion

    }
}
