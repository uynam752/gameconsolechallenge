using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleChallenge
{
    public class WordGenerator
    {
        Random RNG = new Random();

        public List<string> _wordBank = System.IO.File.ReadAllText(@"C:\Eleven Fifty Work_20200309\ElevenFiftyProjects\GoldBadge\CSharpFundamental\GameConsoleChallenge\word.txt").Split('\n').ToList();

        public string GetWord()
        {
            int count = _wordBank.Count;
            return _wordBank[RNG.Next(count)];
        }

    }
}
