using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Studio3
{
    class Count
    {
        public static Dictionary<char, int> CountChars(string input)
        {
            input = input.ToUpper();
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            char[] charactersInStr = input.ToCharArray();
            
            foreach (char item in charactersInStr)
            {
                if (characterCounts.ContainsKey(item))
                {
                    characterCounts[item] ++;
                }
                else
                {
                    characterCounts.Add(item, 1);
                }
            }

            return characterCounts;
        }
    }
}
