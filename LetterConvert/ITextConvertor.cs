using TextConvert.Enums;

namespace TextConvert
{
    public interface ITextConvertor
    {
        ConversionType ConversionType { get; set; }
        CapitalisationType CapitalisationType { get; set; }
        string Convert(string text);
    }
}