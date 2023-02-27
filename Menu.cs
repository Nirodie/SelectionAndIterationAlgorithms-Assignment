using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// This is the menu class which will display a menu to the user with various choices one of which will terminate the program 
    /// </summary>
    public class Menu
    {
        public void start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText(); //Displays the menu to the user
                Console.Write("\nYour choice: ");
                choice = InputControl.ReadIntConsole(); //Reads the choice made by the user

                switch (choice)
                {
                    case 1: //First menu choice, the for statement
                        {
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                            sumObj.start();
                            break;

                        }
                    case 2: //Second menu choice, the while statement
                        {
                            FloatNumbersWhileAdd sumObj = new FloatNumbersWhileAdd();
                            sumObj.start();
                            break;
                        }
                    case 3: //Third menu choice, currency converter, the do-while statment
                        {
                            CurrencyConverterDoWhile sumObj = new CurrencyConverterDoWhile();
                            sumObj.start();
                            break;
                        }
                    case 4: //Forth menu choice, the temperature table
                        {
                            TemperatureTable sumObj = new TemperatureTable();
                            sumObj.start();
                            break;
                        }
                    case 5: //Fifth menu choice, the work schedule
                        {
                            WorkSchedule sumObj = new WorkSchedule();
                            sumObj.start();
                            break;
                        }

                        }
                
                }
            }
        private void WriteMenuText() //Writes out the menu
        {

            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("                                  Main Menu");
            Console.WriteLine("Whole Numbers With For              1");
            Console.WriteLine("Floating Point Numbers With While   2");
            Console.WriteLine("Currency Converter With Do While    3");
            Console.WriteLine("Temperature Table                   4");
            Console.WriteLine("Work Schedule                       5");
            Console.WriteLine("Exit the program                    0");
            Console.WriteLine("_________________________________________________________________________________");
        }
    }
    }
