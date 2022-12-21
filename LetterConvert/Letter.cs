namespace TextConvert
{
    public class Letter
    {
        public Letter(string key, string value)
        {
            Value = value;
            Key = key;
        }

        public string Key { get; }
        public string Value { get; }
    }
}