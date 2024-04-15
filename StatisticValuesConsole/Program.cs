using System;
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
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Add a new number");
                Console.WriteLine("2 - View the complete numbers set");
                Console.WriteLine("3 - Randomize numbers");
                Console.WriteLine("4 - Clear List");
                Console.WriteLine("5 - Order List by asc");
                Console.WriteLine("9 - Exit");
                Console.Write("---> ");


                try
                {

                    // Input Menu Option
                    menuOption = byte.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            // Add a new value to the List
                            addNumber();
                            break;

                        case 2:
                            // Show the content of the List
                            showNumbers();
                            break;

                        case 3:
                            // Randomize numbers to add to the List
                            randomizeNumbers();
                            break;

                        case 4:
                            // Clear the List
                            clearList();
                            break;

                        case 5:
                            // Order the List
                            orderList();
                            break;

                        case 9:
                            // Exit the program
                            throw new Exception("Ending program");

                        default:
                            // Invalid options generates an Exception
                            throw new Exception("Invalid Option");
                    }

                }
                catch (Exception e)
                {

                    // Shows the error message and finishes the program
                    Console.WriteLine("\n" + e.Message + "\nPress any key to exit program");
                    Console.ReadKey();
                    break;

                }


            } while (menuOption >= 1 && menuOption <= 9);


        }

        /// <summary>
        /// Add a new number to the List
        /// </summary>
        static void addNumber()
        {
            Console.Write("\nInsert the new value: -> ");
            int newValue = Convert.ToInt32(Console.ReadLine());
            valuesList.Add(newValue);
            Console.WriteLine($"New value {newValue} added\n");
        }

        /// <summary>
        /// Show the content of the List
        /// </summary>
        static void showNumbers()
        {
            if (valuesList.Count >= 1)
            {
                Console.Write("\nNumbers List: ");
                foreach (int number in valuesList)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nThe List is empty\n");
            }

        }


        /// <summary>
        /// Randomize Numbers to add to the List
        /// </summary>
        static void randomizeNumbers()
        {
            // Initialize Random Object
            Random rand = new Random();

            // Insert the quantity of random values to add
            Console.Write("\nInsert the quantity of random values to add: -> ");
            int qRand = Convert.ToInt32(Console.ReadLine());

            // For loop to add the random values into the List
            for (int i = 0; i < qRand; i++)
            {
                valuesList.Add(rand.Next(0,500));
            }

            // Shows the upgraded List
            showNumbers();
        }

        /// <summary>
        /// Clear the List of values
        /// </summary>
        static void clearList()
        {
            valuesList.Clear();
            Console.WriteLine("\nThe List is empty\n");
        }

        /// <summary>
        /// Order the List ascending
        /// </summary>
        static void orderList()
        {
            valuesList.Sort();
            Console.WriteLine("\nThe List was ordered\n");
            showNumbers();
        }
    
    }
}
