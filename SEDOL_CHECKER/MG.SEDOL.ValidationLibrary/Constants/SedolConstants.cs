namespace MG.SEDOL.ValidationLibrary.Constants
{
    internal static class SedolConstants
    {
        public const int ValidLength = 7;
        public const int LetterOffset = 9;
        public static int[] PositionalSedolWeight = new int[7] { 1, 3, 1, 7, 3, 9, 1 };
    }
}
