using System.Globalization;
using TextConvert.Enums;
using TextConvert.Serbian;

namespace TextConvert
{
    public class TextConvertor : ITextConvertor
    {

        #region Private fields

        private List<Letter> _letterList;
        private ConversionType _conversionType;
        private Capitalization _capitalization;

        public ConversionType ConversionType
        {
            get => _conversionType;
            set
            {
                _conversionType = value;
                _letterList = new List<Letter>(GetDictionary());
            }
        }
        public CapitalisationType CapitalisationType
        {
            get => _capitalization.Capitalisation;
            set
            {
                _capitalization = new Capitalization(value)
                {
                    Capitalisation = value
                };
            }
        }

        #endregion

        #region Constructors

        public TextConvertor(ConversionType type)
        {
            _capitalization = new Capitalization(CapitalisationType.None);
            _conversionType = type;
            _letterList = new List<Letter>(GetDictionary());
        }
        public TextConvertor(List<Letter> letters)
        {
            _letterList = new List<Letter>(letters);
            _conversionType = ConversionType.ToCyrilic;
            _capitalization = new Capitalization(CapitalisationType.None);
        }
        public TextConvertor(List<Letter> letters, CapitalisationType capitalization)
        {
            _letterList = new List<Letter>(letters);
            _conversionType = ConversionType.ToCyrilic;
            _capitalization = new Capitalization(capitalization);

        }
        public TextConvertor(List<Letter> letters, ConversionType type)
        {
            _letterList = new List<Letter>(letters);
            _conversionType = type;
            _capitalization = new Capitalization(CapitalisationType.None);

        }
        public TextConvertor(List<Letter> letters, ConversionType type, CapitalisationType capitalization)
        {
            _letterList = new List<Letter>(letters);
            _conversionType = type;
            _capitalization = new Capitalization(capitalization);

        }
        /// <summary>
        /// Default will use to convert to Cyrilic, with first letter capital
        /// </summary>
        public TextConvertor()
        {
            _conversionType = ConversionType.ToCyrilic;
            _capitalization = new Capitalization(CapitalisationType.None);
            _letterList = new List<Letter>(GetDictionary());
        }
        /// <summary>
        ///Setting conversion type(to Serbian Cyrilic, to Serbian Latin) when default list is used for coonversion
        /// </summary>
        /// <param name="type"></param>
        /// <param name="capitalization"></param>
        public TextConvertor(ConversionType type, CapitalisationType capitalization) : this(type)
        {
            _capitalization = new Capitalization(capitalization);
            _letterList = new List<Letter>(GetDictionary());
        }
        /// <summary>
        /// Setting type of capitalization
        /// </summary>
        /// <param name="capitalization"></param>
        public TextConvertor(CapitalisationType capitalization)
        {
            _conversionType = ConversionType.ToCyrilic;
            _capitalization = new Capitalization(capitalization);
            _letterList = new List<Letter>(GetDictionary());
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Convert will return converted text according to the list supplied. If the list is not supplied it will use the default letters list, and will convert any text supplied to Serbian Cyrillic 
        /// </summary>
        /// <param name="words"></param>
        /// <returns>Type string, provided words converted according to supplied list</returns>
        public string Convert(string words)
        {
            if(HasNoText(words))
                return words;
            words = _capitalization.ChangeCapitalization(words);
            return Convertwords(words);
        }

        #endregion

        #region Private Methods
        private string Convertwords(string words)
        {
            foreach(var item in _letterList)
                if(words.Contains(item.Key))
                    words = words.Replace(item.Key, item.Value);
            return words;
        }
        private static bool HasNoText(string words) 
            => string.IsNullOrEmpty(words);

        private List<Letter> GetDictionary()
            =>
            _conversionType == ConversionType.ToCyrilic
            ? LetterListSeed.GetLettersToCyrilic()
            : LetterListSeed.GetLettersToLatin();


        #endregion


    }
}
