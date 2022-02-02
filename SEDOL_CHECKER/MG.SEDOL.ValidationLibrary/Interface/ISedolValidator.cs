namespace MG.SEDOL.ValidationLibrary.Interface
{
    public interface ISedolValidator
    {
        ISedolValidationResult ValidateSedol(string input);
    }
}
