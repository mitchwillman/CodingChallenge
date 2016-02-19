using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {

        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<String> PossibleWords = new List<string>();
			//put the jumbled word in alphabetical order
            String jumbleWordInOrder = String.Concat(jumble.OrderBy(x => x));

			//put each dictionary word in alphabetical order
			//if the two strings are the same, the dictionary word
			//is a valid posibility for the jumbled word.
            foreach (var word in dictionary)
            {
                string dictionaryWord = String.Concat(word.OrderBy(x => x));

                if (dictionaryWord == jumbleWordInOrder)
                {
                    PossibleWords.Add(word);
                }
            }


            return PossibleWords.ToArray();


        }
    }
}
