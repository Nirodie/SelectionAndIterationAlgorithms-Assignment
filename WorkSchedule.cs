using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SelectionAndIterationAlgorithms
{
    /// <summary>
    /// Work schedule showing weekend and night work. Using a for-loop as the schedule is expected to end on week 52, so the number of iterations are known.
    /// </summary>
    class WorkSchedule
    {
        public void start()
        {
            WriteProgramInfo();


            int choice = -1;

            while (choice != 0) //Using a while-loop for the menu 
            {
                WriteMenuText();
                Console.Write("\nYour choice: ");

                choice = InputControl.ReadIntConsole(); //Uses the input control class

                switch (choice)
                {
                    case 1: //Shows the weekend work
                        {
                            Weekends();
                            break;
                        }
                    case 2: //Shows the night work
                        {
                            Nights();
                            break;
                        }
                }
            }
        }
        private void WriteProgramInfo()//shows info about program
        {
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tWORK SCHEDULE PROGRAM\n");
            Console.WriteLine("Select a number from the menu to see schedule");
            Console.WriteLine();
        }
        private void WriteMenuText()//Shows the menu with the different choices
        {
            Console.WriteLine("\n_________________________________________________________________________________");
            Console.WriteLine("Shows the weekend schedule 1");
            Console.WriteLine("Shows the night schedule   2");
            Console.WriteLine("Back to main menu          0");
            Console.WriteLine("_________________________________________________________________________________");
        }

        public void Weekends()//The weekend schedule using a for-loop as the number of iterations is known
        {
            string textOut = string.Empty;
            string week = string.Empty;
            int p = 0;
            int columns = 6;

            for (int index = 1; index <= 52; index += 3)
            {
                week = string.Format("week {0}", index);
                textOut = string.Format("{0,-10} ", week);
                Console.Write(textOut);
                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
        }
        public void Nights()//The night schedule also using a for-loop with the same motivation above
        {
            string textOut = string.Empty;
            string week = string.Empty;
            int p = 0;
            int columns = 5;

            for (int index = 6; index <= 52; index += 5)
            {
                week = string.Format("week {0}", index);
                textOut = string.Format("{0,-10} ", week);
                Console.Write(textOut);
                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }


        }
    }
}
