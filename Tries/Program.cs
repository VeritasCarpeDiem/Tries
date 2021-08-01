using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Tries
{
    class Program
    {
        public static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Func<int, string> func = x => x.ToString();
        static void Main(string[] args)
        {
            string file = System.IO.File.ReadAllText("fulldictionary.json");

            dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(file);

            #region Trie
            Trie trie = new Trie();

            string userWord = "";
            List<string> allMatchingWords = new List<string>();

            while(true)
            {
                if (Console.ReadKey().Key  == (ConsoleKey.Escape)) break;
                userWord  += Console.ReadKey();

                allMatchingWords = trie.GetAllMatchingPrefix(userWord);
                foreach (var word in allMatchingWords)
                {
                    Console.WriteLine(word);
                }
            }
            
            foreach (var word in dictionary)
            {
                trie.Insert(word.Key);
            }

            var list = trie.GetAllMatchingPrefix("hell");

            var wordToSearch = "hello";
            foreach (var word in dictionary)
            {
                if (dictionary.ContainsKey(wordToSearch))
                {
                    Console.WriteLine($"Definition of {wordToSearch}: {dictionary["hello"]}");
                    break;
                }
            }

            //TrieNode node;
            string prefix = wordToSearch.Substring(0, wordToSearch.Length - wordToSearch.Length + 2);

            list = trie.GetAllMatchingPrefix(prefix);

            Console.WriteLine($"Strings that start with {prefix} ");
            Console.WriteLine(new String('-', 20));

            #endregion

            int[] arr = new int[] { 1, 3, 4 };

            string[] stringArr = arr.Where(x => x > 2).Select(x => x.ToString()).ToArray();

            arr = stringArr.SelectDemo();

            ;
        }
    }
}
