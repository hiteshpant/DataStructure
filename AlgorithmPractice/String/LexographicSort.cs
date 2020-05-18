
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LexographicSolution
    {
        static Queue<string> _Numbers;
        static SortedDictionary<string, string[]> _Words;

        public string[] ReorderLogFiles(string[] logs)
        {
            _Numbers = new Queue<string>();
            _Words = new SortedDictionary<string, string[]>();
            foreach (var log in logs)
            {
                var seprateWords = log.Split(' ');

                if (InitializeNumberQueue(seprateWords))
                {
                    _Numbers.Enqueue(log);
                }

                else
                {
                    AddToLexographicSortedList(seprateWords);
                }

            }
            string[] output = new string[logs.Length];

            for (int i = 0; i < _Words.Count; i++)
            {
                var sntences = _Words.ElementAt(i).Value;
                foreach (var sentence in sntences)
                {
                    output[i] += sentence + " ";
                }
                output[i] = output[i].Trim();
            }

            for (int i = _Words.Count; i < logs.Length; i++)
            {
                output[i] = _Numbers.Dequeue();
            }
            return output;
        }

        private static bool InitializeNumberQueue(string[] sentence)
        {
            bool result = false;
            for (int i = 1; i < sentence.Length; i++)
            {
                var output = double.TryParse(sentence[i], out Double value);
                if (output)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            return result;
        }

        private static void AddToLexographicSortedList(string[] sentence)
        {
            StringBuilder kb = new StringBuilder();
            for (int i = 0; i < sentence.Length-1; i++)
            {
                kb.Append(sentence[i + 1]).Append(" ");
                //var toBesorted = sentence[i];               

            }
            var input =kb.ToString().Trim();

            if (!_Words.ContainsKey(input))
            {
                _Words[input] = sentence;
            }
            else
            {
                var index = sentence[0].Last();
                var wordTobeSorted = index.ToString(); 
                _Words[wordTobeSorted] = sentence;
            }
        }
    }
}

//Question

//You have an array of logs.Each log is a space delimited string of words.

//For each log, the first word in each log is an alphanumeric identifier.Then, either:

//Each word after the identifier will consist only of lowercase letters, or;
//Each word after the identifier will consist only of digits.
//We will call these two varieties of logs letter-logs and digit-logs.It is guaranteed that each log has at least one word after its identifier.

//Reorder the logs so that all of the letter-logs come before any digit-log.The letter-logs are ordered lexicographically ignoring identifier, with the identifier used in case of ties.  The digit-logs should be put in their original order.

//Return the final order of the logs.



//Example 1:

//Input: logs = ["dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"]
//Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]