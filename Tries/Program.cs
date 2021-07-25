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
            string file= System.IO.File.ReadAllText("fulldictionary.json");
          
            dictionary = JsonSerializer.Deserialize<Dictionary<string,string>>(file);

            #region Trie
            Trie trie = new Trie();

            trie.Insert("hello");
            trie.Insert("hey");
            trie.Insert("heaven");

            trie.Remove("he");

            //var list = trie.GetAllMatchingPrefix("h");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            int[] arr = new int[] { 1, 3, 4 };

            string[] stringArr= arr.Where(x => x > 2).Select(x => x.ToString()).ToArray();

            arr = stringArr.SelectDemo();
            
            ;
        }
    }
}
