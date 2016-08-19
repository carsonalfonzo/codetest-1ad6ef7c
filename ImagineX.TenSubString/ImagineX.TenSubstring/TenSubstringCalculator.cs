using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineX.TenSubstring
{
    public class TenSubstringCalculator
    {
        public int InputNumber { get; set; }

        /// <summary>
        /// Generate the 10-Substring List
        /// </summary>
        /// <returns>IList of integers that add to 10</returns>
        public List<int> Generate()
        {
            List<int> results = new List<int>();
            
            Parallel.For(0, InputNumber - 1, i =>
            {
                long sum = 0;
                int length = GetLength(i); // get the length of the current number
                int parsed = 0; // out value for TryParse 
                string number = i.ToString(); // we need the string representation so we add the individual digits 

                for (int index = 0; index < length; index++) // loop over all the digits
                {
                    if (int.TryParse(number[index].ToString(), out parsed)) // if the digit can be parsed to an int add it to the sum variable
                    {
                        sum = sum + parsed;
                    }
                }

                if (sum == 10) // if it adds up to 10 add it to the result set
                    results.Add(i);

                /* reset the local variables */
                number = string.Empty;
                length = 0;
                sum = 0;

            });
            
            results.Sort();
            return results;
        }


        /// <summary>
        /// Get the length of a number
        /// </summary>
        /// <param name="number">Number to get length of</param>
        /// <returns>Number of digits in a number</returns>
        private int GetLength(int number)
        {
            return number.ToString().Length;
        }

        /// <summary>
        /// Gets the string representation of a number
        /// </summary>
        /// <param name="number">integer to convert to string</param>
        /// <returns>String representation of the number</returns>
        private string GetString(int number)
        {
            return number.ToString();
        }
    }
}
