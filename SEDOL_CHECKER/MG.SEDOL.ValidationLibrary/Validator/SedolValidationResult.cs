using MG.SEDOL.ValidationLibrary.Interface;

namespace MG.SEDOL.ValidationLibrary.Validator
{
    public class SedolValidationResult : ISedolValidationResult
    {
        public string InputString { get; set; }
        public bool IsValidSedol { get; set; }
        public bool IsUserDefined { get; set; }
        public string ValidationDetails { get; set; }
    }
}
