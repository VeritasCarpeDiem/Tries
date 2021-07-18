using System;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    public class Trie
    {
        private TrieNode root;
        public void Clear()
        {
            root = new TrieNode('S');
        }

        public Trie()
        {
            Clear();
        }
        public void Insert(string word)
        {
            var children = root.Children;
            TrieNode tempNode;

            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];

                if (children.ContainsKey(letter))
                {
                    tempNode = children[letter];
                }
                else
                {
                    tempNode = new TrieNode(letter);
                    children.Add(letter, tempNode);
                }
                children = tempNode.Children;
                tempNode.IsWord = true;
            }
        }
        public bool Contains(string word)
        {
            var nodeToSearch = SearchNode(word);
            if (nodeToSearch != null && nodeToSearch.IsWord)
            {
                return true;
            }
            return false;
        }

        private TrieNode SearchNode(string word)
        {
            var children = root.Children;
            TrieNode tempNode = null;

            foreach (var letter in word)
            {
                if (children.ContainsKey(letter))
                {
                    tempNode = children[letter];
                    children = tempNode.Children;
                }
                else
                {
                    return null;
                }
            }
            return tempNode;
        }

        public bool Remove(string prefix)
        {
            var nodeToSearch = SearchNode(prefix);

            if (nodeToSearch != null || prefix.Length != 0)
            {
                return true;
            }
            nodeToSearch.IsWord = false;
            return false;
        }

        public List<string> GetAllMatchingPrefix(string prefix)
        {
            List<string> allWordsWithPrefix = new List<string>();

            var node = SearchNode(prefix);

            GetAllWords(node, allWordsWithPrefix, prefix );

            return allWordsWithPrefix;
        }

        private void GetAllWords(TrieNode node, List<string> allWords, string prefix)
        {
            if (node == null)
            {
                return;
            }

            foreach ((char letter, TrieNode tempNode) in node.Children)
            {
                GetAllWords(tempNode, allWords, prefix+node.Letter);
            }

            if (node.IsWord)
            {
                allWords.Add(prefix);
            }
        }
    }
}
