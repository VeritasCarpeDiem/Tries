using System;

using Tries;

using Xunit;

namespace TriesTests
{
    public class TrieTests
    {
        [Fact]
        public void TestForClear()
        {
            Trie trie = new Trie();
            trie.Insert("hello");
            trie.Insert("hey");
            trie.Insert("heaven");
            trie.Insert("babe");
            char expectedRoot = 'S';

            bool expected = expectedRoot == trie.root.Letter;

            trie.Clear();

            Assert.True(expected);

        }
        [Theory]
        [InlineData("hello")]
        [InlineData("hey")]
        [InlineData("heaven")]
        [InlineData("babe")]
        [InlineData("baby")]
        public void TestForInsert(string word)
        {
            Trie trie = new Trie();

            trie.Insert(word);
            Assert.True(trie.Contains(word));
        }

        [Theory]
        [InlineData("he", "hello")]
        [InlineData("he", "hey")]
        [InlineData("he", "heaven")]
        public void TestForDelete(string prefix, string wordToRemove)
        {
            Trie trie = new Trie();

            trie.Insert(wordToRemove);

            Assert.True(trie.Remove(prefix));
            Assert.False(trie.Contains(wordToRemove));
            //This doesn't make sense b/c you'd never want to remove from a trie!
           // Assert.False(trie.Contains(wordToRemove)); 
        }

        [Theory]
        [InlineData ("he")]
        public void TestForMatchingPrefixReturnsListOfWords(string prefix)
        {
            Trie trie = new Trie();
            trie.Insert("hello");
            trie.Insert("hey");
            trie.Insert("heaven");

            var listOfWordsThatMatchPrefix = trie.GetAllMatchingPrefix(prefix);

            ;
            foreach (var word in listOfWordsThatMatchPrefix)
            {
                Assert.True(trie.Contains(word));
            }
        }

    }
}
