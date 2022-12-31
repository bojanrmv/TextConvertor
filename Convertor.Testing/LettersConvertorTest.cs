using TextConvert;
using TextConvert.Enums;
namespace UnitTest.API.LIB.Letters
{
    public class LettersConvertorTest
    {



        [Theory]
        [InlineData("", "")]
        [InlineData("Бојан", "Bojan")]
        [InlineData("Миљан", "Miljan")]
        [InlineData("Џордан", "Dzordan")]
        [InlineData("Љубица", "Ljubica")]
        [InlineData("Ања", "Anja")]
        [InlineData("Џордан", "Džordan")]
        [InlineData("Ђорђе", "Đorđe")]
        [InlineData("Ђорђе", "Djordje")]
        [InlineData("Мирча", "Mirča")]
        public void Convert_different_cases_to_cyrilic(string expected, string param)
        {
            TextConvertor _sut = new();
            var actual = _sut.Convert(param);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Bojan", "Бојан")]
        [InlineData("Miljan", "Миљан")]
        [InlineData("Ljubica", "Љубица")]
        [InlineData("Anja", "Ања")]
        [InlineData("Džordan", "Џордан")]
        [InlineData("Đorđe", "Ђорђе")]
        [InlineData("Mirča", "Мирча")]
        [InlineData("Mljdžpunjdžđ", "Мљџпуњџђ")]
        public void Convert_different_cases_to_latin(string expected, string param)
        {
            TextConvertor _sut = new(ConversionType.ToLatin);
            var actual = _sut.Convert(param);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("bojan", "Бојан")]
        [InlineData("miljan", "Миљан")]
        [InlineData("ljubica", "Љубица")]
        [InlineData("anja", "Ања")]
        [InlineData("džordan", "Џордан")]
        [InlineData("đorđe", "Ђорђе")]
        [InlineData("mirča", "Мирча")]
        [InlineData("mljdžpunjdžđ", "Мљџпуњџђ")]
        public void Convert_different_cases_to_latin_all_lower_case(string expected, string param)
        {
            TextConvertor _sut = new(ConversionType.ToLatin, CapitalisationType.AllLower);
            var actual = _sut.Convert(param);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(CapitalisationType.AllLower, "ја сам тестирао ово", "Ja Sam Testirao Ovo")]
        [InlineData(CapitalisationType.AllCapital, "ЈА САМ ТЕСТИРАО ОВО", "Ja Sam Testirao Ovo")]
        [InlineData(CapitalisationType.EveryFirstInWordCapital, "Ја Сам Тестирао Ово", "ЈА САМ ТЕСТИРАО ОВО")]
        [InlineData(CapitalisationType.FirstCapital, "Ја сам тестирао ово", "Ja Sam Testirao Ovo")]
        public void Convert_long_text_severat_capitalization(CapitalisationType type, string expected, string param)
        {
            TextConvertor _sut = new(type);
            var actual = _sut.Convert(param);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Ja sam samo # # #", "Ja sam samo bla bla bla")]
        [InlineData("Ja sam samo %%%% %%%% %%%%", "Ja sam samo sometest sometest sometest")]
        [InlineData("%%%%a sam samo %%%% %%%% %%%%", "sometesta sam samo sometest sometest sometest")]
        public void Convert_long_text_with_custom_letters_list(string expected, string param)
        {
            var list = new List<Letter>
            {
                new Letter("bla", "#"),
                new Letter("sometest","%%%%")
            };
            TextConvertor _sut = new(list);
            var actual = _sut.Convert(param);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Convert_long_string_from_Latin_to_Cyrilic()
        {
            string expected = TestLongStringCyrilic();
            TextConvertor _sut = new();
            var actual = _sut.Convert(TestLongStringLatin());
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Convert_long_string_from_Cyrilic_to_Latin()
        {
            string expected = TestLongStringLatin();
            TextConvertor _sut = new(ConversionType.ToLatin);
            var actual = _sut.Convert(TestLongStringCyrilic());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_empty_string_returns_empty_string()
        {
            // Arrange
            var sut = new TextConvertor();
            var input = "";
            var expectedOutput = "";

            // Act
            var actualOutput = sut.Convert(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
        
        private static string TestLongStringLatin()
        {
            return @"U računarstvu , običan tekst je labav termin za podatke (npr. sadržaj datoteke) koji predstavljaju samo znakove čitljivog materijala, ali ne i njegov grafički prikaz niti druge objekte ( brojevi s pomičnim zarezom , slike, itd.). Takođe može uključivati ​​ograničen broj.";
        }

        private static string TestLongStringCyrilic()
        {
            return @"У рачунарству , обичан текст је лабав термин за податке (нпр. садржај датотеке) који представљају само знакове читљивог материјала, али не и његов графички приказ нити друге објекте ( бројеви с помичним зарезом , слике, итд.). Такође може укључивати ​​ограничен број.";
        }
    }
}
