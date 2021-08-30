using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class RepeatingCharacterProblem
    {        
        private OrderedDictionary _RepeatingChars = new OrderedDictionary();
        private Queue<char> _NonRepeating;

        public char GetNonRepeatinCharFromStream(StringBuilder sb)
        {
            _RepeatingChars = new OrderedDictionary(256);
            string stream = "geeksforgeeksandgeeksquizfor";
            for (int j = 0;j < stream.Length; j++)
            {
                if(_RepeatingChars.Contains(stream[j]))
                {
                    _RepeatingChars[stream[j]] = (1+ (int)_RepeatingChars[stream[j]]);
                }
                else
                {
                    _RepeatingChars[stream[j]] = 1;
                    _NonRepeating.Enqueue(stream[j]);
                }
            }

            int i = 0;
            for ( i = 0; i < _RepeatingChars.Count; i++)
            {
               if( (int)_RepeatingChars[i]==1)
                {
                    break;
                }
            }
            return (char)_RepeatingChars[i];
        }
    }
}
