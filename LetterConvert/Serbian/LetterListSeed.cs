using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConvert.Serbian
{
    /// <summary>
    /// Returns a list of letters to be converted to latin from cyrillic.
    /// Connected letters are placed at the top for a specific reason:
    /// they need to be identified and replaced first in order to prevent incorrect conversions of entire words or sentences.
    /// </summary>
    /// <returns>List<Letter></returns>
    public class LetterListSeed
    {
        public static List<Letter> GetLettersToLatin()
        {
            return new List<Letter>
            {
                new Letter("џ", "dž"),
                new Letter("љ", "lj"),
                new Letter("њ", "nj"),

                new Letter("Џ", "Dž"),
                new Letter("Љ", "Lj"),
                new Letter("Њ", "Nj"),
                new Letter("Џ", "DŽ"),
                new Letter("Љ", "LJ"),
                new Letter("Њ", "NJ"),
                
                new Letter("А", "A"),
                new Letter("Б", "B"),
                new Letter("В", "V"),
                new Letter("Г", "G"),
                new Letter("Д", "D"),
                new Letter("Ђ", "Đ"),
                new Letter("Е", "E"),
                new Letter("Ж", "Ž"),
                new Letter("З", "Z"),
                new Letter("И", "I"),
                new Letter("Ј", "J"),
                new Letter("К", "K"),
                new Letter("Л", "L"),
                new Letter("М", "M"),
                new Letter("Н", "N"),
                new Letter("О", "O"),
                new Letter("П", "P"),
                new Letter("Р", "R"),
                new Letter("С", "S"),
                new Letter("Т", "T"),
                new Letter("Ћ", "Ć"),
                new Letter("У", "U"),
                new Letter("Ф", "F"),
                new Letter("Х", "H"),
                new Letter("Ц", "C"),
                new Letter("Ч", "Č"),
                new Letter("Ш", "Š"),

                new Letter("а", "a"),
                new Letter("б", "b"),
                new Letter("в", "v"),
                new Letter("г", "g"),
                new Letter("д", "d"),
                new Letter("ђ", "đ"),
                new Letter("е", "e"),
                new Letter("ж", "ž"),
                new Letter("з", "z"),
                new Letter("и", "i"),
                new Letter("ј", "j"),
                new Letter("к", "k"),
                new Letter("л", "l"),
                new Letter("м", "m"),
                new Letter("н", "n"),
                new Letter("о", "o"),
                new Letter("п", "p"),
                new Letter("р", "r"),
                new Letter("с", "s"),
                new Letter("т", "t"),
                new Letter("ћ", "ć"),
                new Letter("у", "u"),
                new Letter("ф", "f"),
                new Letter("х", "h"),
                new Letter("ц", "c"),
                new Letter("ч", "č"),
                new Letter("ш", "š")
            };
        }
        /// <summary>
        /// Returns a list of letters to be converted to cyrillic from latin.
        /// Connected letters are placed at the top for a specific reason:
        /// they need to be identified and replaced first in order to prevent incorrect conversions of entire words or sentences.
        /// </summary>
        /// <returns>List<Letter></returns>
        public static List<Letter> GetLettersToCyrilic()
        {
            return new List<Letter>
            {
                new Letter("Dž", "Џ"),
                new Letter("Dj", "Ђ"),
                new Letter("Lj", "Љ"),
                new Letter("Nj", "Њ"),
                new Letter("Dz", "Џ"),

                new Letter("dž", "џ"),
                new Letter("dj", "ђ"),
                new Letter("lj", "љ"),
                new Letter("nj", "њ"),
                new Letter("dz", "џ"),
                
                new Letter("DŽ", "Џ"),
                new Letter("DJ", "Ђ"),
                new Letter("LJ", "Љ"),
                new Letter("NJ", "Њ"),
                new Letter("DZ", "Џ"),
                new Letter("A", "А"),
                new Letter("B", "Б"),
                new Letter("V", "В"),
                new Letter("G", "Г"),
                new Letter("D", "Д"),
                new Letter("Đ", "Ђ"),
                new Letter("E", "Е"),
                new Letter("Ž", "Ж"),
                new Letter("Z", "З"),
                new Letter("I", "И"),
                new Letter("J", "Ј"),
                new Letter("K", "К"),
                new Letter("L", "Л"),
                new Letter("M", "М"),
                new Letter("N", "Н"),
                new Letter("O", "О"),
                new Letter("P", "П"),
                new Letter("R", "Р"),
                new Letter("S", "С"),
                new Letter("T", "Т"),
                new Letter("Ć", "Ћ"),
                new Letter("U", "У"),
                new Letter("F", "Ф"),
                new Letter("H", "Х"),
                new Letter("C", "Ц"),
                new Letter("Č", "Ч"),
                new Letter("Š", "Ш"),

                new Letter("a", "а"),
                new Letter("b", "б"),
                new Letter("v", "в"),
                new Letter("g", "г"),
                new Letter("d", "д"),
                new Letter("đ", "ђ"),
                new Letter("e", "е"),
                new Letter("ž", "ж"),
                new Letter("z", "з"),
                new Letter("i", "и"),
                new Letter("j", "ј"),
                new Letter("k", "к"),
                new Letter("l", "л"),
                new Letter("m", "м"),
                new Letter("n", "н"),
                new Letter("o", "о"),
                new Letter("p", "п"),
                new Letter("r", "р"),
                new Letter("s", "с"),
                new Letter("t", "т"),
                new Letter("ć", "ћ"),
                new Letter("u", "у"),
                new Letter("f", "ф"),
                new Letter("h", "х"),
                new Letter("c", "ц"),
                new Letter("č", "ч"),
                new Letter("š", "ш"),
                new Letter("dž", "џ"),
                new Letter("dj", "ђ"),
                new Letter("lj", "љ"),
                new Letter("nj", "њ"),
                new Letter("dz", "џ")
            };
        }
    }
}
