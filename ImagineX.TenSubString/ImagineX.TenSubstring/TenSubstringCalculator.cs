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

        public List<int> Generate()
        {
            List<int> results = new List<int>();
            long sum = 0;            
            int length = 0;
            int parsed = 0;
            string number = string.Empty;

            for (int i = 0; i < InputNumber + 1; i++) // 1, 2, 3, 4
            {
                /* Turn this into an async method later
                 * */
                length = GetLength(i);
                number = i.ToString();

                for(int index = 0; index < length; index++)
                {
                    if (int.TryParse(number[index].ToString(), out parsed))
                    {
                        sum = sum + parsed;
                    }
                }

                if (sum == 10)
                    results.Add(i);

                number = string.Empty;
                length = 0;
                sum = 0;

            }

            return results;
        }

        private int GetLength(int number)
        {
            return number.ToString().Length;
        }

        private string GetString(int number)
        {
            return number.ToString();
        }
    }
}
