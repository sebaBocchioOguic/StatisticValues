﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticValuesConsoleWin
{
    internal class Program
    {

        // Initialize List of Int Values (Global)
        static List<int> valuesList = new List<int>();

        // Initialize static functions class from AtomicFunctions Namespace
        static AtomicFunctions.Functions functions = new AtomicFunctions.Functions();

        /// <summary>
        /// Original Console Code for the core of the solution
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            

            // Initialize Byte Variable for Menu Index
            byte menuOption = 1;

            do
            {
                // Menu Description in Console
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Add a new number");
                Console.WriteLine("2 - View the complete numbers set");
                Console.WriteLine("3 - Randomize numbers");
                Console.WriteLine("4 - Clear List");
                Console.WriteLine("5 - Order List Ascending");
                Console.WriteLine("6 - Order List Descending");
                Console.WriteLine("7 - Remove a number Once");
                Console.WriteLine("8 - Remove a number All ocurrencies");
                Console.WriteLine("9 - Finds a number in the List");
                Console.WriteLine("99 - Exit");
                Console.Write("---> ");


                try
                {

                    // Input Menu Option
                    menuOption = byte.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            // Add a new value to the List
                            addNumberConsole();
                            break;

                        case 2:
                            // Show the content of the List in Console
                            showNumbersConsole();
                            break;

                        case 3:
                            // Randomize numbers to add to the List
                            randomizeValuesConsole();
                            break;

                        case 4:
                            // Clear the List
                            functions.clearList(valuesList);
                            pause();
                            break;

                        case 5:
                            // Order the List
                            orderListConsole("ascending");
                            break;

                        case 6:
                            // Order the List
                            orderListConsole("descending");
                            break;

                        case 7:
                            // Remove a number - Only one occurrency
                            removeNumberOnceConsole();
                            break;

                        case 8:
                            // Remove a number - All occurrencies
                            removeNumberAllConsole();
                            break;

                        case 9:
                            // Find a number in the List
                            findNumberConsole();
                            break;

                        case 99:
                            // Exit the program
                            Console.WriteLine("Ending program by user");
                            menuOption = 255;
                            break;
                            

                        default:
                            // Invalid options generates an Exception
                            throw new Exception("Invalid Option");
                    }

                }
                catch (Exception e)
                {

                    if (e is System.FormatException)
                    {
                        Console.WriteLine("The input format is invalid. Please try again and enter an integer number");

                    }
                    else
                    {
                        Console.WriteLine("Unknown Error. Please try again or exit program");
                    }

                }

                pause();

            } while (menuOption >= 1 && menuOption <= 99);


        }

        /// <summary>
        /// Add a new number to the list from the Console
        /// </summary>
        /// <exception cref="Exception"></exception>
        static void addNumberConsole() {
            Console.Write("\nInsert the new value to add: -> ");
            int newValue = Convert.ToInt32(Console.ReadLine());

            if (!(functions.addNumber(valuesList, newValue)))
            {
                throw new Exception("\nThere was an error adding the number to the list!");
            }

            Console.WriteLine("\nNew value inserted: {0}", newValue);
        }

    

        /// <summary>
        /// Show Numbers in the List from the Console
        /// </summary>
        static void showNumbersConsole()
        {

            List<int> auxShowNumbers = functions.showNumbers(valuesList);

            string result = "";
            int i = 0;
            if (auxShowNumbers.Count >= 1)
            {
                foreach (int number in auxShowNumbers)
                {
                    result += " " + number;
                    i++;
                    if(i < auxShowNumbers.Count)
                    {
                        result += ",";
                    }
                }
            }
            else
            {
                result = "\nThe List is empty";
            }
            Console.WriteLine("\nNumbers in the List: " + result);
        }

        /// <summary>
        /// Randomize values from Console to add to the list
        /// </summary>
        static void randomizeValuesConsole()
        {

            Console.Write("\nEnter the amount of random values to add: -> ");
            int qRand = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the minimum integer value to randomize: -> ");
            int minRand = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the maximum integer value to randomize: -> ");
            int maxRand = Convert.ToInt32(Console.ReadLine());

            functions.randomizeNumbers(valuesList, qRand, minRand, maxRand);

            Console.WriteLine("\nSuccesfully randomize {0} values between {1} and {2}", qRand, minRand, maxRand);
        }


        /// <summary>
        /// Order the List by Ascending or Descending Sort
        /// </summary>
        /// <param name="typeOrder">It defines 'Ascending' or 'Descending' sort</param>
        static void orderListConsole(string typeOrder)
        {

            functions.orderList(valuesList, typeOrder);

            Console.WriteLine("\nThe List was ordered by {0}", typeOrder);
            functions.showNumbers(valuesList);

        }




        /// <summary>
        /// This function removes a number from the List, only one ocurrency of the number
        /// </summary>
        static void removeNumberOnceConsole()
        {
            
            // Asks for the number to be removed
            Console.Write("\nWrite the number to be removed from List: -> ");
            int removeNbr = Convert.ToInt32(Console.ReadLine());

            if (functions.removeNumberOnce(valuesList, removeNbr))
            {
                Console.WriteLine("\nThe element {0} was removed once", removeNbr);
            }
            else
            {
                Console.WriteLine("\nThe element {0} was not found in the List\n", removeNbr);
            }

            functions.showNumbers(valuesList);

        }




        /// <summary>
        /// This function removes a number from the List in all its occurrencies
        /// </summary>
        static void removeNumberAllConsole()
        {

            // Asks for the number to be removed
            Console.Write("\nWrite the number to be removed from List: -> ");
            int removeNbr = Convert.ToInt32(Console.ReadLine());

            // Removes the number in all the ocurrencies and returns an integer number of removed positions
            int auxRemove = functions.removeNumberAll(valuesList, removeNbr);
            
            Console.WriteLine("\nThe element {0} was removed in {1} ocurrencies\n", removeNbr, auxRemove);

            functions.showNumbers(valuesList);

        }




        /// <summary>
        /// Finds the number of ocurrencies of a number in the List
        /// Overload 1 - Without parameters
        /// </summary>
        /// <returns>The number of ocurrencies in the List</returns>
        static void findNumberConsole()
        {

            // Insert the number to find in the List
            Console.Write("\nWrite the number to be found in the List: -> ");
            int findNbr = Convert.ToInt32(Console.ReadLine());

            int amountNbr = functions.findNumber(valuesList, findNbr);

            Console.WriteLine("\nThe number {0} has {1} ocurrencies in the List\n", findNbr, amountNbr);

        }





        /// <summary>
        /// Static function to display a message in screen to press any key and wait for it
        /// </summary>
        static void pause()
        {
            Console.WriteLine("\nPress any key to return to main menu");
            Console.ReadKey();
        }
    }
}
