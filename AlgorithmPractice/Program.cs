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
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the first strings");
            //string input1 = Console.ReadLine();

            //Console.WriteLine("Please enter the second strings");
            //string input2 = Console.ReadLine();

            ////UniqueStringChecker stringchecker = new UniqueStringChecker();
            //RemoveDuplicates removeDuplicate = new RemoveDuplicates();
            //var index =removeDuplicate.RemoveDuplicateCharacter(ref inputString);
            //for (int i = 0; i < index; i++)
            //{
            //    Console.Write(inputString[i]);
            //}

            //Console.WriteLine("Please enter the rowSize");
            //Int16 row = 0;
            //Int16.TryParse(Console.ReadLine(), out row);

            //Console.WriteLine("Please enter the colume size");
            //Int16 column = 0;
            //Int16.TryParse(Console.ReadLine(), out column);
            //Int16[,] input = new Int16[row, column];

            //for (int i = 0; i < row; i++)
            //{
            //    var inputrows =Console.ReadLine().Split().ToList().Select((x) =>
            //    {
            //        Int16 output = 0;
            //        Int16.TryParse(x, out output);
            //        return output;
            //    });
            //    for (int j = 0; j < column; j++)
            //    {
            //        input[i, j] = inputrows.ToList()[j];
            //    }
            //}

            ////Anagram.CheckAnagram(input1, input2);
            ////Console.WriteLine(Anagram.CheckAnagram(input1, input2) == true ? "this is anagram" : "not an anagram");

            //int[,] destination =ImageRotate.RotateImageBy90(input);

            Solution sol = new Solution();
            sol.AddTwoNumbers();



            Console.ReadLine();

        }
    }
}
