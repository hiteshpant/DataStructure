using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.BackTracking
{
    public class WordSearch
    {
        public class Solution
        {
            private readonly TrieNode _TrieNode;
            private IList<string> output = new List<string>();

            public Solution()
            {
                _TrieNode = new TrieNode();
            }

            public IList<string> FindWords(char[][] board, string[] words)
            {
                int row = board.Length;
                int colume = board[0].Length;

                for (int i = 0; i < words.Length; i++)
                {
                    BuildTrie(words[i]);
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colume; j++)
                    {
                        Solve(row, colume, board, _TrieNode, row, colume);
                    }

                }
                return output;
            }

            private void Solve(int i, int j, char[][] board, TrieNode root, int rowlwngth, int columLength)
            {
                int index = board[i][j] - 'a';
                if (board[i][j] == '*' || root.Child[index] == null)
                    return;
                root = root.Child[index];
                if (root.IsEnd)
                {
                    output.Add(root.Word);
                }

                var currentChar = board[i][j];
                board[i][j] = '$';
                if (i > 0)
                    Solve(i - 1, j, board, root, rowlwngth, columLength);//Up Move
                if (j > 0)
                    Solve(i, j - 1, board, root, rowlwngth, columLength); // left Move
                if (i < rowlwngth - 1)
                    Solve(i + 1, j, board, root, rowlwngth, columLength); //down Move
                if (j < columLength - 1)
                    Solve(i, j + 1, board, root, rowlwngth, columLength); //right Move

                board[i][j] = currentChar;

            }

            private void BuildTrie(string v)
            {
                TrieNode current = _TrieNode;
                for (int i = 0; i < v.Length; i++)
                {
                    if (!current.Contains(v[i]))
                        current.Put(v[i], new TrieNode());
                    else
                        current = current.Child['a' - v[i]];
                }
                current.Word = v;
            }

        }

        public class TrieNode
        {
            public TrieNode[] Child { get; set; }
            public bool IsEnd { get; }
            public string Word { get; set; }

            public TrieNode()
            {
                Child = new TrieNode[26];
                IsEnd = false;
            }

            public void Put(char ch, TrieNode node)
            {
                Child[ch - 'a'] = node;
            }

            public bool Contains(char ch)
            {
                return Child[ch - 'a'] != null;
            }

            public TrieNode Get(char ch)
            {
                return Child[ch - 'a'];
            }
        }
    }
}
