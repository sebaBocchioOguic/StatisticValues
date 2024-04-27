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
        /// <returns>String with all numbers concatenated</returns>
        public string showNumbers(List<int> valuesList)
        {
            string result = "";
            if (valuesList.Count >= 1)
            {
                foreach (int number in valuesList)
                {
                    result += " " + number;
                }
            }
            else
            {
                result = "The List is empty";
            }

            return result;

        }

    }
}
