using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextConvert.Enums;

namespace TextConvert
{

    internal class Capitalization
    {
        private CapitalisationType _capitalization;
        public CapitalisationType Capitalisation { get => _capitalization; set => _capitalization = value; }
        public Capitalization(CapitalisationType capitalization)
        {
            _capitalization = capitalization;
        }

        public string ChangeCapitalization(string words)
        {
            switch(_capitalization)
            {
                case CapitalisationType.AllLower:
                    return words.ToLower();
                case CapitalisationType.AllCapital:
                    return words.ToUpper();
                case CapitalisationType.EveryFirstInWordCapital:
                    return EveryFirstwordsCapital(words);
                case CapitalisationType.FirstCapital:
                    return UppercaseFirst(words);
                case CapitalisationType.None:
                    break;
            }
            return words;
        }

        private static string EveryFirstwordsCapital(string words)
        {
            TextInfo textInfo = new CultureInfo("sr-RS", false).TextInfo;
            return textInfo.ToTitleCase(words.ToLower());
        }

        static string UppercaseFirst(string s)
        {
            s = s.ToLower();
            if(string.IsNullOrEmpty(s))
                return string.Empty;
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
