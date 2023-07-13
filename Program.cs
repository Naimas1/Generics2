using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class Alphabet : IEnumerable<char>
    {
        private readonly char[] letters;

        public Alphabet()
        {
            letters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)('A' + i);
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (char letter in letters)
            {
                yield return letter;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Programzx
    {
        public static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet();

            foreach (char letter in alphabet)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
