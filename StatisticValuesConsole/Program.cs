using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticValuesConsoleWin
{
    internal class Program
    {
        /// <summary>
        /// Original Console Code for the core of the solution
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Initialize Byte Variable for Menu Index
            byte menuOption = 1;

            while(menuOption == 1 || menuOption == 2)
            {
                // Menu Description in Console
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Add a new number");
                Console.WriteLine("2 - View the complete numbers set");
                Console.WriteLine("3 - Exit");
                Console.Write("---> ");


                try
                {
                    
                    // Input Menu Option
                    menuOption = byte.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                        case 2:
                            continue;
                        case 3:
                            break;
                        
                        // Invalid options generates an Exception
                        default:
                            throw new Exception("Invalid Option");
                    }

                }
                catch (Exception e)
                {

                    // Shows the error message and finishes the program
                    Console.WriteLine(e.Message + "\nPress any key to exit program");
                    Console.ReadKey();
                    break;

                }

                
            }
            
        }
    }
}
