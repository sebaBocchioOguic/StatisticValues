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
                            orderList("ascending");
                            break;

                        case 6:
                            // Order the List
                            orderList("descending");
                            break;

                        case 7:
                            // Remove a number one time
                            removeNumberOneTime();
                            break;

                        case 8:
                            // Remove a number one time
                            removeNumberAll();
                            break;

                        case 9:
                            // Find a number in the List
                            findNumber();
                            break;

                        case 99:
                            // Exit the program
                            throw new Exception("Ending program by user");

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


            } while (menuOption >= 1 && menuOption <= 99);


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
        /// Order the List by Ascending or Descending Sort
        /// </summary>
        /// <param name="typeOrder">It defines 'Ascending' or 'Descending' sort</param>
        static void orderList(string typeOrder)
        {
            // Order the list by deafult
            valuesList.Sort();

            // If param is Descending, it reverses the default (Ascending)
            if (typeOrder == "descending")
            {
                valuesList.Reverse();
            }

            Console.WriteLine("\nThe List was ordered by {0}\n", typeOrder);
            showNumbers();

        }

        /// <summary>
        /// This function removes a number from the List, only one ocurrency of the number
        /// </summary>
        static void removeNumberOneTime()
        {
            
            // Asks for the number to be removed
            Console.Write("\nWrite the number to be removed from List: -> ");
            int removeNbr = Convert.ToInt32(Console.ReadLine());

            if (valuesList.Remove(removeNbr))
            {
                Console.WriteLine("\nThe element {0} was removed\n", removeNbr);
            }
            else
            {
                Console.WriteLine("\nThe element {0} was not found in the List\n", removeNbr);
            }

            showNumbers();

        }




        /// <summary>
        /// This function removes a number from the List, only one ocurrency of the number
        /// </summary>
        static void removeNumberAll()
        {

            // Asks for the number to be removed
            Console.Write("\nWrite the number to be removed from List: -> ");
            int removeNbr = Convert.ToInt32(Console.ReadLine());

            // Removes the number in all the ocurrencies and returns an integer number of removed positions
            int auxRemove = valuesList.RemoveAll(x => x == removeNbr);
            
            Console.WriteLine("\nThe element {0} was removed in {1} ocurrencies\n", removeNbr, auxRemove);
            
            showNumbers();

        }




        /// <summary>
        /// Finds the number of ocurrencies of a number in the List
        /// Overload 1 - Without parameters
        /// </summary>
        /// <returns>The number of ocurrencies in the List</returns>
        static int findNumber()
        {

            // Insert the number to find in the List
            Console.Write("\nWrite the number to be found in the List: -> ");
            int findNbr = Convert.ToInt32(Console.ReadLine());

            // Returns the number of ocurrencies in the List
            return findNumber(findNbr);

        }


        /// <summary>
        /// Finds the number of ocurrencies of a number in the List
        /// Overload 2 - One Integer Parameter
        /// </summary>
        /// <param name="p_findNumber">Number to find in the List</param>
        /// <returns>The number of ocurrencies in the List</returns>
        static int findNumber(int p_findNumber)
        {

            // Uses the function FindAll and return the number of ocurrencies of the number
            List<int> auxList = valuesList.FindAll(x => x == p_findNumber);
            int auxInt = auxList.Count();

            Console.WriteLine("\n The number {0} has {1} ocurrencies in the List\n", p_findNumber, auxInt);

            // Returns the number of ocurrencies in the List
            return auxInt;
        }

    }
}
