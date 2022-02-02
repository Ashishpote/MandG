namespace MG.SEDOL.ValidationLibrary.Validator
{
    internal interface ISedolValidationHelper
    {
        bool IsInvalidLength();
        bool HasInvalidCharacters();
        bool IsInvalidCheckSum();
        bool IsUserDefinedSedol();
    }
}