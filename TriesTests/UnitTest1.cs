using System;
using Tries;
using Xunit;

namespace TriesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("hello")]
        [InlineData ("hey")]
        [InlineData ("heaven")]
        [InlineData ("babe")]
        [InlineData("baby")]
        public void TestForInsert(string word)
        {
            bool expectedOutput = false;
            Trie trie = new Trie();

            trie.Insert(word);

            TrieNode tempNode = null;

            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                expectedOutput = tempNode.Children.ContainsKey(letter);
                Assert.True(expectedOutput == true);
            }
           
           
        }

        
    }
}
