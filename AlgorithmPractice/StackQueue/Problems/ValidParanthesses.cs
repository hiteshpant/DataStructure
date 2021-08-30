using System;
using System.Collections.Generic;
using System.Text;

public class ValidParanthesesSolution
{
    //    Given a string s of '(' , ')' and lowercase English characters.

    //Your task is to remove the minimum number of parentheses ( '(' or ')',
    //in any positions) so that the resulting parentheses string is valid and return any valid string.

    //Formally, a parentheses string is valid if and only if:

    //It is the empty string, contains only lowercase characters, or
    //It can be written as AB(A concatenated with B), where A and B are valid strings, or
    //It can be written as (A), where A is a valid string.
    public string MinRemoveToMakeValid(string s)
    {
        Stack<int> invalidLeftParanthesisQueue = new Stack<int>();
        StringBuilder sb = new StringBuilder(s);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                invalidLeftParanthesisQueue.Push(i);
            }
            else if (s[i] == ')')
            {
                if (invalidLeftParanthesisQueue.Count > 0)
                    invalidLeftParanthesisQueue.Pop();
                else
                {
                    sb[i] = '*';
                }
            }
        }

        foreach (var item in invalidLeftParanthesisQueue)
        {
            sb.Remove(item, 1);
        }

        return sb.Replace("*", "").ToString();
    }

    public class Solution
    {

        public bool IsValid(string s)
        {
            Dictionary<char, char> _BracesMap = new Dictionary<char, char>();
            _BracesMap['('] = ')';
            _BracesMap['{'] = '}';
            _BracesMap['['] = ']';

            if (s.Length == 1 || s.Length % 2 != 0)
            {
                return false;
            }
            Stack<Char> _InvalidParanthesis = new Stack<char>();

            foreach (var character in s)
            {
                if (character == '(' || character == '[' || character == '{')
                {
                    _InvalidParanthesis.Push(character);
                }
                else if (_InvalidParanthesis.Count > 0)
                {
                    var peekedItem = _InvalidParanthesis.Peek();
                    if (_BracesMap[peekedItem] == character)
                    {
                        _InvalidParanthesis.Pop();
                    }
                }
            }
            return _InvalidParanthesis.Count == 0;
        }

        public char GetPairedValue(char input)
        {
            if (input == '(')
            {
                return ')';
            }
            if (input == '[')
            {
                return ']';
            }
            if (input == '{')
            {
                return '}';
            }
            return ' ';
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[] { };
            }
            int maxFrequency = 0;
            int currentFrequency = 0;
            Dictionary<int, int> occurenceMap = new Dictionary<int, int>();
            List<int>[] buckets;
            List<int> results = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (occurenceMap.ContainsKey(nums[i]))
                    occurenceMap[nums[i]] += 1;
                else
                    occurenceMap[nums[i]] = 1;

                currentFrequency = occurenceMap[nums[i]];
                maxFrequency = Math.Max(currentFrequency, maxFrequency);
            }

            buckets = new List<int>[maxFrequency + 1];

            foreach (var item in occurenceMap)
            {
                var freq = item.Value;
                if (buckets[freq] == null)
                    buckets[freq] = new List<int>();
                buckets[freq].Add(item.Key);
            }

            for (int i = buckets.Length - 1; i >= 0 && k > 0; i--)
            {

                if (buckets[i] != null)
                {
                    List<int> result = buckets[i];
                    results.AddRange(result);
                    k -= result.Count;
                }
            }
            return results.ToArray();

        }

    }
}