using System;
using System.Collections.Generic;


namespace C_Task.tier3_question2
{
   public class Class1
    {
        static void Main(string[] args)
        {

            //we create a List of strings to check which of those are anagrams
            List<string> strings = new List<string> { "listen", "silent", "elbow", "below", "state", "taste" };



            List<List<string>> anagramGroups = GetAnagramGroups(strings);

            foreach (List<string> group in anagramGroups)
            {
                if (group.Count > 1)
                {
                    Console.WriteLine("Anagram Group: " + string.Join(", ", group));
                }
            }
        }

        static List<List<string>> GetAnagramGroups(List<string> strings)
        {
            Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();

            foreach (string str in strings)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new string(charArray);

                if (!anagramMap.ContainsKey(sortedStr))
                {
                    anagramMap[sortedStr] = new List<string>();
                }

                anagramMap[sortedStr].Add(str);
            }

            return anagramMap.Values.ToList();
        }
    }

}

