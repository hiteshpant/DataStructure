using AddList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool toBeRepeaed = true;       
            while (toBeRepeaed)
            {
                //Console.WriteLine("Enter the Index for notation");
                long.TryParse(Console.ReadLine(), out long input);
                getSpreadsheetNotation(input);
                Console.WriteLine("Preess q to exit nd any other key to continue");
                toBeRepeaed = Console.ReadLine().ToLowerInvariant() != "q" ? true : false;
            }
        }

        public static string getSpreadsheetNotation(long n)
        {
            var rowNum = getRowNumber(n);

            var columns = printString(n,rowNum);
            StringBuilder outputString = new StringBuilder();
            foreach (var item in columns)
            {
                outputString.Append(item);
            }
            var output = (rowNum + 1) + outputString.ToString().ToUpper();
            Console.WriteLine(output);
            return output;
        }

        private static IEnumerable<char> printString(long columnNumber,long rowNum)
        {
            columnNumber = columnNumber - (702 * rowNum);
            // To store result (Excel column name) 
            StringBuilder columnName = new StringBuilder();

            while (columnNumber > 0)
            {
                // Find remainder 
                var rem = columnNumber % 26;

                // If remainder is 0, then a 
                // 'Z' must be there in output 
                if (rem == 0)
                {
                    columnName.Append('Z');
                    columnNumber = (columnNumber / 26)-1;
                }
                else // If remainder is non-zero 
                {
                    columnName.Append((char)((rem - 1) + 'A'));
                    columnNumber = columnNumber / 26;
                }
            }
            return columnName.ToString().Reverse();
        }

        private static long getRowNumber(long n)
        {
            return n / 703;
        }
    }
}
