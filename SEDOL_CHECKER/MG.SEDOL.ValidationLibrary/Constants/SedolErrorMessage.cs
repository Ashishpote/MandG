namespace MG.SEDOL.ValidationLibrary.Constants
{
    internal static class SedolErrorMessage
    {
        public const string LengthError = "Input string was not 7-characters long";
        public const string ChecksumError = "Checksum digit does not agree with the rest of the input";
        public const string InvalidCharacters = "SEDOL contains invalid characters";
    }
}
