using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    public class Trie
    {
        private readonly TrieNode _TrieNode;

        /** Initialize your data structure here. */
        public Trie()
        {
            _TrieNode = new TrieNode();

        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var node = _TrieNode;
            for (int i = 0; i < word.Length; i++)
            {
                var currentChar = word[i];
                if (!node.ContainsKey(currentChar))
                    node.Put(currentChar, new TrieNode());
                node = node.Get(currentChar);
            }
            node.SetEnd();
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var node = GetNodeStratingWith(word);
            return node == null ? false : node.IsEnd;
        }

        private TrieNode GetNodeStratingWith(string word)
        {
            var node = _TrieNode;
            TrieNode resultingNode = null;
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                if (node.ContainsKey(currentLetter))
                {
                    node = node.Get(currentLetter);                  
                }
                else
                {
                    return null;
                }
            }
            return node;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            return GetNodeStratingWith(prefix) != null;
        }
    }

    public class TrieNode
    {
        public TrieNode[] LinkNode { get; }
        public bool IsEnd { get; private set; }

        public TrieNode()
        {
            LinkNode = new TrieNode[26];
            IsEnd = false;
        }

        public bool ContainsKey(char ch)
        {
            return LinkNode[ch - 'a'] != null;
        }

        public void Put(char ch, TrieNode node)
        {
            LinkNode[ch - 'a'] = node;
        }

        public TrieNode Get(char ch)
        {
            return LinkNode[ch - 'a'];
        }

        public void SetEnd()
        {
            IsEnd = true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
