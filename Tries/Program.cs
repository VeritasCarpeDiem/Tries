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

            string[] dictionary = JsonSerializer.Deserialize<string[]>(file);

            Trie trie = new Trie();

            for (int i = 0; i < dictionary.Length; i++)
            {
                
            }

            int[] arr = new int[] { 1, 3, 4 };

            string[] stringArr= arr.Where(x => x > 2).Select(x => x.ToString()).ToArray();

            arr = stringArr.SelectDemo();

                         
            ;
        }
    }
}
