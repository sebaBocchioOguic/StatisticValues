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

            // Initialize List of Int Values
            List<int> valuesList = new List<int>();

            // Initialize Byte Variable for Menu Index
            byte menuOption = 1;

            while(menuOption == 1 || menuOption == 2)
            {
                // Menu Description in Console
                Console.WriteLine("\nMENU");
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
                            // Add a new value to the List
                            addNumber(ref valuesList);
                            break;

                        case 2:
                            // Show the content of the List
                            showNumbers(ref valuesList);
                            continue;

                        case 3:
                            // Exit the program
                            break;
                        
                        default:
                            // Invalid options generates an Exception
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

        /// <summary>
        /// Add a new number to the List
        /// </summary>
        /// <param name="valuesList">Complete List of values by reference</param>
        static void addNumber(ref List<int> valuesList)
        {
            Console.Write("\nInsert the new value: -> ");
            int newValue = Convert.ToInt32(Console.ReadLine());
            valuesList.Add(newValue);
            Console.WriteLine($"New value {newValue} added.\n");
        }

        /// <summary>
        /// Show the content of the List
        /// </summary>
        /// <param name="valuesList">Complete List of values by reference</param>
        static void showNumbers(ref List<int> valuesList)
        {
            Console.Write("\nNumbers List: ");
            foreach (int number in valuesList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}
