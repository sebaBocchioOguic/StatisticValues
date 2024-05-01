using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicFunctions
{
    public class Functions
    {
        /// <summary>
        /// Add a new number to the List
        /// </summary>
        /// <param name="valuesList">The pointer to the complete List</param>
        /// <param name="newValue">The value to be inserted into the List</param>
        /// <returns>True if could insert the value. False if could not do it</returns>
        public bool addNumber(List<int> valuesList, int newValue)
        {
            try
            {
                valuesList.Add(newValue);
                return true;
            }
            catch { return false; }
            
        }

        /// <summary>
        /// Show the content of the List
        /// </summary>
        /// <param name="valuesList">The List of numbers to be shown</param>
        /// <returns>Returns the List of Numbers to be shown in the Front</returns>
        public List<int> showNumbers(List<int> valuesList)
        {

            return valuesList;

        }

        /// <summary>
        /// Randomize Numbers to add to the List
        /// </summary>
        /// <param name="qRand">Amount of numbers to be added with Random function</param>
        /// <param name="minValue">Minimum value of Random. Default 0</param>
        /// <param name="maxValue">Maximum value of Random. Default 100.000</param>
        public void randomizeNumbers(List<int> valuesList, int qRand, int minValue = 0, int maxValue = 100000)
        {
            // Initialize Random Object
            Random rand = new Random();

            // For loop to add the random values into the List
            for (int i = 1; i <= qRand; i++)
            {
                valuesList.Add(rand.Next(minValue, maxValue));
            }

        }


        /// <summary>
        /// Clear the List of values
        /// </summary>
        /// <param name="valuesList">The List to be Cleaned</param>
        public void clearList(List<int> valuesList)
        {
            valuesList.Clear();
        }



        /// <summary>
        /// Order the List by Ascending or Descending Sort
        /// </summary>
        /// <param name="valuesList">The List to be ordered</param>
        /// <param name="typeOrder">It defines 'Ascending' or 'Descending' sort</param>
        public void orderList(List<int> valuesList, string typeOrder)
        {
            // Order the list Ascending by default
            valuesList.Sort();

            // If param is Descending, it reverses the default
            if (typeOrder == "descending")
            {
                valuesList.Reverse();
            }

        }

    }
}
