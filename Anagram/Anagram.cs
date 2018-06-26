using System;

namespace Anagram
{
    public static class AnBuilder
    {
        static public string GetAnagram(string src)
        {
            const int MIN_WORD_LEN = 1;
            string anagram = src;
            int wordBeg = 0;  // Word begin iterator
            int wordEnd;      // Word end iterator
            int wordLength;

            while (wordBeg < anagram.Length)
            {
                wordLength = GetWordLength(anagram, wordBeg);
                wordEnd = (wordBeg + wordLength);

                // Checking word length
                if (wordLength > MIN_WORD_LEN)
                    anagram = ShuffleChars(anagram, wordBeg, wordEnd);
                else
                    ++wordEnd;

                // To the next word
                wordBeg = wordEnd;
            }

            return anagram;
        }

        static public int GetWordLength(string text, int wordBegin)
        {
            int i = wordBegin;
            int length = 0;

            while (i < text.Length && char.IsLetter(text[i]))
            {
                ++length;
                ++i;
            }

            return length;
        }

        static public string ShuffleChars(string source, int wordBegin, int wordEnd)
        {
            char[] text = source.ToCharArray();
            int wordLength = wordEnd - wordBegin;
            Random r = new Random(DateTime.Now.Millisecond);
            int pos1, pos2;

            for (int i = 0; i != wordLength; ++i)
            {
                // Generating 2 random positions
                pos1 = r.Next(wordBegin, wordEnd);
                pos2 = r.Next(wordBegin, wordEnd);
                while (pos1 == pos2)
                    pos2 = r.Next(wordBegin, wordEnd);

                SwapChars(ref text, pos1, pos2);
            }

            return new string(text);
        }

        static public void SwapChars(ref char[] text, int i, int j)
        {
            char tmp = text[i];
            text[i] = text[j];
            text[j] = tmp;
        }
    }
}