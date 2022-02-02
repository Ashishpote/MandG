namespace MG.SEDOL.ValidationLibrary.Interface
{
    public interface ISedolValidationResult
    {
        string InputString { get; set; }
        bool IsValidSedol { get; set; }
        bool IsUserDefined { get; set; }
        string ValidationDetails { get; set; }

    }
}
