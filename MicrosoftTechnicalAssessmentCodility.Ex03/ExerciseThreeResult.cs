using System.Collections.Generic;

namespace MicrosoftTechnicalAssessmentCodility.Ex03
{
    public static  class ExerciseThreeResult
    {
        /*
         * For example
         * acbcbba - 1
         * axxaxa - 2
         * aaaa - 0
         */

        public static int Solution(string s)
        {
            int lettersToDeleteCount = 0;
            Dictionary<string, int> lettersDictionary = new Dictionary<string, int>();

            if (AllLettersAreAEquals(s))
                return 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (lettersDictionary.ContainsKey(s[i].ToString()))
                    lettersDictionary[s[i].ToString()] += 1;
                else
                    lettersDictionary.Add(s[i].ToString(), 1);
            }

            foreach (var letter in lettersDictionary)
                if (letter.Value > 2)
                    lettersToDeleteCount++;

            return lettersToDeleteCount;
        }

        private static bool AllLettersAreAEquals(string word)
        {
            var firstLetter = word[0];

            for (int i = 0; i < word.Length; i++)
                if (word[i] != firstLetter)
                    return false;

            return true;
        }
    }
}
