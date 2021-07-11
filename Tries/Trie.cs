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

                if(children.ContainsKey(letter))
                {
                    tempNode = children[letter];
                }
                else
                {
                    tempNode = new TrieNode(letter);
                    children.Add(letter, tempNode);
                }
                children = tempNode.Children;

            }
        }
        public bool Contains(string word)
        {
            var nodeToSearch = SearchNode(word);

            return false;
        }

        private TrieNode SearchNode(string word)
        {
            var children = root.Children;
            TrieNode tempNode = null;

            foreach (var letter in word)
            {
                if(children.ContainsKey(letter))
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

        public void Remove()
        {
            var children = root.Children;
            foreach (var letter in children)
            {
                
            }
        }
    }
}
