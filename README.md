# Text Conversion Library

This library provides a simple way to convert text between Serbian alphabets (Cyrillic and Latin) in C#. It includes a `TextConvertor` class with various constructors that allow you to customize the conversion by specifying the alphabet to convert to, the capitalization of the output text, and a list of letters to use for the conversion.

## Installation

To install the library, run the following command:


## Usage

To use the `TextConvertor` class, import it into your project and create a new instance with the desired conversion and capitalization options. Then, call the `Convert` method with the text you want to convert as an argument.

using TextConvert;
using TextConvert.Enums;

TextConvertor convertor = new TextConvertor(ConversionType.ToCyrillic, CapitalisationType.AllCapital);
string convertedText = convertor.Convert("Hello, world!");
Console.WriteLine(convertedText);  // Output: "ХЕЛЛО, ВОРЛД!"


using TextConvert;
using TextConvert.Enums;

List<Letter> customLetters = new List<Letter>()
{
    new Letter('A', 'А'),
    new Letter('B', 'Б'),
    ...
};

TextConvertor convertor = new TextConvertor(customLetters, ConversionType.ToLatin, CapitalisationType.FirstCapital);
string convertedText = convertor.Convert("ХЕЛЛО, ВОРЛД!");
Console.WriteLine(convertedText);  // Output: "Hello, World!"
